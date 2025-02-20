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
    public sealed class ApplicationSetSpecStrategy
    {
        /// <summary>
        /// Update strategy allowing you to group Applications by labels present on the generated Application resources. When the ApplicationSet changes, the changes will be applied to each group of Application resources sequentially.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationSetSpecStrategyRollingSync> RollingSyncs;
        /// <summary>
        /// Type of progressive sync.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ApplicationSetSpecStrategy(
            ImmutableArray<Outputs.ApplicationSetSpecStrategyRollingSync> rollingSyncs,

            string type)
        {
            RollingSyncs = rollingSyncs;
            Type = type;
        }
    }
}
