// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DrawingObjectInsertData.cs">
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
    /// Drawing object element for insert with the image passed by reference.
    /// </summary>
    public class DrawingObjectInsertData : DrawingObjectInsert, IFileReference, IModel
    {
        /// <summary>
        /// Gets or sets the reference to the image file.
        /// Source "Storage": the reference is either a storage path to the image located in the folder of the document or in one of its subfolders,
        /// or an absolute HTTP(S) URL to download the image from. For online methods any storage path is allowed.
        /// Source "Request": the reference is the name of the multipart request part that contains the image.
        /// </summary>
        public virtual FileReference ImageReference { get; set; }

        /// <summary>
        /// Collect all files content properties.
        /// </summary>
        /// <param name="resultFileReferences">File references collection used to append new references from current model.</param>
        public override void CollectFileReferences(ref List<FileReference> resultFileReferences)
        {
            base.CollectFileReferences(ref resultFileReferences);
            if (this.ImageReference != null)
            {
                this.ImageReference.CollectFileReferences(ref resultFileReferences);
            }

        }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (this.ImageReference == null)
            {
                throw new ArgumentException("Property ImageReference in DrawingObjectInsertData is required.");
            }

            this.ImageReference?.Validate();

        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DrawingObjectInsertData {\n");
            sb.Append("  Position: ").Append(this.Position).Append("\n");
            sb.Append("  RelativeHorizontalPosition: ").Append(this.RelativeHorizontalPosition).Append("\n");
            sb.Append("  Left: ").Append(this.Left).Append("\n");
            sb.Append("  RelativeVerticalPosition: ").Append(this.RelativeVerticalPosition).Append("\n");
            sb.Append("  Top: ").Append(this.Top).Append("\n");
            sb.Append("  Width: ").Append(this.Width).Append("\n");
            sb.Append("  Height: ").Append(this.Height).Append("\n");
            sb.Append("  WrapType: ").Append(this.WrapType).Append("\n");
            sb.Append("  AspectRatioLocked: ").Append(this.AspectRatioLocked).Append("\n");
            sb.Append("  ImageReference: ").Append(this.ImageReference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
