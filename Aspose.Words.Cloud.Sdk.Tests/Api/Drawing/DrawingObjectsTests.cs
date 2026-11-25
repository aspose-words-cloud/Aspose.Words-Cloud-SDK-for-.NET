// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DrawingObjectsTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Drawing
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to get drawing objects.
    /// </summary>
    [TestFixture]
    public class DrawingObjectsTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/DrawingObjectss";
        private readonly string localFile = "Common/test_multi_pages.docx";
        private readonly string localDrawingFile = "DocumentElements/DrawingObjects/sample_EmbeddedOLE.docx";

        /// <summary>
        /// Test for getting drawing objects from document.
        /// </summary>
        [Test]
        public async Task TestGetDocumentDrawingObjects()
        {
            string remoteFileName = "TestGetDocumentDrawingObjects.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetDocumentDrawingObjectsRequest(
                name: remoteFileName,
                nodePath: "sections/0",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetDocumentDrawingObjects(request);
        }

        /// <summary>
        /// Test for getting drawing objects from document online.
        /// </summary>
        [Test]
        public async Task TestGetDocumentDrawingObjectsOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetDocumentDrawingObjectsOnlineRequest(
                document: requestDocument,
                nodePath: "sections/0"
            );
            var actual = await this.WordsApi.GetDocumentDrawingObjectsOnline(request);
        }

        /// <summary>
        /// Test for getting drawing objects from document without node path.
        /// </summary>
        [Test]
        public async Task TestGetDocumentDrawingObjectsWithoutNodePath()
        {
            string remoteFileName = "TestGetDocumentDrawingObjectsWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetDocumentDrawingObjectsRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetDocumentDrawingObjects(request);
        }

        /// <summary>
        /// Test for getting drawing object by specified index.
        /// </summary>
        [Test]
        public async Task TestGetDocumentDrawingObjectByIndex()
        {
            string remoteFileName = "TestGetDocumentDrawingObjectByIndex.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetDocumentDrawingObjectByIndexRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "sections/0",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetDocumentDrawingObjectByIndex(request);
        }

        /// <summary>
        /// Test for getting drawing object by specified index online.
        /// </summary>
        [Test]
        public async Task TestGetDocumentDrawingObjectByIndexOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetDocumentDrawingObjectByIndexOnlineRequest(
                document: requestDocument,
                index: 0,
                nodePath: "sections/0"
            );
            var actual = await this.WordsApi.GetDocumentDrawingObjectByIndexOnline(request);
        }

        /// <summary>
        /// Test for getting drawing object by specified index without node path.
        /// </summary>
        [Test]
        public async Task TestGetDocumentDrawingObjectByIndexWithoutNodePath()
        {
            string remoteFileName = "TestGetDocumentDrawingObjectByIndexWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetDocumentDrawingObjectByIndexRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetDocumentDrawingObjectByIndex(request);
        }

        /// <summary>
        /// Test for getting drawing object by specified index and format.
        /// </summary>
        [Test]
        public async Task TestRenderDrawingObject()
        {
            string remoteFileName = "TestGetDocumentDrawingObjectByIndexWithFormat.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new RenderDrawingObjectRequest(
                name: remoteFileName,
                format: "png",
                index: 0,
                nodePath: "sections/0",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.RenderDrawingObject(request);
        }

        /// <summary>
        /// Test for getting drawing object by specified index and format online.
        /// </summary>
        [Test]
        public async Task TestRenderDrawingObjectOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new RenderDrawingObjectOnlineRequest(
                document: requestDocument,
                format: "png",
                index: 0,
                nodePath: "sections/0"
            );
            var actual = await this.WordsApi.RenderDrawingObjectOnline(request);
        }

        /// <summary>
        /// Test for getting drawing object by specified index and format without node path.
        /// </summary>
        [Test]
        public async Task TestRenderDrawingObjectWithoutNodePath()
        {
            string remoteFileName = "TestGetDocumentDrawingObjectByIndexWithFormatWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new RenderDrawingObjectRequest(
                name: remoteFileName,
                format: "png",
                index: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.RenderDrawingObject(request);
        }

        /// <summary>
        /// Test for reading drawing object's image data.
        /// </summary>
        [Test]
        public async Task TestGetDocumentDrawingObjectImageData()
        {
            string remoteFileName = "TestGetDocumentDrawingObjectImageData.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetDocumentDrawingObjectImageDataRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "sections/0",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetDocumentDrawingObjectImageData(request);
        }

        /// <summary>
        /// Test for reading drawing object's image data online.
        /// </summary>
        [Test]
        public async Task TestGetDocumentDrawingObjectImageDataOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetDocumentDrawingObjectImageDataOnlineRequest(
                document: requestDocument,
                index: 0,
                nodePath: "sections/0"
            );
            var actual = await this.WordsApi.GetDocumentDrawingObjectImageDataOnline(request);
        }

        /// <summary>
        /// Test for reading drawing object's image data without node path.
        /// </summary>
        [Test]
        public async Task TestGetDocumentDrawingObjectImageDataWithoutNodePath()
        {
            string remoteFileName = "TestGetDocumentDrawingObjectImageDataWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetDocumentDrawingObjectImageDataRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetDocumentDrawingObjectImageData(request);
        }

        /// <summary>
        /// Test for getting drawing object OLE data.
        /// </summary>
        [Test]
        public async Task TestGetDocumentDrawingObjectOleData()
        {
            string remoteFileName = "TestGetDocumentDrawingObjectOleData.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localDrawingFile)
            );

            var request = new GetDocumentDrawingObjectOleDataRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "sections/0",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetDocumentDrawingObjectOleData(request);
        }

        /// <summary>
        /// Test for getting drawing object OLE data online.
        /// </summary>
        [Test]
        public async Task TestGetDocumentDrawingObjectOleDataOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localDrawingFile);
            var request = new GetDocumentDrawingObjectOleDataOnlineRequest(
                document: requestDocument,
                index: 0,
                nodePath: "sections/0"
            );
            var actual = await this.WordsApi.GetDocumentDrawingObjectOleDataOnline(request);
        }

        /// <summary>
        /// Test for getting drawing object OLE data without node path.
        /// </summary>
        [Test]
        public async Task TestGetDocumentDrawingObjectOleDataWithoutNodePath()
        {
            string remoteFileName = "TestGetDocumentDrawingObjectOleDataWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localDrawingFile)
            );

            var request = new GetDocumentDrawingObjectOleDataRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetDocumentDrawingObjectOleData(request);
        }

        /// <summary>
        /// Test for adding drawing object.
        /// </summary>
        [Test]
        public async Task TestInsertDrawingObject()
        {
            string remoteFileName = "TestInsetDrawingObject.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestDrawingObject = new DrawingObjectInsert()
            {
                Height = 0f,
                Left = 0f,
                Top = 0f,
                Width = 0f,
                RelativeHorizontalPosition = DrawingObjectInsert.RelativeHorizontalPositionEnum.Margin,
                RelativeVerticalPosition = DrawingObjectInsert.RelativeVerticalPositionEnum.Margin,
                WrapType = DrawingObjectInsert.WrapTypeEnum.Inline
            };
            using var requestImageFile = File.OpenRead(LocalTestDataFolder + "Common/aspose-cloud.png");
            var request = new InsertDrawingObjectRequest(
                name: remoteFileName,
                drawingObject: requestDrawingObject,
                imageFile: requestImageFile,
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.InsertDrawingObject(request);
        }

        /// <summary>
        /// Test for adding drawing object online.
        /// </summary>
        [Test]
        public async Task TestInsertDrawingObjectOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestDrawingObject = new DrawingObjectInsert()
            {
                Height = 0f,
                Left = 0f,
                Top = 0f,
                Width = 0f,
                RelativeHorizontalPosition = DrawingObjectInsert.RelativeHorizontalPositionEnum.Margin,
                RelativeVerticalPosition = DrawingObjectInsert.RelativeVerticalPositionEnum.Margin,
                WrapType = DrawingObjectInsert.WrapTypeEnum.Inline
            };
            using var requestImageFile = File.OpenRead(LocalTestDataFolder + "Common/aspose-cloud.png");
            var request = new InsertDrawingObjectOnlineRequest(
                document: requestDocument,
                drawingObject: requestDrawingObject,
                imageFile: requestImageFile,
                nodePath: ""
            );
            var actual = await this.WordsApi.InsertDrawingObjectOnline(request);
        }

        /// <summary>
        /// Test for adding drawing object without node path.
        /// </summary>
        [Test]
        public async Task TestInsertDrawingObjectWithoutNodePath()
        {
            string remoteFileName = "TestInsetDrawingObjectWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestDrawingObject = new DrawingObjectInsert()
            {
                Height = 0f,
                Left = 0f,
                Top = 0f,
                Width = 0f,
                RelativeHorizontalPosition = DrawingObjectInsert.RelativeHorizontalPositionEnum.Margin,
                RelativeVerticalPosition = DrawingObjectInsert.RelativeVerticalPositionEnum.Margin,
                WrapType = DrawingObjectInsert.WrapTypeEnum.Inline
            };
            using var requestImageFile = File.OpenRead(LocalTestDataFolder + "Common/aspose-cloud.png");
            var request = new InsertDrawingObjectRequest(
                name: remoteFileName,
                drawingObject: requestDrawingObject,
                imageFile: requestImageFile,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.InsertDrawingObject(request);
        }

        /// <summary>
        /// Test for adding drawing object with the image from the storage.
        /// </summary>
        [Test]
        public async Task TestInsertDrawingObjectByReference()
        {
            string remoteFileName = "TestInsertDrawingObjectByReference.docx";
            string remoteImagePath = remoteDataFolder + "/TestInsertDrawingObjectByReference.png";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );
            await this.UploadFileToStorage(
                remoteImagePath,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + "Common/aspose-cloud.png")
            );

            var requestDrawingObjectImageReference = new FileReference(remoteImagePath);
            var requestDrawingObject = new DrawingObjectInsertData()
            {
                Height = 0f,
                Left = 0f,
                Top = 0f,
                Width = 0f,
                RelativeHorizontalPosition = DrawingObjectInsertData.RelativeHorizontalPositionEnum.Margin,
                RelativeVerticalPosition = DrawingObjectInsertData.RelativeVerticalPositionEnum.Margin,
                WrapType = DrawingObjectInsertData.WrapTypeEnum.Inline,
                ImageReference = requestDrawingObjectImageReference
            };
            var request = new InsertDrawingObjectByReferenceRequest(
                name: remoteFileName,
                drawingObject: requestDrawingObject,
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.InsertDrawingObjectByReference(request);
        }

        /// <summary>
        /// Test for adding drawing object online with the image from the request.
        /// </summary>
        [Test]
        public async Task TestInsertDrawingObjectByReferenceOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            using var requestDrawingObjectImageReferenceStream = File.OpenRead(LocalTestDataFolder + "Common/aspose-cloud.png");
            var requestDrawingObjectImageReference = new FileReference(requestDrawingObjectImageReferenceStream);
            var requestDrawingObject = new DrawingObjectInsertData()
            {
                Height = 0f,
                Left = 0f,
                Top = 0f,
                Width = 0f,
                RelativeHorizontalPosition = DrawingObjectInsertData.RelativeHorizontalPositionEnum.Margin,
                RelativeVerticalPosition = DrawingObjectInsertData.RelativeVerticalPositionEnum.Margin,
                WrapType = DrawingObjectInsertData.WrapTypeEnum.Inline,
                ImageReference = requestDrawingObjectImageReference
            };
            var request = new InsertDrawingObjectByReferenceOnlineRequest(
                document: requestDocument,
                drawingObject: requestDrawingObject,
                nodePath: ""
            );
            var actual = await this.WordsApi.InsertDrawingObjectByReferenceOnline(request);
        }

        /// <summary>
        /// Test for deleting drawing object.
        /// </summary>
        [Test]
        public async Task TestDeleteDrawingObject()
        {
            string remoteFileName = "TestDeleteDrawingObject.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteDrawingObjectRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "",
                folder: remoteDataFolder
            );
        await this.WordsApi.DeleteDrawingObject(request);
        }

        /// <summary>
        /// Test for deleting drawing object online.
        /// </summary>
        [Test]
        public async Task TestDeleteDrawingObjectOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteDrawingObjectOnlineRequest(
                document: requestDocument,
                index: 0,
                nodePath: ""
            );
            var actual = await this.WordsApi.DeleteDrawingObjectOnline(request);
        }

        /// <summary>
        /// Test for deleting drawing object without node path.
        /// </summary>
        [Test]
        public async Task TestDeleteDrawingObjectWithoutNodePath()
        {
            string remoteFileName = "TestDeleteDrawingObjectWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteDrawingObjectRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );
        await this.WordsApi.DeleteDrawingObject(request);
        }

        /// <summary>
        /// Test for updating drawing object.
        /// </summary>
        [Test]
        public async Task TestUpdateDrawingObject()
        {
            string remoteFileName = "TestUpdateDrawingObject.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestDrawingObject = new DrawingObjectUpdate()
            {
                Left = 0f
            };
            using var requestImageFile = File.OpenRead(LocalTestDataFolder + "Common/aspose-cloud.png");
            var request = new UpdateDrawingObjectRequest(
                name: remoteFileName,
                drawingObject: requestDrawingObject,
                imageFile: requestImageFile,
                index: 0,
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.UpdateDrawingObject(request);
        }

        /// <summary>
        /// Test for updating drawing object online.
        /// </summary>
        [Test]
        public async Task TestUpdateDrawingObjectOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestDrawingObject = new DrawingObjectUpdate()
            {
                Left = 0f
            };
            using var requestImageFile = File.OpenRead(LocalTestDataFolder + "Common/aspose-cloud.png");
            var request = new UpdateDrawingObjectOnlineRequest(
                document: requestDocument,
                drawingObject: requestDrawingObject,
                imageFile: requestImageFile,
                index: 0,
                nodePath: ""
            );
            var actual = await this.WordsApi.UpdateDrawingObjectOnline(request);
        }

        /// <summary>
        /// Test for updating drawing object without node path.
        /// </summary>
        [Test]
        public async Task TestUpdateDrawingObjectWithoutNodePath()
        {
            string remoteFileName = "TestUpdateDrawingObjectWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestDrawingObject = new DrawingObjectUpdate()
            {
                Left = 0f
            };
            using var requestImageFile = File.OpenRead(LocalTestDataFolder + "Common/aspose-cloud.png");
            var request = new UpdateDrawingObjectRequest(
                name: remoteFileName,
                drawingObject: requestDrawingObject,
                imageFile: requestImageFile,
                index: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.UpdateDrawingObject(request);
        }
    }
}
