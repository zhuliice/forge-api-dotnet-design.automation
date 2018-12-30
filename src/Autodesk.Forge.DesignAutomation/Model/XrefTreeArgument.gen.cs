/* 
 * Forge Design Automation
 *
 * Generated by [Forge Swagger Codegen](https://git.autodesk.com/forge-ozone/forge-rsdk-codegen)
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Autodesk.Forge.DesignAutomation.Model
{
    /// <summary>
    /// XrefTreeArgument
    /// </summary>
    [DataContract]
    public partial class XrefTreeArgument : IArgument
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XrefTreeArgument" /> class.
        /// </summary>
        public XrefTreeArgument() : base()
        {
        }
        
        /// <summary>
        /// Gets or Sets Optional
        /// </summary>
        [DataMember(Name="optional", EmitDefaultValue=false)]
        public bool Optional { get; set; }

        /// <summary>
        /// Gets or Sets LocalName
        /// </summary>
        [DataMember(Name="localName", EmitDefaultValue=false)]
        public string LocalName { get; set; }

        /// <summary>
        /// Gets or Sets PathInZip
        /// </summary>
        [DataMember(Name="pathInZip", EmitDefaultValue=false)]
        public string PathInZip { get; set; }

        /// <summary>
        /// Gets or Sets References
        /// </summary>
        [DataMember(Name="references", EmitDefaultValue=false)]
        public List<XrefTreeArgument> References { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Headers
        /// </summary>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Gets or Sets Verb
        /// </summary>
        [DataMember(Name="verb", EmitDefaultValue=false)]
        public Verb Verb { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

}
