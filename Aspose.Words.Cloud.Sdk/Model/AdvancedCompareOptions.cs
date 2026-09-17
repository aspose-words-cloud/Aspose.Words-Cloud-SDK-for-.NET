// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AdvancedCompareOptions.cs">
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
    /// Allows to set advanced compare options.
    /// </summary>
    public class AdvancedCompareOptions : IModel
    {
        /// <summary>
        /// Gets or sets the value indicating whether list definition contents are compared instead of list definition Ids.
        /// Default value is false.
        /// </summary>
        public virtual bool? CompareListDefinitions { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to ignore difference in DrawingML unique Id.
        /// Default value is false.
        /// </summary>
        public virtual bool? IgnoreDmlUniqueId { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to ignore difference in StructuredDocumentTag store item Id.
        /// Default value is false.
        /// </summary>
        public virtual bool? IgnoreStoreItemId { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public virtual void Validate()
        {
        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvancedCompareOptions {\n");
            sb.Append("  CompareListDefinitions: ").Append(this.CompareListDefinitions).Append("\n");
            sb.Append("  IgnoreDmlUniqueId: ").Append(this.IgnoreDmlUniqueId).Append("\n");
            sb.Append("  IgnoreStoreItemId: ").Append(this.IgnoreStoreItemId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
