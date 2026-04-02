// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DeleteTableRequest.cs">
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
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteTable" /> operation.
    /// </summary>
    public class DeleteTableRequest : IRequestModel, IWordDocumentRequest, ICanModifyDocumentRequest, ICanSaveRevisionRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTableRequest"/> class.
        /// </summary>
        public DeleteTableRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTableRequest"/> class.
        /// </summary>
        /// <param name="name">The filename of the input document.</param>
        /// <param name="index">Object index.</param>
        /// <param name="nodePath">The path to the node in the document tree.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="storage">Original document storage.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password of protected Word document. Use the parameter to pass a password via SDK. SDK encrypts it automatically. We don't recommend to use the parameter to pass a plain password for direct call of API.</param>
        /// <param name="encryptedPassword">Password of protected Word document. Use the parameter to pass an encrypted password for direct calls of API. See SDK code for encyption details.</param>
        /// <param name="openTypeSupport">The value indicates whether OpenType support is on.</param>
        /// <param name="destFileName">Result path of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param>
        /// <param name="revisionDateTime">The date and time to use for revisions.</param>
        public DeleteTableRequest(string name, int index, string nodePath = null, string folder = null, string storage = null, string loadEncoding = null, string password = null, string encryptedPassword = null, bool? openTypeSupport = null, string destFileName = null, string revisionAuthor = null, string revisionDateTime = null)
        {
            this.Name = name;
            this.Index = index;
            this.NodePath = nodePath;
            this.Folder = folder;
            this.Storage = storage;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.EncryptedPassword = encryptedPassword;
            this.OpenTypeSupport = openTypeSupport;
            this.DestFileName = destFileName;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
        }

        /// <summary>
        /// The filename of the input document.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Object index.
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// The path to the node in the document tree.
        /// </summary>
        public string NodePath { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>
        public string Folder { get; set; }

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
        /// Result path of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>
        public string DestFileName { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>
        public string RevisionDateTime { get; set; }

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
            // verify the required parameter 'name' is set
            if (this.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteTable");
            }

            var path = configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/tables/{index}";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = UrlHelper.AddPathParameter(path, "name", this.Name);
            path = UrlHelper.AddPathParameter(path, "index", this.Index);
            path = UrlHelper.AddPathParameter(path, "nodePath", this.NodePath);
            path = await UrlHelper.AddQueryParameterToUrl(path, "folder", this.Folder, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "storage", this.Storage, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "loadEncoding", this.LoadEncoding, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "password", this.Password, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "encryptedPassword", this.EncryptedPassword, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "openTypeSupport", this.OpenTypeSupport, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "destFileName", this.DestFileName, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "revisionAuthor", this.RevisionAuthor, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "revisionDateTime", this.RevisionDateTime, encryptor);

            var formData = new List< Tuple<string, object> >();
            var result = new HttpRequestMessage(HttpMethod.Delete, path);
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
            return null;
        }
    }
}
