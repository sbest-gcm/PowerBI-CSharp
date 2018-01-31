// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Power BI user Access Right entry for datasource
    /// </summary>
    public partial class UserAccessRight
    {
        /// <summary>
        /// Initializes a new instance of the UserAccessRight class.
        /// </summary>
        public UserAccessRight()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserAccessRight class.
        /// </summary>
        /// <param name="datasourceAccessRight">Access rights user has for
        /// datasource. Possible values include: 'None', 'Read', 'Write',
        /// 'Admin', 'ReadWrite'</param>
        /// <param name="emailAddress">Email address of the user.</param>
        public UserAccessRight(string datasourceAccessRight = default(string), string emailAddress = default(string))
        {
            DatasourceAccessRight = datasourceAccessRight;
            EmailAddress = emailAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets access rights user has for datasource. Possible values
        /// include: 'None', 'Read', 'Write', 'Admin', 'ReadWrite'
        /// </summary>
        [JsonProperty(PropertyName = "datasourceAccessRight")]
        public string DatasourceAccessRight { get; set; }

        /// <summary>
        /// Gets or sets email address of the user.
        /// </summary>
        [JsonProperty(PropertyName = "emailAddress")]
        public string EmailAddress { get; set; }

    }
}