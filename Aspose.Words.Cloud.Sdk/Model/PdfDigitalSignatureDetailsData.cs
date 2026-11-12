// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PdfDigitalSignatureDetailsData.cs">
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
    /// Container class for details of digital signature.
    /// </summary>
    public class PdfDigitalSignatureDetailsData : IModel
    {
        /// <summary>
        /// Gets or sets the hash algorithm.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HashAlgorithmEnum
        {
            /// <summary>
            /// Enum value "Sha256"
            /// </summary>
            Sha256,

            /// <summary>
            /// Enum value "Sha384"
            /// </summary>
            Sha384,

            /// <summary>
            /// Enum value "Sha512"
            /// </summary>
            Sha512,

            /// <summary>
            /// Enum value "RipeMD160"
            /// </summary>
            RipeMD160,

            /// <summary>
            /// Enum value "Auto"
            /// </summary>
            Auto,
        }

        /// <summary>
        /// Gets or sets the certificate's filename using for signing.
        /// </summary>
        public virtual string CertificateFilename { get; set; }

        /// <summary>
        /// Gets or sets the hash algorithm.
        /// </summary>
        public virtual HashAlgorithmEnum? HashAlgorithm { get; set; }

        /// <summary>
        /// Gets or sets the location of the signing.
        /// </summary>
        public virtual string Location { get; set; }

        /// <summary>
        /// Gets or sets the reason for the signing.
        /// </summary>
        public virtual string Reason { get; set; }

        /// <summary>
        /// Gets or sets the date of the signing.
        /// </summary>
        public virtual DateTime? SignatureDate { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public virtual void Validate()
        {
        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PdfDigitalSignatureDetailsData {\n");
            sb.Append("  CertificateFilename: ").Append(this.CertificateFilename).Append("\n");
            sb.Append("  HashAlgorithm: ").Append(this.HashAlgorithm).Append("\n");
            sb.Append("  Location: ").Append(this.Location).Append("\n");
            sb.Append("  Reason: ").Append(this.Reason).Append("\n");
            sb.Append("  SignatureDate: ").Append(this.SignatureDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
