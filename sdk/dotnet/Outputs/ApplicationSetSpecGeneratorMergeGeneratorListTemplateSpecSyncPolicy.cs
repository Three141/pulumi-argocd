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
    public sealed class ApplicationSetSpecGeneratorMergeGeneratorListTemplateSpecSyncPolicy
    {
        /// <summary>
        /// Whether to automatically keep an application synced to the target revision.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorListTemplateSpecSyncPolicyAutomated? Automated;
        /// <summary>
        /// Controls metadata in the given namespace (if `CreateNamespace=true`).
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorListTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata;
        /// <summary>
        /// Controls failed sync retry behavior.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorListTemplateSpecSyncPolicyRetry? Retry;
        /// <summary>
        /// List of sync options. More info: https://argo-cd.readthedocs.io/en/stable/user-guide/sync-options/.
        /// </summary>
        public readonly ImmutableArray<string> SyncOptions;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorMergeGeneratorListTemplateSpecSyncPolicy(
            Outputs.ApplicationSetSpecGeneratorMergeGeneratorListTemplateSpecSyncPolicyAutomated? automated,

            Outputs.ApplicationSetSpecGeneratorMergeGeneratorListTemplateSpecSyncPolicyManagedNamespaceMetadata? managedNamespaceMetadata,

            Outputs.ApplicationSetSpecGeneratorMergeGeneratorListTemplateSpecSyncPolicyRetry? retry,

            ImmutableArray<string> syncOptions)
        {
            Automated = automated;
            ManagedNamespaceMetadata = managedNamespaceMetadata;
            Retry = retry;
            SyncOptions = syncOptions;
        }
    }
}
