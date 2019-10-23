// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Plane.cs">
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
  /// Plane Entity
  /// </summary>
  [DataContract]
  public class Plane 
  {                       
        /// <summary>
        /// The name of Plane
        /// </summary>  
        [DataMember(Name="Name", EmitDefaultValue=false)] 
        public string Name { get; set; }
		
        /// <summary>
        /// Gets or sets the length of the plane.             
        /// </summary>  
        [DataMember(Name="Length", EmitDefaultValue=false)] 
        public double? Length { get; set; }
		
        /// <summary>
        /// Gets or sets the width of the plane             
        /// </summary>  
        [DataMember(Name="Width", EmitDefaultValue=false)] 
        public double? Width { get; set; }
		
        /// <summary>
        /// Gets or sets the length segments.             
        /// </summary>  
        [DataMember(Name="LengthSegments", EmitDefaultValue=false)] 
        public int? LengthSegments { get; set; }
		
        /// <summary>
        /// Gets or sets the width segments.
        /// </summary>  
        [DataMember(Name="WidthSegments", EmitDefaultValue=false)] 
        public int? WidthSegments { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Plane {\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  Length: ").Append(this.Length).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  LengthSegments: ").Append(this.LengthSegments).Append("\n");
          sb.Append("  WidthSegments: ").Append(this.WidthSegments).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
