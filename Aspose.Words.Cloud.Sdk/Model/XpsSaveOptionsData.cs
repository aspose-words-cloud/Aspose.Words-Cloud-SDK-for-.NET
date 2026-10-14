// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="XpsSaveOptionsData.cs">
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
    /// Container class for xps save options.
    /// </summary>
    public class XpsSaveOptionsData : FixedPageSaveOptionsData, IModel
    {
        /// <summary>
        /// Gets or sets a compression level used to save document.
        /// The default value is Normal.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompressionLevelEnum
        {
            /// <summary>
            /// Enum value "Normal"
            /// </summary>
            Normal,

            /// <summary>
            /// Enum value "Maximum"
            /// </summary>
            Maximum,

            /// <summary>
            /// Enum value "Fast"
            /// </summary>
            Fast,

            /// <summary>
            /// Enum value "SuperFast"
            /// </summary>
            SuperFast,
        }

        /// <summary>
        /// Gets or sets the level in the XPS document outline at which to display Word bookmarks.
        /// </summary>
        public virtual int? BookmarksOutlineLevel { get; set; }

        /// <summary>
        /// Gets or sets a compression level used to save document.
        /// The default value is Normal.
        /// </summary>
        public virtual CompressionLevelEnum? CompressionLevel { get; set; }

        /// <summary>
        /// Gets or sets the details for signing the output document.
        /// </summary>
        public virtual DigitalSignatureDetails DigitalSignatureDetails { get; set; }

        /// <summary>
        /// Gets or sets the number of heading levels (paragraphs formatted with the Heading styles) to include in the XPS document outline.
        /// </summary>
        public virtual int? HeadingsOutlineLevels { get; set; }

        /// <summary>
        /// Gets or sets the outline options.
        /// </summary>
        public virtual OutlineOptionsData OutlineOptions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the document should be saved using a booklet printing layout.
        /// </summary>
        public virtual bool? UseBookFoldPrintingSettings { get; set; }

        /// <summary>
        /// Gets the format of save.
        /// </summary>
        public override string SaveFormat { get; } = "xps";


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public override void Validate()
        {
            base.Validate();

            this.DigitalSignatureDetails?.Validate();




            this.OutlineOptions?.Validate();



        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XpsSaveOptionsData {\n");
            sb.Append("  AllowEmbeddingPostScriptFonts: ").Append(this.AllowEmbeddingPostScriptFonts).Append("\n");
            sb.Append("  CustomTimeZoneInfoData: ").Append(this.CustomTimeZoneInfoData).Append("\n");
            sb.Append("  Dml3DEffectsRenderingMode: ").Append(this.Dml3DEffectsRenderingMode).Append("\n");
            sb.Append("  DmlEffectsRenderingMode: ").Append(this.DmlEffectsRenderingMode).Append("\n");
            sb.Append("  DmlRenderingMode: ").Append(this.DmlRenderingMode).Append("\n");
            sb.Append("  FileName: ").Append(this.FileName).Append("\n");
            sb.Append("  ImlRenderingMode: ").Append(this.ImlRenderingMode).Append("\n");
            sb.Append("  UpdateAmbiguousTextFont: ").Append(this.UpdateAmbiguousTextFont).Append("\n");
            sb.Append("  UpdateCreatedTimeProperty: ").Append(this.UpdateCreatedTimeProperty).Append("\n");
            sb.Append("  UpdateFields: ").Append(this.UpdateFields).Append("\n");
            sb.Append("  UpdateLastPrintedProperty: ").Append(this.UpdateLastPrintedProperty).Append("\n");
            sb.Append("  UpdateLastSavedTimeProperty: ").Append(this.UpdateLastSavedTimeProperty).Append("\n");
            sb.Append("  ZipOutput: ").Append(this.ZipOutput).Append("\n");
            sb.Append("  ColorMode: ").Append(this.ColorMode).Append("\n");
            sb.Append("  JpegQuality: ").Append(this.JpegQuality).Append("\n");
            sb.Append("  MetafileRenderingOptions: ").Append(this.MetafileRenderingOptions).Append("\n");
            sb.Append("  NumeralFormat: ").Append(this.NumeralFormat).Append("\n");
            sb.Append("  OptimizeOutput: ").Append(this.OptimizeOutput).Append("\n");
            sb.Append("  PageCount: ").Append(this.PageCount).Append("\n");
            sb.Append("  PageIndex: ").Append(this.PageIndex).Append("\n");
            sb.Append("  BookmarksOutlineLevel: ").Append(this.BookmarksOutlineLevel).Append("\n");
            sb.Append("  CompressionLevel: ").Append(this.CompressionLevel).Append("\n");
            sb.Append("  DigitalSignatureDetails: ").Append(this.DigitalSignatureDetails).Append("\n");
            sb.Append("  HeadingsOutlineLevels: ").Append(this.HeadingsOutlineLevels).Append("\n");
            sb.Append("  OutlineOptions: ").Append(this.OutlineOptions).Append("\n");
            sb.Append("  UseBookFoldPrintingSettings: ").Append(this.UseBookFoldPrintingSettings).Append("\n");
            sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
