// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ExecuteMailMergeOnlineJobRequest.cs">
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

namespace Aspose.Words.Cloud.Sdk.Model.Requests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using System.Security.Cryptography;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Responses;

    /// <summary>
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.ExecuteMailMergeOnlineJob" /> operation.
    /// </summary>
    public class ExecuteMailMergeOnlineJobRequest : IRequestModel, IPutExecuteRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteMailMergeOnlineJobRequest"/> class.
        /// </summary>
        public ExecuteMailMergeOnlineJobRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteMailMergeOnlineJobRequest"/> class.
        /// </summary>
        /// <param name="template">File with template.</param>
        /// <param name="data">File with mailmerge data.</param>
        /// <param name="options">Field options.</param>
        /// <param name="withRegions">The flag indicating whether to execute Mail Merge operation with regions.</param>
        /// <param name="mergeWholeDocument">The flag indicating whether fields in whole document are updated while executing of a mail merge with regions.</param>
        /// <param name="cleanup">The cleanup options.</param>
        /// <param name="documentFileName">The filename of the output document, that will be used when the resulting document has a dynamic field {filename}. If it is not set, the "template" will be used instead.</param>
        public ExecuteMailMergeOnlineJobRequest(System.IO.Stream template, System.IO.Stream data, FieldOptions options = null, bool? withRegions = null, bool? mergeWholeDocument = null, string cleanup = null, string documentFileName = null)
        {
            this.Template = template;
            this.Data = data;
            this.Options = options;
            this.WithRegions = withRegions;
            this.MergeWholeDocument = mergeWholeDocument;
            this.Cleanup = cleanup;
            this.DocumentFileName = documentFileName;
        }

        /// <summary>
        /// File with template.
        /// </summary>
        public System.IO.Stream Template { get; set; }

        /// <summary>
        /// File with mailmerge data.
        /// </summary>
        public System.IO.Stream Data { get; set; }

        /// <summary>
        /// Field options.
        /// </summary>
        public FieldOptions Options { get; set; }

        /// <summary>
        /// The flag indicating whether to execute Mail Merge operation with regions.
        /// </summary>
        public bool? WithRegions { get; set; }

        /// <summary>
        /// The flag indicating whether fields in whole document are updated while executing of a mail merge with regions.
        /// </summary>
        public bool? MergeWholeDocument { get; set; }

        /// <summary>
        /// The cleanup options.
        /// </summary>
        public string Cleanup { get; set; }

        /// <summary>
        /// The filename of the output document, that will be used when the resulting document has a dynamic field {filename}. If it is not set, the "template" will be used instead.
        /// </summary>
        public string DocumentFileName { get; set; }

        /// <summary>
        /// Returns the original request for the current operation.
        /// </summary>
        /// <returns>The original request instance.</returns>
        public IRequestModel GetOriginalRequest()
        {
            return new ExecuteMailMergeOnlineRequest(template: this.Template,
            data: this.Data,
            options: this.Options,
            withRegions: this.WithRegions,
            mergeWholeDocument: this.MergeWholeDocument,
            cleanup: this.Cleanup,
            documentFileName: this.DocumentFileName);
        }

        /// <summary>
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="configuration">SDK configuration.</param>
        /// <param name="encryptor">password encyptor.</param>
        /// <returns>The http request instance.</returns>
        public async Task<HttpRequestMessage> CreateHttpRequest(Configuration configuration, IEncryptor encryptor)
        {
            // verify the required parameter 'template' is set
            if (this.Template == null)
            {
                throw new ApiException(400, "Missing required parameter 'template' when calling ExecuteMailMergeOnlineJob");
            }

            // verify the required parameter 'data' is set
            if (this.Data == null)
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling ExecuteMailMergeOnlineJob");
            }

            this.Options?.Validate();

            var path = configuration.GetApiRootUrl() + "/words/job/put/MailMerge";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = await UrlHelper.AddQueryParameterToUrl(path, "withRegions", this.WithRegions, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "mergeWholeDocument", this.MergeWholeDocument, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "cleanup", this.Cleanup, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "documentFileName", this.DocumentFileName, encryptor);

            var formData = new List< Tuple<string, object> >();
            var result = new HttpRequestMessage(HttpMethod.Put, path);
            if (this.Template != null)
            {
                formData.Add(new Tuple<string, object>("template", new Aspose.Words.Cloud.Sdk.FileInfo() { Name = "Template", FileContent = StreamHelper.ReadAsBytes(this.Template) }));
            }

            if (this.Data != null)
            {
                formData.Add(new Tuple<string, object>("data", new Aspose.Words.Cloud.Sdk.FileInfo() { Name = "Data", FileContent = StreamHelper.ReadAsBytes(this.Data) }));
            }

            if (this.Options != null)
            {
                formData.Add(new Tuple<string, object>("Options", this.Options));
            }

            result.Content = await ApiInvoker.GetRequestContent(formData, encryptor);
            return result;
        }

        /// <summary>
        /// Deserialize response object.
        /// </summary>
        /// <param name="message">Response message.</param>
        /// <returns>Response type.</returns>
        public async Task<object> DeserializeResponse(HttpResponseMessage message)
        {
            return SerializationHelper.Deserialize(await message.Content.ReadAsStringAsync(), typeof(JobInfo));
        }
    }
}
