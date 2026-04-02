// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SplitDocumentToFormatTests.cs">
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
    /// Example of how to split document and return result with specified format and page range.
    /// </summary>
    [TestFixture]
    public class SplitDocumentToFormatTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentActions/SplitDocument";
        private readonly string localFile = "Common/test_multi_pages.docx";

        /// <summary>
        /// Test for document splitting.
        /// </summary>
        [Test]
        public async Task TestSplitDocument()
        {
            string remoteFileName = "TestSplitDocument.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new SplitDocumentRequest(
                name: remoteFileName,
                format: "text",
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/TestSplitDocument.text",
                from: 1,
                to: 2
            );
            var actual = await this.WordsApi.SplitDocument(request);
            Assert.NotNull(actual.SplitResult);
            Assert.NotNull(actual.SplitResult.Pages);
            Assert.AreEqual(2, actual.SplitResult.Pages.Count);
        }

        /// <summary>
        /// Test for document splitting job.
        /// </summary>
        [Test]
        public async Task TestSplitDocumentJob()
        {
            string remoteFileName = "TestSplitDocument.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new SplitDocumentJobRequest(
                name: remoteFileName,
                format: "text",
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/TestSplitDocument.text",
                from: 1,
                to: 2
            );
            var jobHandler = await this.WordsApi.SplitDocumentJob(request);
            var actual = await jobHandler.WaitResult();
            Assert.NotNull(actual.SplitResult);
            Assert.NotNull(actual.SplitResult.Pages);
            Assert.AreEqual(2, actual.SplitResult.Pages.Count);
        }

        /// <summary>
        /// Test for document splitting online.
        /// </summary>
        [Test]
        public async Task TestSplitDocumentOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new SplitDocumentOnlineRequest(
                document: requestDocument,
                format: "text",
                destFileName: BaseTestOutPath + "/TestSplitDocument.text",
                from: 1,
                to: 2
            );
            var actual = await this.WordsApi.SplitDocumentOnline(request);
        }

        /// <summary>
        /// Test for document splitting online job.
        /// </summary>
        [Test]
        public async Task TestSplitDocumentOnlineJob()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new SplitDocumentOnlineJobRequest(
                document: requestDocument,
                format: "text",
                destFileName: BaseTestOutPath + "/TestSplitDocument.text",
                from: 1,
                to: 2
            );
            var jobHandler = await this.WordsApi.SplitDocumentOnlineJob(request);
            var actual = await jobHandler.WaitResult();
        }
    }
}
