namespace Microsoft.Azure.Management.Compute
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using System.Linq.Expressions;
    using Microsoft.Azure;
    using Models;

    public static partial class VirtualMachineExtensionImagesOperationsExtensions
    {
            /// <summary>
            /// Gets a virtual machine extension image.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='publisherName'>
            /// </param>
            /// <param name='type'>
            /// </param>
            /// <param name='version'>
            /// </param>
            public static VirtualMachineExtensionImage Get(this IVirtualMachineExtensionImagesOperations operations, string location, string publisherName, string type, string version)
            {
                return Task.Factory.StartNew(s => ((IVirtualMachineExtensionImagesOperations)s).GetAsync(location, publisherName, type, version), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a virtual machine extension image.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='publisherName'>
            /// </param>
            /// <param name='type'>
            /// </param>
            /// <param name='version'>
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<VirtualMachineExtensionImage> GetAsync( this IVirtualMachineExtensionImagesOperations operations, string location, string publisherName, string type, string version, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<VirtualMachineExtensionImage> result = await operations.GetWithHttpMessagesAsync(location, publisherName, type, version, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets a list of virtual machine extension image versions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='publisherName'>
            /// </param>
            /// <param name='type'>
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='orderby'>
            /// </param>
            public static IList<VirtualMachineImageResource> ListVersions(this IVirtualMachineExtensionImagesOperations operations, string location, string publisherName, string type, Expression<Func<VirtualMachineImageResource, bool>> filter = default(Expression<Func<VirtualMachineImageResource, bool>>), int? top = default(int?), string orderby = default(string))
            {
                return Task.Factory.StartNew(s => ((IVirtualMachineExtensionImagesOperations)s).ListVersionsAsync(location, publisherName, type, filter, top, orderby), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of virtual machine extension image versions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='publisherName'>
            /// </param>
            /// <param name='type'>
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='orderby'>
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<IList<VirtualMachineImageResource>> ListVersionsAsync( this IVirtualMachineExtensionImagesOperations operations, string location, string publisherName, string type, Expression<Func<VirtualMachineImageResource, bool>> filter = default(Expression<Func<VirtualMachineImageResource, bool>>), int? top = default(int?), string orderby = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IList<VirtualMachineImageResource>> result = await operations.ListVersionsWithHttpMessagesAsync(location, publisherName, type, filter, top, orderby, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets a list of virtual machine extension image types.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='publisherName'>
            /// </param>
            public static IList<VirtualMachineImageResource> ListTypes(this IVirtualMachineExtensionImagesOperations operations, string location, string publisherName)
            {
                return Task.Factory.StartNew(s => ((IVirtualMachineExtensionImagesOperations)s).ListTypesAsync(location, publisherName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of virtual machine extension image types.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='publisherName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<IList<VirtualMachineImageResource>> ListTypesAsync( this IVirtualMachineExtensionImagesOperations operations, string location, string publisherName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IList<VirtualMachineImageResource>> result = await operations.ListTypesWithHttpMessagesAsync(location, publisherName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}
