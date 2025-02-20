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
    public sealed class ApplicationSetSpecGeneratorMatrixGeneratorScmProvider
    {
        /// <summary>
        /// Uses the Azure DevOps API to look up eligible repositories based on a team project within an Azure DevOps organization.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixGeneratorScmProviderAzureDevops? AzureDevops;
        /// <summary>
        /// Uses the Bitbucket API V2 to scan a workspace in bitbucket.org.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixGeneratorScmProviderBitbucketCloud? BitbucketCloud;
        /// <summary>
        /// Use the Bitbucket Server API (1.0) to scan repos in a project.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixGeneratorScmProviderBitbucketServer? BitbucketServer;
        /// <summary>
        /// Which protocol to use for the SCM URL. Default is provider-specific but ssh if possible. Not all providers necessarily support all protocols.
        /// </summary>
        public readonly string? CloneProtocol;
        /// <summary>
        /// Filters for which repos should be considered.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationSetSpecGeneratorMatrixGeneratorScmProviderFilter> Filters;
        /// <summary>
        /// Gitea mode uses the Gitea API to scan organizations in your instance.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixGeneratorScmProviderGitea? Gitea;
        /// <summary>
        /// Uses the GitHub API to scan an organization in either github.com or GitHub Enterprise.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixGeneratorScmProviderGithub? Github;
        /// <summary>
        /// Uses the GitLab API to scan and organization in either gitlab.com or self-hosted GitLab.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixGeneratorScmProviderGitlab? Gitlab;
        /// <summary>
        /// How often to check for changes (in seconds). Default: 3min.
        /// </summary>
        public readonly string? RequeueAfterSeconds;
        /// <summary>
        /// Generator template. Used to override the values of the spec-level template.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixGeneratorScmProviderTemplate? Template;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorMatrixGeneratorScmProvider(
            Outputs.ApplicationSetSpecGeneratorMatrixGeneratorScmProviderAzureDevops? azureDevops,

            Outputs.ApplicationSetSpecGeneratorMatrixGeneratorScmProviderBitbucketCloud? bitbucketCloud,

            Outputs.ApplicationSetSpecGeneratorMatrixGeneratorScmProviderBitbucketServer? bitbucketServer,

            string? cloneProtocol,

            ImmutableArray<Outputs.ApplicationSetSpecGeneratorMatrixGeneratorScmProviderFilter> filters,

            Outputs.ApplicationSetSpecGeneratorMatrixGeneratorScmProviderGitea? gitea,

            Outputs.ApplicationSetSpecGeneratorMatrixGeneratorScmProviderGithub? github,

            Outputs.ApplicationSetSpecGeneratorMatrixGeneratorScmProviderGitlab? gitlab,

            string? requeueAfterSeconds,

            Outputs.ApplicationSetSpecGeneratorMatrixGeneratorScmProviderTemplate? template)
        {
            AzureDevops = azureDevops;
            BitbucketCloud = bitbucketCloud;
            BitbucketServer = bitbucketServer;
            CloneProtocol = cloneProtocol;
            Filters = filters;
            Gitea = gitea;
            Github = github;
            Gitlab = gitlab;
            RequeueAfterSeconds = requeueAfterSeconds;
            Template = template;
        }
    }
}
