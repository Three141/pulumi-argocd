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
    public sealed class ApplicationSetSpecGeneratorMatrixGeneratorPullRequest
    {
        /// <summary>
        /// Fetch pull requests from a repo hosted on a Bitbucket Server.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixGeneratorPullRequestBitbucketServer? BitbucketServer;
        /// <summary>
        /// Filters allow selecting which pull requests to generate for.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationSetSpecGeneratorMatrixGeneratorPullRequestFilter> Filters;
        /// <summary>
        /// Specify the repository from which to fetch the Gitea Pull requests.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixGeneratorPullRequestGitea? Gitea;
        /// <summary>
        /// Specify the repository from which to fetch the GitHub Pull requests.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixGeneratorPullRequestGithub? Github;
        /// <summary>
        /// Specify the project from which to fetch the GitLab merge requests.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixGeneratorPullRequestGitlab? Gitlab;
        /// <summary>
        /// How often to check for changes (in seconds). Default: 30min.
        /// </summary>
        public readonly string? RequeueAfterSeconds;
        /// <summary>
        /// Generator template. Used to override the values of the spec-level template.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixGeneratorPullRequestTemplate? Template;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorMatrixGeneratorPullRequest(
            Outputs.ApplicationSetSpecGeneratorMatrixGeneratorPullRequestBitbucketServer? bitbucketServer,

            ImmutableArray<Outputs.ApplicationSetSpecGeneratorMatrixGeneratorPullRequestFilter> filters,

            Outputs.ApplicationSetSpecGeneratorMatrixGeneratorPullRequestGitea? gitea,

            Outputs.ApplicationSetSpecGeneratorMatrixGeneratorPullRequestGithub? github,

            Outputs.ApplicationSetSpecGeneratorMatrixGeneratorPullRequestGitlab? gitlab,

            string? requeueAfterSeconds,

            Outputs.ApplicationSetSpecGeneratorMatrixGeneratorPullRequestTemplate? template)
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
