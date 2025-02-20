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
    public sealed class ClusterInfo
    {
        /// <summary>
        /// Number of applications managed by Argo CD on the cluster.
        /// </summary>
        public readonly string? ApplicationsCount;
        /// <summary>
        /// Information about the connection to the cluster.
        /// </summary>
        public readonly ImmutableArray<Outputs.ClusterInfoConnectionState> ConnectionStates;
        /// <summary>
        /// Kubernetes version of the cluster.
        /// </summary>
        public readonly string? ServerVersion;

        [OutputConstructor]
        private ClusterInfo(
            string? applicationsCount,

            ImmutableArray<Outputs.ClusterInfoConnectionState> connectionStates,

            string? serverVersion)
        {
            ApplicationsCount = applicationsCount;
            ConnectionStates = connectionStates;
            ServerVersion = serverVersion;
        }
    }
}
