// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ApiInvoker.cs">
//   Copyright (c) 2026 Aspose.Words for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Words.Cloud.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.RequestHandlers;
    using Microsoft.AspNetCore.WebUtilities;
    using Microsoft.Extensions.Primitives;

    internal class ApiInvoker
    {
        private const string AsposeClientHeaderName = "x-aspose-client";
        private const string AsposeClientVersionHeaderName = "x-aspose-client-version";
        private readonly Dictionary<string, string> defaultHeaderMap = new Dictionary<string, string>();
        private readonly List<IRequestHandler> requestHandlers;
        private readonly Configuration configuration;

        /// <summary>
        /// Gets HttpClient instance.
        /// </summary>
        public HttpClient HttpClient { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiInvoker"/> class.
        /// </summary>
        /// <param name="requestHandlers">set of request handlers.</param>
        /// <param name="configuration">SDK configuration.</param>
        public ApiInvoker(List<IRequestHandler> requestHandlers, Configuration configuration)
        {
            this.AddDefaultHeader(AsposeClientHeaderName, ".net sdk");
            this.AddDefaultHeader(AsposeClientVersionHeaderName, "26.4");
            this.requestHandlers = requestHandlers;
            this.configuration = configuration;
            this.HttpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(configuration.Timeout), };
        }

        internal static async Task<HttpContent> GetRequestContent(List< Tuple<string, object> > formData, IEncryptor encryptor)
        {
            var fileReferences = new List<FileReference>();
            foreach (var formElement in formData)
            {
                if (formElement.Item2 is IFileReference)
                {
                    var modelElement = (IFileReference)formElement.Item2;
                    modelElement.CollectFileReferences(ref fileReferences);
                }
            }

            foreach (var fileReference in fileReferences)
            {
                await fileReference.EncryptPassword(encryptor);
                if (fileReference.Source == FileReference.FileSource.Request)
                {
                    var fileInfo = new FileInfo()
                    {
                        Name = fileReference.Reference,
                        MimeType = "application/octet-stream",
                        FileContent = fileReference.Content,
                    };
                    formData.Add(new Tuple<string, object>(fileReference.Reference, fileInfo));
                }
            }

            if (formData.Count == 1)
            {
                return ApiInvoker.GetBodyParameterData(formData[0].Item2);
            }
            else if (formData.Count > 1)
            {
                return ApiInvoker.GetMultipartFormData(formData);
            }
            else
            {
                return null;
            }
        }

        internal static HttpContent GetBodyParameterData(object param)
        {
            HttpContent result = null;
            if (param is FileInfo)
            {
                result = new ByteArrayContent(((FileInfo)param).FileContent);
            }
            else if (param is string)
            {
                result = new StringContent((string)param, Encoding.UTF8, "text/plain");
            }
            else
            {
                var stringData = SerializationHelper.Serialize(param);
                result = new StringContent(stringData, Encoding.UTF8, "application/json");
            }

            return result;
        }

        internal static MultipartContent GetMultipartFormData(List< Tuple<string, object> > postParameters)
        {
            var multipart = new MultipartFormDataContent();
            foreach (var param in postParameters)
            {
                if (param.Item2 is FileInfo)
                {
                    var fileInfo = (FileInfo)param.Item2;
                    multipart.Add(new ByteArrayContent(fileInfo.FileContent), param.Item1, param.Item1);
                }
                else if (param.Item2 is string)
                {
                    multipart.Add(new StringContent((string)param.Item2, Encoding.UTF8, "text/plain"), param.Item1);
                }
                else
                {
                    var stringData = SerializationHelper.Serialize(param.Item2);
                    multipart.Add(new StringContent(stringData, Encoding.UTF8, "application/json"), param.Item1);
                }
            }

            return multipart;
        }

        internal static async Task< Dictionary<string, ChildResponseContent> > ToMultipartForm(HttpResponseMessage response)
        {
            try
            {
                var boundary = response.Content.Headers.ContentType.Parameters
                    .FirstOrDefault(a => string.Equals(a.Name, "boundary", StringComparison.OrdinalIgnoreCase))?.Value.Trim('"');
                var reader = new MultipartReader(boundary, await response.Content.ReadAsStreamAsync());

                var result = new Dictionary<string, ChildResponseContent>();
                MultipartSection childSection;
                while ((childSection = await reader.ReadNextSectionAsync()) != null)
                {
                    string partName = null;
                    var contentHeaders = childSection.ContentDisposition.Split(';');
                    foreach (var contentHeader in contentHeaders)
                    {
                        var contentHeaderParts = contentHeader.Split('=');
                        if (contentHeaderParts.Length == 2)
                        {
                            if (contentHeaderParts[0].Trim().Equals("name"))
                            {
                                partName = contentHeaderParts[1].Trim();
                                break;
                            }
                        }
                    }

                    if (partName != null)
                    {
                        result.Add(partName, new ChildResponseContent(
                            new Dictionary<string, StringValues>(childSection.Headers, StringComparer.OrdinalIgnoreCase),
                            await SerializationHelper.MultipartSectionToStream(childSection)));
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new ApiException(400, "Failed to read multipart response: " + ex.Message);
            }
        }

        internal static async Task<ChildResponseContent[]> ToMultipartOrderedParts(HttpResponseMessage response)
        {
            try
            {
                var boundary = response.Content.Headers.ContentType.Parameters
                    .FirstOrDefault(a => string.Equals(a.Name, "boundary", StringComparison.OrdinalIgnoreCase))?.Value.Trim('"');
                var reader = new MultipartReader(boundary, await response.Content.ReadAsStreamAsync());

                var result = new List<ChildResponseContent>();
                MultipartSection childSection;
                while ((childSection = await reader.ReadNextSectionAsync()) != null)
                {
                    result.Add(new ChildResponseContent(
                        new Dictionary<string, StringValues>(childSection.Headers, StringComparer.OrdinalIgnoreCase),
                        await SerializationHelper.MultipartSectionToStream(childSection)));
                }

                return result.ToArray();
            }
            catch (Exception ex)
            {
                throw new ApiException(400, "Failed to read multipart response: " + ex.Message);
            }
        }

        internal static async Task<JobInfo> DeserializeJobInfoPart(ChildResponseContent responsePart)
        {
            responsePart.Content.Seek(0, SeekOrigin.Begin);
            using (var reader = new StreamReader(responsePart.Content, Encoding.UTF8, true, 1024, true))
            {
                return (JobInfo)SerializationHelper.Deserialize(await reader.ReadToEndAsync(), typeof(JobInfo));
            }
        }

        internal static async Task<object> DeserializeHttpResponsePart(IRequestModel request, ChildResponseContent responsePart)
        {
            var response = await ToChildHttpResponseMessage(responsePart);
            if (response.IsSuccessStatusCode)
            {
                return await request.DeserializeResponse(response);
            }

            await ApiExceptionRequestHandler.ThrowApiException(response);
            return null;
        }

        internal async Task<ChildResponseContent[]> CallJobResult(string jobId)
        {
            var response = await this.InvokeApi(async () =>
            {
                var path = this.configuration.GetApiRootUrl() + "/words/job";
                path = await UrlHelper.AddQueryParameterToUrl(path, "id", jobId, null);
                return new HttpRequestMessage(HttpMethod.Get, path);
            });

            return await ApiInvoker.ToMultipartOrderedParts(response);
        }

        internal async Task<HttpResponseMessage> InvokeApi(System.Func< Task<HttpRequestMessage> > httpRequestFactory)
        {
            try
            {
                return await this.InvokeApiInternal(await httpRequestFactory());
            }
            catch (NeedRepeatRequestException)
            {
                try
                {
                    return await this.InvokeApiInternal(await httpRequestFactory());
                }
                catch (NeedRepeatRequestException)
                {
                    throw new ApiException(401, "Authorization failed");
                }
            }
        }

        private static async Task<HttpResponseMessage> ToChildHttpResponseMessage(ChildResponseContent responsePart, CancellationToken cancellationToken = default(CancellationToken))
        {
            responsePart.Content.Seek(0, SeekOrigin.Begin);

            var bufferedStream = new BufferedReadStream(responsePart.Content, 4096);
            var line = await bufferedStream.ReadLineAsync(MultipartReader.DefaultHeadersLengthLimit, cancellationToken).ConfigureAwait(false);
            if (string.IsNullOrEmpty(line))
            {
                throw new InvalidDataException("Invalid response line.");
            }

            var requestLineParts = line.Split(' ');
            int statusCode;
            int reasonPhraseIndex;
            if (requestLineParts.Length >= 3 && requestLineParts[0].StartsWith("HTTP/"))
            {
                if (!int.TryParse(requestLineParts[1], out statusCode))
                {
                    throw new InvalidDataException("Invalid response status code.");
                }

                reasonPhraseIndex = 2;
            }
            else if (requestLineParts.Length >= 2 && int.TryParse(requestLineParts[0], out statusCode))
            {
                reasonPhraseIndex = 1;
            }
            else
            {
                throw new InvalidDataException("Invalid response line.");
            }

            var headers = await ApiInvoker.ReadHeadersAsync(bufferedStream, cancellationToken).ConfigureAwait(false);
            var response = new HttpResponseMessage((HttpStatusCode)statusCode)
            {
                ReasonPhrase = string.Join(" ", requestLineParts.Skip(reasonPhraseIndex)),
            };

            var contentStream = new MemoryStream();
            await bufferedStream.CopyToAsync(contentStream);
            contentStream.Position = 0;
            response.Content = new StreamContent(contentStream);

            ApiInvoker.AddHeaders(response, headers);

            return response;
        }

        private static void AddHeaders(HttpResponseMessage response, Dictionary<string, StringValues> headers)
        {
            foreach (var header in headers)
            {
                if (response.Headers.TryAddWithoutValidation(header.Key, header.Value.ToArray()))
                {
                    continue;
                }

                if (!response.Content.Headers.TryAddWithoutValidation(header.Key, header.Value.ToArray()))
                {
                    throw new InvalidDataException($"Invalid header line: {header.Key}");
                }
            }
        }

        private static async Task<Dictionary<string, StringValues>> ReadHeadersAsync(BufferedReadStream stream, CancellationToken cancellationToken = default(CancellationToken))
        {
            var totalSize = 0;
            var accumulator = default(KeyValueAccumulator);
            var line = await stream.ReadLineAsync(MultipartReader.DefaultHeadersLengthLimit, cancellationToken).ConfigureAwait(false);
            while (!string.IsNullOrEmpty(line))
            {
                if (MultipartReader.DefaultHeadersLengthLimit - totalSize < line.Length)
                {
                    throw new InvalidDataException(
                        $"Multipart headers length limit {MultipartReader.DefaultHeadersLengthLimit} exceeded.");
                }

                totalSize += line.Length;
                var splitIndex = line.IndexOf(':');
                if (splitIndex <= 0)
                {
                    throw new InvalidDataException($"Invalid header line: {line}");
                }

                var name = line.Substring(0, splitIndex);
                var value = line.Substring(splitIndex + 1, line.Length - splitIndex - 1).Trim();
                accumulator.Append(name, value);
                if (accumulator.KeyCount > MultipartReader.DefaultHeadersCountLimit)
                {
                    throw new InvalidDataException(
                        $"Multipart headers count limit {MultipartReader.DefaultHeadersCountLimit} exceeded.");
                }

                line = await stream.ReadLineAsync(MultipartReader.DefaultHeadersLengthLimit - totalSize, cancellationToken).ConfigureAwait(false);
            }

            return accumulator.GetResults();
        }

        private void AddDefaultHeader(string key, string value)
        {
            if (!this.defaultHeaderMap.ContainsKey(key))
            {
                this.defaultHeaderMap.Add(key, value);
            }
        }

        private async Task<HttpResponseMessage> InvokeApiInternal(HttpRequestMessage httpRequest)
        {
            foreach (var defaultHeader in this.defaultHeaderMap)
            {
                if (httpRequest.Headers.Contains(defaultHeader.Key))
                {
                    httpRequest.Headers.Remove(defaultHeader.Key);
                }

                httpRequest.Headers.Add(defaultHeader.Key, defaultHeader.Value);
            }

            foreach (var handler in this.requestHandlers)
            {
                await handler.ProcessRequest(httpRequest);
            }

            var response = await this.HttpClient.SendAsync(httpRequest);

            try
            {
                foreach (var handler in this.requestHandlers)
                {
                    await handler.ProcessResponse(response);
                }

                return response;
            }
            catch
            {
                throw;
            }
        }
    }
}
