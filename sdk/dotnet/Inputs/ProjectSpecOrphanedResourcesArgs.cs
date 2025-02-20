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

    public sealed class ProjectSpecOrphanedResourcesArgs : global::Pulumi.ResourceArgs
    {
        [Input("ignores")]
        private InputList<Inputs.ProjectSpecOrphanedResourcesIgnoreArgs>? _ignores;
        public InputList<Inputs.ProjectSpecOrphanedResourcesIgnoreArgs> Ignores
        {
            get => _ignores ?? (_ignores = new InputList<Inputs.ProjectSpecOrphanedResourcesIgnoreArgs>());
            set => _ignores = value;
        }

        /// <summary>
        /// Whether a warning condition should be created for apps which have orphaned resources.
        /// </summary>
        [Input("warn")]
        public Input<bool>? Warn { get; set; }

        public ProjectSpecOrphanedResourcesArgs()
        {
        }
        public static new ProjectSpecOrphanedResourcesArgs Empty => new ProjectSpecOrphanedResourcesArgs();
    }
}
