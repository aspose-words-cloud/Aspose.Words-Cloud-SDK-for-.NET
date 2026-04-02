// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="JobHandler.cs">
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

namespace Aspose.Words.Cloud.Sdk.Api
{
    using System;
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;

    /// <summary>
    /// Handles asynchronous job execution and polling.
    /// </summary>
    public class JobHandler<T>
    {
        private readonly ApiInvoker apiInvoker;
        private readonly IRequestModel request;
        private JobInfo info;
        private T result;

        internal JobHandler(ApiInvoker apiInvoker, IRequestModel request, JobInfo info)
        {
            this.apiInvoker = apiInvoker;
            this.request = request;
            this.info = info;
        }

        /// <summary>
        /// Gets current job status.
        /// </summary>
        public JobInfo.StatusEnum? Status => this.info?.Status;

        /// <summary>
        /// Gets current job message.
        /// </summary>
        public string Message => this.info?.Message ?? string.Empty;

        /// <summary>
        /// Gets resolved result when available.
        /// </summary>
        public T Result => this.result;

        /// <summary>
        /// Updates job status and result.
        /// </summary>
        /// <returns>Resolved result when available.</returns>
        public async Task<T> Update()
        {
            if (string.IsNullOrEmpty(this.info?.JobId))
            {
                throw new ApiException(400, "Invalid job id.");
            }

            var responseParts = await this.apiInvoker.CallJobResult(this.info.JobId);
            if (responseParts.Length >= 1)
            {
                this.info = await ApiInvoker.DeserializeJobInfoPart(responseParts[0]);
                if (responseParts.Length >= 2 && this.info.Status == JobInfo.StatusEnum.Succeded)
                {
                    this.result = (T)await ApiInvoker.DeserializeHttpResponsePart(this.request, responseParts[1]);
                }
            }

            return this.result;
        }

        /// <summary>
        /// Waits for job completion with the default polling interval.
        /// </summary>
        /// <returns>Resolved result.</returns>
        public async Task<T> WaitResult()
        {
            return await this.WaitResult(TimeSpan.FromSeconds(3));
        }

        /// <summary>
        /// Waits for job completion.
        /// </summary>
        /// <param name="updateInterval">Polling interval.</param>
        /// <returns>Resolved result.</returns>
        public async Task<T> WaitResult(TimeSpan updateInterval)
        {
            while (this.info?.Status == JobInfo.StatusEnum.Queued || this.info?.Status == JobInfo.StatusEnum.Processing)
            {
                await Task.Delay(updateInterval);
                await this.Update();
            }

            if (Equals(this.result, default(T)) && this.info?.Status == JobInfo.StatusEnum.Succeded)
            {
                await this.Update();
            }

            if (this.info?.Status != JobInfo.StatusEnum.Succeded)
            {
                throw new ApiException(400, $"Job failed with status \"{this.info?.Status}\" - \"{this.Message}\".");
            }

            return this.result;
        }
    }
}
