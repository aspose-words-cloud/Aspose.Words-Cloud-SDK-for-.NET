// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OfficeMathObject.cs">
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
    /// DTO container with an OfficeMath object.
    /// </summary>
    public class OfficeMathObject : OfficeMathLink, IModel
    {
        /// <summary>
        /// Gets or sets the display format type of the OfficeMath object. This display format defines whether an equation is displayed inline with the text or displayed on its own line.
        /// Display format type has effect for top level Office Math only.Returned display format type is always Inline for nested Office Math.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DisplayTypeEnum
        {
            /// <summary>
            /// Enum value "Display"
            /// </summary>
            Display,

            /// <summary>
            /// Enum value "Inline"
            /// </summary>
            Inline,
        }

        /// <summary>
        /// Gets or sets the justification of the OfficeMath object.
        /// Justification cannot be set to the Office Math with display format type Inline.Inline justification cannot be set to the Office Math with display format type Display.Corresponding DisplayType has to be set before setting Office Math justification.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum JustificationEnum
        {
            /// <summary>
            /// Enum value "CenterGroup"
            /// </summary>
            CenterGroup,

            /// <summary>
            /// Enum value "Default"
            /// </summary>
            Default,

            /// <summary>
            /// Enum value "Center"
            /// </summary>
            Center,

            /// <summary>
            /// Enum value "Left"
            /// </summary>
            Left,

            /// <summary>
            /// Enum value "Right"
            /// </summary>
            Right,

            /// <summary>
            /// Enum value "Inline"
            /// </summary>
            Inline,
        }

        /// <summary>
        /// Gets or sets the type of the OfficeMath object.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MathObjectTypeEnum
        {
            /// <summary>
            /// Enum value "OMath"
            /// </summary>
            OMath,

            /// <summary>
            /// Enum value "OMathPara"
            /// </summary>
            OMathPara,

            /// <summary>
            /// Enum value "Accent"
            /// </summary>
            Accent,

            /// <summary>
            /// Enum value "Bar"
            /// </summary>
            Bar,

            /// <summary>
            /// Enum value "BorderBox"
            /// </summary>
            BorderBox,

            /// <summary>
            /// Enum value "Box"
            /// </summary>
            Box,

            /// <summary>
            /// Enum value "Delimiter"
            /// </summary>
            Delimiter,

            /// <summary>
            /// Enum value "Degree"
            /// </summary>
            Degree,

            /// <summary>
            /// Enum value "Argument"
            /// </summary>
            Argument,

            /// <summary>
            /// Enum value "Array"
            /// </summary>
            Array,

            /// <summary>
            /// Enum value "Fraction"
            /// </summary>
            Fraction,

            /// <summary>
            /// Enum value "Denominator"
            /// </summary>
            Denominator,

            /// <summary>
            /// Enum value "Numerator"
            /// </summary>
            Numerator,

            /// <summary>
            /// Enum value "Function"
            /// </summary>
            Function,

            /// <summary>
            /// Enum value "FunctionName"
            /// </summary>
            FunctionName,

            /// <summary>
            /// Enum value "GroupCharacter"
            /// </summary>
            GroupCharacter,

            /// <summary>
            /// Enum value "Limit"
            /// </summary>
            Limit,

            /// <summary>
            /// Enum value "LowerLimit"
            /// </summary>
            LowerLimit,

            /// <summary>
            /// Enum value "UpperLimit"
            /// </summary>
            UpperLimit,

            /// <summary>
            /// Enum value "Matrix"
            /// </summary>
            Matrix,

            /// <summary>
            /// Enum value "MatrixRow"
            /// </summary>
            MatrixRow,

            /// <summary>
            /// Enum value "NAry"
            /// </summary>
            NAry,

            /// <summary>
            /// Enum value "Phantom"
            /// </summary>
            Phantom,

            /// <summary>
            /// Enum value "Radical"
            /// </summary>
            Radical,

            /// <summary>
            /// Enum value "SubscriptPart"
            /// </summary>
            SubscriptPart,

            /// <summary>
            /// Enum value "SuperscriptPart"
            /// </summary>
            SuperscriptPart,

            /// <summary>
            /// Enum value "PreSubSuperscript"
            /// </summary>
            PreSubSuperscript,

            /// <summary>
            /// Enum value "Subscript"
            /// </summary>
            Subscript,

            /// <summary>
            /// Enum value "SubSuperscript"
            /// </summary>
            SubSuperscript,

            /// <summary>
            /// Enum value "Superscript"
            /// </summary>
            Superscript,

            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,
        }

        /// <summary>
        /// Gets or sets the content of a footnote.
        /// </summary>
        public virtual StoryChildNodes Content { get; set; }

        /// <summary>
        /// Gets or sets the display format type of the OfficeMath object. This display format defines whether an equation is displayed inline with the text or displayed on its own line.
        /// Display format type has effect for top level Office Math only.Returned display format type is always Inline for nested Office Math.
        /// </summary>
        public virtual DisplayTypeEnum? DisplayType { get; set; }

        /// <summary>
        /// Gets or sets the justification of the OfficeMath object.
        /// Justification cannot be set to the Office Math with display format type Inline.Inline justification cannot be set to the Office Math with display format type Display.Corresponding DisplayType has to be set before setting Office Math justification.
        /// </summary>
        public virtual JustificationEnum? Justification { get; set; }

        /// <summary>
        /// Gets or sets the type of the OfficeMath object.
        /// </summary>
        public virtual MathObjectTypeEnum? MathObjectType { get; set; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public override void Validate()
        {
            base.Validate();

            this.Content?.Validate();




        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OfficeMathObject {\n");
            sb.Append("  Link: ").Append(this.Link).Append("\n");
            sb.Append("  NodeId: ").Append(this.NodeId).Append("\n");
            sb.Append("  Content: ").Append(this.Content).Append("\n");
            sb.Append("  DisplayType: ").Append(this.DisplayType).Append("\n");
            sb.Append("  Justification: ").Append(this.Justification).Append("\n");
            sb.Append("  MathObjectType: ").Append(this.MathObjectType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
