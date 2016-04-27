// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.WebServices.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Defines a global parameter in the graph.
    /// </summary>
    public partial class GraphParameter
    {
        /// <summary>
        /// Initializes a new instance of the GraphParameter class.
        /// </summary>
        public GraphParameter() { }

        /// <summary>
        /// Initializes a new instance of the GraphParameter class.
        /// </summary>
        public GraphParameter(string type, IList<GraphParameterLink> links, string description = default(string))
        {
            Description = description;
            Type = type;
            Links = links;
        }

        /// <summary>
        /// Description of this graph parameter.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Graph parameter's type. Possible values include: 'String', 'Int',
        /// 'Float', 'Enumerated', 'Script', 'Mode', 'Credential', 'Boolean',
        /// 'Double', 'ColumnPicker', 'ParameterRange', 'DataGatewayName'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Association links for this parameter to nodes in the graph.
        /// </summary>
        [JsonProperty(PropertyName = "links")]
        public IList<GraphParameterLink> Links { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (Links == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Links");
            }
            if (this.Links != null)
            {
                foreach (var element in this.Links)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
