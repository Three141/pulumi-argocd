// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Three14.Argocd.Inputs
{

    public sealed class ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorPullRequestTemplateGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Kubernetes object metadata for templated Application.
        /// </summary>
        [Input("metadata")]
        public Input<Inputs.ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorPullRequestTemplateMetadataGetArgs>? Metadata { get; set; }

        /// <summary>
        /// The application specification.
        /// </summary>
        [Input("spec")]
        public Input<Inputs.ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorPullRequestTemplateSpecGetArgs>? Spec { get; set; }

        public ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorPullRequestTemplateGetArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorPullRequestTemplateGetArgs Empty => new ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorPullRequestTemplateGetArgs();
    }
}
