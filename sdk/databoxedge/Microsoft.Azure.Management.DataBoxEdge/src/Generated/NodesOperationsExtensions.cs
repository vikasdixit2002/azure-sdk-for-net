// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for NodesOperations.
    /// </summary>
    public static partial class NodesOperationsExtensions
    {
            /// <summary>
            /// Gets all the nodes currently configured under this Data Box Edge device
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// The device name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            public static IEnumerable<Node> ListByDataBoxEdgeDevice(this INodesOperations operations, string deviceName, string resourceGroupName)
            {
                return operations.ListByDataBoxEdgeDeviceAsync(deviceName, resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the nodes currently configured under this Data Box Edge device
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// The device name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Node>> ListByDataBoxEdgeDeviceAsync(this INodesOperations operations, string deviceName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDataBoxEdgeDeviceWithHttpMessagesAsync(deviceName, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
