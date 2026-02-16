// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SerializationHelper.cs">
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
    using System.IO;
    using System.Linq;
#if NETSTANDARD2_0
    using System.Reflection;
#endif
    using System.Threading.Tasks;

    using Aspose.Words.Cloud.Sdk.Model;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    internal class SerializationHelper
    {
        public static readonly IReadOnlyDictionary<string, Type> ModelTypes = new Dictionary<string, Type>()
        {
            { "ApiError, _", typeof(ApiError) },
            { "AvailableFontsResponse, _", typeof(AvailableFontsResponse) },
            { "Azw3SaveOptionsData, _", typeof(Azw3SaveOptionsData) },
            { "BmpSaveOptionsData, _", typeof(BmpSaveOptionsData) },
            { "Bookmark, _", typeof(Bookmark) },
            { "BookmarkData, _", typeof(BookmarkData) },
            { "BookmarkInsert, _", typeof(BookmarkInsert) },
            { "BookmarkResponse, _", typeof(BookmarkResponse) },
            { "Bookmarks, _", typeof(Bookmarks) },
            { "BookmarksOutlineLevelData, _", typeof(BookmarksOutlineLevelData) },
            { "BookmarksResponse, _", typeof(BookmarksResponse) },
            { "Border, _", typeof(Border) },
            { "BorderResponse, _", typeof(BorderResponse) },
            { "BordersCollection, _", typeof(BordersCollection) },
            { "BordersResponse, _", typeof(BordersResponse) },
            { "Comment, _", typeof(Comment) },
            { "CommentInsert, _", typeof(CommentInsert) },
            { "CommentLink, _", typeof(CommentLink) },
            { "CommentRangeEnd, _", typeof(CommentRangeEnd) },
            { "CommentRangeStart, _", typeof(CommentRangeStart) },
            { "CommentResponse, _", typeof(CommentResponse) },
            { "CommentsCollection, _", typeof(CommentsCollection) },
            { "CommentsResponse, _", typeof(CommentsResponse) },
            { "CommentUpdate, _", typeof(CommentUpdate) },
            { "CompareData, _", typeof(CompareData) },
            { "CompareOptions, _", typeof(CompareOptions) },
            { "CompressOptions, _", typeof(CompressOptions) },
            { "CompressResponse, _", typeof(CompressResponse) },
            { "CsvDataLoadOptions, _", typeof(CsvDataLoadOptions) },
            { "CustomXmlPart, _", typeof(CustomXmlPart) },
            { "CustomXmlPartInsert, _", typeof(CustomXmlPartInsert) },
            { "CustomXmlPartLink, _", typeof(CustomXmlPartLink) },
            { "CustomXmlPartResponse, _", typeof(CustomXmlPartResponse) },
            { "CustomXmlPartsCollection, _", typeof(CustomXmlPartsCollection) },
            { "CustomXmlPartsResponse, _", typeof(CustomXmlPartsResponse) },
            { "CustomXmlPartUpdate, _", typeof(CustomXmlPartUpdate) },
            { "DigitalSignatureDetails, _", typeof(DigitalSignatureDetails) },
            { "DoclingSaveOptionsData, _", typeof(DoclingSaveOptionsData) },
            { "DocmSaveOptionsData, _", typeof(DocmSaveOptionsData) },
            { "DocSaveOptionsData, _", typeof(DocSaveOptionsData) },
            { "Document, _", typeof(Document) },
            { "DocumentEntry, _", typeof(DocumentEntry) },
            { "DocumentEntryList, _", typeof(DocumentEntryList) },
            { "DocumentPosition, _", typeof(DocumentPosition) },
            { "DocumentProperties, _", typeof(DocumentProperties) },
            { "DocumentPropertiesResponse, _", typeof(DocumentPropertiesResponse) },
            { "DocumentProperty, _", typeof(DocumentProperty) },
            { "DocumentPropertyCreateOrUpdate, _", typeof(DocumentPropertyCreateOrUpdate) },
            { "DocumentPropertyResponse, _", typeof(DocumentPropertyResponse) },
            { "DocumentResponse, _", typeof(DocumentResponse) },
            { "DocumentStatData, _", typeof(DocumentStatData) },
            { "DocxSaveOptionsData, _", typeof(DocxSaveOptionsData) },
            { "DotmSaveOptionsData, _", typeof(DotmSaveOptionsData) },
            { "DotSaveOptionsData, _", typeof(DotSaveOptionsData) },
            { "DotxSaveOptionsData, _", typeof(DotxSaveOptionsData) },
            { "DownsampleOptionsData, _", typeof(DownsampleOptionsData) },
            { "DrawingObject, _", typeof(DrawingObject) },
            { "DrawingObjectCollection, _", typeof(DrawingObjectCollection) },
            { "DrawingObjectInsert, _", typeof(DrawingObjectInsert) },
            { "DrawingObjectLink, _", typeof(DrawingObjectLink) },
            { "DrawingObjectResponse, _", typeof(DrawingObjectResponse) },
            { "DrawingObjectsResponse, _", typeof(DrawingObjectsResponse) },
            { "DrawingObjectUpdate, _", typeof(DrawingObjectUpdate) },
            { "EmfSaveOptionsData, _", typeof(EmfSaveOptionsData) },
            { "EpsSaveOptionsData, _", typeof(EpsSaveOptionsData) },
            { "EpubSaveOptionsData, _", typeof(EpubSaveOptionsData) },
            { "Error, _", typeof(Error) },
            { "ErrorDetails, _", typeof(ErrorDetails) },
            { "Field, _", typeof(Field) },
            { "FieldCollection, _", typeof(FieldCollection) },
            { "FieldInsert, _", typeof(FieldInsert) },
            { "FieldLink, _", typeof(FieldLink) },
            { "FieldNames, _", typeof(FieldNames) },
            { "FieldNamesResponse, _", typeof(FieldNamesResponse) },
            { "FieldOptions, _", typeof(FieldOptions) },
            { "FieldResponse, _", typeof(FieldResponse) },
            { "FieldsResponse, _", typeof(FieldsResponse) },
            { "FieldUpdate, _", typeof(FieldUpdate) },
            { "FileLink, _", typeof(FileLink) },
            { "FilesList, _", typeof(FilesList) },
            { "FilesUploadResult, _", typeof(FilesUploadResult) },
            { "FlatOpcMacroSaveOptionsData, _", typeof(FlatOpcMacroSaveOptionsData) },
            { "FlatOpcSaveOptionsData, _", typeof(FlatOpcSaveOptionsData) },
            { "FlatOpcTemplateMacroSaveOptionsData, _", typeof(FlatOpcTemplateMacroSaveOptionsData) },
            { "FlatOpcTemplateSaveOptionsData, _", typeof(FlatOpcTemplateSaveOptionsData) },
            { "Font, _", typeof(Font) },
            { "FontInfo, _", typeof(FontInfo) },
            { "FontResponse, _", typeof(FontResponse) },
            { "Footnote, _", typeof(Footnote) },
            { "FootnoteCollection, _", typeof(FootnoteCollection) },
            { "FootnoteInsert, _", typeof(FootnoteInsert) },
            { "FootnoteLink, _", typeof(FootnoteLink) },
            { "FootnoteResponse, _", typeof(FootnoteResponse) },
            { "FootnotesResponse, _", typeof(FootnotesResponse) },
            { "FootnotesStatData, _", typeof(FootnotesStatData) },
            { "FootnoteUpdate, _", typeof(FootnoteUpdate) },
            { "FormFieldCheckbox, _", typeof(FormFieldCheckbox) },
            { "FormFieldCheckboxLink, _", typeof(FormFieldCheckboxLink) },
            { "FormFieldCollection, _", typeof(FormFieldCollection) },
            { "FormFieldDropDown, _", typeof(FormFieldDropDown) },
            { "FormFieldDropDownLink, _", typeof(FormFieldDropDownLink) },
            { "FormFieldResponse, _", typeof(FormFieldResponse) },
            { "FormFieldsResponse, _", typeof(FormFieldsResponse) },
            { "FormFieldTextInput, _", typeof(FormFieldTextInput) },
            { "FormFieldTextInputLink, _", typeof(FormFieldTextInputLink) },
            { "GifSaveOptionsData, _", typeof(GifSaveOptionsData) },
            { "HeaderFooter, _", typeof(HeaderFooter) },
            { "HeaderFooterLink, _", typeof(HeaderFooterLink) },
            { "HeaderFooterLinkCollection, _", typeof(HeaderFooterLinkCollection) },
            { "HeaderFooterResponse, _", typeof(HeaderFooterResponse) },
            { "HeaderFootersResponse, _", typeof(HeaderFootersResponse) },
            { "HtmlFixedSaveOptionsData, _", typeof(HtmlFixedSaveOptionsData) },
            { "HtmlSaveOptionsData, _", typeof(HtmlSaveOptionsData) },
            { "Hyperlink, _", typeof(Hyperlink) },
            { "HyperlinkResponse, _", typeof(HyperlinkResponse) },
            { "Hyperlinks, _", typeof(Hyperlinks) },
            { "HyperlinksResponse, _", typeof(HyperlinksResponse) },
            { "ImageEntry, _", typeof(ImageEntry) },
            { "ImageEntryList, _", typeof(ImageEntryList) },
            { "InfoAdditionalItem, _", typeof(InfoAdditionalItem) },
            { "InfoResponse, _", typeof(InfoResponse) },
            { "JpegSaveOptionsData, _", typeof(JpegSaveOptionsData) },
            { "JsonDataLoadOptions, _", typeof(JsonDataLoadOptions) },
            { "Link, _", typeof(Link) },
            { "LinkElement, _", typeof(LinkElement) },
            { "ListFormat, _", typeof(ListFormat) },
            { "ListFormatUpdate, _", typeof(ListFormatUpdate) },
            { "ListInfo, _", typeof(ListInfo) },
            { "ListInsert, _", typeof(ListInsert) },
            { "ListLevel, _", typeof(ListLevel) },
            { "ListLevels, _", typeof(ListLevels) },
            { "ListLevelUpdate, _", typeof(ListLevelUpdate) },
            { "ListResponse, _", typeof(ListResponse) },
            { "Lists, _", typeof(Lists) },
            { "ListsResponse, _", typeof(ListsResponse) },
            { "ListUpdate, _", typeof(ListUpdate) },
            { "LoadWebDocumentData, _", typeof(LoadWebDocumentData) },
            { "MarkdownSaveOptionsData, _", typeof(MarkdownSaveOptionsData) },
            { "MetafileRenderingOptionsData, _", typeof(MetafileRenderingOptionsData) },
            { "MhtmlSaveOptionsData, _", typeof(MhtmlSaveOptionsData) },
            { "ModificationOperationResult, _", typeof(ModificationOperationResult) },
            { "NodeLink, _", typeof(NodeLink) },
            { "OdtSaveOptionsData, _", typeof(OdtSaveOptionsData) },
            { "OfficeMathLink, _", typeof(OfficeMathLink) },
            { "OfficeMathObject, _", typeof(OfficeMathObject) },
            { "OfficeMathObjectResponse, _", typeof(OfficeMathObjectResponse) },
            { "OfficeMathObjectsCollection, _", typeof(OfficeMathObjectsCollection) },
            { "OfficeMathObjectsResponse, _", typeof(OfficeMathObjectsResponse) },
            { "OpenXpsSaveOptionsData, _", typeof(OpenXpsSaveOptionsData) },
            { "OptimizationOptions, _", typeof(OptimizationOptions) },
            { "OttSaveOptionsData, _", typeof(OttSaveOptionsData) },
            { "OutlineOptionsData, _", typeof(OutlineOptionsData) },
            { "PageNumber, _", typeof(PageNumber) },
            { "PageSetup, _", typeof(PageSetup) },
            { "PageStatData, _", typeof(PageStatData) },
            { "Paragraph, _", typeof(Paragraph) },
            { "ParagraphFormat, _", typeof(ParagraphFormat) },
            { "ParagraphFormatResponse, _", typeof(ParagraphFormatResponse) },
            { "ParagraphFormatUpdate, _", typeof(ParagraphFormatUpdate) },
            { "ParagraphInsert, _", typeof(ParagraphInsert) },
            { "ParagraphLink, _", typeof(ParagraphLink) },
            { "ParagraphLinkCollection, _", typeof(ParagraphLinkCollection) },
            { "ParagraphLinkCollectionResponse, _", typeof(ParagraphLinkCollectionResponse) },
            { "ParagraphListFormatResponse, _", typeof(ParagraphListFormatResponse) },
            { "ParagraphResponse, _", typeof(ParagraphResponse) },
            { "PclSaveOptionsData, _", typeof(PclSaveOptionsData) },
            { "PdfDigitalSignatureDetailsData, _", typeof(PdfDigitalSignatureDetailsData) },
            { "PdfEncryptionDetailsData, _", typeof(PdfEncryptionDetailsData) },
            { "PdfPermissions, _", typeof(PdfPermissions) },
            { "PdfSaveOptionsData, _", typeof(PdfSaveOptionsData) },
            { "PngSaveOptionsData, _", typeof(PngSaveOptionsData) },
            { "PositionAfterNode, _", typeof(PositionAfterNode) },
            { "PositionBeforeNode, _", typeof(PositionBeforeNode) },
            { "PositionInsideNode, _", typeof(PositionInsideNode) },
            { "PreferredWidth, _", typeof(PreferredWidth) },
            { "ProtectionData, _", typeof(ProtectionData) },
            { "ProtectionDataResponse, _", typeof(ProtectionDataResponse) },
            { "ProtectionRequest, _", typeof(ProtectionRequest) },
            { "ProtectionRequestV2, _", typeof(ProtectionRequestV2) },
            { "PsSaveOptionsData, _", typeof(PsSaveOptionsData) },
            { "PublicKeyResponse, _", typeof(PublicKeyResponse) },
            { "RangeDocument, _", typeof(RangeDocument) },
            { "RangeTextResponse, _", typeof(RangeTextResponse) },
            { "ReplaceRange, _", typeof(ReplaceRange) },
            { "ReplaceTextParameters, _", typeof(ReplaceTextParameters) },
            { "ReplaceTextResponse, _", typeof(ReplaceTextResponse) },
            { "ReportBuildOptions, _", typeof(ReportBuildOptions) },
            { "ReportEngineSettings, _", typeof(ReportEngineSettings) },
            { "Revision, _", typeof(Revision) },
            { "RevisionCollection, _", typeof(RevisionCollection) },
            { "RevisionsModificationResponse, _", typeof(RevisionsModificationResponse) },
            { "RevisionsResponse, _", typeof(RevisionsResponse) },
            { "RtfSaveOptionsData, _", typeof(RtfSaveOptionsData) },
            { "Run, _", typeof(Run) },
            { "RunInsert, _", typeof(RunInsert) },
            { "RunLink, _", typeof(RunLink) },
            { "RunResponse, _", typeof(RunResponse) },
            { "Runs, _", typeof(Runs) },
            { "RunsResponse, _", typeof(RunsResponse) },
            { "RunUpdate, _", typeof(RunUpdate) },
            { "SaveResponse, _", typeof(SaveResponse) },
            { "SaveResult, _", typeof(SaveResult) },
            { "SearchResponse, _", typeof(SearchResponse) },
            { "SearchResult, _", typeof(SearchResult) },
            { "SearchResultsCollection, _", typeof(SearchResultsCollection) },
            { "Section, _", typeof(Section) },
            { "SectionLink, _", typeof(SectionLink) },
            { "SectionLinkCollection, _", typeof(SectionLinkCollection) },
            { "SectionLinkCollectionResponse, _", typeof(SectionLinkCollectionResponse) },
            { "SectionPageSetupResponse, _", typeof(SectionPageSetupResponse) },
            { "SectionResponse, _", typeof(SectionResponse) },
            { "Shading, _", typeof(Shading) },
            { "Signature, _", typeof(Signature) },
            { "SignatureCollectionResponse, _", typeof(SignatureCollectionResponse) },
            { "SignOptions, _", typeof(SignOptions) },
            { "SplitDocumentResponse, _", typeof(SplitDocumentResponse) },
            { "SplitDocumentResult, _", typeof(SplitDocumentResult) },
            { "StatDataResponse, _", typeof(StatDataResponse) },
            { "StorageFile, _", typeof(StorageFile) },
            { "StoryChildNodes, _", typeof(StoryChildNodes) },
            { "StructuredDocumentTag, _", typeof(StructuredDocumentTag) },
            { "StructuredDocumentTagCollection, _", typeof(StructuredDocumentTagCollection) },
            { "StructuredDocumentTagInsert, _", typeof(StructuredDocumentTagInsert) },
            { "StructuredDocumentTagListItem, _", typeof(StructuredDocumentTagListItem) },
            { "StructuredDocumentTagResponse, _", typeof(StructuredDocumentTagResponse) },
            { "StructuredDocumentTagsResponse, _", typeof(StructuredDocumentTagsResponse) },
            { "StructuredDocumentTagUpdate, _", typeof(StructuredDocumentTagUpdate) },
            { "Style, _", typeof(Style) },
            { "StyleApply, _", typeof(StyleApply) },
            { "StyleCopy, _", typeof(StyleCopy) },
            { "StyleInsert, _", typeof(StyleInsert) },
            { "StyleResponse, _", typeof(StyleResponse) },
            { "StylesResponse, _", typeof(StylesResponse) },
            { "StyleUpdate, _", typeof(StyleUpdate) },
            { "SvgSaveOptionsData, _", typeof(SvgSaveOptionsData) },
            { "Table, _", typeof(Table) },
            { "TableCell, _", typeof(TableCell) },
            { "TableCellFormat, _", typeof(TableCellFormat) },
            { "TableCellFormatResponse, _", typeof(TableCellFormatResponse) },
            { "TableCellInsert, _", typeof(TableCellInsert) },
            { "TableCellResponse, _", typeof(TableCellResponse) },
            { "TableInsert, _", typeof(TableInsert) },
            { "TableLink, _", typeof(TableLink) },
            { "TableLinkCollection, _", typeof(TableLinkCollection) },
            { "TableLinkCollectionResponse, _", typeof(TableLinkCollectionResponse) },
            { "TableProperties, _", typeof(TableProperties) },
            { "TablePropertiesResponse, _", typeof(TablePropertiesResponse) },
            { "TableResponse, _", typeof(TableResponse) },
            { "TableRow, _", typeof(TableRow) },
            { "TableRowFormat, _", typeof(TableRowFormat) },
            { "TableRowFormatResponse, _", typeof(TableRowFormatResponse) },
            { "TableRowInsert, _", typeof(TableRowInsert) },
            { "TableRowResponse, _", typeof(TableRowResponse) },
            { "TabStop, _", typeof(TabStop) },
            { "TabStopInsert, _", typeof(TabStopInsert) },
            { "TabStopsResponse, _", typeof(TabStopsResponse) },
            { "TextSaveOptionsData, _", typeof(TextSaveOptionsData) },
            { "TiffSaveOptionsData, _", typeof(TiffSaveOptionsData) },
            { "TimeZoneInfoData, _", typeof(TimeZoneInfoData) },
            { "TranslateNodeIdResponse, _", typeof(TranslateNodeIdResponse) },
            { "UserInformation, _", typeof(UserInformation) },
            { "WatermarkDataImage, _", typeof(WatermarkDataImage) },
            { "WatermarkDataText, _", typeof(WatermarkDataText) },
            { "WatermarkText, _", typeof(WatermarkText) },
            { "WordMLSaveOptionsData, _", typeof(WordMLSaveOptionsData) },
            { "WordsApiErrorResponse, _", typeof(WordsApiErrorResponse) },
            { "WordsApiLink, _", typeof(WordsApiLink) },
            { "WordsResponse, _", typeof(WordsResponse) },
            { "XamlFixedSaveOptionsData, _", typeof(XamlFixedSaveOptionsData) },
            { "XamlFlowPackSaveOptionsData, _", typeof(XamlFlowPackSaveOptionsData) },
            { "XamlFlowSaveOptionsData, _", typeof(XamlFlowSaveOptionsData) },
            { "XmlColor, _", typeof(XmlColor) },
            { "XmlDataLoadOptions, _", typeof(XmlDataLoadOptions) },
            { "XpsSaveOptionsData, _", typeof(XpsSaveOptionsData) },
        };

        public static string Serialize(object obj)
        {
            try
            {
                return obj != null
                           ? JsonConvert.SerializeObject(
                               obj,
                               new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore })
                           : null;
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        public static object Deserialize(string json, Type type)
        {
            try
            {
                if (json.StartsWith("{") || json.StartsWith("["))
                {
                    return JsonConvert.DeserializeObject(json, type, new AsposeModelsJsonConverter());
                }

                throw new ApiException(500, "Server does not return json: '" + json + "'");
            }
            catch (IOException e)
            {
                throw new ApiException(500, e.Message);
            }
            catch (JsonSerializationException jse)
            {
                throw new ApiException(500, "Error while parse response: " + jse.Message);
            }
            catch (System.Xml.XmlException xmle)
            {
                throw new ApiException(500, "Error while parse response: " + xmle.Message);
            }
            catch (Exception ex)
            {
                throw new ApiException(500, "Internal deserialization error: " + ex.Message);
            }
        }

        public static async Task< System.IO.Stream > MultipartSectionToStream(Microsoft.AspNetCore.WebUtilities.MultipartSection section)
        {
            var ms = new MemoryStream();
            section.Body.Seek(0, SeekOrigin.Begin);
            await section.Body.CopyToAsync(ms);
            ms.Seek(0, SeekOrigin.Begin);
            return ms;
        }

        public static string GetFileNameFromContentDisposition(string contentDisposition)
        {
            string fileName = string.Empty;
            if (contentDisposition != null)
            {
                var contentHeaders = contentDisposition.Split(';');
                foreach (var contentHeader in contentHeaders)
                {
                    var contentHeaderParts = contentHeader.Split('=');
                    if (contentHeaderParts.Length == 2)
                    {
                        if (contentHeaderParts[0].Trim().Equals("filename"))
                        {
                            fileName = contentHeaderParts[1].Trim(' ', '"');
                            break;
                        }
                    }
                }
            }

            return fileName;
        }

        public static async Task< System.Collections.Generic.Dictionary<string, System.IO.Stream> > DeserializeFilesCollection(ChildResponseContent section)
        {
            var result = new System.Collections.Generic.Dictionary<string, System.IO.Stream>();
            var dataType = section.ContentType;
            if (dataType != null && dataType.StartsWith("multipart/mixed"))
            {
                string boundary = null;
                var boundaryParts = dataType.Split(';');
                foreach (var boundaryPart in boundaryParts)
                {
                    var boundarySubparts = boundaryPart.Trim().Split('=');
                    if (boundarySubparts.Length == 2 && boundarySubparts[0] == "boundary")
                    {
                        boundary = boundarySubparts[1].Trim(' ', '"');
                        break;
                    }
                }

                section.Content.Seek(0, SeekOrigin.Begin);
                Microsoft.AspNetCore.WebUtilities.MultipartSection fileSection;
                var reader = new Microsoft.AspNetCore.WebUtilities.MultipartReader(boundary, section.Content);
                while ((fileSection = await reader.ReadNextSectionAsync()) != null)
                {
                    result[GetFileNameFromContentDisposition(fileSection.ContentDisposition)] = await MultipartSectionToStream(fileSection);
                }
            }
            else
            {
                section.Content.Seek(0, SeekOrigin.Begin);
                result[GetFileNameFromContentDisposition(section.ContentDisposition)] = section.Content;
            }

            return result;
        }

        public static async Task< System.Collections.Generic.Dictionary<string, System.IO.Stream> > DeserializeFilesCollection(System.Net.Http.HttpResponseMessage response)
        {
            var result = new System.Collections.Generic.Dictionary<string, System.IO.Stream>();
            string contentType = response.Content.Headers.ContentType?.ToString();
            var contentStream = await response.Content.ReadAsStreamAsync();
            contentStream.Seek(0, SeekOrigin.Begin);

            if (contentType != null && contentType.StartsWith("multipart/mixed"))
            {
                string boundary = null;
                var boundaryParts = contentType.Split(';');
                foreach (var boundaryPart in boundaryParts)
                {
                    var boundarySubparts = boundaryPart.Trim().Split('=');
                    if (boundarySubparts.Length == 2 && boundarySubparts[0] == "boundary")
                    {
                        boundary = boundarySubparts[1].Trim(' ', '"');
                        break;
                    }
                }

                Microsoft.AspNetCore.WebUtilities.MultipartSection fileSection;
                var reader = new Microsoft.AspNetCore.WebUtilities.MultipartReader(boundary, contentStream);
                while ((fileSection = await reader.ReadNextSectionAsync()) != null)
                {
                    result[GetFileNameFromContentDisposition(fileSection.ContentDisposition)] = await MultipartSectionToStream(fileSection);
                }
            }
            else
            {
                result[GetFileNameFromContentDisposition(response.Content.Headers.ContentDisposition?.ToString())] = contentStream;
            }

            return result;
        }

        private class AsposeModelsJsonConverter : JsonConverter
        {
            public override bool CanWrite
            {
                get
                {
                    return false;
                }
            }

            public override bool CanConvert(Type objectType)
            {
                return objectType.GetInterfaces().Contains(typeof(IModel));
            }

            public override object ReadJson(
                JsonReader reader,
                Type objectType,
                object existingValue,
                JsonSerializer serializer)
            {
                object target;
                var jsonObject = JObject.Load(reader);
                if (jsonObject.ContainsKey("$type"))
                {
                    var jsonType = jsonObject.GetValue("$type")?.Value<string>();
                    if (jsonType != null && ModelTypes.ContainsKey(jsonType))
                    {
                        target = Activator.CreateInstance(ModelTypes[jsonType]);
                    }
                    else
                    {
                        throw new ApiException(400, "Invalid json type.");
                    }
                }
                else
                {
                    target = Activator.CreateInstance(objectType);
                }

                serializer.Populate(jsonObject.CreateReader(), target);
                return target;
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, value);
            }
        }
    }
}
