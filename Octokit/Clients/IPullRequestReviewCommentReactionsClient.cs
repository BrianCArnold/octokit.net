﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Octokit
{
    /// <summary>
    /// A client for GitHub's Reactions API.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developer.github.com/v3/reactions/">Reactions API documentation</a> for more information.
    /// </remarks>
    public interface IPullRequestReviewCommentReactionsClient
    {
        /// <summary>
        /// Get all reactions for a specified Pull Request Review Comment.
        /// </summary>
        /// <remarks>https://developer.github.com/v3/reactions/#list-reactions-for-a-pull-request-review-comment</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="commentId">The comment id</param>
        Task<IReadOnlyList<Reaction>> GetAll(string owner, string name, long commentId);

        /// <summary>
        /// Get all reactions for a specified Pull Request Review Comment.
        /// </summary>
        /// <remarks>https://developer.github.com/v3/reactions/#list-reactions-for-a-pull-request-review-comment</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="commentId">The comment id</param>
        /// <param name="options">Options for changing the API response</param>
        Task<IReadOnlyList<Reaction>> GetAll(string owner, string name, long commentId, ApiOptions options);

        /// <summary>
        /// Get all reactions for a specified Pull Request Review Comment.
        /// </summary>
        /// <remarks>https://developer.github.com/v3/reactions/#list-reactions-for-a-pull-request-review-comment</remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="commentId">The comment id</param>
        Task<IReadOnlyList<Reaction>> GetAll(long repositoryId, long commentId);

        /// <summary>
        /// Get all reactions for a specified Pull Request Review Comment.
        /// </summary>
        /// <remarks>https://developer.github.com/v3/reactions/#list-reactions-for-a-pull-request-review-comment</remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="commentId">The comment id</param>
        /// <param name="options">Options for changing the API response</param>
        Task<IReadOnlyList<Reaction>> GetAll(long repositoryId, long commentId, ApiOptions options);

        /// <summary>
        /// Creates a reaction for a specified Pull Request Review Comment.
        /// </summary>
        /// <remarks>https://developer.github.com/v3/reactions/#create-reaction-for-a-pull-request-review-comment</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="commentId">The comment id</param>
        /// <param name="reaction">The reaction to create</param>
        Task<Reaction> Create(string owner, string name, long commentId, NewReaction reaction);

        /// <summary>
        /// Creates a reaction for a specified Pull Request Review Comment.
        /// </summary>
        /// <remarks>https://developer.github.com/v3/reactions/#create-reaction-for-a-pull-request-review-comment</remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="commentId">The comment id</param>
        /// <param name="reaction">The reaction to create</param>
        Task<Reaction> Create(long repositoryId, long commentId, NewReaction reaction);

        /// <summary>
        /// Deletes a reaction for a specified Pull Request comment
        /// </summary>
        /// <remarks>https://docs.github.com/rest/reactions#delete-a-pull-request-comment-reaction</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="commentId">The issue id</param>
        /// <param name="reactionId">The reaction id</param>
        /// <returns></returns>
        Task Delete(string owner, string name, long commentId, long reactionId);

        /// <summary>
        /// Deletes a reaction for a specified Pull Request comment
        /// </summary>
        /// <remarks>https://docs.github.com/rest/reactions#delete-a-pull-request-comment-reaction</remarks>
        /// <param name="repositoryId">The owner of the repository</param>
        /// <param name="commentId">The issue id</param>
        /// <param name="reactionId">The reaction id</param>
        /// <returns></returns>
        Task Delete(long repositoryId, long commentId, long reactionId);
    }
}
