// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Resources
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for SubscriptionsOperations
    /// </summary>
    public static partial class SubscriptionsOperationsExtensions
    {
        /// <summary>
        /// This operation provides all the locations that are available for resource
        /// providers; however, each resource provider may support a subset of this
        /// list.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='subscriptionId'>
        /// The ID of the target subscription.
        /// </param>
        /// <param name='includeExtendedLocations'>
        /// Whether to include extended locations.
        /// </param>
        public static System.Collections.Generic.IEnumerable<Location> ListLocations(this ISubscriptionsOperations operations, string subscriptionId, bool? includeExtendedLocations = default(bool?))
        {
                return ((ISubscriptionsOperations)operations).ListLocationsAsync(subscriptionId, includeExtendedLocations).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This operation provides all the locations that are available for resource
        /// providers; however, each resource provider may support a subset of this
        /// list.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='subscriptionId'>
        /// The ID of the target subscription.
        /// </param>
        /// <param name='includeExtendedLocations'>
        /// Whether to include extended locations.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Location>> ListLocationsAsync(this ISubscriptionsOperations operations, string subscriptionId, bool? includeExtendedLocations = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListLocationsWithHttpMessagesAsync(subscriptionId, includeExtendedLocations, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets details about a specified subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='subscriptionId'>
        /// The ID of the target subscription.
        /// </param>
        public static Subscription Get(this ISubscriptionsOperations operations, string subscriptionId)
        {
                return ((ISubscriptionsOperations)operations).GetAsync(subscriptionId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets details about a specified subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='subscriptionId'>
        /// The ID of the target subscription.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Subscription> GetAsync(this ISubscriptionsOperations operations, string subscriptionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(subscriptionId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets all subscriptions for a tenant.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Subscription> List(this ISubscriptionsOperations operations)
        {
                return ((ISubscriptionsOperations)operations).ListAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets all subscriptions for a tenant.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Subscription>> ListAsync(this ISubscriptionsOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Compares a subscriptions logical zone mapping
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='subscriptionId'>
        /// The ID of the target subscription.
        /// </param>
        public static CheckZonePeersResult CheckZonePeers(this ISubscriptionsOperations operations, string subscriptionId, CheckZonePeersRequest parameters)
        {
                return ((ISubscriptionsOperations)operations).CheckZonePeersAsync(subscriptionId, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Compares a subscriptions logical zone mapping
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='subscriptionId'>
        /// The ID of the target subscription.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<CheckZonePeersResult> CheckZonePeersAsync(this ISubscriptionsOperations operations, string subscriptionId, CheckZonePeersRequest parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CheckZonePeersWithHttpMessagesAsync(subscriptionId, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets all subscriptions for a tenant.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Subscription> ListNext(this ISubscriptionsOperations operations, string nextPageLink)
        {
                return ((ISubscriptionsOperations)operations).ListNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets all subscriptions for a tenant.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Subscription>> ListNextAsync(this ISubscriptionsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
