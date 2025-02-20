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
    public sealed class ApplicationSetSpecGeneratorMatrixGeneratorPullRequestFilter
    {
        /// <summary>
        /// A regex which must match the branch name.
        /// </summary>
        public readonly string? BranchMatch;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorMatrixGeneratorPullRequestFilter(string? branchMatch)
        {
            BranchMatch = branchMatch;
        }
    }
}
