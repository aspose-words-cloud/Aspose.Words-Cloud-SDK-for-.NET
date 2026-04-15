// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConvertDocumentTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Document
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to convert document to one of the available formats.
    /// </summary>
    [TestFixture]
    public class ConvertDocumentTests : BaseTestContext
    {
        private readonly string remoteFolder = RemoteBaseTestDataFolder + "/DocumentActions/ConvertDocument";
        private readonly string localFolder = "DocumentActions/ConvertDocument";

        /// <summary>
        /// Test for converting document to one of the available formats.
        /// </summary>
        [Test]
        public async Task TestSaveAs()
        {
            string localName = "test_multi_pages.docx";
            string remoteName = "TestSaveAs.docx";

            await this.UploadFileToStorage(
                remoteFolder + "/" + remoteName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + "Common/" + localName)
            );

            var requestSaveOptionsData = new PdfSaveOptionsData()
            {
                FileName = BaseTestOutPath + "/TestSaveAs.pdf"
            };
            var request = new SaveAsRequest(
                name: remoteName,
                saveOptionsData: requestSaveOptionsData,
                folder: remoteFolder
            );
            var actual = await this.WordsApi.SaveAs(request);
            Assert.NotNull(actual.SaveResult);
            Assert.NotNull(actual.SaveResult.DestDocument);
        }

        /// <summary>
        /// Test for converting document online to one of the available formats.
        /// </summary>
        [Test]
        public async Task TestSaveAsOnline()
        {
            string localName = "test_multi_pages.docx";

            using var requestDocument = File.OpenRead(LocalTestDataFolder + "Common/" + localName);
            var requestSaveOptionsData = new PdfSaveOptionsData()
            {
                FileName = BaseTestOutPath + "/TestSaveAs.pdf"
            };
            var request = new SaveAsOnlineRequest(
                document: requestDocument,
                saveOptionsData: requestSaveOptionsData
            );
            var actual = await this.WordsApi.SaveAsOnline(request);
        }

        /// <summary>
        /// Test for converting document online to html with additional files like css and images.
        /// </summary>
        [Test]
        public async Task TestSaveAsOnlineHtmlMultifile()
        {
            string localName = "test_multi_pages.docx";

            using var requestDocument = File.OpenRead(LocalTestDataFolder + "Common/" + localName);
            var requestSaveOptionsData = new HtmlSaveOptionsData()
            {
                FileName = BaseTestOutPath + "/TestSaveAsHtml.html",
                CssStyleSheetType = HtmlSaveOptionsData.CssStyleSheetTypeEnum.External,
                CssStyleSheetFileName = BaseTestOutPath + "/TestSaveAsHtml.css"
            };
            var request = new SaveAsOnlineRequest(
                document: requestDocument,
                saveOptionsData: requestSaveOptionsData
            );
            var actual = await this.WordsApi.SaveAsOnline(request);
        }

        /// <summary>
        /// Test for converting document to one of the available formats.
        /// </summary>
        [Test]
        public async Task TestSaveAsDocx()
        {
            string localName = "45.pdf";
            string remoteName = "TestSaveAsFromPdfToDoc.pdf";

            await this.UploadFileToStorage(
                remoteFolder + "/" + remoteName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFolder + "/" + localName)
            );

            var requestSaveOptionsData = new DocxSaveOptionsData()
            {
                FileName = BaseTestOutPath + "/TestSaveAsFromPdfToDoc.docx"
            };
            var request = new SaveAsRequest(
                name: remoteName,
                saveOptionsData: requestSaveOptionsData,
                folder: remoteFolder
            );
            var actual = await this.WordsApi.SaveAs(request);
            Assert.NotNull(actual.SaveResult);
            Assert.NotNull(actual.SaveResult.DestDocument);
        }

        /// <summary>
        /// Test for converting document to one of the available formats.
        /// </summary>
        [Test]
        public async Task TestSaveAsTiff()
        {
            string localName = "test_multi_pages.docx";
            string remoteName = "TestSaveAsTiff.pdf";

            await this.UploadFileToStorage(
                remoteFolder + "/" + remoteName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + "Common/" + localName)
            );

            var requestSaveOptions = new TiffSaveOptionsData()
            {
                FileName = BaseTestOutPath + "/abc.tiff"
            };
            var request = new SaveAsTiffRequest(
                name: remoteName,
                saveOptions: requestSaveOptions,
                folder: remoteFolder
            );
            var actual = await this.WordsApi.SaveAsTiff(request);
            Assert.NotNull(actual.SaveResult);
            Assert.NotNull(actual.SaveResult.DestDocument);
        }

        /// <summary>
        /// Test for converting document to one of the available formats.
        /// </summary>
        [Test]
        public async Task TestSaveAsTiffOnline()
        {
            string localName = "test_multi_pages.docx";

            using var requestDocument = File.OpenRead(LocalTestDataFolder + "Common/" + localName);
            var requestSaveOptions = new TiffSaveOptionsData()
            {
                FileName = BaseTestOutPath + "/abc.tiff"
            };
            var request = new SaveAsTiffOnlineRequest(
                document: requestDocument,
                saveOptions: requestSaveOptions
            );
            var actual = await this.WordsApi.SaveAsTiffOnline(request);
        }

        /// <summary>
        /// A test for ConvertDocument.
        /// </summary>
        [Test]
        public async Task TestConvertDocument()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFolder + "/test_uploadfile.docx");
            var request = new ConvertDocumentRequest(
                document: requestDocument,
                format: "pdf"
            );
            var actual = await this.WordsApi.ConvertDocument(request);
        }

        /// <summary>
        /// A test for ConvertDocument as a job.
        /// </summary>
        [Test]
        public async Task TestConvertDocumentJob()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFolder + "/test_uploadfile.docx");
            var request = new ConvertDocumentJobRequest(
                document: requestDocument,
                format: "pdf"
            );
            var jobHandler = await this.WordsApi.ConvertDocumentJob(request);
            var actual = await jobHandler.WaitResult();
        }
    }
}
