// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ColladaSaveOption.cs">
//   Copyright (c) 2018 Aspose.ThreeD for Cloud
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

using System; 

namespace Aspose.ThreeD.Cloud.SDK.Model 
{
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ColladaSaveOption : SaveOptions 
  {                       
        /// <summary>
        /// Gets or sets whether the exported XML document is indented.
        /// </summary>  
        [DataMember(Name="Indented", EmitDefaultValue=false)] 
        public bool? Indented { get; set; }
		
        /// <summary>
        /// Gets or sets  of the Transform Style.
        /// </summary>  
        [DataMember(Name="TransformStyle", EmitDefaultValue=false)] 
        public ColladaTransformStyle TransformStyle { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ColladaSaveOption {\n");
          sb.Append("  Indented: ").Append(this.Indented).Append("\n");
          sb.Append("  TransformStyle: ").Append(this.TransformStyle).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}