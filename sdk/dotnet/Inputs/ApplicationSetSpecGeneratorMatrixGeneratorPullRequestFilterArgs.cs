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

    public sealed class ApplicationSetSpecGeneratorMatrixGeneratorPullRequestFilterArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// A regex which must match the branch name.
        /// </summary>
        [Input("branchMatch")]
        public Input<string>? BranchMatch { get; set; }

        public ApplicationSetSpecGeneratorMatrixGeneratorPullRequestFilterArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorMatrixGeneratorPullRequestFilterArgs Empty => new ApplicationSetSpecGeneratorMatrixGeneratorPullRequestFilterArgs();
    }
}
