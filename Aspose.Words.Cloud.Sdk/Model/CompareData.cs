// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CompareData.cs">
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
    /// Container class for compare documents.
    /// </summary>
    public class CompareData : IFileReference, IModel
    {
        /// <summary>
        /// Gets or sets advanced compare options that might help to produce more precise comparison output.
        /// </summary>
        public virtual AdvancedCompareOptions AdvancedOptions { get; set; }

        /// <summary>
        /// Gets or sets the initials of the author to use for revisions.
        /// </summary>
        public virtual string Author { get; set; }

        /// <summary>
        /// Gets or sets the compare options.
        /// </summary>
        public virtual CompareOptions CompareOptions { get; set; }

        /// <summary>
        /// Gets or sets the path to document to compare at the server.
        /// </summary>
        [Obsolete("This field is deprecated and used only for backward compatibility. Please use FileReference instead.")]
        public virtual string ComparingWithDocument { get; set; }

        /// <summary>
        /// Gets or sets the date and time to use for revisions.
        /// </summary>
        public virtual DateTime? DateTime { get; set; }

        /// <summary>
        /// Gets or sets the file reference.
        /// </summary>
        public virtual FileReference FileReference { get; set; }

        /// <summary>
        /// Gets or sets the result document format.
        /// </summary>
        public virtual string ResultDocumentFormat { get; set; }

        /// <summary>
        /// Collect all files content properties.
        /// </summary>
        /// <param name="resultFileReferences">File references collection used to append new references from current model.</param>
        public virtual void CollectFileReferences(ref List<FileReference> resultFileReferences)
        {
            if (this.FileReference != null)
            {
                this.FileReference.CollectFileReferences(ref resultFileReferences);
            }


        }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Author == null)
            {
                throw new ArgumentException("Property Author in CompareData is required.");
            }
            if (this.FileReference == null)
            {
                throw new ArgumentException("Property FileReference in CompareData is required.");
            }

            this.AdvancedOptions?.Validate();




            this.CompareOptions?.Validate();





            this.FileReference?.Validate();


        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompareData {\n");
            sb.Append("  AdvancedOptions: ").Append(this.AdvancedOptions).Append("\n");
            sb.Append("  Author: ").Append(this.Author).Append("\n");
            sb.Append("  CompareOptions: ").Append(this.CompareOptions).Append("\n");
            sb.Append("  ComparingWithDocument: ").Append(this.ComparingWithDocument).Append("\n");
            sb.Append("  DateTime: ").Append(this.DateTime).Append("\n");
            sb.Append("  FileReference: ").Append(this.FileReference).Append("\n");
            sb.Append("  ResultDocumentFormat: ").Append(this.ResultDocumentFormat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
