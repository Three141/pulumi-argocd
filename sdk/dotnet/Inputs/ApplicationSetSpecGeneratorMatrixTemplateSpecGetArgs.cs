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

    public sealed class ApplicationSetSpecGeneratorMatrixTemplateSpecGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Reference to the Kubernetes server and namespace in which the application will be deployed.
        /// </summary>
        [Input("destination")]
        public Input<Inputs.ApplicationSetSpecGeneratorMatrixTemplateSpecDestinationGetArgs>? Destination { get; set; }

        [Input("ignoreDifferences")]
        private InputList<Inputs.ApplicationSetSpecGeneratorMatrixTemplateSpecIgnoreDifferenceGetArgs>? _ignoreDifferences;

        /// <summary>
        /// Resources and their fields which should be ignored during comparison. More info: https://argo-cd.readthedocs.io/en/stable/user-guide/diffing/#application-level-configuration.
        /// </summary>
        public InputList<Inputs.ApplicationSetSpecGeneratorMatrixTemplateSpecIgnoreDifferenceGetArgs> IgnoreDifferences
        {
            get => _ignoreDifferences ?? (_ignoreDifferences = new InputList<Inputs.ApplicationSetSpecGeneratorMatrixTemplateSpecIgnoreDifferenceGetArgs>());
            set => _ignoreDifferences = value;
        }

        [Input("infos")]
        private InputList<Inputs.ApplicationSetSpecGeneratorMatrixTemplateSpecInfoGetArgs>? _infos;

        /// <summary>
        /// List of information (URLs, email addresses, and plain text) that relates to the application.
        /// </summary>
        public InputList<Inputs.ApplicationSetSpecGeneratorMatrixTemplateSpecInfoGetArgs> Infos
        {
            get => _infos ?? (_infos = new InputList<Inputs.ApplicationSetSpecGeneratorMatrixTemplateSpecInfoGetArgs>());
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

        [Input("sources")]
        private InputList<Inputs.ApplicationSetSpecGeneratorMatrixTemplateSpecSourceGetArgs>? _sources;

        /// <summary>
        /// Location of the application's manifests or chart.
        /// </summary>
        public InputList<Inputs.ApplicationSetSpecGeneratorMatrixTemplateSpecSourceGetArgs> Sources
        {
            get => _sources ?? (_sources = new InputList<Inputs.ApplicationSetSpecGeneratorMatrixTemplateSpecSourceGetArgs>());
            set => _sources = value;
        }

        /// <summary>
        /// Controls when and how a sync will be performed.
        /// </summary>
        [Input("syncPolicy")]
        public Input<Inputs.ApplicationSetSpecGeneratorMatrixTemplateSpecSyncPolicyGetArgs>? SyncPolicy { get; set; }

        public ApplicationSetSpecGeneratorMatrixTemplateSpecGetArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorMatrixTemplateSpecGetArgs Empty => new ApplicationSetSpecGeneratorMatrixTemplateSpecGetArgs();
    }
}
