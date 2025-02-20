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
    public sealed class ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorPullRequestTemplate
    {
        /// <summary>
        /// Kubernetes object metadata for templated Application.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorPullRequestTemplateMetadata? Metadata;
        /// <summary>
        /// The application specification.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorPullRequestTemplateSpec? Spec;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorPullRequestTemplate(
            Outputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorPullRequestTemplateMetadata? metadata,

            Outputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorPullRequestTemplateSpec? spec)
        {
            Metadata = metadata;
            Spec = spec;
        }
    }
}
