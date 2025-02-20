// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Three14.Argocd.Outputs
{

    [OutputType]
    public sealed class ApplicationSetSpecGeneratorMergeGeneratorMergeGeneratorPullRequest
    {
        /// <summary>
        /// Fetch pull requests from a repo hosted on a Bitbucket Server.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorMergeGeneratorPullRequestBitbucketServer? BitbucketServer;
        /// <summary>
        /// Filters allow selecting which pull requests to generate for.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationSetSpecGeneratorMergeGeneratorMergeGeneratorPullRequestFilter> Filters;
        /// <summary>
        /// Specify the repository from which to fetch the Gitea Pull requests.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorMergeGeneratorPullRequestGitea? Gitea;
        /// <summary>
        /// Specify the repository from which to fetch the GitHub Pull requests.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorMergeGeneratorPullRequestGithub? Github;
        /// <summary>
        /// Specify the project from which to fetch the GitLab merge requests.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorMergeGeneratorPullRequestGitlab? Gitlab;
        /// <summary>
        /// How often to check for changes (in seconds). Default: 30min.
        /// </summary>
        public readonly string? RequeueAfterSeconds;
        /// <summary>
        /// Generator template. Used to override the values of the spec-level template.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorMergeGeneratorPullRequestTemplate? Template;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorMergeGeneratorMergeGeneratorPullRequest(
            Outputs.ApplicationSetSpecGeneratorMergeGeneratorMergeGeneratorPullRequestBitbucketServer? bitbucketServer,

            ImmutableArray<Outputs.ApplicationSetSpecGeneratorMergeGeneratorMergeGeneratorPullRequestFilter> filters,

            Outputs.ApplicationSetSpecGeneratorMergeGeneratorMergeGeneratorPullRequestGitea? gitea,

            Outputs.ApplicationSetSpecGeneratorMergeGeneratorMergeGeneratorPullRequestGithub? github,

            Outputs.ApplicationSetSpecGeneratorMergeGeneratorMergeGeneratorPullRequestGitlab? gitlab,

            string? requeueAfterSeconds,

            Outputs.ApplicationSetSpecGeneratorMergeGeneratorMergeGeneratorPullRequestTemplate? template)
        {
            BitbucketServer = bitbucketServer;
            Filters = filters;
            Gitea = gitea;
            Github = github;
            Gitlab = gitlab;
            RequeueAfterSeconds = requeueAfterSeconds;
            Template = template;
        }
    }
}
