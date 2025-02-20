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
    public sealed class ProjectSpecDestination
    {
        /// <summary>
        /// Name of the destination cluster which can be used instead of server.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Target namespace for applications' resources.
        /// </summary>
        public readonly string Namespace;
        /// <summary>
        /// URL of the target cluster and must be set to the Kubernetes control plane API.
        /// </summary>
        public readonly string? Server;

        [OutputConstructor]
        private ProjectSpecDestination(
            string? name,

            string @namespace,

            string? server)
        {
            Name = name;
            Namespace = @namespace;
            Server = server;
        }
    }
}
