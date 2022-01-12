// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A request to execute queries against a dataset
    /// </summary>
    public partial class DatasetExecuteQueriesRequest
    {
        /// <summary>
        /// Initializes a new instance of the DatasetExecuteQueriesRequest
        /// class.
        /// </summary>
        public DatasetExecuteQueriesRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatasetExecuteQueriesRequest
        /// class.
        /// </summary>
        /// <param name="queries">The list of dataset queries to
        /// execute</param>
        /// <param name="serializerSettings">The serialization settings for the
        /// result set</param>
        public DatasetExecuteQueriesRequest(IList<DatasetExecuteQueriesQuery> queries, DatasetExecuteQueriesSerializationSettings serializerSettings = default(DatasetExecuteQueriesSerializationSettings))
        {
            Queries = queries;
            SerializerSettings = serializerSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of dataset queries to execute
        /// </summary>
        [JsonProperty(PropertyName = "queries")]
        public IList<DatasetExecuteQueriesQuery> Queries { get; set; }

        /// <summary>
        /// Gets or sets the serialization settings for the result set
        /// </summary>
        [JsonProperty(PropertyName = "serializerSettings")]
        public DatasetExecuteQueriesSerializationSettings SerializerSettings { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Queries == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Queries");
            }
            if (Queries != null)
            {
                foreach (var element in Queries)
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