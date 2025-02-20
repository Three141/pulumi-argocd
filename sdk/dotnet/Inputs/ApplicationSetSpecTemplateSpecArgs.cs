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

    public sealed class ApplicationSetSpecTemplateSpecArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Reference to the Kubernetes server and namespace in which the application will be deployed.
        /// </summary>
        [Input("destination", required: true)]
        public Input<Inputs.ApplicationSetSpecTemplateSpecDestinationArgs> Destination { get; set; } = null!;

        [Input("ignoreDifferences")]
        private InputList<Inputs.ApplicationSetSpecTemplateSpecIgnoreDifferenceArgs>? _ignoreDifferences;

        /// <summary>
        /// Resources and their fields which should be ignored during comparison. More info: https://argo-cd.readthedocs.io/en/stable/user-guide/diffing/#application-level-configuration.
        /// </summary>
        public InputList<Inputs.ApplicationSetSpecTemplateSpecIgnoreDifferenceArgs> IgnoreDifferences
        {
            get => _ignoreDifferences ?? (_ignoreDifferences = new InputList<Inputs.ApplicationSetSpecTemplateSpecIgnoreDifferenceArgs>());
            set => _ignoreDifferences = value;
        }

        [Input("infos")]
        private InputList<Inputs.ApplicationSetSpecTemplateSpecInfoArgs>? _infos;

        /// <summary>
        /// List of information (URLs, email addresses, and plain text) that relates to the application.
        /// </summary>
        public InputList<Inputs.ApplicationSetSpecTemplateSpecInfoArgs> Infos
        {
            get => _infos ?? (_infos = new InputList<Inputs.ApplicationSetSpecTemplateSpecInfoArgs>());
            set => _infos = value;
        }

        /// <summary>
        /// The project the application belongs to. Defaults to `default`.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// Limits the number of items kept in the application's revision history, which is used for informational purposes as well as for rollbacks to previous versions. This should only be changed in exceptional circumstances. Setting to zero will store no history. This will reduce storage used. Increasing will increase the space used to store the history, so we do not recommend increasing it. Default is 10.
        /// </summary>
        [Input("revisionHistoryLimit")]
        public Input<int>? RevisionHistoryLimit { get; set; }

        [Input("sources", required: true)]
        private InputList<Inputs.ApplicationSetSpecTemplateSpecSourceArgs>? _sources;

        /// <summary>
        /// Location of the application's manifests or chart.
        /// </summary>
        public InputList<Inputs.ApplicationSetSpecTemplateSpecSourceArgs> Sources
        {
            get => _sources ?? (_sources = new InputList<Inputs.ApplicationSetSpecTemplateSpecSourceArgs>());
            set => _sources = value;
        }

        /// <summary>
        /// Controls when and how a sync will be performed.
        /// </summary>
        [Input("syncPolicy")]
        public Input<Inputs.ApplicationSetSpecTemplateSpecSyncPolicyArgs>? SyncPolicy { get; set; }

        public ApplicationSetSpecTemplateSpecArgs()
        {
        }
        public static new ApplicationSetSpecTemplateSpecArgs Empty => new ApplicationSetSpecTemplateSpecArgs();
    }
}
