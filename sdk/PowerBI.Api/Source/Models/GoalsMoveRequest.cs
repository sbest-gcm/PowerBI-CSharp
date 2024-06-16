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
    /// A request object to be used with the [Move
    /// Goals](/rest/api/power-bi/scorecards_(preview)/move-goals) API request
    /// </summary>
    public partial class GoalsMoveRequest
    {
        /// <summary>
        /// Initializes a new instance of the GoalsMoveRequest class.
        /// </summary>
        public GoalsMoveRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GoalsMoveRequest class.
        /// </summary>
        /// <param name="goalToMove">The rank validation information for the
        /// goal to be moved. The caller provides validation information to
        /// confirm that they know the existing position of a goal within the
        /// hierarchy of goals.</param>
        /// <param name="newParent">Optional. The rank validation information
        /// for the new parent of the goal to be moved. The caller provides
        /// validation information to confirm that they know the existing
        /// position of a goal within the hierarchy of goals.</param>
        /// <param name="newPrevious">Optional. The rank validation information
        /// for the new previous-sibling of the goal to be moved. The caller
        /// provides validation information to confirm that they know the
        /// existing position of a goal within the hierarchy of goals.</param>
        /// <param name="newNext">Optional. The rank validation information for
        /// the new next-sibling of the goal to be moved. The caller provides
        /// validation information to confirm that they know the existing
        /// position of a goal within the hierarchy of goals.</param>
        public GoalsMoveRequest(GoalRankValidationInfo goalToMove, GoalRankValidationInfo newParent = default(GoalRankValidationInfo), GoalRankValidationInfo newPrevious = default(GoalRankValidationInfo), GoalRankValidationInfo newNext = default(GoalRankValidationInfo))
        {
            GoalToMove = goalToMove;
            NewParent = newParent;
            NewPrevious = newPrevious;
            NewNext = newNext;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the rank validation information for the goal to be
        /// moved. The caller provides validation information to confirm that
        /// they know the existing position of a goal within the hierarchy of
        /// goals.
        /// </summary>
        [JsonProperty(PropertyName = "goalToMove")]
        public GoalRankValidationInfo GoalToMove { get; set; }

        /// <summary>
        /// Gets or sets optional. The rank validation information for the new
        /// parent of the goal to be moved. The caller provides validation
        /// information to confirm that they know the existing position of a
        /// goal within the hierarchy of goals.
        /// </summary>
        [JsonProperty(PropertyName = "newParent")]
        public GoalRankValidationInfo NewParent { get; set; }

        /// <summary>
        /// Gets or sets optional. The rank validation information for the new
        /// previous-sibling of the goal to be moved. The caller provides
        /// validation information to confirm that they know the existing
        /// position of a goal within the hierarchy of goals.
        /// </summary>
        [JsonProperty(PropertyName = "newPrevious")]
        public GoalRankValidationInfo NewPrevious { get; set; }

        /// <summary>
        /// Gets or sets optional. The rank validation information for the new
        /// next-sibling of the goal to be moved. The caller provides
        /// validation information to confirm that they know the existing
        /// position of a goal within the hierarchy of goals.
        /// </summary>
        [JsonProperty(PropertyName = "newNext")]
        public GoalRankValidationInfo NewNext { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (GoalToMove == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "GoalToMove");
            }
        }
    }
}