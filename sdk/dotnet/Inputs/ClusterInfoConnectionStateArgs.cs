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

    public sealed class ClusterInfoConnectionStateArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Human readable information about the connection status.
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        /// <summary>
        /// Current status indicator for the connection.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        public ClusterInfoConnectionStateArgs()
        {
        }
        public static new ClusterInfoConnectionStateArgs Empty => new ClusterInfoConnectionStateArgs();
    }
}
