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
    /// Properties specific to a Graph based web service.
    /// </summary>
    [JsonObject("Graph")]
    public partial class WebServicePropertiesForGraph : WebServiceProperties
    {
        /// <summary>
        /// Initializes a new instance of the WebServicePropertiesForGraph
        /// class.
        /// </summary>
        public WebServicePropertiesForGraph() { }

        /// <summary>
        /// Initializes a new instance of the WebServicePropertiesForGraph
        /// class.
        /// </summary>
        public WebServicePropertiesForGraph(string title = default(string), string description = default(string), DateTime? createdOn = default(DateTime?), DateTime? modifiedOn = default(DateTime?), string provisioningState = default(string), WebServiceKeys keys = default(WebServiceKeys), bool? readOnlyProperty = default(bool?), string swaggerLocation = default(string), RealtimeConfiguration realtimeConfiguration = default(RealtimeConfiguration), DiagnosticsConfiguration diagnostics = default(DiagnosticsConfiguration), StorageAccount storageAccount = default(StorageAccount), MachineLearningWorkspace machineLearningWorkspace = default(MachineLearningWorkspace), CommitmentPlan commitmentPlan = default(CommitmentPlan), ServiceInputOutputSpecification input = default(ServiceInputOutputSpecification), ServiceInputOutputSpecification output = default(ServiceInputOutputSpecification), IDictionary<string, AssetItem> assets = default(IDictionary<string, AssetItem>), IDictionary<string, string> parameters = default(IDictionary<string, string>), WebServicePropertiesForGraphPackage package = default(WebServicePropertiesForGraphPackage))
            : base(title, description, createdOn, modifiedOn, provisioningState, keys, readOnlyProperty, swaggerLocation, realtimeConfiguration, diagnostics, storageAccount, machineLearningWorkspace, commitmentPlan, input, output, assets, parameters)
        {
            Package = package;
        }

        /// <summary>
        /// The definition of the graph package making up this web service.
        /// </summary>
        [JsonProperty(PropertyName = "package")]
        public WebServicePropertiesForGraphPackage Package { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
