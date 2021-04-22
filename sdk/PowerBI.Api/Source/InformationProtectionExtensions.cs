// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for InformationProtection.
    /// </summary>
    public static partial class InformationProtectionExtensions
    {
            /// <summary>
            /// Remove sensitivity labels from artifacts by artifact ID.
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Office 365
            /// Global Administrator or Power BI Service Administrator) to call this API.
            /// &lt;br/&gt; The admin user must have sufficient [usage
            /// rights](https://go.microsoft.com/fwlink/?linkid=2157685) to delete
            /// labels.&lt;br/&gt;This API allows a maximum of 25 requests per hour. Each
            /// request can update up to 2000 artifacts. &lt;br/&gt;&lt;br/&gt;**Required
            /// scope**: Tenant.ReadWrite.All
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='artifacts'>
            /// Composite of artifact Id lists per Type.
            /// </param>
            public static InformationProtectionChangeLabelResponse RemoveLabelsAsAdmin(this IInformationProtection operations, InformationProtectionArtifactsChangeLabel artifacts)
            {
                return operations.RemoveLabelsAsAdminAsync(artifacts).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Remove sensitivity labels from artifacts by artifact ID.
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Office 365
            /// Global Administrator or Power BI Service Administrator) to call this API.
            /// &lt;br/&gt; The admin user must have sufficient [usage
            /// rights](https://go.microsoft.com/fwlink/?linkid=2157685) to delete
            /// labels.&lt;br/&gt;This API allows a maximum of 25 requests per hour. Each
            /// request can update up to 2000 artifacts. &lt;br/&gt;&lt;br/&gt;**Required
            /// scope**: Tenant.ReadWrite.All
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='artifacts'>
            /// Composite of artifact Id lists per Type.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InformationProtectionChangeLabelResponse> RemoveLabelsAsAdminAsync(this IInformationProtection operations, InformationProtectionArtifactsChangeLabel artifacts, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RemoveLabelsAsAdminWithHttpMessagesAsync(artifacts, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Set sensitivity labels on content in Power BI by artifact ID.
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Office 365
            /// Global Administrator or Power BI Service Administrator) to call this API.
            /// &lt;br/&gt; To set a sensitivity label using this API, the admin user (or
            /// the delegated user, if provided) must have the label included in their
            /// [label
            /// policy](https://docs.microsoft.com/en-us/microsoft-365/compliance/create-sensitivity-labels?view=o365-worldwide).
            /// &lt;br/&gt; The admin user (and the delegated user, if provided) must have
            /// sufficient [usage rights](https://go.microsoft.com/fwlink/?linkid=2157685)
            /// to set labels.&lt;br/&gt;This API allows a maximum of 25 requests per hour.
            /// Each request can update up to 2000 artifacts.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.ReadWrite.All
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='informationProtectionChangeLabelDetails'>
            /// Set label details.
            /// </param>
            public static InformationProtectionChangeLabelResponse SetLabelsAsAdmin(this IInformationProtection operations, InformationProtectionChangeLabelDetails informationProtectionChangeLabelDetails)
            {
                return operations.SetLabelsAsAdminAsync(informationProtectionChangeLabelDetails).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Set sensitivity labels on content in Power BI by artifact ID.
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Office 365
            /// Global Administrator or Power BI Service Administrator) to call this API.
            /// &lt;br/&gt; To set a sensitivity label using this API, the admin user (or
            /// the delegated user, if provided) must have the label included in their
            /// [label
            /// policy](https://docs.microsoft.com/en-us/microsoft-365/compliance/create-sensitivity-labels?view=o365-worldwide).
            /// &lt;br/&gt; The admin user (and the delegated user, if provided) must have
            /// sufficient [usage rights](https://go.microsoft.com/fwlink/?linkid=2157685)
            /// to set labels.&lt;br/&gt;This API allows a maximum of 25 requests per hour.
            /// Each request can update up to 2000 artifacts.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.ReadWrite.All
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='informationProtectionChangeLabelDetails'>
            /// Set label details.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InformationProtectionChangeLabelResponse> SetLabelsAsAdminAsync(this IInformationProtection operations, InformationProtectionChangeLabelDetails informationProtectionChangeLabelDetails, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SetLabelsAsAdminWithHttpMessagesAsync(informationProtectionChangeLabelDetails, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
