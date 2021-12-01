// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Power BI email subscription user
    /// </summary>
    public partial class SubscriptionUser
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionUser class.
        /// </summary>
        public SubscriptionUser()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptionUser class.
        /// </summary>
        /// <param name="emailAddress">Email address of the user</param>
        /// <param name="identifier">Identifier of the principal</param>
        /// <param name="principalType">Possible values include: 'None',
        /// 'User', 'Group', 'App'</param>
        /// <param name="displayName">Display name of the principal</param>
        /// <param name="graphId">Identifier of the principal in Microsoft
        /// Graph. Only available for admin APIs.</param>
        public SubscriptionUser(string emailAddress, string identifier, PrincipalType principalType, string displayName = default(string), string graphId = default(string))
        {
            EmailAddress = emailAddress;
            DisplayName = displayName;
            Identifier = identifier;
            GraphId = graphId;
            PrincipalType = principalType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets email address of the user
        /// </summary>
        [JsonProperty(PropertyName = "emailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets display name of the principal
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets identifier of the principal
        /// </summary>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets identifier of the principal in Microsoft Graph. Only
        /// available for admin APIs.
        /// </summary>
        [JsonProperty(PropertyName = "graphId")]
        public string GraphId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'None', 'User', 'Group',
        /// 'App'
        /// </summary>
        [JsonProperty(PropertyName = "principalType")]
        public PrincipalType PrincipalType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EmailAddress == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EmailAddress");
            }
            if (Identifier == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Identifier");
            }
        }
    }
}
