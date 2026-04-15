// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ChildRequestContent.cs">
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
    using Microsoft.Extensions.Primitives;

    /// <summary>
    /// Represents child response content.
    /// </summary>
    internal class ChildResponseContent : IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChildResponseContent"/> class.
        /// </summary>
        /// <param name="headers">Content headers</param>
        /// <param name="content">Content Stream</param>
        internal ChildResponseContent(Dictionary<string, StringValues> headers, Stream content)
        {
            this.Headers = headers ?? new Dictionary<string, StringValues>(StringComparer.OrdinalIgnoreCase);
            this.Content = content;
        }

        /// <summary>
        /// Gets content headers.
        /// </summary>
        internal Dictionary<string, StringValues> Headers { get; private set; }

        /// <summary>
        /// Gets content disposition.
        /// </summary>
        internal string ContentDisposition => this.GetHeader("Content-Disposition");

        /// <summary>
        /// Gets content type.
        /// </summary>
        internal string ContentType => this.GetHeader("Content-Type");

        /// <summary>
        /// Gets content stream.
        /// </summary>
        internal Stream Content { get; private set; }

        /// <summary>
        /// Gets a header value.
        /// </summary>
        /// <param name="name">Header name.</param>
        /// <returns>First header value or null.</returns>
        internal string GetHeader(string name)
        {
            if (this.Headers.TryGetValue(name, out var value))
            {
                return value.Count > 0 ? value[0] : null;
            }

            return null;
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            this.Content?.Dispose();
        }
    }
}
