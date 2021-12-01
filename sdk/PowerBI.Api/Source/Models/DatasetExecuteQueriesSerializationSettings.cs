// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The serialization settings for the results of a dataset query
    /// </summary>
    public partial class DatasetExecuteQueriesSerializationSettings
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DatasetExecuteQueriesSerializationSettings class.
        /// </summary>
        public DatasetExecuteQueriesSerializationSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DatasetExecuteQueriesSerializationSettings class.
        /// </summary>
        /// <param name="includeNulls">Whether null (blank) values should be
        /// included in the result set. If unspecified, the default value is
        /// `false`.</param>
        public DatasetExecuteQueriesSerializationSettings(bool? includeNulls = default(bool?))
        {
            IncludeNulls = includeNulls;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether null (blank) values should be included in the
        /// result set. If unspecified, the default value is `false`.
        /// </summary>
        [JsonProperty(PropertyName = "includeNulls")]
        public bool? IncludeNulls { get; set; }

    }
}
