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
    /// Extension methods for GoalsOperations.
    /// </summary>
    public static partial class GoalsOperationsExtensions
    {
            /// <summary>
            /// Returns a list of goals from a scorecard.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dataset.Read.All or Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline, receives a comma-separated list of data
            /// types. Supported: goalValues and aggregations.
            /// </param>
            /// <param name='select'>
            /// Allows the clients to select specific properties from the server.
            /// </param>
            public static Goals Get(this IGoalsOperations operations, string expand = default(string), string select = default(string))
            {
                return operations.GetAsync(expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of goals from a scorecard.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dataset.Read.All or Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline, receives a comma-separated list of data
            /// types. Supported: goalValues and aggregations.
            /// </param>
            /// <param name='select'>
            /// Allows the clients to select specific properties from the server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Goals> GetAsync(this IGoalsOperations operations, string expand = default(string), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Adds a new goal to a scorecard.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='goal'>
            /// The properties of the new goal.
            /// </param>
            public static Goal Post(this IGoalsOperations operations, GoalCreateRequest goal)
            {
                return operations.PostAsync(goal).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a new goal to a scorecard.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='goal'>
            /// The properties of the new goal.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Goal> PostAsync(this IGoalsOperations operations, GoalCreateRequest goal, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(goal, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a goal by ID from a scorecard.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dataset.Read.All or Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// description
            /// </param>
            public static Goal GetById(this IGoalsOperations operations, string expand = default(string))
            {
                return operations.GetByIdAsync(expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a goal by ID from a scorecard.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dataset.Read.All or Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// description
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Goal> GetByIdAsync(this IGoalsOperations operations, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a goal by ID.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='goal'>
            /// The goal properties to patch.
            /// </param>
            public static Goal PatchById(this IGoalsOperations operations, Goal goal)
            {
                return operations.PatchByIdAsync(goal).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a goal by ID.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='goal'>
            /// The goal properties to patch.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Goal> PatchByIdAsync(this IGoalsOperations operations, Goal goal, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PatchByIdWithHttpMessagesAsync(goal, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a goal from a scorecard by goal ID.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void DeleteById(this IGoalsOperations operations)
            {
                operations.DeleteByIdAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a goal from a scorecard by goal ID.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteByIdAsync(this IGoalsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteByIdWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Reads refresh history of a connected goal.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dataset.Read.All or Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static GoalRefreshHistories GetRefreshHistory(this IGoalsOperations operations)
            {
                return operations.GetRefreshHistoryAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Reads refresh history of a connected goal.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dataset.Read.All or Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GoalRefreshHistories> GetRefreshHistoryAsync(this IGoalsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRefreshHistoryWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Disconnects the current value of a goal.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Goal DeleteGoalCurrentValueConnection(this IGoalsOperations operations)
            {
                return operations.DeleteGoalCurrentValueConnectionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Disconnects the current value of a goal.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Goal> DeleteGoalCurrentValueConnectionAsync(this IGoalsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteGoalCurrentValueConnectionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Disconnects the target value of a goal.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Goal DeleteGoalTargetValueConnection(this IGoalsOperations operations)
            {
                return operations.DeleteGoalTargetValueConnectionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Disconnects the target value of a goal.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Goal> DeleteGoalTargetValueConnectionAsync(this IGoalsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteGoalTargetValueConnectionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Schedules a refresh of the connected value of a goal.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void RefreshGoalCurrentValue(this IGoalsOperations operations)
            {
                operations.RefreshGoalCurrentValueAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Schedules a refresh of the connected value of a goal.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RefreshGoalCurrentValueAsync(this IGoalsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RefreshGoalCurrentValueWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Schedules a refresh of the target value of a goal.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void RefreshGoalTargetValue(this IGoalsOperations operations)
            {
                operations.RefreshGoalTargetValueAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Schedules a refresh of the target value of a goal.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RefreshGoalTargetValueAsync(this IGoalsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RefreshGoalTargetValueWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
