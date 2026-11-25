// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="InsertDrawingObjectByReferenceOnlineResponse.cs">
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

namespace Aspose.Words.Cloud.Sdk.Model.Responses
{
    using Aspose.Words.Cloud.Sdk.Model;

    /// <summary>
    /// Response model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.InsertDrawingObjectByReferenceOnline" /> operation.
    /// </summary>
    public class InsertDrawingObjectByReferenceOnlineResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsertDrawingObjectByReferenceOnlineResponse"/> class.
        /// </summary>
        /// <param name="model">The REST response with a DrawingObject.</param>
        /// <param name="document">The document after modification.</param>
        public InsertDrawingObjectByReferenceOnlineResponse(DrawingObjectResponse model, System.Collections.Generic.Dictionary<string, System.IO.Stream> document)
        {
            this.Model = model;
            this.Document = document;
        }

        /// <summary>
        /// The REST response with a DrawingObject.
        /// </summary>
        public DrawingObjectResponse Model { get; private set; }

        /// <summary>
        /// The document after modification.
        /// </summary>
        public System.Collections.Generic.Dictionary<string, System.IO.Stream> Document { get; private set; }
    }
}
