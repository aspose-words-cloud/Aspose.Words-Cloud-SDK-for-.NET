// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AppendDocumentTests.cs">
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
    /// Example of how to append document.
    /// </summary>
    [TestFixture]
    public class AppendDocumentTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentActions/AppendDocument";
        private readonly string localFile = "Common/test_multi_pages.docx";

        /// <summary>
        /// Test for appending document.
        /// </summary>
        [Test]
        public async Task TestAppendDocument()
        {
            string remoteFileName = "TestAppendDocument.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestDocumentListDocumentEntries0FileReference = new FileReference(remoteDataFolder + "/" + remoteFileName);
            var requestDocumentListDocumentEntries0 = new DocumentEntry()
            {
                FileReference = requestDocumentListDocumentEntries0FileReference,
                ImportFormatMode = DocumentEntry.ImportFormatModeEnum.KeepSourceFormatting
            };
            var requestDocumentListDocumentEntries = new List<DocumentEntry>()
            {
                requestDocumentListDocumentEntries0
            };
            var requestDocumentList = new DocumentEntryList()
            {
                DocumentEntries = requestDocumentListDocumentEntries
            };
            var request = new AppendDocumentRequest(
                name: remoteFileName,
                documentList: requestDocumentList,
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var actual = await this.WordsApi.AppendDocument(request);
            Assert.NotNull(actual.Document);
            Assert.AreEqual("TestAppendDocument.docx", actual.Document.FileName);
        }

        /// <summary>
        /// Test for appending document job.
        /// </summary>
        [Test]
        public async Task TestAppendDocumentJob()
        {
            string remoteFileName = "TestAppendDocument.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestDocumentListDocumentEntries0FileReference = new FileReference(remoteDataFolder + "/" + remoteFileName);
            var requestDocumentListDocumentEntries0 = new DocumentEntry()
            {
                FileReference = requestDocumentListDocumentEntries0FileReference,
                ImportFormatMode = DocumentEntry.ImportFormatModeEnum.KeepSourceFormatting
            };
            var requestDocumentListDocumentEntries = new List<DocumentEntry>()
            {
                requestDocumentListDocumentEntries0
            };
            var requestDocumentList = new DocumentEntryList()
            {
                DocumentEntries = requestDocumentListDocumentEntries
            };
            var request = new AppendDocumentJobRequest(
                name: remoteFileName,
                documentList: requestDocumentList,
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var jobHandler = await this.WordsApi.AppendDocumentJob(request);
            var actual = await jobHandler.WaitResult();
            Assert.NotNull(actual.Document);
            Assert.AreEqual("TestAppendDocument.docx", actual.Document.FileName);
        }

        /// <summary>
        /// Test for appending document online.
        /// </summary>
        [Test]
        public async Task TestAppendDocumentOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            using var requestDocumentListDocumentEntries0FileReferenceStream = File.OpenRead(LocalTestDataFolder + localFile);
            var requestDocumentListDocumentEntries0FileReference = new FileReference(requestDocumentListDocumentEntries0FileReferenceStream);
            var requestDocumentListDocumentEntries0 = new DocumentEntry()
            {
                FileReference = requestDocumentListDocumentEntries0FileReference,
                ImportFormatMode = DocumentEntry.ImportFormatModeEnum.KeepSourceFormatting
            };
            var requestDocumentListDocumentEntries = new List<DocumentEntry>()
            {
                requestDocumentListDocumentEntries0
            };
            var requestDocumentList = new DocumentEntryList()
            {
                DocumentEntries = requestDocumentListDocumentEntries
            };
            var request = new AppendDocumentOnlineRequest(
                document: requestDocument,
                documentList: requestDocumentList
            );
            var actual = await this.WordsApi.AppendDocumentOnline(request);
        }

        /// <summary>
        /// Test for appending document online job.
        /// </summary>
        [Test]
        public async Task TestAppendDocumentOnlineJob()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            using var requestDocumentListDocumentEntries0FileReferenceStream = File.OpenRead(LocalTestDataFolder + localFile);
            var requestDocumentListDocumentEntries0FileReference = new FileReference(requestDocumentListDocumentEntries0FileReferenceStream);
            var requestDocumentListDocumentEntries0 = new DocumentEntry()
            {
                FileReference = requestDocumentListDocumentEntries0FileReference,
                ImportFormatMode = DocumentEntry.ImportFormatModeEnum.KeepSourceFormatting
            };
            var requestDocumentListDocumentEntries = new List<DocumentEntry>()
            {
                requestDocumentListDocumentEntries0
            };
            var requestDocumentList = new DocumentEntryList()
            {
                DocumentEntries = requestDocumentListDocumentEntries
            };
            var request = new AppendDocumentOnlineJobRequest(
                document: requestDocument,
                documentList: requestDocumentList
            );
            var jobHandler = await this.WordsApi.AppendDocumentOnlineJob(request);
            var actual = await jobHandler.WaitResult();
        }
    }
}
