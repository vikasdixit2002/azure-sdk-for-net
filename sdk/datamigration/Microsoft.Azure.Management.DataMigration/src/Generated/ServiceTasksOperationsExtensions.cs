// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ServiceTasksOperations.
    /// </summary>
    public static partial class ServiceTasksOperationsExtensions
    {
            /// <summary>
            /// Get service level tasks for a service
            /// </summary>
            /// <remarks>
            /// The services resource is the top-level resource that represents the
            /// Database Migration Service. This method returns a list of service level
            /// tasks owned by a service resource. Some tasks may have a status of Unknown,
            /// which indicates that an error occurred while querying the status of that
            /// task.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='taskType'>
            /// Filter tasks by task type
            /// </param>
            public static IPage<ProjectTask> List(this IServiceTasksOperations operations, string groupName, string serviceName, string taskType = default(string))
            {
                return operations.ListAsync(groupName, serviceName, taskType).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get service level tasks for a service
            /// </summary>
            /// <remarks>
            /// The services resource is the top-level resource that represents the
            /// Database Migration Service. This method returns a list of service level
            /// tasks owned by a service resource. Some tasks may have a status of Unknown,
            /// which indicates that an error occurred while querying the status of that
            /// task.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='taskType'>
            /// Filter tasks by task type
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ProjectTask>> ListAsync(this IServiceTasksOperations operations, string groupName, string serviceName, string taskType = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(groupName, serviceName, taskType, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update service task
            /// </summary>
            /// <remarks>
            /// The service tasks resource is a nested, proxy-only resource representing
            /// work performed by a DMS instance. The PUT method creates a new service task
            /// or updates an existing one, although since service tasks have no mutable
            /// custom properties, there is little reason to update an existing one.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Information about the task
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='taskName'>
            /// Name of the Task
            /// </param>
            public static ProjectTask CreateOrUpdate(this IServiceTasksOperations operations, ProjectTask parameters, string groupName, string serviceName, string taskName)
            {
                return operations.CreateOrUpdateAsync(parameters, groupName, serviceName, taskName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update service task
            /// </summary>
            /// <remarks>
            /// The service tasks resource is a nested, proxy-only resource representing
            /// work performed by a DMS instance. The PUT method creates a new service task
            /// or updates an existing one, although since service tasks have no mutable
            /// custom properties, there is little reason to update an existing one.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Information about the task
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='taskName'>
            /// Name of the Task
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProjectTask> CreateOrUpdateAsync(this IServiceTasksOperations operations, ProjectTask parameters, string groupName, string serviceName, string taskName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(parameters, groupName, serviceName, taskName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get service task information
            /// </summary>
            /// <remarks>
            /// The service tasks resource is a nested, proxy-only resource representing
            /// work performed by a DMS instance. The GET method retrieves information
            /// about a service task.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='taskName'>
            /// Name of the Task
            /// </param>
            /// <param name='expand'>
            /// Expand the response
            /// </param>
            public static ProjectTask Get(this IServiceTasksOperations operations, string groupName, string serviceName, string taskName, string expand = default(string))
            {
                return operations.GetAsync(groupName, serviceName, taskName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get service task information
            /// </summary>
            /// <remarks>
            /// The service tasks resource is a nested, proxy-only resource representing
            /// work performed by a DMS instance. The GET method retrieves information
            /// about a service task.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='taskName'>
            /// Name of the Task
            /// </param>
            /// <param name='expand'>
            /// Expand the response
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProjectTask> GetAsync(this IServiceTasksOperations operations, string groupName, string serviceName, string taskName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(groupName, serviceName, taskName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete service task
            /// </summary>
            /// <remarks>
            /// The service tasks resource is a nested, proxy-only resource representing
            /// work performed by a DMS instance. The DELETE method deletes a service task,
            /// canceling it first if it's running.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='taskName'>
            /// Name of the Task
            /// </param>
            /// <param name='deleteRunningTasks'>
            /// Delete the resource even if it contains running tasks
            /// </param>
            public static void Delete(this IServiceTasksOperations operations, string groupName, string serviceName, string taskName, bool? deleteRunningTasks = default(bool?))
            {
                operations.DeleteAsync(groupName, serviceName, taskName, deleteRunningTasks).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete service task
            /// </summary>
            /// <remarks>
            /// The service tasks resource is a nested, proxy-only resource representing
            /// work performed by a DMS instance. The DELETE method deletes a service task,
            /// canceling it first if it's running.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='taskName'>
            /// Name of the Task
            /// </param>
            /// <param name='deleteRunningTasks'>
            /// Delete the resource even if it contains running tasks
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IServiceTasksOperations operations, string groupName, string serviceName, string taskName, bool? deleteRunningTasks = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(groupName, serviceName, taskName, deleteRunningTasks, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create or update service task
            /// </summary>
            /// <remarks>
            /// The service tasks resource is a nested, proxy-only resource representing
            /// work performed by a DMS instance. The PATCH method updates an existing
            /// service task, but since service tasks have no mutable custom properties,
            /// there is little reason to do so.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Information about the task
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='taskName'>
            /// Name of the Task
            /// </param>
            public static ProjectTask Update(this IServiceTasksOperations operations, ProjectTask parameters, string groupName, string serviceName, string taskName)
            {
                return operations.UpdateAsync(parameters, groupName, serviceName, taskName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update service task
            /// </summary>
            /// <remarks>
            /// The service tasks resource is a nested, proxy-only resource representing
            /// work performed by a DMS instance. The PATCH method updates an existing
            /// service task, but since service tasks have no mutable custom properties,
            /// there is little reason to do so.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Information about the task
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='taskName'>
            /// Name of the Task
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProjectTask> UpdateAsync(this IServiceTasksOperations operations, ProjectTask parameters, string groupName, string serviceName, string taskName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(parameters, groupName, serviceName, taskName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancel a service task
            /// </summary>
            /// <remarks>
            /// The service tasks resource is a nested, proxy-only resource representing
            /// work performed by a DMS instance. This method cancels a service task if
            /// it's currently queued or running.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='taskName'>
            /// Name of the Task
            /// </param>
            public static ProjectTask Cancel(this IServiceTasksOperations operations, string groupName, string serviceName, string taskName)
            {
                return operations.CancelAsync(groupName, serviceName, taskName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancel a service task
            /// </summary>
            /// <remarks>
            /// The service tasks resource is a nested, proxy-only resource representing
            /// work performed by a DMS instance. This method cancels a service task if
            /// it's currently queued or running.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='taskName'>
            /// Name of the Task
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProjectTask> CancelAsync(this IServiceTasksOperations operations, string groupName, string serviceName, string taskName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CancelWithHttpMessagesAsync(groupName, serviceName, taskName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get service level tasks for a service
            /// </summary>
            /// <remarks>
            /// The services resource is the top-level resource that represents the
            /// Database Migration Service. This method returns a list of service level
            /// tasks owned by a service resource. Some tasks may have a status of Unknown,
            /// which indicates that an error occurred while querying the status of that
            /// task.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ProjectTask> ListNext(this IServiceTasksOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get service level tasks for a service
            /// </summary>
            /// <remarks>
            /// The services resource is the top-level resource that represents the
            /// Database Migration Service. This method returns a list of service level
            /// tasks owned by a service resource. Some tasks may have a status of Unknown,
            /// which indicates that an error occurred while querying the status of that
            /// task.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ProjectTask>> ListNextAsync(this IServiceTasksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
