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
    public sealed class ApplicationSetSpecGeneratorMatrixTemplate
    {
        /// <summary>
        /// Kubernetes object metadata for templated Application.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixTemplateMetadata? Metadata;
        /// <summary>
        /// The application specification.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixTemplateSpec? Spec;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorMatrixTemplate(
            Outputs.ApplicationSetSpecGeneratorMatrixTemplateMetadata? metadata,

            Outputs.ApplicationSetSpecGeneratorMatrixTemplateSpec? spec)
        {
            Metadata = metadata;
            Spec = spec;
        }
    }
}
