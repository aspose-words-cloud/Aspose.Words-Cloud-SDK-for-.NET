// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="JobInfo.cs">
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

namespace Aspose.Words.Cloud.Sdk.Model
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The REST response with a job result.
    /// </summary>
    public class JobInfo : IModel
    {
        /// <summary>
        /// Gets or sets the job status.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum value "Unknown"
            /// </summary>
            Unknown,

            /// <summary>
            /// Enum value "Queued"
            /// </summary>
            Queued,

            /// <summary>
            /// Enum value "Processing"
            /// </summary>
            Processing,

            /// <summary>
            /// Enum value "Succeded"
            /// </summary>
            Succeded,

            /// <summary>
            /// Enum value "Failed"
            /// </summary>
            Failed,
        }

        /// <summary>
        /// Gets or sets the job id.
        /// </summary>
        public virtual string JobId { get; set; }

        /// <summary>
        /// Gets or sets the job message.
        /// </summary>
        public virtual string Message { get; set; }

        /// <summary>
        /// Gets or sets the job status.
        /// </summary>
        public virtual StatusEnum? Status { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Status == null)
            {
                throw new ArgumentException("Property Status in JobInfo is required.");
            }
        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobInfo {\n");
            sb.Append("  JobId: ").Append(this.JobId).Append("\n");
            sb.Append("  Message: ").Append(this.Message).Append("\n");
            sb.Append("  Status: ").Append(this.Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
