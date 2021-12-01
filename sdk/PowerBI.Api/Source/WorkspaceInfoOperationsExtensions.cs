// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for WorkspaceInfoOperations.
    /// </summary>
    public static partial class WorkspaceInfoOperationsExtensions
    {
            /// <summary>
            /// Initiates a call to receive metadata for the requested list of workspaces.
            /// This is a preview API call.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have administrator rights (such as Microsoft 365 Global
            /// Administrator or Power BI Service Administrator) or authenticate using a
            /// service principal.
            ///
            /// ## Required scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// - Maximum 500 requests per hour.
            /// - Maximum 16 simultaneous requests.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requiredWorkspaces'>
            /// Required workspace IDs to get info for
            /// </param>
            /// <param name='lineage'>
            /// Whether to return lineage info (upstream dataflows, tiles, datasource IDs)​
            /// </param>
            /// <param name='datasourceDetails'>
            /// Whether to return datasource details​
            /// </param>
            /// <param name='datasetSchema'>
            /// Whether to return dataset schema (Tables, Columns and Measures)​
            /// </param>
            /// <param name='datasetExpressions'>
            /// Whether to return dataset expressions (Dax query and Mashup)​
            /// </param>
            /// <param name='getArtifactUsers'>
            /// Whether to return artifact user details​ (Preview) (Permission level)
            /// </param>
            public static ScanRequest PostWorkspaceInfo(this IWorkspaceInfoOperations operations, RequiredWorkspaces requiredWorkspaces, bool? lineage = default(bool?), bool? datasourceDetails = default(bool?), bool? datasetSchema = default(bool?), bool? datasetExpressions = default(bool?), bool? getArtifactUsers = default(bool?))
            {
                return operations.PostWorkspaceInfoAsync(requiredWorkspaces, lineage, datasourceDetails, datasetSchema, datasetExpressions, getArtifactUsers).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Initiates a call to receive metadata for the requested list of workspaces.
            /// This is a preview API call.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have administrator rights (such as Microsoft 365 Global
            /// Administrator or Power BI Service Administrator) or authenticate using a
            /// service principal.
            ///
            /// ## Required scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// - Maximum 500 requests per hour.
            /// - Maximum 16 simultaneous requests.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requiredWorkspaces'>
            /// Required workspace IDs to get info for
            /// </param>
            /// <param name='lineage'>
            /// Whether to return lineage info (upstream dataflows, tiles, datasource IDs)​
            /// </param>
            /// <param name='datasourceDetails'>
            /// Whether to return datasource details​
            /// </param>
            /// <param name='datasetSchema'>
            /// Whether to return dataset schema (Tables, Columns and Measures)​
            /// </param>
            /// <param name='datasetExpressions'>
            /// Whether to return dataset expressions (Dax query and Mashup)​
            /// </param>
            /// <param name='getArtifactUsers'>
            /// Whether to return artifact user details​ (Preview) (Permission level)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ScanRequest> PostWorkspaceInfoAsync(this IWorkspaceInfoOperations operations, RequiredWorkspaces requiredWorkspaces, bool? lineage = default(bool?), bool? datasourceDetails = default(bool?), bool? datasetSchema = default(bool?), bool? datasetExpressions = default(bool?), bool? getArtifactUsers = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWorkspaceInfoWithHttpMessagesAsync(requiredWorkspaces, lineage, datasourceDetails, datasetSchema, datasetExpressions, getArtifactUsers, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the scan status for the specified scan. This is a preview API call.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have administrator rights (such as Microsoft 365 Global
            /// Administrator or Power BI Service Administrator) or authenticate using a
            /// service principal.
            ///
            /// ## Required scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Maximum 10,000 requests per hour.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scanId'>
            /// The scan ID, which is included in the response from the workspaces or
            /// getInfo API that triggered the scan
            /// </param>
            public static ScanRequest GetScanStatus(this IWorkspaceInfoOperations operations, System.Guid scanId)
            {
                return operations.GetScanStatusAsync(scanId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the scan status for the specified scan. This is a preview API call.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have administrator rights (such as Microsoft 365 Global
            /// Administrator or Power BI Service Administrator) or authenticate using a
            /// service principal.
            ///
            /// ## Required scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Maximum 10,000 requests per hour.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scanId'>
            /// The scan ID, which is included in the response from the workspaces or
            /// getInfo API that triggered the scan
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ScanRequest> GetScanStatusAsync(this IWorkspaceInfoOperations operations, System.Guid scanId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetScanStatusWithHttpMessagesAsync(scanId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the scan result for the specified scan. This is a preview API call.
            /// </summary>
            /// <remarks>
            ///
            /// Only make this API call after a successful
            /// [GetScanStatus](/rest/api/power-bi/admin/workspace-info-get-scan-status)
            /// API call. The scan result will remain available for 24 hours.
            ///
            /// ## Permissions
            ///
            /// The user must have administrator rights (such as Microsoft 365 Global
            /// Administrator or Power BI Service Administrator) or authenticate using a
            /// service principal.
            ///
            /// ## Required scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Maximum 500 requests per hour.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scanId'>
            /// The scan ID, which is included in the response from the workspaces or
            /// getInfo API that triggered the scan
            /// </param>
            public static WorkspaceInfoResponse GetScanResult(this IWorkspaceInfoOperations operations, System.Guid scanId)
            {
                return operations.GetScanResultAsync(scanId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the scan result for the specified scan. This is a preview API call.
            /// </summary>
            /// <remarks>
            ///
            /// Only make this API call after a successful
            /// [GetScanStatus](/rest/api/power-bi/admin/workspace-info-get-scan-status)
            /// API call. The scan result will remain available for 24 hours.
            ///
            /// ## Permissions
            ///
            /// The user must have administrator rights (such as Microsoft 365 Global
            /// Administrator or Power BI Service Administrator) or authenticate using a
            /// service principal.
            ///
            /// ## Required scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Maximum 500 requests per hour.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scanId'>
            /// The scan ID, which is included in the response from the workspaces or
            /// getInfo API that triggered the scan
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkspaceInfoResponse> GetScanResultAsync(this IWorkspaceInfoOperations operations, System.Guid scanId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetScanResultWithHttpMessagesAsync(scanId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of workspace IDs in the organization. This is a preview API
            /// call.
            /// </summary>
            /// <remarks>
            ///
            /// If the optional `modifiedSince` parameter is set to a date-time, only the
            /// IDs of workspaces that changed after that date-time are returned. If the
            /// `modifiedSince` parameter isn't used, the IDs of all workspaces in the
            /// organization are returned. The date-time specified by the `modifiedSince`
            /// parameter must be in the range of 30 minutes (to allow workspace changes to
            /// take effect) to 30 days prior to the current time.
            ///
            /// ## Permissions
            ///
            /// The user must have administrator rights (such as Microsoft 365 Global
            /// Administrator or Power BI Service Administrator) or authenticate using a
            /// service principal.
            ///
            /// ## Required scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Maximum 30 requests per hour.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='modifiedSince'>
            /// Last modified date​ (must be in ISO 8601 compliant UTC format)
            /// </param>
            /// <param name='excludePersonalWorkspaces'>
            /// Whether to exclude personal workspaces​
            /// </param>
            public static IList<ModifiedWorkspace> GetModifiedWorkspaces(this IWorkspaceInfoOperations operations, System.DateTime? modifiedSince = default(System.DateTime?), bool? excludePersonalWorkspaces = default(bool?))
            {
                return operations.GetModifiedWorkspacesAsync(modifiedSince, excludePersonalWorkspaces).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of workspace IDs in the organization. This is a preview API
            /// call.
            /// </summary>
            /// <remarks>
            ///
            /// If the optional `modifiedSince` parameter is set to a date-time, only the
            /// IDs of workspaces that changed after that date-time are returned. If the
            /// `modifiedSince` parameter isn't used, the IDs of all workspaces in the
            /// organization are returned. The date-time specified by the `modifiedSince`
            /// parameter must be in the range of 30 minutes (to allow workspace changes to
            /// take effect) to 30 days prior to the current time.
            ///
            /// ## Permissions
            ///
            /// The user must have administrator rights (such as Microsoft 365 Global
            /// Administrator or Power BI Service Administrator) or authenticate using a
            /// service principal.
            ///
            /// ## Required scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Maximum 30 requests per hour.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='modifiedSince'>
            /// Last modified date​ (must be in ISO 8601 compliant UTC format)
            /// </param>
            /// <param name='excludePersonalWorkspaces'>
            /// Whether to exclude personal workspaces​
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ModifiedWorkspace>> GetModifiedWorkspacesAsync(this IWorkspaceInfoOperations operations, System.DateTime? modifiedSince = default(System.DateTime?), bool? excludePersonalWorkspaces = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetModifiedWorkspacesWithHttpMessagesAsync(modifiedSince, excludePersonalWorkspaces, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
