// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WordsApi.cs">
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
    using System.Linq;
    using System.Net.Http;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.Api;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Model.Responses;
    using Aspose.Words.Cloud.Sdk.RequestHandlers;

    /// <summary>
    /// Aspose.Words for Cloud API.
    /// </summary>
    public class WordsApi : IEncryptor
    {
        private RSA encryptor = null;

        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Gets HttpClient instance.
        /// </summary>
        public HttpClient HttpClient => apiInvoker.HttpClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="WordsApi"/> class.
        /// </summary>
        /// <param name="clientId">
        /// The client id.
        /// </param>
        /// <param name="clientSecret">
        /// The client secret.
        /// </param>
        public WordsApi(string clientId, string clientSecret)
            : this(new Configuration { ClientId = clientId, ClientSecret = clientSecret })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordsApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public WordsApi(Configuration configuration)
        {

            if (string.IsNullOrEmpty(configuration.ClientId?.Trim()))
            {
                throw new ArgumentException("ClientId configuration value must be non-empty string");
            }

            if (string.IsNullOrEmpty(configuration.ClientSecret?.Trim()))
            {
                throw new ArgumentException("ClientSecret configuration value must be non-empty string");
            }

            this.configuration = configuration;

            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new OAuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers, configuration);
        }

        /// <summary>
        /// Accepts all the revisions in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="AcceptAllRevisionsRequest" /></param>
        /// <returns><see cref="RevisionsModificationResponse" /></returns>
        public async Task<RevisionsModificationResponse> AcceptAllRevisions(AcceptAllRevisionsRequest request)
        {
            return (RevisionsModificationResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Accepts all the revisions in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="AcceptAllRevisionsOnlineRequest" /></param>
        /// <returns><see cref="AcceptAllRevisionsOnlineResponse" /></returns>
        public async Task<AcceptAllRevisionsOnlineResponse> AcceptAllRevisionsOnline(AcceptAllRevisionsOnlineRequest request)
        {
            return (AcceptAllRevisionsOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Appends documents to the original document.
        /// </summary>
        /// <param name="request">Request. <see cref="AppendDocumentRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public async Task<DocumentResponse> AppendDocument(AppendDocumentRequest request)
        {
            return (DocumentResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Appends documents to the original document.
        /// </summary>
        /// <param name="request">Request. <see cref="AppendDocumentJobRequest" /></param>
        /// <returns><see cref="JobHandler< DocumentResponse >" /></returns>
        public async Task<JobHandler< DocumentResponse >> AppendDocumentJob(AppendDocumentJobRequest request)
        {
            var info = (JobInfo)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
            return new JobHandler< DocumentResponse >(this.apiInvoker, request.GetOriginalRequest(), info);
        }

        /// <summary>
        /// Appends documents to the original document.
        /// </summary>
        /// <param name="request">Request. <see cref="AppendDocumentOnlineRequest" /></param>
        /// <returns><see cref="AppendDocumentOnlineResponse" /></returns>
        public async Task<AppendDocumentOnlineResponse> AppendDocumentOnline(AppendDocumentOnlineRequest request)
        {
            return (AppendDocumentOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Appends documents to the original document.
        /// </summary>
        /// <param name="request">Request. <see cref="AppendDocumentOnlineJobRequest" /></param>
        /// <returns><see cref="JobHandler< AppendDocumentOnlineResponse >" /></returns>
        public async Task<JobHandler< AppendDocumentOnlineResponse >> AppendDocumentOnlineJob(AppendDocumentOnlineJobRequest request)
        {
            var info = (JobInfo)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
            return new JobHandler< AppendDocumentOnlineResponse >(this.apiInvoker, request.GetOriginalRequest(), info);
        }

        /// <summary>
        /// Applies a style to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="ApplyStyleToDocumentElementRequest" /></param>
        /// <returns><see cref="WordsResponse" /></returns>
        public async Task<WordsResponse> ApplyStyleToDocumentElement(ApplyStyleToDocumentElementRequest request)
        {
            return (WordsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Applies a style to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="ApplyStyleToDocumentElementOnlineRequest" /></param>
        /// <returns><see cref="ApplyStyleToDocumentElementOnlineResponse" /></returns>
        public async Task<ApplyStyleToDocumentElementOnlineResponse> ApplyStyleToDocumentElementOnline(ApplyStyleToDocumentElementOnlineRequest request)
        {
            return (ApplyStyleToDocumentElementOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Executes the report generation process using the specified document template and the external data source in XML, JSON or CSV format.
        /// </summary>
        /// <param name="request">Request. <see cref="BuildReportRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public async Task<DocumentResponse> BuildReport(BuildReportRequest request)
        {
            return (DocumentResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Executes the report generation process online using the specified document template and the external data source in XML, JSON or CSV format.
        /// </summary>
        /// <param name="request">Request. <see cref="BuildReportOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public async Task<System.IO.Stream> BuildReportOnline(BuildReportOnlineRequest request)
        {
            return (System.IO.Stream)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Compares two documents.
        /// </summary>
        /// <param name="request">Request. <see cref="CompareDocumentRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public async Task<DocumentResponse> CompareDocument(CompareDocumentRequest request)
        {
            return (DocumentResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Compares two documents.
        /// </summary>
        /// <param name="request">Request. <see cref="CompareDocumentOnlineRequest" /></param>
        /// <returns><see cref="CompareDocumentOnlineResponse" /></returns>
        public async Task<CompareDocumentOnlineResponse> CompareDocumentOnline(CompareDocumentOnlineRequest request)
        {
            return (CompareDocumentOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Compress and resize images inside the document.
        /// The default settings allows to reduce the size of the document without any visible degradation of images quality.
        /// </summary>
        /// <param name="request">Request. <see cref="CompressDocumentRequest" /></param>
        /// <returns><see cref="CompressResponse" /></returns>
        public async Task<CompressResponse> CompressDocument(CompressDocumentRequest request)
        {
            return (CompressResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Compress and resize images inside the document.
        /// The default settings allows to reduce the size of the document without any visible degradation of images quality.
        /// </summary>
        /// <param name="request">Request. <see cref="CompressDocumentOnlineRequest" /></param>
        /// <returns><see cref="CompressDocumentOnlineResponse" /></returns>
        public async Task<CompressDocumentOnlineResponse> CompressDocumentOnline(CompressDocumentOnlineRequest request)
        {
            return (CompressDocumentOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Converts a document on a local drive to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertDocumentRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public async Task<System.IO.Stream> ConvertDocument(ConvertDocumentRequest request)
        {
            return (System.IO.Stream)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Converts a document on a local drive to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertDocumentJobRequest" /></param>
        /// <returns><see cref="JobHandler< System.IO.Stream >" /></returns>
        public async Task<JobHandler< System.IO.Stream >> ConvertDocumentJob(ConvertDocumentJobRequest request)
        {
            var info = (JobInfo)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
            return new JobHandler< System.IO.Stream >(this.apiInvoker, request.GetOriginalRequest(), info);
        }

        /// <summary>
        /// Copy file.
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFileRequest" /></param>
        public async Task CopyFile(CopyFileRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Copy folder.
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFolderRequest" /></param>
        public async Task CopyFolder(CopyFolderRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Makes a copy of the style in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="CopyStyleRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public async Task<StyleResponse> CopyStyle(CopyStyleRequest request)
        {
            return (StyleResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Makes a copy of the style in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="CopyStyleOnlineRequest" /></param>
        /// <returns><see cref="CopyStyleOnlineResponse" /></returns>
        public async Task<CopyStyleOnlineResponse> CopyStyleOnline(CopyStyleOnlineRequest request)
        {
            return (CopyStyleOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Copies styles from the origin document to the target document.
        /// </summary>
        /// <param name="request">Request. <see cref="CopyStylesFromTemplateRequest" /></param>
        /// <returns><see cref="WordsResponse" /></returns>
        public async Task<WordsResponse> CopyStylesFromTemplate(CopyStylesFromTemplateRequest request)
        {
            return (WordsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Creates a new document in cloud storage in the format, determined by the file extension.
        /// Supported all save format extensions.
        /// </summary>
        /// <param name="request">Request. <see cref="CreateDocumentRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public async Task<DocumentResponse> CreateDocument(CreateDocumentRequest request)
        {
            return (DocumentResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Create the folder.
        /// </summary>
        /// <param name="request">Request. <see cref="CreateFolderRequest" /></param>
        public async Task CreateFolder(CreateFolderRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Adds a new or updates an existing document property.
        /// </summary>
        /// <param name="request">Request. <see cref="CreateOrUpdateDocumentPropertyRequest" /></param>
        /// <returns><see cref="DocumentPropertyResponse" /></returns>
        public async Task<DocumentPropertyResponse> CreateOrUpdateDocumentProperty(CreateOrUpdateDocumentPropertyRequest request)
        {
            return (DocumentPropertyResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Adds a new or updates an existing document property.
        /// </summary>
        /// <param name="request">Request. <see cref="CreateOrUpdateDocumentPropertyOnlineRequest" /></param>
        /// <returns><see cref="CreateOrUpdateDocumentPropertyOnlineResponse" /></returns>
        public async Task<CreateOrUpdateDocumentPropertyOnlineResponse> CreateOrUpdateDocumentPropertyOnline(CreateOrUpdateDocumentPropertyOnlineRequest request)
        {
            return (CreateOrUpdateDocumentPropertyOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes paragraph tab stops from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteAllParagraphTabStopsRequest" /></param>
        /// <returns><see cref="TabStopsResponse" /></returns>
        public async Task<TabStopsResponse> DeleteAllParagraphTabStops(DeleteAllParagraphTabStopsRequest request)
        {
            return (TabStopsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes paragraph tab stops from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteAllParagraphTabStopsOnlineRequest" /></param>
        /// <returns><see cref="DeleteAllParagraphTabStopsOnlineResponse" /></returns>
        public async Task<DeleteAllParagraphTabStopsOnlineResponse> DeleteAllParagraphTabStopsOnline(DeleteAllParagraphTabStopsOnlineRequest request)
        {
            return (DeleteAllParagraphTabStopsOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a bookmark from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteBookmarkRequest" /></param>
        public async Task DeleteBookmark(DeleteBookmarkRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a bookmark from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteBookmarkOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteBookmarkOnline(DeleteBookmarkOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes all bookmarks from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteBookmarksRequest" /></param>
        public async Task DeleteBookmarks(DeleteBookmarksRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes all bookmarks from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteBookmarksOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteBookmarksOnline(DeleteBookmarksOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a border from the document node.
        /// The 'nodePath' parameter should refer to a paragraph, a cell or a row.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteBorderRequest" /></param>
        /// <returns><see cref="BorderResponse" /></returns>
        public async Task<BorderResponse> DeleteBorder(DeleteBorderRequest request)
        {
            return (BorderResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a border from the document node.
        /// The 'nodePath' parameter should refer to a paragraph, a cell or a row.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteBorderOnlineRequest" /></param>
        /// <returns><see cref="DeleteBorderOnlineResponse" /></returns>
        public async Task<DeleteBorderOnlineResponse> DeleteBorderOnline(DeleteBorderOnlineRequest request)
        {
            return (DeleteBorderOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes borders from the document node.
        /// The 'nodePath' parameter should refer to a paragraph, a cell or a row.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteBordersRequest" /></param>
        /// <returns><see cref="BordersResponse" /></returns>
        public async Task<BordersResponse> DeleteBorders(DeleteBordersRequest request)
        {
            return (BordersResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes borders from the document node.
        /// The 'nodePath' parameter should refer to a paragraph, a cell or a row.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteBordersOnlineRequest" /></param>
        /// <returns><see cref="DeleteBordersOnlineResponse" /></returns>
        public async Task<DeleteBordersOnlineResponse> DeleteBordersOnline(DeleteBordersOnlineRequest request)
        {
            return (DeleteBordersOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a comment from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteCommentRequest" /></param>
        public async Task DeleteComment(DeleteCommentRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a comment from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteCommentOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteCommentOnline(DeleteCommentOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes all comments from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteCommentsRequest" /></param>
        public async Task DeleteComments(DeleteCommentsRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes all comments from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteCommentsOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteCommentsOnline(DeleteCommentsOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes the custom xml part from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteCustomXmlPartRequest" /></param>
        public async Task DeleteCustomXmlPart(DeleteCustomXmlPartRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes the custom xml part from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteCustomXmlPartOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteCustomXmlPartOnline(DeleteCustomXmlPartOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes all custom xml parts from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteCustomXmlPartsRequest" /></param>
        public async Task DeleteCustomXmlParts(DeleteCustomXmlPartsRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes all custom xml parts from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteCustomXmlPartsOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteCustomXmlPartsOnline(DeleteCustomXmlPartsOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a document property.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDocumentPropertyRequest" /></param>
        public async Task DeleteDocumentProperty(DeleteDocumentPropertyRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a document property.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDocumentPropertyOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteDocumentPropertyOnline(DeleteDocumentPropertyOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a DrawingObject from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDrawingObjectRequest" /></param>
        public async Task DeleteDrawingObject(DeleteDrawingObjectRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a DrawingObject from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDrawingObjectOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteDrawingObjectOnline(DeleteDrawingObjectOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a field from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFieldRequest" /></param>
        public async Task DeleteField(DeleteFieldRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a field from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFieldOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteFieldOnline(DeleteFieldOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes fields from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFieldsRequest" /></param>
        public async Task DeleteFields(DeleteFieldsRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes fields from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFieldsOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteFieldsOnline(DeleteFieldsOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Delete file.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFileRequest" /></param>
        public async Task DeleteFile(DeleteFileRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Delete folder.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFolderRequest" /></param>
        public async Task DeleteFolder(DeleteFolderRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a footnote from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFootnoteRequest" /></param>
        public async Task DeleteFootnote(DeleteFootnoteRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a footnote from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFootnoteOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteFootnoteOnline(DeleteFootnoteOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a form field from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFormFieldRequest" /></param>
        public async Task DeleteFormField(DeleteFormFieldRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a form field from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFormFieldOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteFormFieldOnline(DeleteFormFieldOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a HeaderFooter object from the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHeaderFooterRequest" /></param>
        public async Task DeleteHeaderFooter(DeleteHeaderFooterRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a HeaderFooter object from the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHeaderFooterOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteHeaderFooterOnline(DeleteHeaderFooterOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes HeaderFooter objects from the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHeadersFootersRequest" /></param>
        public async Task DeleteHeadersFooters(DeleteHeadersFootersRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes HeaderFooter objects from the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHeadersFootersOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteHeadersFootersOnline(DeleteHeadersFootersOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes macros from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteMacrosRequest" /></param>
        public async Task DeleteMacros(DeleteMacrosRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes macros from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteMacrosOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteMacrosOnline(DeleteMacrosOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes an OfficeMath object from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteOfficeMathObjectRequest" /></param>
        public async Task DeleteOfficeMathObject(DeleteOfficeMathObjectRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes an OfficeMath object from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteOfficeMathObjectOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteOfficeMathObjectOnline(DeleteOfficeMathObjectOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes all office math objects from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteOfficeMathObjectsRequest" /></param>
        public async Task DeleteOfficeMathObjects(DeleteOfficeMathObjectsRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes all office math objects from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteOfficeMathObjectsOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteOfficeMathObjectsOnline(DeleteOfficeMathObjectsOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a paragraph from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphRequest" /></param>
        public async Task DeleteParagraph(DeleteParagraphRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes the formatting properties of a paragraph list from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphListFormatRequest" /></param>
        /// <returns><see cref="ParagraphListFormatResponse" /></returns>
        public async Task<ParagraphListFormatResponse> DeleteParagraphListFormat(DeleteParagraphListFormatRequest request)
        {
            return (ParagraphListFormatResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes the formatting properties of a paragraph list from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphListFormatOnlineRequest" /></param>
        /// <returns><see cref="DeleteParagraphListFormatOnlineResponse" /></returns>
        public async Task<DeleteParagraphListFormatOnlineResponse> DeleteParagraphListFormatOnline(DeleteParagraphListFormatOnlineRequest request)
        {
            return (DeleteParagraphListFormatOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a paragraph from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteParagraphOnline(DeleteParagraphOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a paragraph tab stop from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphTabStopRequest" /></param>
        /// <returns><see cref="TabStopsResponse" /></returns>
        public async Task<TabStopsResponse> DeleteParagraphTabStop(DeleteParagraphTabStopRequest request)
        {
            return (TabStopsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a paragraph tab stop from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphTabStopOnlineRequest" /></param>
        /// <returns><see cref="DeleteParagraphTabStopOnlineResponse" /></returns>
        public async Task<DeleteParagraphTabStopOnlineResponse> DeleteParagraphTabStopOnline(DeleteParagraphTabStopOnlineRequest request)
        {
            return (DeleteParagraphTabStopOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a Run object from the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteRunRequest" /></param>
        public async Task DeleteRun(DeleteRunRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a Run object from the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteRunOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteRunOnline(DeleteRunOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a section from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSectionRequest" /></param>
        public async Task DeleteSection(DeleteSectionRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a section from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSectionOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteSectionOnline(DeleteSectionOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a StructuredDocumentTag (SDT) from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteStructuredDocumentTagRequest" /></param>
        public async Task DeleteStructuredDocumentTag(DeleteStructuredDocumentTagRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a StructuredDocumentTag (SDT) from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteStructuredDocumentTagOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteStructuredDocumentTagOnline(DeleteStructuredDocumentTagOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a table from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableRequest" /></param>
        public async Task DeleteTable(DeleteTableRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a cell from the table row.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableCellRequest" /></param>
        public async Task DeleteTableCell(DeleteTableCellRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a cell from the table row.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableCellOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteTableCellOnline(DeleteTableCellOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a table from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteTableOnline(DeleteTableOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a row from the table.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableRowRequest" /></param>
        public async Task DeleteTableRow(DeleteTableRowRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a row from the table.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTableRowOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> DeleteTableRowOnline(DeleteTableRowOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a watermark from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWatermarkRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public async Task<DocumentResponse> DeleteWatermark(DeleteWatermarkRequest request)
        {
            return (DocumentResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a watermark from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWatermarkOnlineRequest" /></param>
        /// <returns><see cref="DeleteWatermarkOnlineResponse" /></returns>
        public async Task<DeleteWatermarkOnlineResponse> DeleteWatermarkOnline(DeleteWatermarkOnlineRequest request)
        {
            return (DeleteWatermarkOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Download file.
        /// </summary>
        /// <param name="request">Request. <see cref="DownloadFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public async Task<System.IO.Stream> DownloadFile(DownloadFileRequest request)
        {
            return (System.IO.Stream)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Executes a Mail Merge operation.
        /// </summary>
        /// <param name="request">Request. <see cref="ExecuteMailMergeRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public async Task<DocumentResponse> ExecuteMailMerge(ExecuteMailMergeRequest request)
        {
            return (DocumentResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Executes a Mail Merge operation.
        /// </summary>
        /// <param name="request">Request. <see cref="ExecuteMailMergeJobRequest" /></param>
        /// <returns><see cref="JobHandler< DocumentResponse >" /></returns>
        public async Task<JobHandler< DocumentResponse >> ExecuteMailMergeJob(ExecuteMailMergeJobRequest request)
        {
            var info = (JobInfo)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
            return new JobHandler< DocumentResponse >(this.apiInvoker, request.GetOriginalRequest(), info);
        }

        /// <summary>
        /// Executes a Mail Merge operation online.
        /// </summary>
        /// <param name="request">Request. <see cref="ExecuteMailMergeOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public async Task<System.IO.Stream> ExecuteMailMergeOnline(ExecuteMailMergeOnlineRequest request)
        {
            return (System.IO.Stream)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Executes a Mail Merge operation online.
        /// </summary>
        /// <param name="request">Request. <see cref="ExecuteMailMergeOnlineJobRequest" /></param>
        /// <returns><see cref="JobHandler< System.IO.Stream >" /></returns>
        public async Task<JobHandler< System.IO.Stream >> ExecuteMailMergeOnlineJob(ExecuteMailMergeOnlineJobRequest request)
        {
            var info = (JobInfo)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
            return new JobHandler< System.IO.Stream >(this.apiInvoker, request.GetOriginalRequest(), info);
        }

        /// <summary>
        /// Get all information about revisions.
        /// </summary>
        /// <param name="request">Request. <see cref="GetAllRevisionsRequest" /></param>
        /// <returns><see cref="RevisionsResponse" /></returns>
        public async Task<RevisionsResponse> GetAllRevisions(GetAllRevisionsRequest request)
        {
            return (RevisionsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Get all information about revisions.
        /// </summary>
        /// <param name="request">Request. <see cref="GetAllRevisionsOnlineRequest" /></param>
        /// <returns><see cref="RevisionsResponse" /></returns>
        public async Task<RevisionsResponse> GetAllRevisionsOnline(GetAllRevisionsOnlineRequest request)
        {
            return (RevisionsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads available fonts from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetAvailableFontsRequest" /></param>
        /// <returns><see cref="AvailableFontsResponse" /></returns>
        public async Task<AvailableFontsResponse> GetAvailableFonts(GetAvailableFontsRequest request)
        {
            return (AvailableFontsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a bookmark, specified by name, from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBookmarkByNameRequest" /></param>
        /// <returns><see cref="BookmarkResponse" /></returns>
        public async Task<BookmarkResponse> GetBookmarkByName(GetBookmarkByNameRequest request)
        {
            return (BookmarkResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a bookmark, specified by name, from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBookmarkByNameOnlineRequest" /></param>
        /// <returns><see cref="BookmarkResponse" /></returns>
        public async Task<BookmarkResponse> GetBookmarkByNameOnline(GetBookmarkByNameOnlineRequest request)
        {
            return (BookmarkResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads bookmarks from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBookmarksRequest" /></param>
        /// <returns><see cref="BookmarksResponse" /></returns>
        public async Task<BookmarksResponse> GetBookmarks(GetBookmarksRequest request)
        {
            return (BookmarksResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads bookmarks from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBookmarksOnlineRequest" /></param>
        /// <returns><see cref="BookmarksResponse" /></returns>
        public async Task<BookmarksResponse> GetBookmarksOnline(GetBookmarksOnlineRequest request)
        {
            return (BookmarksResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a border from the document node.
        /// The 'nodePath' parameter should refer to a paragraph, a cell or a row.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBorderRequest" /></param>
        /// <returns><see cref="BorderResponse" /></returns>
        public async Task<BorderResponse> GetBorder(GetBorderRequest request)
        {
            return (BorderResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a border from the document node.
        /// The 'nodePath' parameter should refer to a paragraph, a cell or a row.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBorderOnlineRequest" /></param>
        /// <returns><see cref="BorderResponse" /></returns>
        public async Task<BorderResponse> GetBorderOnline(GetBorderOnlineRequest request)
        {
            return (BorderResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads borders from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBordersRequest" /></param>
        /// <returns><see cref="BordersResponse" /></returns>
        public async Task<BordersResponse> GetBorders(GetBordersRequest request)
        {
            return (BordersResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads borders from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBordersOnlineRequest" /></param>
        /// <returns><see cref="BordersResponse" /></returns>
        public async Task<BordersResponse> GetBordersOnline(GetBordersOnlineRequest request)
        {
            return (BordersResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a comment from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetCommentRequest" /></param>
        /// <returns><see cref="CommentResponse" /></returns>
        public async Task<CommentResponse> GetComment(GetCommentRequest request)
        {
            return (CommentResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a comment from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetCommentOnlineRequest" /></param>
        /// <returns><see cref="CommentResponse" /></returns>
        public async Task<CommentResponse> GetCommentOnline(GetCommentOnlineRequest request)
        {
            return (CommentResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads comments from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetCommentsRequest" /></param>
        /// <returns><see cref="CommentsResponse" /></returns>
        public async Task<CommentsResponse> GetComments(GetCommentsRequest request)
        {
            return (CommentsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads comments from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetCommentsOnlineRequest" /></param>
        /// <returns><see cref="CommentsResponse" /></returns>
        public async Task<CommentsResponse> GetCommentsOnline(GetCommentsOnlineRequest request)
        {
            return (CommentsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads the custom xml part from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetCustomXmlPartRequest" /></param>
        /// <returns><see cref="CustomXmlPartResponse" /></returns>
        public async Task<CustomXmlPartResponse> GetCustomXmlPart(GetCustomXmlPartRequest request)
        {
            return (CustomXmlPartResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads the custom xml part from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetCustomXmlPartOnlineRequest" /></param>
        /// <returns><see cref="CustomXmlPartResponse" /></returns>
        public async Task<CustomXmlPartResponse> GetCustomXmlPartOnline(GetCustomXmlPartOnlineRequest request)
        {
            return (CustomXmlPartResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads custom xml parts from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetCustomXmlPartsRequest" /></param>
        /// <returns><see cref="CustomXmlPartsResponse" /></returns>
        public async Task<CustomXmlPartsResponse> GetCustomXmlParts(GetCustomXmlPartsRequest request)
        {
            return (CustomXmlPartsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads custom xml parts from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetCustomXmlPartsOnlineRequest" /></param>
        /// <returns><see cref="CustomXmlPartsResponse" /></returns>
        public async Task<CustomXmlPartsResponse> GetCustomXmlPartsOnline(GetCustomXmlPartsOnlineRequest request)
        {
            return (CustomXmlPartsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads common information from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public async Task<DocumentResponse> GetDocument(GetDocumentRequest request)
        {
            return (DocumentResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a DrawingObject from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectByIndexRequest" /></param>
        /// <returns><see cref="DrawingObjectResponse" /></returns>
        public async Task<DrawingObjectResponse> GetDocumentDrawingObjectByIndex(GetDocumentDrawingObjectByIndexRequest request)
        {
            return (DrawingObjectResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a DrawingObject from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectByIndexOnlineRequest" /></param>
        /// <returns><see cref="DrawingObjectResponse" /></returns>
        public async Task<DrawingObjectResponse> GetDocumentDrawingObjectByIndexOnline(GetDocumentDrawingObjectByIndexOnlineRequest request)
        {
            return (DrawingObjectResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads image data of a DrawingObject from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectImageDataRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public async Task<System.IO.Stream> GetDocumentDrawingObjectImageData(GetDocumentDrawingObjectImageDataRequest request)
        {
            return (System.IO.Stream)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads image data of a DrawingObject from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectImageDataOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public async Task<System.IO.Stream> GetDocumentDrawingObjectImageDataOnline(GetDocumentDrawingObjectImageDataOnlineRequest request)
        {
            return (System.IO.Stream)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads OLE data of a DrawingObject from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectOleDataRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public async Task<System.IO.Stream> GetDocumentDrawingObjectOleData(GetDocumentDrawingObjectOleDataRequest request)
        {
            return (System.IO.Stream)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads OLE data of a DrawingObject from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectOleDataOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public async Task<System.IO.Stream> GetDocumentDrawingObjectOleDataOnline(GetDocumentDrawingObjectOleDataOnlineRequest request)
        {
            return (System.IO.Stream)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads DrawingObjects from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectsRequest" /></param>
        /// <returns><see cref="DrawingObjectsResponse" /></returns>
        public async Task<DrawingObjectsResponse> GetDocumentDrawingObjects(GetDocumentDrawingObjectsRequest request)
        {
            return (DrawingObjectsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads DrawingObjects from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectsOnlineRequest" /></param>
        /// <returns><see cref="DrawingObjectsResponse" /></returns>
        public async Task<DrawingObjectsResponse> GetDocumentDrawingObjectsOnline(GetDocumentDrawingObjectsOnlineRequest request)
        {
            return (DrawingObjectsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads merge field names from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentFieldNamesRequest" /></param>
        /// <returns><see cref="FieldNamesResponse" /></returns>
        public async Task<FieldNamesResponse> GetDocumentFieldNames(GetDocumentFieldNamesRequest request)
        {
            return (FieldNamesResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads merge field names from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentFieldNamesOnlineRequest" /></param>
        /// <returns><see cref="FieldNamesResponse" /></returns>
        public async Task<FieldNamesResponse> GetDocumentFieldNamesOnline(GetDocumentFieldNamesOnlineRequest request)
        {
            return (FieldNamesResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a hyperlink from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentHyperlinkByIndexRequest" /></param>
        /// <returns><see cref="HyperlinkResponse" /></returns>
        public async Task<HyperlinkResponse> GetDocumentHyperlinkByIndex(GetDocumentHyperlinkByIndexRequest request)
        {
            return (HyperlinkResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a hyperlink from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentHyperlinkByIndexOnlineRequest" /></param>
        /// <returns><see cref="HyperlinkResponse" /></returns>
        public async Task<HyperlinkResponse> GetDocumentHyperlinkByIndexOnline(GetDocumentHyperlinkByIndexOnlineRequest request)
        {
            return (HyperlinkResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads hyperlinks from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentHyperlinksRequest" /></param>
        /// <returns><see cref="HyperlinksResponse" /></returns>
        public async Task<HyperlinksResponse> GetDocumentHyperlinks(GetDocumentHyperlinksRequest request)
        {
            return (HyperlinksResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads hyperlinks from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentHyperlinksOnlineRequest" /></param>
        /// <returns><see cref="HyperlinksResponse" /></returns>
        public async Task<HyperlinksResponse> GetDocumentHyperlinksOnline(GetDocumentHyperlinksOnlineRequest request)
        {
            return (HyperlinksResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads document properties.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentPropertiesRequest" /></param>
        /// <returns><see cref="DocumentPropertiesResponse" /></returns>
        public async Task<DocumentPropertiesResponse> GetDocumentProperties(GetDocumentPropertiesRequest request)
        {
            return (DocumentPropertiesResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads document properties.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentPropertiesOnlineRequest" /></param>
        /// <returns><see cref="DocumentPropertiesResponse" /></returns>
        public async Task<DocumentPropertiesResponse> GetDocumentPropertiesOnline(GetDocumentPropertiesOnlineRequest request)
        {
            return (DocumentPropertiesResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a document property.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentPropertyRequest" /></param>
        /// <returns><see cref="DocumentPropertyResponse" /></returns>
        public async Task<DocumentPropertyResponse> GetDocumentProperty(GetDocumentPropertyRequest request)
        {
            return (DocumentPropertyResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a document property.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentPropertyOnlineRequest" /></param>
        /// <returns><see cref="DocumentPropertyResponse" /></returns>
        public async Task<DocumentPropertyResponse> GetDocumentPropertyOnline(GetDocumentPropertyOnlineRequest request)
        {
            return (DocumentPropertyResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads protection properties from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentProtectionRequest" /></param>
        /// <returns><see cref="ProtectionDataResponse" /></returns>
        public async Task<ProtectionDataResponse> GetDocumentProtection(GetDocumentProtectionRequest request)
        {
            return (ProtectionDataResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads protection properties from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentProtectionOnlineRequest" /></param>
        /// <returns><see cref="ProtectionDataResponse" /></returns>
        public async Task<ProtectionDataResponse> GetDocumentProtectionOnline(GetDocumentProtectionOnlineRequest request)
        {
            return (ProtectionDataResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads document statistics.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentStatisticsRequest" /></param>
        /// <returns><see cref="StatDataResponse" /></returns>
        public async Task<StatDataResponse> GetDocumentStatistics(GetDocumentStatisticsRequest request)
        {
            return (StatDataResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads document statistics.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentStatisticsOnlineRequest" /></param>
        /// <returns><see cref="StatDataResponse" /></returns>
        public async Task<StatDataResponse> GetDocumentStatisticsOnline(GetDocumentStatisticsOnlineRequest request)
        {
            return (StatDataResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Converts a document in cloud storage to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentWithFormatRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public async Task<System.IO.Stream> GetDocumentWithFormat(GetDocumentWithFormatRequest request)
        {
            return (System.IO.Stream)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a field from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFieldRequest" /></param>
        /// <returns><see cref="FieldResponse" /></returns>
        public async Task<FieldResponse> GetField(GetFieldRequest request)
        {
            return (FieldResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a field from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFieldOnlineRequest" /></param>
        /// <returns><see cref="FieldResponse" /></returns>
        public async Task<FieldResponse> GetFieldOnline(GetFieldOnlineRequest request)
        {
            return (FieldResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads fields from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFieldsRequest" /></param>
        /// <returns><see cref="FieldsResponse" /></returns>
        public async Task<FieldsResponse> GetFields(GetFieldsRequest request)
        {
            return (FieldsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads fields from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFieldsOnlineRequest" /></param>
        /// <returns><see cref="FieldsResponse" /></returns>
        public async Task<FieldsResponse> GetFieldsOnline(GetFieldsOnlineRequest request)
        {
            return (FieldsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Get all files and folders within a folder.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFilesListRequest" /></param>
        /// <returns><see cref="FilesList" /></returns>
        public async Task<FilesList> GetFilesList(GetFilesListRequest request)
        {
            return (FilesList)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a footnote from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFootnoteRequest" /></param>
        /// <returns><see cref="FootnoteResponse" /></returns>
        public async Task<FootnoteResponse> GetFootnote(GetFootnoteRequest request)
        {
            return (FootnoteResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a footnote from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFootnoteOnlineRequest" /></param>
        /// <returns><see cref="FootnoteResponse" /></returns>
        public async Task<FootnoteResponse> GetFootnoteOnline(GetFootnoteOnlineRequest request)
        {
            return (FootnoteResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads footnotes from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFootnotesRequest" /></param>
        /// <returns><see cref="FootnotesResponse" /></returns>
        public async Task<FootnotesResponse> GetFootnotes(GetFootnotesRequest request)
        {
            return (FootnotesResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads footnotes from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFootnotesOnlineRequest" /></param>
        /// <returns><see cref="FootnotesResponse" /></returns>
        public async Task<FootnotesResponse> GetFootnotesOnline(GetFootnotesOnlineRequest request)
        {
            return (FootnotesResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a form field from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFormFieldRequest" /></param>
        /// <returns><see cref="FormFieldResponse" /></returns>
        public async Task<FormFieldResponse> GetFormField(GetFormFieldRequest request)
        {
            return (FormFieldResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a form field from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFormFieldOnlineRequest" /></param>
        /// <returns><see cref="FormFieldResponse" /></returns>
        public async Task<FormFieldResponse> GetFormFieldOnline(GetFormFieldOnlineRequest request)
        {
            return (FormFieldResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads form fields from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFormFieldsRequest" /></param>
        /// <returns><see cref="FormFieldsResponse" /></returns>
        public async Task<FormFieldsResponse> GetFormFields(GetFormFieldsRequest request)
        {
            return (FormFieldsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads form fields from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFormFieldsOnlineRequest" /></param>
        /// <returns><see cref="FormFieldsResponse" /></returns>
        public async Task<FormFieldsResponse> GetFormFieldsOnline(GetFormFieldsOnlineRequest request)
        {
            return (FormFieldsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a HeaderFooter object from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetHeaderFooterRequest" /></param>
        /// <returns><see cref="HeaderFooterResponse" /></returns>
        public async Task<HeaderFooterResponse> GetHeaderFooter(GetHeaderFooterRequest request)
        {
            return (HeaderFooterResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a HeaderFooter object from the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="GetHeaderFooterOfSectionRequest" /></param>
        /// <returns><see cref="HeaderFooterResponse" /></returns>
        public async Task<HeaderFooterResponse> GetHeaderFooterOfSection(GetHeaderFooterOfSectionRequest request)
        {
            return (HeaderFooterResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a HeaderFooter object from the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="GetHeaderFooterOfSectionOnlineRequest" /></param>
        /// <returns><see cref="HeaderFooterResponse" /></returns>
        public async Task<HeaderFooterResponse> GetHeaderFooterOfSectionOnline(GetHeaderFooterOfSectionOnlineRequest request)
        {
            return (HeaderFooterResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a HeaderFooter object from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetHeaderFooterOnlineRequest" /></param>
        /// <returns><see cref="HeaderFooterResponse" /></returns>
        public async Task<HeaderFooterResponse> GetHeaderFooterOnline(GetHeaderFooterOnlineRequest request)
        {
            return (HeaderFooterResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads HeaderFooter objects from the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="GetHeaderFootersRequest" /></param>
        /// <returns><see cref="HeaderFootersResponse" /></returns>
        public async Task<HeaderFootersResponse> GetHeaderFooters(GetHeaderFootersRequest request)
        {
            return (HeaderFootersResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads HeaderFooter objects from the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="GetHeaderFootersOnlineRequest" /></param>
        /// <returns><see cref="HeaderFootersResponse" /></returns>
        public async Task<HeaderFootersResponse> GetHeaderFootersOnline(GetHeaderFootersOnlineRequest request)
        {
            return (HeaderFootersResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Returns application info.
        /// </summary>
        /// <param name="request">Request. <see cref="GetInfoRequest" /></param>
        /// <returns><see cref="InfoResponse" /></returns>
        public async Task<InfoResponse> GetInfo(GetInfoRequest request)
        {
            return (InfoResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a list from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetListRequest" /></param>
        /// <returns><see cref="ListResponse" /></returns>
        public async Task<ListResponse> GetList(GetListRequest request)
        {
            return (ListResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a list from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetListOnlineRequest" /></param>
        /// <returns><see cref="ListResponse" /></returns>
        public async Task<ListResponse> GetListOnline(GetListOnlineRequest request)
        {
            return (ListResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads lists from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetListsRequest" /></param>
        /// <returns><see cref="ListsResponse" /></returns>
        public async Task<ListsResponse> GetLists(GetListsRequest request)
        {
            return (ListsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads lists from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetListsOnlineRequest" /></param>
        /// <returns><see cref="ListsResponse" /></returns>
        public async Task<ListsResponse> GetListsOnline(GetListsOnlineRequest request)
        {
            return (ListsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads an OfficeMath object from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetOfficeMathObjectRequest" /></param>
        /// <returns><see cref="OfficeMathObjectResponse" /></returns>
        public async Task<OfficeMathObjectResponse> GetOfficeMathObject(GetOfficeMathObjectRequest request)
        {
            return (OfficeMathObjectResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads an OfficeMath object from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetOfficeMathObjectOnlineRequest" /></param>
        /// <returns><see cref="OfficeMathObjectResponse" /></returns>
        public async Task<OfficeMathObjectResponse> GetOfficeMathObjectOnline(GetOfficeMathObjectOnlineRequest request)
        {
            return (OfficeMathObjectResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads OfficeMath objects from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetOfficeMathObjectsRequest" /></param>
        /// <returns><see cref="OfficeMathObjectsResponse" /></returns>
        public async Task<OfficeMathObjectsResponse> GetOfficeMathObjects(GetOfficeMathObjectsRequest request)
        {
            return (OfficeMathObjectsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads OfficeMath objects from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetOfficeMathObjectsOnlineRequest" /></param>
        /// <returns><see cref="OfficeMathObjectsResponse" /></returns>
        public async Task<OfficeMathObjectsResponse> GetOfficeMathObjectsOnline(GetOfficeMathObjectsOnlineRequest request)
        {
            return (OfficeMathObjectsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a paragraph from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphRequest" /></param>
        /// <returns><see cref="ParagraphResponse" /></returns>
        public async Task<ParagraphResponse> GetParagraph(GetParagraphRequest request)
        {
            return (ParagraphResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads the formatting properties of a paragraph from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphFormatRequest" /></param>
        /// <returns><see cref="ParagraphFormatResponse" /></returns>
        public async Task<ParagraphFormatResponse> GetParagraphFormat(GetParagraphFormatRequest request)
        {
            return (ParagraphFormatResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads the formatting properties of a paragraph from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphFormatOnlineRequest" /></param>
        /// <returns><see cref="ParagraphFormatResponse" /></returns>
        public async Task<ParagraphFormatResponse> GetParagraphFormatOnline(GetParagraphFormatOnlineRequest request)
        {
            return (ParagraphFormatResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads the formatting properties of a paragraph list from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphListFormatRequest" /></param>
        /// <returns><see cref="ParagraphListFormatResponse" /></returns>
        public async Task<ParagraphListFormatResponse> GetParagraphListFormat(GetParagraphListFormatRequest request)
        {
            return (ParagraphListFormatResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads the formatting properties of a paragraph list from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphListFormatOnlineRequest" /></param>
        /// <returns><see cref="ParagraphListFormatResponse" /></returns>
        public async Task<ParagraphListFormatResponse> GetParagraphListFormatOnline(GetParagraphListFormatOnlineRequest request)
        {
            return (ParagraphListFormatResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a paragraph from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphOnlineRequest" /></param>
        /// <returns><see cref="ParagraphResponse" /></returns>
        public async Task<ParagraphResponse> GetParagraphOnline(GetParagraphOnlineRequest request)
        {
            return (ParagraphResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads paragraphs from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphsRequest" /></param>
        /// <returns><see cref="ParagraphLinkCollectionResponse" /></returns>
        public async Task<ParagraphLinkCollectionResponse> GetParagraphs(GetParagraphsRequest request)
        {
            return (ParagraphLinkCollectionResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads paragraphs from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphsOnlineRequest" /></param>
        /// <returns><see cref="ParagraphLinkCollectionResponse" /></returns>
        public async Task<ParagraphLinkCollectionResponse> GetParagraphsOnline(GetParagraphsOnlineRequest request)
        {
            return (ParagraphLinkCollectionResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads paragraph tab stops from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphTabStopsRequest" /></param>
        /// <returns><see cref="TabStopsResponse" /></returns>
        public async Task<TabStopsResponse> GetParagraphTabStops(GetParagraphTabStopsRequest request)
        {
            return (TabStopsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads paragraph tab stops from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphTabStopsOnlineRequest" /></param>
        /// <returns><see cref="TabStopsResponse" /></returns>
        public async Task<TabStopsResponse> GetParagraphTabStopsOnline(GetParagraphTabStopsOnlineRequest request)
        {
            return (TabStopsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Get asymmetric public key.
        /// </summary>
        /// <param name="request">Request. <see cref="GetPublicKeyRequest" /></param>
        /// <returns><see cref="PublicKeyResponse" /></returns>
        public async Task<PublicKeyResponse> GetPublicKey(GetPublicKeyRequest request)
        {
            return (PublicKeyResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads range text from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRangeTextRequest" /></param>
        /// <returns><see cref="RangeTextResponse" /></returns>
        public async Task<RangeTextResponse> GetRangeText(GetRangeTextRequest request)
        {
            return (RangeTextResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads range text from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRangeTextOnlineRequest" /></param>
        /// <returns><see cref="RangeTextResponse" /></returns>
        public async Task<RangeTextResponse> GetRangeTextOnline(GetRangeTextOnlineRequest request)
        {
            return (RangeTextResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a Run object from the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRunRequest" /></param>
        /// <returns><see cref="RunResponse" /></returns>
        public async Task<RunResponse> GetRun(GetRunRequest request)
        {
            return (RunResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads the font properties of a Run object from the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRunFontRequest" /></param>
        /// <returns><see cref="FontResponse" /></returns>
        public async Task<FontResponse> GetRunFont(GetRunFontRequest request)
        {
            return (FontResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads the font properties of a Run object from the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRunFontOnlineRequest" /></param>
        /// <returns><see cref="FontResponse" /></returns>
        public async Task<FontResponse> GetRunFontOnline(GetRunFontOnlineRequest request)
        {
            return (FontResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a Run object from the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRunOnlineRequest" /></param>
        /// <returns><see cref="RunResponse" /></returns>
        public async Task<RunResponse> GetRunOnline(GetRunOnlineRequest request)
        {
            return (RunResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads Run objects from the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRunsRequest" /></param>
        /// <returns><see cref="RunsResponse" /></returns>
        public async Task<RunsResponse> GetRuns(GetRunsRequest request)
        {
            return (RunsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads Run objects from the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="GetRunsOnlineRequest" /></param>
        /// <returns><see cref="RunsResponse" /></returns>
        public async Task<RunsResponse> GetRunsOnline(GetRunsOnlineRequest request)
        {
            return (RunsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a section from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetSectionRequest" /></param>
        /// <returns><see cref="SectionResponse" /></returns>
        public async Task<SectionResponse> GetSection(GetSectionRequest request)
        {
            return (SectionResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a section from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetSectionOnlineRequest" /></param>
        /// <returns><see cref="SectionResponse" /></returns>
        public async Task<SectionResponse> GetSectionOnline(GetSectionOnlineRequest request)
        {
            return (SectionResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads the page setup of a section from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetSectionPageSetupRequest" /></param>
        /// <returns><see cref="SectionPageSetupResponse" /></returns>
        public async Task<SectionPageSetupResponse> GetSectionPageSetup(GetSectionPageSetupRequest request)
        {
            return (SectionPageSetupResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads the page setup of a section from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetSectionPageSetupOnlineRequest" /></param>
        /// <returns><see cref="SectionPageSetupResponse" /></returns>
        public async Task<SectionPageSetupResponse> GetSectionPageSetupOnline(GetSectionPageSetupOnlineRequest request)
        {
            return (SectionPageSetupResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads sections from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetSectionsRequest" /></param>
        /// <returns><see cref="SectionLinkCollectionResponse" /></returns>
        public async Task<SectionLinkCollectionResponse> GetSections(GetSectionsRequest request)
        {
            return (SectionLinkCollectionResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads sections from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetSectionsOnlineRequest" /></param>
        /// <returns><see cref="SectionLinkCollectionResponse" /></returns>
        public async Task<SectionLinkCollectionResponse> GetSectionsOnline(GetSectionsOnlineRequest request)
        {
            return (SectionLinkCollectionResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Gets signatures from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetSignaturesRequest" /></param>
        /// <returns><see cref="SignatureCollectionResponse" /></returns>
        public async Task<SignatureCollectionResponse> GetSignatures(GetSignaturesRequest request)
        {
            return (SignatureCollectionResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Gets signatures from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetSignaturesOnlineRequest" /></param>
        /// <returns><see cref="SignatureCollectionResponse" /></returns>
        public async Task<SignatureCollectionResponse> GetSignaturesOnline(GetSignaturesOnlineRequest request)
        {
            return (SignatureCollectionResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a StructuredDocumentTag (SDT) from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetStructuredDocumentTagRequest" /></param>
        /// <returns><see cref="StructuredDocumentTagResponse" /></returns>
        public async Task<StructuredDocumentTagResponse> GetStructuredDocumentTag(GetStructuredDocumentTagRequest request)
        {
            return (StructuredDocumentTagResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a StructuredDocumentTag (SDT) from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetStructuredDocumentTagOnlineRequest" /></param>
        /// <returns><see cref="StructuredDocumentTagResponse" /></returns>
        public async Task<StructuredDocumentTagResponse> GetStructuredDocumentTagOnline(GetStructuredDocumentTagOnlineRequest request)
        {
            return (StructuredDocumentTagResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads StructuredDocumentTags (SDT) from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetStructuredDocumentTagsRequest" /></param>
        /// <returns><see cref="StructuredDocumentTagsResponse" /></returns>
        public async Task<StructuredDocumentTagsResponse> GetStructuredDocumentTags(GetStructuredDocumentTagsRequest request)
        {
            return (StructuredDocumentTagsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads StructuredDocumentTags (SDT) from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetStructuredDocumentTagsOnlineRequest" /></param>
        /// <returns><see cref="StructuredDocumentTagsResponse" /></returns>
        public async Task<StructuredDocumentTagsResponse> GetStructuredDocumentTagsOnline(GetStructuredDocumentTagsOnlineRequest request)
        {
            return (StructuredDocumentTagsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a style from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetStyleRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public async Task<StyleResponse> GetStyle(GetStyleRequest request)
        {
            return (StyleResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a style from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetStyleFromDocumentElementRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public async Task<StyleResponse> GetStyleFromDocumentElement(GetStyleFromDocumentElementRequest request)
        {
            return (StyleResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a style from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetStyleFromDocumentElementOnlineRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public async Task<StyleResponse> GetStyleFromDocumentElementOnline(GetStyleFromDocumentElementOnlineRequest request)
        {
            return (StyleResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a style from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetStyleOnlineRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public async Task<StyleResponse> GetStyleOnline(GetStyleOnlineRequest request)
        {
            return (StyleResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads styles from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetStylesRequest" /></param>
        /// <returns><see cref="StylesResponse" /></returns>
        public async Task<StylesResponse> GetStyles(GetStylesRequest request)
        {
            return (StylesResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads styles from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="GetStylesOnlineRequest" /></param>
        /// <returns><see cref="StylesResponse" /></returns>
        public async Task<StylesResponse> GetStylesOnline(GetStylesOnlineRequest request)
        {
            return (StylesResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a table from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableRequest" /></param>
        /// <returns><see cref="TableResponse" /></returns>
        public async Task<TableResponse> GetTable(GetTableRequest request)
        {
            return (TableResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a cell from the table row.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableCellRequest" /></param>
        /// <returns><see cref="TableCellResponse" /></returns>
        public async Task<TableCellResponse> GetTableCell(GetTableCellRequest request)
        {
            return (TableCellResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads the formatting properties of a table cell.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableCellFormatRequest" /></param>
        /// <returns><see cref="TableCellFormatResponse" /></returns>
        public async Task<TableCellFormatResponse> GetTableCellFormat(GetTableCellFormatRequest request)
        {
            return (TableCellFormatResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads the formatting properties of a table cell.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableCellFormatOnlineRequest" /></param>
        /// <returns><see cref="TableCellFormatResponse" /></returns>
        public async Task<TableCellFormatResponse> GetTableCellFormatOnline(GetTableCellFormatOnlineRequest request)
        {
            return (TableCellFormatResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a cell from the table row.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableCellOnlineRequest" /></param>
        /// <returns><see cref="TableCellResponse" /></returns>
        public async Task<TableCellResponse> GetTableCellOnline(GetTableCellOnlineRequest request)
        {
            return (TableCellResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a table from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableOnlineRequest" /></param>
        /// <returns><see cref="TableResponse" /></returns>
        public async Task<TableResponse> GetTableOnline(GetTableOnlineRequest request)
        {
            return (TableResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads properties of a table from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTablePropertiesRequest" /></param>
        /// <returns><see cref="TablePropertiesResponse" /></returns>
        public async Task<TablePropertiesResponse> GetTableProperties(GetTablePropertiesRequest request)
        {
            return (TablePropertiesResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads properties of a table from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTablePropertiesOnlineRequest" /></param>
        /// <returns><see cref="TablePropertiesResponse" /></returns>
        public async Task<TablePropertiesResponse> GetTablePropertiesOnline(GetTablePropertiesOnlineRequest request)
        {
            return (TablePropertiesResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a row from the table.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableRowRequest" /></param>
        /// <returns><see cref="TableRowResponse" /></returns>
        public async Task<TableRowResponse> GetTableRow(GetTableRowRequest request)
        {
            return (TableRowResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads the formatting properties of a table row.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableRowFormatRequest" /></param>
        /// <returns><see cref="TableRowFormatResponse" /></returns>
        public async Task<TableRowFormatResponse> GetTableRowFormat(GetTableRowFormatRequest request)
        {
            return (TableRowFormatResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads the formatting properties of a table row.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableRowFormatOnlineRequest" /></param>
        /// <returns><see cref="TableRowFormatResponse" /></returns>
        public async Task<TableRowFormatResponse> GetTableRowFormatOnline(GetTableRowFormatOnlineRequest request)
        {
            return (TableRowFormatResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads a row from the table.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTableRowOnlineRequest" /></param>
        /// <returns><see cref="TableRowResponse" /></returns>
        public async Task<TableRowResponse> GetTableRowOnline(GetTableRowOnlineRequest request)
        {
            return (TableRowResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads tables from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTablesRequest" /></param>
        /// <returns><see cref="TableLinkCollectionResponse" /></returns>
        public async Task<TableLinkCollectionResponse> GetTables(GetTablesRequest request)
        {
            return (TableLinkCollectionResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reads tables from the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="GetTablesOnlineRequest" /></param>
        /// <returns><see cref="TableLinkCollectionResponse" /></returns>
        public async Task<TableLinkCollectionResponse> GetTablesOnline(GetTablesOnlineRequest request)
        {
            return (TableLinkCollectionResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new bookmark to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertBookmarkRequest" /></param>
        /// <returns><see cref="BookmarkResponse" /></returns>
        public async Task<BookmarkResponse> InsertBookmark(InsertBookmarkRequest request)
        {
            return (BookmarkResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new bookmark to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertBookmarkOnlineRequest" /></param>
        /// <returns><see cref="InsertBookmarkOnlineResponse" /></returns>
        public async Task<InsertBookmarkOnlineResponse> InsertBookmarkOnline(InsertBookmarkOnlineRequest request)
        {
            return (InsertBookmarkOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new comment to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertCommentRequest" /></param>
        /// <returns><see cref="CommentResponse" /></returns>
        public async Task<CommentResponse> InsertComment(InsertCommentRequest request)
        {
            return (CommentResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new comment to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertCommentOnlineRequest" /></param>
        /// <returns><see cref="InsertCommentOnlineResponse" /></returns>
        public async Task<InsertCommentOnlineResponse> InsertCommentOnline(InsertCommentOnlineRequest request)
        {
            return (InsertCommentOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new custom xml part to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertCustomXmlPartRequest" /></param>
        /// <returns><see cref="CustomXmlPartResponse" /></returns>
        public async Task<CustomXmlPartResponse> InsertCustomXmlPart(InsertCustomXmlPartRequest request)
        {
            return (CustomXmlPartResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new custom xml part to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertCustomXmlPartOnlineRequest" /></param>
        /// <returns><see cref="InsertCustomXmlPartOnlineResponse" /></returns>
        public async Task<InsertCustomXmlPartOnlineResponse> InsertCustomXmlPartOnline(InsertCustomXmlPartOnlineRequest request)
        {
            return (InsertCustomXmlPartOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new DrawingObject to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertDrawingObjectRequest" /></param>
        /// <returns><see cref="DrawingObjectResponse" /></returns>
        public async Task<DrawingObjectResponse> InsertDrawingObject(InsertDrawingObjectRequest request)
        {
            return (DrawingObjectResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new DrawingObject to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertDrawingObjectOnlineRequest" /></param>
        /// <returns><see cref="InsertDrawingObjectOnlineResponse" /></returns>
        public async Task<InsertDrawingObjectOnlineResponse> InsertDrawingObjectOnline(InsertDrawingObjectOnlineRequest request)
        {
            return (InsertDrawingObjectOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new field to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFieldRequest" /></param>
        /// <returns><see cref="FieldResponse" /></returns>
        public async Task<FieldResponse> InsertField(InsertFieldRequest request)
        {
            return (FieldResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new field to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFieldOnlineRequest" /></param>
        /// <returns><see cref="InsertFieldOnlineResponse" /></returns>
        public async Task<InsertFieldOnlineResponse> InsertFieldOnline(InsertFieldOnlineRequest request)
        {
            return (InsertFieldOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new footnote to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFootnoteRequest" /></param>
        /// <returns><see cref="FootnoteResponse" /></returns>
        public async Task<FootnoteResponse> InsertFootnote(InsertFootnoteRequest request)
        {
            return (FootnoteResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new footnote to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFootnoteOnlineRequest" /></param>
        /// <returns><see cref="InsertFootnoteOnlineResponse" /></returns>
        public async Task<InsertFootnoteOnlineResponse> InsertFootnoteOnline(InsertFootnoteOnlineRequest request)
        {
            return (InsertFootnoteOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new form field to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFormFieldRequest" /></param>
        /// <returns><see cref="FormFieldResponse" /></returns>
        public async Task<FormFieldResponse> InsertFormField(InsertFormFieldRequest request)
        {
            return (FormFieldResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new form field to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertFormFieldOnlineRequest" /></param>
        /// <returns><see cref="InsertFormFieldOnlineResponse" /></returns>
        public async Task<InsertFormFieldOnlineResponse> InsertFormFieldOnline(InsertFormFieldOnlineRequest request)
        {
            return (InsertFormFieldOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new HeaderFooter object to the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertHeaderFooterRequest" /></param>
        /// <returns><see cref="HeaderFooterResponse" /></returns>
        public async Task<HeaderFooterResponse> InsertHeaderFooter(InsertHeaderFooterRequest request)
        {
            return (HeaderFooterResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new HeaderFooter object to the document section.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertHeaderFooterOnlineRequest" /></param>
        /// <returns><see cref="InsertHeaderFooterOnlineResponse" /></returns>
        public async Task<InsertHeaderFooterOnlineResponse> InsertHeaderFooterOnline(InsertHeaderFooterOnlineRequest request)
        {
            return (InsertHeaderFooterOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new list to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertListRequest" /></param>
        /// <returns><see cref="ListResponse" /></returns>
        public async Task<ListResponse> InsertList(InsertListRequest request)
        {
            return (ListResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new list to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertListOnlineRequest" /></param>
        /// <returns><see cref="InsertListOnlineResponse" /></returns>
        public async Task<InsertListOnlineResponse> InsertListOnline(InsertListOnlineRequest request)
        {
            return (InsertListOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new or updates an existing paragraph tab stop in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertOrUpdateParagraphTabStopRequest" /></param>
        /// <returns><see cref="TabStopsResponse" /></returns>
        public async Task<TabStopsResponse> InsertOrUpdateParagraphTabStop(InsertOrUpdateParagraphTabStopRequest request)
        {
            return (TabStopsResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new or updates an existing paragraph tab stop in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertOrUpdateParagraphTabStopOnlineRequest" /></param>
        /// <returns><see cref="InsertOrUpdateParagraphTabStopOnlineResponse" /></returns>
        public async Task<InsertOrUpdateParagraphTabStopOnlineResponse> InsertOrUpdateParagraphTabStopOnline(InsertOrUpdateParagraphTabStopOnlineRequest request)
        {
            return (InsertOrUpdateParagraphTabStopOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts page numbers to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertPageNumbersRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public async Task<DocumentResponse> InsertPageNumbers(InsertPageNumbersRequest request)
        {
            return (DocumentResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts page numbers to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertPageNumbersOnlineRequest" /></param>
        /// <returns><see cref="InsertPageNumbersOnlineResponse" /></returns>
        public async Task<InsertPageNumbersOnlineResponse> InsertPageNumbersOnline(InsertPageNumbersOnlineRequest request)
        {
            return (InsertPageNumbersOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new paragraph to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertParagraphRequest" /></param>
        /// <returns><see cref="ParagraphResponse" /></returns>
        public async Task<ParagraphResponse> InsertParagraph(InsertParagraphRequest request)
        {
            return (ParagraphResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new paragraph to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertParagraphOnlineRequest" /></param>
        /// <returns><see cref="InsertParagraphOnlineResponse" /></returns>
        public async Task<InsertParagraphOnlineResponse> InsertParagraphOnline(InsertParagraphOnlineRequest request)
        {
            return (InsertParagraphOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new Run object to the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertRunRequest" /></param>
        /// <returns><see cref="RunResponse" /></returns>
        public async Task<RunResponse> InsertRun(InsertRunRequest request)
        {
            return (RunResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new Run object to the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertRunOnlineRequest" /></param>
        /// <returns><see cref="InsertRunOnlineResponse" /></returns>
        public async Task<InsertRunOnlineResponse> InsertRunOnline(InsertRunOnlineRequest request)
        {
            return (InsertRunOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a section to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertSectionRequest" /></param>
        public async Task InsertSection(InsertSectionRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a section to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertSectionOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> InsertSectionOnline(InsertSectionOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new StructuredDocumentTag (SDT) to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertStructuredDocumentTagRequest" /></param>
        /// <returns><see cref="StructuredDocumentTagResponse" /></returns>
        public async Task<StructuredDocumentTagResponse> InsertStructuredDocumentTag(InsertStructuredDocumentTagRequest request)
        {
            return (StructuredDocumentTagResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new StructuredDocumentTag (SDT) to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertStructuredDocumentTagOnlineRequest" /></param>
        /// <returns><see cref="InsertStructuredDocumentTagOnlineResponse" /></returns>
        public async Task<InsertStructuredDocumentTagOnlineResponse> InsertStructuredDocumentTagOnline(InsertStructuredDocumentTagOnlineRequest request)
        {
            return (InsertStructuredDocumentTagOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new style to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertStyleRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public async Task<StyleResponse> InsertStyle(InsertStyleRequest request)
        {
            return (StyleResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new style to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertStyleOnlineRequest" /></param>
        /// <returns><see cref="InsertStyleOnlineResponse" /></returns>
        public async Task<InsertStyleOnlineResponse> InsertStyleOnline(InsertStyleOnlineRequest request)
        {
            return (InsertStyleOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new table to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableRequest" /></param>
        /// <returns><see cref="TableResponse" /></returns>
        public async Task<TableResponse> InsertTable(InsertTableRequest request)
        {
            return (TableResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new cell to the table row.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableCellRequest" /></param>
        /// <returns><see cref="TableCellResponse" /></returns>
        public async Task<TableCellResponse> InsertTableCell(InsertTableCellRequest request)
        {
            return (TableCellResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new cell to the table row.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableCellOnlineRequest" /></param>
        /// <returns><see cref="InsertTableCellOnlineResponse" /></returns>
        public async Task<InsertTableCellOnlineResponse> InsertTableCellOnline(InsertTableCellOnlineRequest request)
        {
            return (InsertTableCellOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new table to the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableOnlineRequest" /></param>
        /// <returns><see cref="InsertTableOnlineResponse" /></returns>
        public async Task<InsertTableOnlineResponse> InsertTableOnline(InsertTableOnlineRequest request)
        {
            return (InsertTableOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new row to the table.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableRowRequest" /></param>
        /// <returns><see cref="TableRowResponse" /></returns>
        public async Task<TableRowResponse> InsertTableRow(InsertTableRowRequest request)
        {
            return (TableRowResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new row to the table.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertTableRowOnlineRequest" /></param>
        /// <returns><see cref="InsertTableRowOnlineResponse" /></returns>
        public async Task<InsertTableRowOnlineResponse> InsertTableRowOnline(InsertTableRowOnlineRequest request)
        {
            return (InsertTableRowOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Insert a watermark to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertWatermarkRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public async Task<DocumentResponse> InsertWatermark(InsertWatermarkRequest request)
        {
            return (DocumentResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new watermark image to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertWatermarkImageRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        [System.Obsolete("This operation is deprecated and is used for backward compatibility only. Please use InsertWatermark instead.")]
        public async Task<DocumentResponse> InsertWatermarkImage(InsertWatermarkImageRequest request)
        {
            return (DocumentResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new watermark image to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertWatermarkImageOnlineRequest" /></param>
        /// <returns><see cref="InsertWatermarkImageOnlineResponse" /></returns>
        [System.Obsolete("This operation is deprecated and is used for backward compatibility only. Please use InsertWatermark instead.")]
        public async Task<InsertWatermarkImageOnlineResponse> InsertWatermarkImageOnline(InsertWatermarkImageOnlineRequest request)
        {
            return (InsertWatermarkImageOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Insert a watermark to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertWatermarkOnlineRequest" /></param>
        /// <returns><see cref="InsertWatermarkOnlineResponse" /></returns>
        public async Task<InsertWatermarkOnlineResponse> InsertWatermarkOnline(InsertWatermarkOnlineRequest request)
        {
            return (InsertWatermarkOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new watermark text to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertWatermarkTextRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        [System.Obsolete("This operation is deprecated and is used for backward compatibility only. Please use InsertWatermark instead.")]
        public async Task<DocumentResponse> InsertWatermarkText(InsertWatermarkTextRequest request)
        {
            return (DocumentResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Inserts a new watermark text to the document.
        /// </summary>
        /// <param name="request">Request. <see cref="InsertWatermarkTextOnlineRequest" /></param>
        /// <returns><see cref="InsertWatermarkTextOnlineResponse" /></returns>
        [System.Obsolete("This operation is deprecated and is used for backward compatibility only. Please use InsertWatermark instead.")]
        public async Task<InsertWatermarkTextOnlineResponse> InsertWatermarkTextOnline(InsertWatermarkTextOnlineRequest request)
        {
            return (InsertWatermarkTextOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Links headers / footers of the section to the previous one.
        /// </summary>
        /// <param name="request">Request. <see cref="LinkHeaderFootersToPreviousRequest" /></param>
        public async Task LinkHeaderFootersToPrevious(LinkHeaderFootersToPreviousRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Downloads a document from the Web using URL and saves it to cloud storage in the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="LoadWebDocumentRequest" /></param>
        /// <returns><see cref="SaveResponse" /></returns>
        public async Task<SaveResponse> LoadWebDocument(LoadWebDocumentRequest request)
        {
            return (SaveResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Downloads a document from the Web using URL and saves it to cloud storage in the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="LoadWebDocumentOnlineRequest" /></param>
        /// <returns><see cref="LoadWebDocumentOnlineResponse" /></returns>
        public async Task<LoadWebDocumentOnlineResponse> LoadWebDocumentOnline(LoadWebDocumentOnlineRequest request)
        {
            return (LoadWebDocumentOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Merge the section with the next one.
        /// </summary>
        /// <param name="request">Request. <see cref="MergeWithNextRequest" /></param>
        public async Task MergeWithNext(MergeWithNextRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Merge the section with the next one.
        /// </summary>
        /// <param name="request">Request. <see cref="MergeWithNextOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> MergeWithNextOnline(MergeWithNextOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Move file.
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFileRequest" /></param>
        public async Task MoveFile(MoveFileRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Move folder.
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFolderRequest" /></param>
        public async Task MoveFolder(MoveFolderRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Applies document content optimization options, specific to a particular versions of Microsoft Word.
        /// </summary>
        /// <param name="request">Request. <see cref="OptimizeDocumentRequest" /></param>
        public async Task OptimizeDocument(OptimizeDocumentRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Applies document content optimization options, specific to a particular versions of Microsoft Word.
        /// </summary>
        /// <param name="request">Request. <see cref="OptimizeDocumentOnlineRequest" /></param>
        /// <returns><see cref="System.Collections.Generic.Dictionary<string, System.IO.Stream>" /></returns>
        public async Task<System.Collections.Generic.Dictionary<string, System.IO.Stream>> OptimizeDocumentOnline(OptimizeDocumentOnlineRequest request)
        {
            return (System.Collections.Generic.Dictionary<string, System.IO.Stream>)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Changes the document protection. The previous protection will be overwritten if it exist.
        /// </summary>
        /// <param name="request">Request. <see cref="ProtectDocumentRequest" /></param>
        /// <returns><see cref="ProtectionDataResponse" /></returns>
        public async Task<ProtectionDataResponse> ProtectDocument(ProtectDocumentRequest request)
        {
            return (ProtectionDataResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Changes the document protection. The previous protection will be overwritten if it exist.
        /// </summary>
        /// <param name="request">Request. <see cref="ProtectDocumentOnlineRequest" /></param>
        /// <returns><see cref="ProtectDocumentOnlineResponse" /></returns>
        public async Task<ProtectDocumentOnlineResponse> ProtectDocumentOnline(ProtectDocumentOnlineRequest request)
        {
            return (ProtectDocumentOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Rejects all revisions in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="RejectAllRevisionsRequest" /></param>
        /// <returns><see cref="RevisionsModificationResponse" /></returns>
        public async Task<RevisionsModificationResponse> RejectAllRevisions(RejectAllRevisionsRequest request)
        {
            return (RevisionsModificationResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Rejects all revisions in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="RejectAllRevisionsOnlineRequest" /></param>
        /// <returns><see cref="RejectAllRevisionsOnlineResponse" /></returns>
        public async Task<RejectAllRevisionsOnlineResponse> RejectAllRevisionsOnline(RejectAllRevisionsOnlineRequest request)
        {
            return (RejectAllRevisionsOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes all signatures of the document.
        /// </summary>
        /// <param name="request">Request. <see cref="RemoveAllSignaturesRequest" /></param>
        /// <returns><see cref="SignatureCollectionResponse" /></returns>
        public async Task<SignatureCollectionResponse> RemoveAllSignatures(RemoveAllSignaturesRequest request)
        {
            return (SignatureCollectionResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes all signatures of the document.
        /// </summary>
        /// <param name="request">Request. <see cref="RemoveAllSignaturesOnlineRequest" /></param>
        /// <returns><see cref="RemoveAllSignaturesOnlineResponse" /></returns>
        public async Task<RemoveAllSignaturesOnlineResponse> RemoveAllSignaturesOnline(RemoveAllSignaturesOnlineRequest request)
        {
            return (RemoveAllSignaturesOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a range from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="RemoveRangeRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public async Task<DocumentResponse> RemoveRange(RemoveRangeRequest request)
        {
            return (DocumentResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes a range from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="RemoveRangeOnlineRequest" /></param>
        /// <returns><see cref="RemoveRangeOnlineResponse" /></returns>
        public async Task<RemoveRangeOnlineResponse> RemoveRangeOnline(RemoveRangeOnlineRequest request)
        {
            return (RemoveRangeOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Renders a DrawingObject to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderDrawingObjectRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public async Task<System.IO.Stream> RenderDrawingObject(RenderDrawingObjectRequest request)
        {
            return (System.IO.Stream)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Renders a DrawingObject to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderDrawingObjectOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public async Task<System.IO.Stream> RenderDrawingObjectOnline(RenderDrawingObjectOnlineRequest request)
        {
            return (System.IO.Stream)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Renders an OfficeMath object to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderMathObjectRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public async Task<System.IO.Stream> RenderMathObject(RenderMathObjectRequest request)
        {
            return (System.IO.Stream)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Renders an OfficeMath object to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderMathObjectOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public async Task<System.IO.Stream> RenderMathObjectOnline(RenderMathObjectOnlineRequest request)
        {
            return (System.IO.Stream)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Renders a page to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderPageRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public async Task<System.IO.Stream> RenderPage(RenderPageRequest request)
        {
            return (System.IO.Stream)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Renders a page to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderPageOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public async Task<System.IO.Stream> RenderPageOnline(RenderPageOnlineRequest request)
        {
            return (System.IO.Stream)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Renders a paragraph to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderParagraphRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public async Task<System.IO.Stream> RenderParagraph(RenderParagraphRequest request)
        {
            return (System.IO.Stream)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Renders a paragraph to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderParagraphOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public async Task<System.IO.Stream> RenderParagraphOnline(RenderParagraphOnlineRequest request)
        {
            return (System.IO.Stream)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Renders a table to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderTableRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public async Task<System.IO.Stream> RenderTable(RenderTableRequest request)
        {
            return (System.IO.Stream)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Renders a table to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="RenderTableOnlineRequest" /></param>
        /// <returns><see cref="System.IO.Stream" /></returns>
        public async Task<System.IO.Stream> RenderTableOnline(RenderTableOnlineRequest request)
        {
            return (System.IO.Stream)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Replaces text in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="ReplaceTextRequest" /></param>
        /// <returns><see cref="ReplaceTextResponse" /></returns>
        public async Task<ReplaceTextResponse> ReplaceText(ReplaceTextRequest request)
        {
            return (ReplaceTextResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Replaces text in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="ReplaceTextOnlineRequest" /></param>
        /// <returns><see cref="ReplaceTextOnlineResponse" /></returns>
        public async Task<ReplaceTextOnlineResponse> ReplaceTextOnline(ReplaceTextOnlineRequest request)
        {
            return (ReplaceTextOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Replaces a range with text in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="ReplaceWithTextRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public async Task<DocumentResponse> ReplaceWithText(ReplaceWithTextRequest request)
        {
            return (DocumentResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Replaces a range with text in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="ReplaceWithTextOnlineRequest" /></param>
        /// <returns><see cref="ReplaceWithTextOnlineResponse" /></returns>
        public async Task<ReplaceWithTextOnlineResponse> ReplaceWithTextOnline(ReplaceWithTextOnlineRequest request)
        {
            return (ReplaceWithTextOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Clears the font cache.
        /// </summary>
        /// <param name="request">Request. <see cref="ResetCacheRequest" /></param>
        public async Task ResetCache(ResetCacheRequest request)
        {
        await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Converts a document in cloud storage to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="SaveAsRequest" /></param>
        /// <returns><see cref="SaveResponse" /></returns>
        public async Task<SaveResponse> SaveAs(SaveAsRequest request)
        {
            return (SaveResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Converts a document in cloud storage to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="SaveAsOnlineRequest" /></param>
        /// <returns><see cref="SaveAsOnlineResponse" /></returns>
        public async Task<SaveAsOnlineResponse> SaveAsOnline(SaveAsOnlineRequest request)
        {
            return (SaveAsOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Saves a range as a new document.
        /// </summary>
        /// <param name="request">Request. <see cref="SaveAsRangeRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public async Task<DocumentResponse> SaveAsRange(SaveAsRangeRequest request)
        {
            return (DocumentResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Saves a range as a new document.
        /// </summary>
        /// <param name="request">Request. <see cref="SaveAsRangeOnlineRequest" /></param>
        /// <returns><see cref="SaveAsRangeOnlineResponse" /></returns>
        public async Task<SaveAsRangeOnlineResponse> SaveAsRangeOnline(SaveAsRangeOnlineRequest request)
        {
            return (SaveAsRangeOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Converts a document in cloud storage to TIFF format using detailed conversion settings.
        /// </summary>
        /// <param name="request">Request. <see cref="SaveAsTiffRequest" /></param>
        /// <returns><see cref="SaveResponse" /></returns>
        [System.Obsolete("This operation will be removed in the future.")]
        public async Task<SaveResponse> SaveAsTiff(SaveAsTiffRequest request)
        {
            return (SaveResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Converts a document in cloud storage to TIFF format using detailed conversion settings.
        /// </summary>
        /// <param name="request">Request. <see cref="SaveAsTiffOnlineRequest" /></param>
        /// <returns><see cref="SaveAsTiffOnlineResponse" /></returns>
        [System.Obsolete("This operation will be removed in the future.")]
        public async Task<SaveAsTiffOnlineResponse> SaveAsTiffOnline(SaveAsTiffOnlineRequest request)
        {
            return (SaveAsTiffOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Searches text, specified by the regular expression, in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="SearchRequest" /></param>
        /// <returns><see cref="SearchResponse" /></returns>
        public async Task<SearchResponse> Search(SearchRequest request)
        {
            return (SearchResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Searches text, specified by the regular expression, in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="SearchOnlineRequest" /></param>
        /// <returns><see cref="SearchResponse" /></returns>
        public async Task<SearchResponse> SearchOnline(SearchOnlineRequest request)
        {
            return (SearchResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Signs the document with given certificate.
        /// </summary>
        /// <param name="request">Request. <see cref="SignDocumentRequest" /></param>
        /// <returns><see cref="SignatureCollectionResponse" /></returns>
        public async Task<SignatureCollectionResponse> SignDocument(SignDocumentRequest request)
        {
            return (SignatureCollectionResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Signs the document with given certificate.
        /// </summary>
        /// <param name="request">Request. <see cref="SignDocumentOnlineRequest" /></param>
        /// <returns><see cref="SignDocumentOnlineResponse" /></returns>
        public async Task<SignDocumentOnlineResponse> SignDocumentOnline(SignDocumentOnlineRequest request)
        {
            return (SignDocumentOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Splits a document into parts and saves them in the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="SplitDocumentRequest" /></param>
        /// <returns><see cref="SplitDocumentResponse" /></returns>
        public async Task<SplitDocumentResponse> SplitDocument(SplitDocumentRequest request)
        {
            return (SplitDocumentResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Splits a document into parts and saves them in the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="SplitDocumentJobRequest" /></param>
        /// <returns><see cref="JobHandler< SplitDocumentResponse >" /></returns>
        public async Task<JobHandler< SplitDocumentResponse >> SplitDocumentJob(SplitDocumentJobRequest request)
        {
            var info = (JobInfo)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
            return new JobHandler< SplitDocumentResponse >(this.apiInvoker, request.GetOriginalRequest(), info);
        }

        /// <summary>
        /// Splits a document into parts and saves them in the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="SplitDocumentOnlineRequest" /></param>
        /// <returns><see cref="SplitDocumentOnlineResponse" /></returns>
        public async Task<SplitDocumentOnlineResponse> SplitDocumentOnline(SplitDocumentOnlineRequest request)
        {
            return (SplitDocumentOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Splits a document into parts and saves them in the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="SplitDocumentOnlineJobRequest" /></param>
        /// <returns><see cref="JobHandler< SplitDocumentOnlineResponse >" /></returns>
        public async Task<JobHandler< SplitDocumentOnlineResponse >> SplitDocumentOnlineJob(SplitDocumentOnlineJobRequest request)
        {
            var info = (JobInfo)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
            return new JobHandler< SplitDocumentOnlineResponse >(this.apiInvoker, request.GetOriginalRequest(), info);
        }

        /// <summary>
        /// Translate a node id to a node path.
        /// </summary>
        /// <param name="request">Request. <see cref="TranslateNodeIdRequest" /></param>
        /// <returns><see cref="TranslateNodeIdResponse" /></returns>
        public async Task<TranslateNodeIdResponse> TranslateNodeId(TranslateNodeIdRequest request)
        {
            return (TranslateNodeIdResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Translate a node id to a node path.
        /// </summary>
        /// <param name="request">Request. <see cref="TranslateNodeIdOnlineRequest" /></param>
        /// <returns><see cref="TranslateNodeIdResponse" /></returns>
        public async Task<TranslateNodeIdResponse> TranslateNodeIdOnline(TranslateNodeIdOnlineRequest request)
        {
            return (TranslateNodeIdResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes protection from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UnprotectDocumentRequest" /></param>
        /// <returns><see cref="ProtectionDataResponse" /></returns>
        public async Task<ProtectionDataResponse> UnprotectDocument(UnprotectDocumentRequest request)
        {
            return (ProtectionDataResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Removes protection from the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UnprotectDocumentOnlineRequest" /></param>
        /// <returns><see cref="UnprotectDocumentOnlineResponse" /></returns>
        public async Task<UnprotectDocumentOnlineResponse> UnprotectDocumentOnline(UnprotectDocumentOnlineRequest request)
        {
            return (UnprotectDocumentOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates a bookmark in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateBookmarkRequest" /></param>
        /// <returns><see cref="BookmarkResponse" /></returns>
        public async Task<BookmarkResponse> UpdateBookmark(UpdateBookmarkRequest request)
        {
            return (BookmarkResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates a bookmark in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateBookmarkOnlineRequest" /></param>
        /// <returns><see cref="UpdateBookmarkOnlineResponse" /></returns>
        public async Task<UpdateBookmarkOnlineResponse> UpdateBookmarkOnline(UpdateBookmarkOnlineRequest request)
        {
            return (UpdateBookmarkOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates a border in the document node.
        /// The 'nodePath' parameter should refer to a paragraph, a cell or a row.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateBorderRequest" /></param>
        /// <returns><see cref="BorderResponse" /></returns>
        public async Task<BorderResponse> UpdateBorder(UpdateBorderRequest request)
        {
            return (BorderResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates a border in the document node.
        /// The 'nodePath' parameter should refer to a paragraph, a cell or a row.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateBorderOnlineRequest" /></param>
        /// <returns><see cref="UpdateBorderOnlineResponse" /></returns>
        public async Task<UpdateBorderOnlineResponse> UpdateBorderOnline(UpdateBorderOnlineRequest request)
        {
            return (UpdateBorderOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates a comment in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateCommentRequest" /></param>
        /// <returns><see cref="CommentResponse" /></returns>
        public async Task<CommentResponse> UpdateComment(UpdateCommentRequest request)
        {
            return (CommentResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates a comment in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateCommentOnlineRequest" /></param>
        /// <returns><see cref="UpdateCommentOnlineResponse" /></returns>
        public async Task<UpdateCommentOnlineResponse> UpdateCommentOnline(UpdateCommentOnlineRequest request)
        {
            return (UpdateCommentOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates the custom xml part in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateCustomXmlPartRequest" /></param>
        /// <returns><see cref="CustomXmlPartResponse" /></returns>
        public async Task<CustomXmlPartResponse> UpdateCustomXmlPart(UpdateCustomXmlPartRequest request)
        {
            return (CustomXmlPartResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates the custom xml part in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateCustomXmlPartOnlineRequest" /></param>
        /// <returns><see cref="UpdateCustomXmlPartOnlineResponse" /></returns>
        public async Task<UpdateCustomXmlPartOnlineResponse> UpdateCustomXmlPartOnline(UpdateCustomXmlPartOnlineRequest request)
        {
            return (UpdateCustomXmlPartOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates a DrawingObject in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateDrawingObjectRequest" /></param>
        /// <returns><see cref="DrawingObjectResponse" /></returns>
        public async Task<DrawingObjectResponse> UpdateDrawingObject(UpdateDrawingObjectRequest request)
        {
            return (DrawingObjectResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates a DrawingObject in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateDrawingObjectOnlineRequest" /></param>
        /// <returns><see cref="UpdateDrawingObjectOnlineResponse" /></returns>
        public async Task<UpdateDrawingObjectOnlineResponse> UpdateDrawingObjectOnline(UpdateDrawingObjectOnlineRequest request)
        {
            return (UpdateDrawingObjectOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates a field in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFieldRequest" /></param>
        /// <returns><see cref="FieldResponse" /></returns>
        public async Task<FieldResponse> UpdateField(UpdateFieldRequest request)
        {
            return (FieldResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates a field in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFieldOnlineRequest" /></param>
        /// <returns><see cref="UpdateFieldOnlineResponse" /></returns>
        public async Task<UpdateFieldOnlineResponse> UpdateFieldOnline(UpdateFieldOnlineRequest request)
        {
            return (UpdateFieldOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reevaluates field values in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFieldsRequest" /></param>
        /// <returns><see cref="DocumentResponse" /></returns>
        public async Task<DocumentResponse> UpdateFields(UpdateFieldsRequest request)
        {
            return (DocumentResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Reevaluates field values in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFieldsOnlineRequest" /></param>
        /// <returns><see cref="UpdateFieldsOnlineResponse" /></returns>
        public async Task<UpdateFieldsOnlineResponse> UpdateFieldsOnline(UpdateFieldsOnlineRequest request)
        {
            return (UpdateFieldsOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates a footnote in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFootnoteRequest" /></param>
        /// <returns><see cref="FootnoteResponse" /></returns>
        public async Task<FootnoteResponse> UpdateFootnote(UpdateFootnoteRequest request)
        {
            return (FootnoteResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates a footnote in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFootnoteOnlineRequest" /></param>
        /// <returns><see cref="UpdateFootnoteOnlineResponse" /></returns>
        public async Task<UpdateFootnoteOnlineResponse> UpdateFootnoteOnline(UpdateFootnoteOnlineRequest request)
        {
            return (UpdateFootnoteOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates a form field in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFormFieldRequest" /></param>
        /// <returns><see cref="FormFieldResponse" /></returns>
        public async Task<FormFieldResponse> UpdateFormField(UpdateFormFieldRequest request)
        {
            return (FormFieldResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates a form field in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateFormFieldOnlineRequest" /></param>
        /// <returns><see cref="UpdateFormFieldOnlineResponse" /></returns>
        public async Task<UpdateFormFieldOnlineResponse> UpdateFormFieldOnline(UpdateFormFieldOnlineRequest request)
        {
            return (UpdateFormFieldOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates a list in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateListRequest" /></param>
        /// <returns><see cref="ListResponse" /></returns>
        public async Task<ListResponse> UpdateList(UpdateListRequest request)
        {
            return (ListResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates the level of a List element in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateListLevelRequest" /></param>
        /// <returns><see cref="ListResponse" /></returns>
        public async Task<ListResponse> UpdateListLevel(UpdateListLevelRequest request)
        {
            return (ListResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates the level of a List element in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateListLevelOnlineRequest" /></param>
        /// <returns><see cref="UpdateListLevelOnlineResponse" /></returns>
        public async Task<UpdateListLevelOnlineResponse> UpdateListLevelOnline(UpdateListLevelOnlineRequest request)
        {
            return (UpdateListLevelOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates a list in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateListOnlineRequest" /></param>
        /// <returns><see cref="UpdateListOnlineResponse" /></returns>
        public async Task<UpdateListOnlineResponse> UpdateListOnline(UpdateListOnlineRequest request)
        {
            return (UpdateListOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates the formatting properties of a paragraph in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateParagraphFormatRequest" /></param>
        /// <returns><see cref="ParagraphFormatResponse" /></returns>
        public async Task<ParagraphFormatResponse> UpdateParagraphFormat(UpdateParagraphFormatRequest request)
        {
            return (ParagraphFormatResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates the formatting properties of a paragraph in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateParagraphFormatOnlineRequest" /></param>
        /// <returns><see cref="UpdateParagraphFormatOnlineResponse" /></returns>
        public async Task<UpdateParagraphFormatOnlineResponse> UpdateParagraphFormatOnline(UpdateParagraphFormatOnlineRequest request)
        {
            return (UpdateParagraphFormatOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates the formatting properties of a paragraph list in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateParagraphListFormatRequest" /></param>
        /// <returns><see cref="ParagraphListFormatResponse" /></returns>
        public async Task<ParagraphListFormatResponse> UpdateParagraphListFormat(UpdateParagraphListFormatRequest request)
        {
            return (ParagraphListFormatResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates the formatting properties of a paragraph list in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateParagraphListFormatOnlineRequest" /></param>
        /// <returns><see cref="UpdateParagraphListFormatOnlineResponse" /></returns>
        public async Task<UpdateParagraphListFormatOnlineResponse> UpdateParagraphListFormatOnline(UpdateParagraphListFormatOnlineRequest request)
        {
            return (UpdateParagraphListFormatOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates a Run object in the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateRunRequest" /></param>
        /// <returns><see cref="RunResponse" /></returns>
        public async Task<RunResponse> UpdateRun(UpdateRunRequest request)
        {
            return (RunResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates the font properties of a Run object in the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateRunFontRequest" /></param>
        /// <returns><see cref="FontResponse" /></returns>
        public async Task<FontResponse> UpdateRunFont(UpdateRunFontRequest request)
        {
            return (FontResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates the font properties of a Run object in the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateRunFontOnlineRequest" /></param>
        /// <returns><see cref="UpdateRunFontOnlineResponse" /></returns>
        public async Task<UpdateRunFontOnlineResponse> UpdateRunFontOnline(UpdateRunFontOnlineRequest request)
        {
            return (UpdateRunFontOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates a Run object in the paragraph.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateRunOnlineRequest" /></param>
        /// <returns><see cref="UpdateRunOnlineResponse" /></returns>
        public async Task<UpdateRunOnlineResponse> UpdateRunOnline(UpdateRunOnlineRequest request)
        {
            return (UpdateRunOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates the page setup of a section in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateSectionPageSetupRequest" /></param>
        /// <returns><see cref="SectionPageSetupResponse" /></returns>
        public async Task<SectionPageSetupResponse> UpdateSectionPageSetup(UpdateSectionPageSetupRequest request)
        {
            return (SectionPageSetupResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates the page setup of a section in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateSectionPageSetupOnlineRequest" /></param>
        /// <returns><see cref="UpdateSectionPageSetupOnlineResponse" /></returns>
        public async Task<UpdateSectionPageSetupOnlineResponse> UpdateSectionPageSetupOnline(UpdateSectionPageSetupOnlineRequest request)
        {
            return (UpdateSectionPageSetupOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates a StructuredDocumentTag (SDT) in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateStructuredDocumentTagRequest" /></param>
        /// <returns><see cref="StructuredDocumentTagResponse" /></returns>
        public async Task<StructuredDocumentTagResponse> UpdateStructuredDocumentTag(UpdateStructuredDocumentTagRequest request)
        {
            return (StructuredDocumentTagResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates a StructuredDocumentTag (SDT) in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateStructuredDocumentTagOnlineRequest" /></param>
        /// <returns><see cref="UpdateStructuredDocumentTagOnlineResponse" /></returns>
        public async Task<UpdateStructuredDocumentTagOnlineResponse> UpdateStructuredDocumentTagOnline(UpdateStructuredDocumentTagOnlineRequest request)
        {
            return (UpdateStructuredDocumentTagOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates a style in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateStyleRequest" /></param>
        /// <returns><see cref="StyleResponse" /></returns>
        public async Task<StyleResponse> UpdateStyle(UpdateStyleRequest request)
        {
            return (StyleResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates a style in the document.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateStyleOnlineRequest" /></param>
        /// <returns><see cref="UpdateStyleOnlineResponse" /></returns>
        public async Task<UpdateStyleOnlineResponse> UpdateStyleOnline(UpdateStyleOnlineRequest request)
        {
            return (UpdateStyleOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates the formatting properties of a cell in the table row.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTableCellFormatRequest" /></param>
        /// <returns><see cref="TableCellFormatResponse" /></returns>
        public async Task<TableCellFormatResponse> UpdateTableCellFormat(UpdateTableCellFormatRequest request)
        {
            return (TableCellFormatResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates the formatting properties of a cell in the table row.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTableCellFormatOnlineRequest" /></param>
        /// <returns><see cref="UpdateTableCellFormatOnlineResponse" /></returns>
        public async Task<UpdateTableCellFormatOnlineResponse> UpdateTableCellFormatOnline(UpdateTableCellFormatOnlineRequest request)
        {
            return (UpdateTableCellFormatOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates properties of a table in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTablePropertiesRequest" /></param>
        /// <returns><see cref="TablePropertiesResponse" /></returns>
        public async Task<TablePropertiesResponse> UpdateTableProperties(UpdateTablePropertiesRequest request)
        {
            return (TablePropertiesResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates properties of a table in the document node.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTablePropertiesOnlineRequest" /></param>
        /// <returns><see cref="UpdateTablePropertiesOnlineResponse" /></returns>
        public async Task<UpdateTablePropertiesOnlineResponse> UpdateTablePropertiesOnline(UpdateTablePropertiesOnlineRequest request)
        {
            return (UpdateTablePropertiesOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates the formatting properties of a table row.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTableRowFormatRequest" /></param>
        /// <returns><see cref="TableRowFormatResponse" /></returns>
        public async Task<TableRowFormatResponse> UpdateTableRowFormat(UpdateTableRowFormatRequest request)
        {
            return (TableRowFormatResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Updates the formatting properties of a table row.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateTableRowFormatOnlineRequest" /></param>
        /// <returns><see cref="UpdateTableRowFormatOnlineResponse" /></returns>
        public async Task<UpdateTableRowFormatOnlineResponse> UpdateTableRowFormatOnline(UpdateTableRowFormatOnlineRequest request)
        {
            return (UpdateTableRowFormatOnlineResponse)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Upload file.
        /// </summary>
        /// <param name="request">Request. <see cref="UploadFileRequest" /></param>
        /// <returns><see cref="FilesUploadResult" /></returns>
        public async Task<FilesUploadResult> UploadFile(UploadFileRequest request)
        {
            return (FilesUploadResult)await request.DeserializeResponse(await this.apiInvoker.InvokeApi(async () => await request.CreateHttpRequest(this.configuration, this)));
        }

        /// <summary>
        /// Batch request.
        /// </summary>
        /// <param name="requests">Array of <see cref="BatchPartRequest" /> requests.</param>
        /// <returns><see cref="object[]" /></returns>
        public async Task<object[]> Batch(params BatchPartRequest[] requests)
        {
            return await this.Batch(true, requests);
        }

        /// <summary>
        /// Batch request.
        /// </summary>
        /// <param name="displayIntermediateResults">Display intermediate results or not.</param>
        /// <param name="requests">Array of <see cref="BatchPartRequest" /> requests.</param>
        /// <returns><see cref="object[]" /></returns>
        public async Task<object[]> Batch(bool displayIntermediateResults, params BatchPartRequest[] requests)
        {
            if (requests == null || requests.Length == 0)
            {
                 return null;
            }

            var idToRequestMap = requests.ToDictionary(x => x.RequestId, x => x);

            var url = this.configuration.GetApiRootUrl() + "/words/batch";
            if (!displayIntermediateResults)
            {
                url += "?displayIntermediateResults=false";
            }

            var response = await this.apiInvoker.InvokeApi(async () =>
            {
                var multipartFormDataContent = new MultipartFormDataContent();
                foreach (var request in requests)
                {
                    multipartFormDataContent.Add(new ChildRequestContent(this.configuration, await request.CreateHttpRequest(this.configuration, this)));
                }

                var httpContent = new HttpRequestMessage(HttpMethod.Put, url);
                httpContent.Content = multipartFormDataContent;
                return httpContent;
            });
            var responseParts = await ApiInvoker.ToMultipartOrderedParts(response);

            if (displayIntermediateResults && responseParts.Length != requests.Length)
            {
                 throw new ApiException(400, "The number of responses does not match the number of requests.");
            }

            var result = new object[responseParts.Length];
            for (int i = 0; i < responseParts.Length; i++)
            {
                var responsePart = responseParts[i];
                var requestId = responsePart.GetHeader("RequestId");
                if (!string.IsNullOrEmpty(requestId) && idToRequestMap.ContainsKey(requestId))
                {
                    try
                    {
                        result[i] = await ApiInvoker.DeserializeHttpResponsePart(idToRequestMap[requestId].Request, responsePart);
                    }
                    catch (Exception ex)
                    {
                        result[i] = ex;
                    }
                }
                else
                {
                    try
                    {
                        throw new ApiException(400, "API doesn't return a RequestId header");
                    }
                    catch (Exception ex)
                    {
                        result[i] = ex;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Encrypt a string.
        /// </summary>
        /// <param name="data">data to encrypt.</param>
        /// <returns>encrypted data as base64 string.</returns>
        public async Task<string> Encrypt(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return data;
            }

            if (this.encryptor == null)
            {
                this.encryptor = new RSACryptoServiceProvider();

                if (string.IsNullOrEmpty(this.configuration.Exponent) || string.IsNullOrEmpty(this.configuration.Exponent))
                {
                    var publicKey = await this.GetPublicKey(new GetPublicKeyRequest());

                    this.encryptor.ImportParameters(new RSAParameters
                    {
                        Exponent = Convert.FromBase64String(publicKey.Exponent),
                        Modulus = Convert.FromBase64String(publicKey.Modulus),
                    });
                }
                else
                {
                    this.encryptor.ImportParameters(new RSAParameters
                    {
                        Exponent = Convert.FromBase64String(this.configuration.Exponent),
                        Modulus = Convert.FromBase64String(this.configuration.Modulus),
                    });
                }
            }

            return Convert.ToBase64String(this.encryptor.Encrypt(Encoding.UTF8.GetBytes(data), RSAEncryptionPadding.Pkcs1));
        }
    }
}
