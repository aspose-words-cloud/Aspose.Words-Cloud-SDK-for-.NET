// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PdfSaveOptionsData.cs">
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
    /// Container class for pdf save options.
    /// </summary>
    public class PdfSaveOptionsData : FixedPageSaveOptionsData, IModel
    {
        /// <summary>
        /// Gets or sets a value determining how attachments are embedded to the PDF document.
        /// The default value is None and attachments are not embedded.
        /// PDF/A-1, PDF/A-2 and regular PDF/A-4 (not PDF/A-4f) standards do not allow embedded files.
        /// None value will be used automatically.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AttachmentsEmbeddingModeEnum
        {
            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,

            /// <summary>
            /// Enum value "Annotations"
            /// </summary>
            Annotations,

            /// <summary>
            /// Enum value "DocumentEmbeddedFiles"
            /// </summary>
            DocumentEmbeddedFiles,
        }

        /// <summary>
        /// Gets or sets the PDF standards compliance level for output documents.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ComplianceEnum
        {
            /// <summary>
            /// Enum value "Pdf17"
            /// </summary>
            Pdf17,

            /// <summary>
            /// Enum value "Pdf20"
            /// </summary>
            Pdf20,

            /// <summary>
            /// Enum value "PdfA1a"
            /// </summary>
            PdfA1a,

            /// <summary>
            /// Enum value "PdfA1b"
            /// </summary>
            PdfA1b,

            /// <summary>
            /// Enum value "PdfA2a"
            /// </summary>
            PdfA2a,

            /// <summary>
            /// Enum value "PdfA2u"
            /// </summary>
            PdfA2u,

            /// <summary>
            /// Enum value "PdfA3a"
            /// </summary>
            PdfA3a,

            /// <summary>
            /// Enum value "PdfA3u"
            /// </summary>
            PdfA3u,

            /// <summary>
            /// Enum value "PdfA4"
            /// </summary>
            PdfA4,

            /// <summary>
            /// Enum value "PdfA4f"
            /// </summary>
            PdfA4f,

            /// <summary>
            /// Enum value "PdfA4Ua2"
            /// </summary>
            PdfA4Ua2,

            /// <summary>
            /// Enum value "PdfUa1"
            /// </summary>
            PdfUa1,

            /// <summary>
            /// Enum value "PdfUa2"
            /// </summary>
            PdfUa2,
        }

        /// <summary>
        /// Gets or sets the option that controls the way CustomDocumentProperties are exported to PDF file.
        /// The default value is None.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CustomPropertiesExportEnum
        {
            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,

            /// <summary>
            /// Enum value "Standard"
            /// </summary>
            Standard,

            /// <summary>
            /// Enum value "Metadata"
            /// </summary>
            Metadata,
        }

        /// <summary>
        /// Gets or sets the font embedding mode.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FontEmbeddingModeEnum
        {
            /// <summary>
            /// Enum value "EmbedAll"
            /// </summary>
            EmbedAll,

            /// <summary>
            /// Enum value "EmbedNonstandard"
            /// </summary>
            EmbedNonstandard,

            /// <summary>
            /// Enum value "EmbedNone"
            /// </summary>
            EmbedNone,
        }

        /// <summary>
        /// Gets or sets the option that controls how bookmarks in headers/footers are exported.
        /// The default value is Aspose.Words.Saving.HeaderFooterBookmarksExportMode.All.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HeaderFooterBookmarksExportModeEnum
        {
            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,

            /// <summary>
            /// Enum value "First"
            /// </summary>
            First,

            /// <summary>
            /// Enum value "All"
            /// </summary>
            All,
        }

        /// <summary>
        /// Gets or sets the option that controls how the color space will be selected for the images in PDF document.
        /// The default value is "Auto". If "SimpleCmyk" value is specified, ImageCompression option is ignored and Flate compression is used for all images in the document.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ImageColorSpaceExportModeEnum
        {
            /// <summary>
            /// Enum value "Auto"
            /// </summary>
            Auto,

            /// <summary>
            /// Enum value "SimpleCmyk"
            /// </summary>
            SimpleCmyk,
        }

        /// <summary>
        /// Gets or sets the option that controls how the PDF document should be displayed when opened in the PDF reader.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PageModeEnum
        {
            /// <summary>
            /// Enum value "UseNone"
            /// </summary>
            UseNone,

            /// <summary>
            /// Enum value "UseOutlines"
            /// </summary>
            UseOutlines,

            /// <summary>
            /// Enum value "UseThumbs"
            /// </summary>
            UseThumbs,

            /// <summary>
            /// Enum value "FullScreen"
            /// </summary>
            FullScreen,

            /// <summary>
            /// Enum value "UseOC"
            /// </summary>
            UseOC,

            /// <summary>
            /// Enum value "UseAttachments"
            /// </summary>
            UseAttachments,
        }

        /// <summary>
        /// Gets or sets the compression type to be used for all textual content in the document.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextCompressionEnum
        {
            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,

            /// <summary>
            /// Enum value "Flate"
            /// </summary>
            Flate,
        }

        /// <summary>
        /// Gets or sets the option that controls what type of zoom should be applied when a document is opened with a PDF viewer.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ZoomBehaviorEnum
        {
            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,

            /// <summary>
            /// Enum value "ZoomFactor"
            /// </summary>
            ZoomFactor,

            /// <summary>
            /// Enum value "FitPage"
            /// </summary>
            FitPage,

            /// <summary>
            /// Enum value "FitWidth"
            /// </summary>
            FitWidth,

            /// <summary>
            /// Enum value "FitHeight"
            /// </summary>
            FitHeight,

            /// <summary>
            /// Enum value "FitBox"
            /// </summary>
            FitBox,
        }

        /// <summary>
        /// Gets or sets a value determining how attachments are embedded to the PDF document.
        /// The default value is None and attachments are not embedded.
        /// PDF/A-1, PDF/A-2 and regular PDF/A-4 (not PDF/A-4f) standards do not allow embedded files.
        /// None value will be used automatically.
        /// </summary>
        public virtual AttachmentsEmbeddingModeEnum? AttachmentsEmbeddingMode { get; set; }

        /// <summary>
        /// Gets or sets a value determining whether or not to cache graphics placed in document's background.
        /// The default value is true and background graphics are written to the PDF document as an xObject. When the value is false background graphics are not cached. Some shapes are not supported for caching(shapes with fields, bookmarks, HRefs). Document background graphic is various shapes, charts, images placed in the footer or header,
        /// well as background and border of a page.
        /// </summary>
        public virtual bool? CacheBackgroundGraphics { get; set; }

        /// <summary>
        /// Gets or sets the PDF standards compliance level for output documents.
        /// </summary>
        public virtual ComplianceEnum? Compliance { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to convert footnote/endnote references in main text story into active hyperlinks.
        /// When clicked the hyperlink will lead to the corresponding footnote/endnote.
        /// The default value is false.
        /// </summary>
        public virtual bool? CreateNoteHyperlinks { get; set; }

        /// <summary>
        /// Gets or sets the option that controls the way CustomDocumentProperties are exported to PDF file.
        /// The default value is None.
        /// </summary>
        public virtual CustomPropertiesExportEnum? CustomPropertiesExport { get; set; }

        /// <summary>
        /// Gets or sets the details for signing the output PDF document.
        /// </summary>
        public virtual PdfDigitalSignatureDetailsData DigitalSignatureDetails { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the window’s title bar should display the document title taken from the Title entry of the document information dictionary.
        /// If false, the title bar should instead display the name of the PDF file containing the document.
        /// The default value is false.
        /// </summary>
        public virtual bool? DisplayDocTitle { get; set; }

        /// <summary>
        /// Gets or sets the downsample options.
        /// </summary>
        public virtual DownsampleOptionsData DownsampleOptions { get; set; }

        /// <summary>
        /// Gets or sets a value determining whether or not to embed attachments to the PDF document.
        /// The default value is false and attachments are not embedded.
        /// When the value is true attachments are embedded to the PDF document.
        /// Embedding attachments is not supported when saving to PDF/A and PDF/UA compliance.
        /// false value will be used automatically.
        /// Embedding attachments is not supported when encryption is enabled. false value will be used automatically.
        /// </summary>
        [Obsolete("Obsolete, please use AttachmentsEmbeddingMode instead.")]
        public virtual bool? EmbedAttachments { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether fonts are embedded into the resulting PDF documents.
        /// </summary>
        public virtual bool? EmbedFullFonts { get; set; }

        /// <summary>
        /// Gets or sets the details for encrypting the output PDF document.
        /// </summary>
        public virtual PdfEncryptionDetailsData EncryptionDetails { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to export document structure.
        /// </summary>
        public virtual bool? ExportDocumentStructure { get; set; }

        /// <summary>
        /// Gets or sets a value determining whether or not to create a "Span" tag in the document structure to export the text language.
        /// The default value is false and "Lang" attribute is attached to a marked-content sequence in a page content stream.
        /// When the value is true "Span" tag is created for the text with non-default language and "Lang" attribute is attached to this tag.
        /// This value is ignored when Aspose.Words.Saving.PdfSaveOptions.ExportDocumentStructure is false.
        /// </summary>
        public virtual bool? ExportLanguageToSpanTag { get; set; }

        /// <summary>
        /// Gets or sets the font embedding mode.
        /// </summary>
        public virtual FontEmbeddingModeEnum? FontEmbeddingMode { get; set; }

        /// <summary>
        /// Gets or sets a value determining  whether to generate scripts that emulate specific Microsoft Word form field behavior in PDF.
        /// Default is false.
        /// When this option is enabled, the exporter generates PDF JavaScript actions to emulate Microsoft Word
        /// form field behavior, such as date and time form fields with formatting and validation rules.When set to true, supported behavior will be exported as PDF JavaScript actions.
        /// When set to false, no form field scripts will be generated.Script execution depends on the PDF viewer. Some PDF viewers might ignore scripts, restrict script execution,
        /// or require the user to enable JavaScript.JavaScript actions are prohibited by PDF/A-1, PDF/A-2 and PDF/A-3 compliance.
        /// The false value will be used automatically in this case.
        /// </summary>
        public virtual bool? GenerateFormFieldScripts { get; set; }

        /// <summary>
        /// Gets or sets the option that controls how bookmarks in headers/footers are exported.
        /// The default value is Aspose.Words.Saving.HeaderFooterBookmarksExportMode.All.
        /// </summary>
        public virtual HeaderFooterBookmarksExportModeEnum? HeaderFooterBookmarksExportMode { get; set; }

        /// <summary>
        /// Gets or sets the option that controls how the color space will be selected for the images in PDF document.
        /// The default value is "Auto". If "SimpleCmyk" value is specified, ImageCompression option is ignored and Flate compression is used for all images in the document.
        /// </summary>
        public virtual ImageColorSpaceExportModeEnum? ImageColorSpaceExportMode { get; set; }

        /// <summary>
        /// Gets or sets the compression type to be used for all images in the document.
        /// </summary>
        public virtual string ImageCompression { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether image interpolation shall be performed by a conforming reader. When false is specified, the flag is not written to the output document and the default behavior of reader is used instead.
        /// When the resolution of a source image is significantly lower than that of the output device, each source sample covers many device pixels. As a result, images can appear jaggy or blocky. These visual artifacts can be reduced by applying an image interpolation algorithm during rendering. Instead of painting all pixels covered by a source sample with the same color, image interpolation attempts to produce a smooth transition between adjacent sample values. A conforming Reader may choose to not implement this feature of PDF, or may use any specific implementation of interpolation that it wishes. The default value is false.
        /// </summary>
        public virtual bool? InterpolateImages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether hyperlinks in the output Pdf document are forced to be opened in a new window (or tab) of a browser.
        /// </summary>
        public virtual bool? OpenHyperlinksInNewWindow { get; set; }

        /// <summary>
        /// Gets or sets the outline options.
        /// </summary>
        public virtual OutlineOptionsData OutlineOptions { get; set; }

        /// <summary>
        /// Gets or sets the option that controls how the PDF document should be displayed when opened in the PDF reader.
        /// </summary>
        public virtual PageModeEnum? PageMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to preblend transparent images with black background color.
        /// Preblending images may improve PDF document visual appearance in Adobe Reader and remove anti-aliasing artifacts.In order to properly display preblended images, PDF viewer application must support /Matte entry in soft-mask image dictionary.
        /// Also preblending images may decrease PDF rendering performance.The default value is false.
        /// </summary>
        public virtual bool? PreblendImages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to preserve Microsoft Word form fields as form fields in PDF or convert them to text.
        /// </summary>
        public virtual bool? PreserveFormFields { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to render PDF choice form field border.
        /// PDF choice form fields are used for export of SDT Combo Box Content Control, SDT Drop-Down List Content
        /// Control and legacy Drop-Down Form Field when PreserveFormFields option is enabled.The default value is true.
        /// </summary>
        public virtual bool? RenderChoiceFormFieldBorder { get; set; }

        /// <summary>
        /// Gets or sets the compression type to be used for all textual content in the document.
        /// </summary>
        public virtual TextCompressionEnum? TextCompression { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the document should be saved using a booklet printing layout.
        /// </summary>
        public virtual bool? UseBookFoldPrintingSettings { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to substitute TrueType fonts Arial, Times New Roman, Courier New and Symbol with core PDF Type 1 fonts.
        /// </summary>
        public virtual bool? UseCoreFonts { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use SDT control Tag or Id property as a name of form field in PDF.
        /// The default value is false.When set to false, SDT control Id property is used as a name of form field in PDF.When set to true, SDT control Tag property is used as a name of form field in PDF.If set to true and Tag is empty, Id property will be used as a form field name.If set to true and Tag values are not unique, duplicate Tag values will be altered to build
        /// unique PDF form field names.
        /// </summary>
        public virtual bool? UseSdtTagAsFormFieldName { get; set; }

        /// <summary>
        /// Gets or sets the option that controls what type of zoom should be applied when a document is opened with a PDF viewer.
        /// </summary>
        public virtual ZoomBehaviorEnum? ZoomBehavior { get; set; }

        /// <summary>
        /// Gets or sets the zoom factor (in percentages) for a document.
        /// </summary>
        public virtual int? ZoomFactor { get; set; }

        /// <summary>
        /// Gets or sets a value determining whether floating shapes are exported as inline tags in the document structure.
        /// The default value is false and floating shapes will be exported as block-level tags,
        /// placed after the paragraph in which they are anchored. When the value is true floating shapes will be exported as inline tags,
        /// placed within the paragraph where they are anchored. This value is ignored when ExportDocumentStructure is false.
        /// </summary>
        public virtual bool? ExportFloatingShapesAsInlineTag { get; set; }

        /// <summary>
        /// Gets the format of save.
        /// </summary>
        public override string SaveFormat { get; } = "pdf";


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public override void Validate()
        {
            base.Validate();

            this.DigitalSignatureDetails?.Validate();




            this.DownsampleOptions?.Validate();





            this.EncryptionDetails?.Validate();












            this.OutlineOptions?.Validate();













        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PdfSaveOptionsData {\n");
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
            sb.Append("  AttachmentsEmbeddingMode: ").Append(this.AttachmentsEmbeddingMode).Append("\n");
            sb.Append("  CacheBackgroundGraphics: ").Append(this.CacheBackgroundGraphics).Append("\n");
            sb.Append("  Compliance: ").Append(this.Compliance).Append("\n");
            sb.Append("  CreateNoteHyperlinks: ").Append(this.CreateNoteHyperlinks).Append("\n");
            sb.Append("  CustomPropertiesExport: ").Append(this.CustomPropertiesExport).Append("\n");
            sb.Append("  DigitalSignatureDetails: ").Append(this.DigitalSignatureDetails).Append("\n");
            sb.Append("  DisplayDocTitle: ").Append(this.DisplayDocTitle).Append("\n");
            sb.Append("  DownsampleOptions: ").Append(this.DownsampleOptions).Append("\n");
            sb.Append("  EmbedAttachments: ").Append(this.EmbedAttachments).Append("\n");
            sb.Append("  EmbedFullFonts: ").Append(this.EmbedFullFonts).Append("\n");
            sb.Append("  EncryptionDetails: ").Append(this.EncryptionDetails).Append("\n");
            sb.Append("  ExportDocumentStructure: ").Append(this.ExportDocumentStructure).Append("\n");
            sb.Append("  ExportLanguageToSpanTag: ").Append(this.ExportLanguageToSpanTag).Append("\n");
            sb.Append("  FontEmbeddingMode: ").Append(this.FontEmbeddingMode).Append("\n");
            sb.Append("  GenerateFormFieldScripts: ").Append(this.GenerateFormFieldScripts).Append("\n");
            sb.Append("  HeaderFooterBookmarksExportMode: ").Append(this.HeaderFooterBookmarksExportMode).Append("\n");
            sb.Append("  ImageColorSpaceExportMode: ").Append(this.ImageColorSpaceExportMode).Append("\n");
            sb.Append("  ImageCompression: ").Append(this.ImageCompression).Append("\n");
            sb.Append("  InterpolateImages: ").Append(this.InterpolateImages).Append("\n");
            sb.Append("  OpenHyperlinksInNewWindow: ").Append(this.OpenHyperlinksInNewWindow).Append("\n");
            sb.Append("  OutlineOptions: ").Append(this.OutlineOptions).Append("\n");
            sb.Append("  PageMode: ").Append(this.PageMode).Append("\n");
            sb.Append("  PreblendImages: ").Append(this.PreblendImages).Append("\n");
            sb.Append("  PreserveFormFields: ").Append(this.PreserveFormFields).Append("\n");
            sb.Append("  RenderChoiceFormFieldBorder: ").Append(this.RenderChoiceFormFieldBorder).Append("\n");
            sb.Append("  TextCompression: ").Append(this.TextCompression).Append("\n");
            sb.Append("  UseBookFoldPrintingSettings: ").Append(this.UseBookFoldPrintingSettings).Append("\n");
            sb.Append("  UseCoreFonts: ").Append(this.UseCoreFonts).Append("\n");
            sb.Append("  UseSdtTagAsFormFieldName: ").Append(this.UseSdtTagAsFormFieldName).Append("\n");
            sb.Append("  ZoomBehavior: ").Append(this.ZoomBehavior).Append("\n");
            sb.Append("  ZoomFactor: ").Append(this.ZoomFactor).Append("\n");
            sb.Append("  ExportFloatingShapesAsInlineTag: ").Append(this.ExportFloatingShapesAsInlineTag).Append("\n");
            sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
