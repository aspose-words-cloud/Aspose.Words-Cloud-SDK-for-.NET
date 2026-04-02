// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConvertDocumentRequest.cs">
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
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.ConvertDocument" /> operation.
    /// </summary>
    public class ConvertDocumentRequest : IRequestModel, ICanUseCustomFontsRequest, ICanSpecifyOutputFormatRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertDocumentRequest"/> class.
        /// </summary>
        public ConvertDocumentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertDocumentRequest"/> class.
        /// </summary>
        /// <param name="document">Converting document.</param>
        /// <param name="format">The format to convert.</param>
        /// <param name="outPath">The path to the output document on a local storage.</param>
        /// <param name="fileNameFieldValue">The filename of the output document, that will be used when the resulting document has a dynamic field {filename}. If it is not set, the "sourceFilename" will be used instead.</param>
        /// <param name="storage">Original document storage.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password of protected Word document. Use the parameter to pass a password via SDK. SDK encrypts it automatically. We don't recommend to use the parameter to pass a plain password for direct call of API.</param>
        /// <param name="encryptedPassword">Password of protected Word document. Use the parameter to pass an encrypted password for direct calls of API. See SDK code for encyption details.</param>
        /// <param name="openTypeSupport">The value indicates whether OpenType support is on.</param>
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param>
        public ConvertDocumentRequest(System.IO.Stream document, string format, string outPath = null, string fileNameFieldValue = null, string storage = null, string loadEncoding = null, string password = null, string encryptedPassword = null, bool? openTypeSupport = null, string fontsLocation = null)
        {
            this.Document = document;
            this.Format = format;
            this.OutPath = outPath;
            this.FileNameFieldValue = fileNameFieldValue;
            this.Storage = storage;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.EncryptedPassword = encryptedPassword;
            this.OpenTypeSupport = openTypeSupport;
            this.FontsLocation = fontsLocation;
        }

        /// <summary>
        /// Converting document.
        /// </summary>
        public System.IO.Stream Document { get; set; }

        /// <summary>
        /// The format to convert.
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// The path to the output document on a local storage.
        /// </summary>
        public string OutPath { get; set; }

        /// <summary>
        /// The filename of the output document, that will be used when the resulting document has a dynamic field {filename}. If it is not set, the "sourceFilename" will be used instead.
        /// </summary>
        public string FileNameFieldValue { get; set; }

        /// <summary>
        /// Original document storage.
        /// </summary>
        public string Storage { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password of protected Word document. Use the parameter to pass a password via SDK. SDK encrypts it automatically. We don't recommend to use the parameter to pass a plain password for direct call of API.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Password of protected Word document. Use the parameter to pass an encrypted password for direct calls of API. See SDK code for encyption details.
        /// </summary>
        public string EncryptedPassword { get; set; }

        /// <summary>
        /// The value indicates whether OpenType support is on.
        /// </summary>
        public bool? OpenTypeSupport { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>
        public string FontsLocation { get; set; }

        /// <summary>
        /// Returns the original request for the current operation.
        /// </summary>
        /// <returns>The original request instance.</returns>
        public IRequestModel GetOriginalRequest()
        {
            return this;
        }

        /// <summary>
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="configuration">SDK configuration.</param>
        /// <param name="encryptor">password encyptor.</param>
        /// <returns>The http request instance.</returns>
        public async Task<HttpRequestMessage> CreateHttpRequest(Configuration configuration, IEncryptor encryptor)
        {
            // verify the required parameter 'document' is set
            if (this.Document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling ConvertDocument");
            }

            // verify the required parameter 'format' is set
            if (this.Format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling ConvertDocument");
            }

            var path = configuration.GetApiRootUrl() + "/words/convert";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = await UrlHelper.AddQueryParameterToUrl(path, "format", this.Format, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "outPath", this.OutPath, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "fileNameFieldValue", this.FileNameFieldValue, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "storage", this.Storage, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "loadEncoding", this.LoadEncoding, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "password", this.Password, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "encryptedPassword", this.EncryptedPassword, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "openTypeSupport", this.OpenTypeSupport, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "fontsLocation", this.FontsLocation, encryptor);

            var formData = new List< Tuple<string, object> >();
            var result = new HttpRequestMessage(HttpMethod.Put, path);
            if (this.Document != null)
            {
                formData.Add(new Tuple<string, object>("document", new Aspose.Words.Cloud.Sdk.FileInfo() { Name = "Document", FileContent = StreamHelper.ReadAsBytes(this.Document) }));
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
            return await message.Content.ReadAsStreamAsync();
        }
    }
}
