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
    public sealed class ApplicationSetSpecGeneratorMatrixGeneratorClusterDecisionResourceTemplateSpecSourceDirectoryJsonnet
    {
        /// <summary>
        /// List of Jsonnet External Variables.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationSetSpecGeneratorMatrixGeneratorClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetExtVar> ExtVars;
        /// <summary>
        /// Additional library search dirs.
        /// </summary>
        public readonly ImmutableArray<string> Libs;
        /// <summary>
        /// List of Jsonnet Top-level Arguments
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationSetSpecGeneratorMatrixGeneratorClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetTla> Tlas;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorMatrixGeneratorClusterDecisionResourceTemplateSpecSourceDirectoryJsonnet(
            ImmutableArray<Outputs.ApplicationSetSpecGeneratorMatrixGeneratorClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetExtVar> extVars,

            ImmutableArray<string> libs,

            ImmutableArray<Outputs.ApplicationSetSpecGeneratorMatrixGeneratorClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetTla> tlas)
        {
            ExtVars = extVars;
            Libs = libs;
            Tlas = tlas;
        }
    }
}
