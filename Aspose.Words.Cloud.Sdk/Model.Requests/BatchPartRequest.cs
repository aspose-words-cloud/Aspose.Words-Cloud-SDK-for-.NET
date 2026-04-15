// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BatchPartRequest.cs">
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
    using System.IO;
    using System.Net.Http;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// An IRequestModel wrapper to add batch part features.
    /// </summary>
    public class BatchPartRequest
    {
        private IRequestModel request;

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchPartRequest"/> class.
        /// </summary>
        /// <param name="request">inner request.</param>
        public BatchPartRequest(IRequestModel request)
        {
            this.request = request ?? throw new ArgumentNullException(nameof(request));
        }

        /// <summary>
        /// Gets request ID.
        /// </summary>
        public string RequestId { get; } = Guid.NewGuid().ToString();

        /// <summary>
        /// Gets or sets parent request ID.
        /// </summary>
        public string ParentRequestId { get; set; } = null;

        /// <summary>
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="configuration">SDK configuration.</param>
        /// <param name="encryptor">password encryptor.</param>
        /// <returns>The http request instance.</returns>
        public async Task<HttpRequestMessage> CreateHttpRequest(Configuration configuration, IEncryptor encryptor)
        {
            var httpMessage = await this.request.CreateHttpRequest(configuration, encryptor);

            httpMessage.Headers.Add("RequestId", this.RequestId);

            if (this.ParentRequestId != null)
            {
                httpMessage.Headers.Add("DependsOn", this.ParentRequestId);
            }

            return httpMessage;
        }

        /// <summary>
        /// Deserialize response object.
        /// </summary>
        /// <param name="message">Response message.</param>
        /// <returns>Response type.</returns>
        public async Task<object> DeserializeResponse(HttpResponseMessage message) => await this.request.DeserializeResponse(message);

        /// <summary>
        /// Gets inner request.
        /// </summary>
        internal IRequestModel Request => this.request;

        /// <summary>
        /// Set parent request.
        /// </summary>
        /// <param name="parentRequest">a parent request.</param>
        /// <returns>the modified child request.</returns>
        public BatchPartRequest DependsOn(BatchPartRequest parentRequest)
        {
            this.ParentRequestId = parentRequest.RequestId;
            return this;
        }

        /// <summary>
        /// Use a binary response of the request as an input for another request.
        /// </summary>
        /// <returns>A template that will be fulfilled with response data of the request.</returns>
        public Stream UseAsSource()
        {
            return new MemoryStream(Encoding.UTF8.GetBytes($"resultOf({this.RequestId})"));
        }
    }
}
