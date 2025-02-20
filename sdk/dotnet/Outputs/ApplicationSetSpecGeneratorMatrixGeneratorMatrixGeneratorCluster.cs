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
    public sealed class ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorCluster
    {
        /// <summary>
        /// Boolean value defaulting to `true` to indicate that this block has been added thereby allowing all other attributes to be optional.
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// Label selector used to narrow the scope of targeted clusters.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorClusterSelector? Selector;
        /// <summary>
        /// Generator template. Used to override the values of the spec-level template.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorClusterTemplate? Template;
        /// <summary>
        /// Arbitrary string key-value pairs to pass to the template via the values field of the cluster generator.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Values;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorCluster(
            bool enabled,

            Outputs.ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorClusterSelector? selector,

            Outputs.ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorClusterTemplate? template,

            ImmutableDictionary<string, string>? values)
        {
            Enabled = enabled;
            Selector = selector;
            Template = template;
            Values = values;
        }
    }
}
