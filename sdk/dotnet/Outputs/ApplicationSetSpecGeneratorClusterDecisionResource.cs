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
    public sealed class ApplicationSetSpecGeneratorClusterDecisionResource
    {
        /// <summary>
        /// ConfigMap with the duck type definitions needed to retrieve the data this includes apiVersion(group/version), kind, matchKey and validation settings.
        /// </summary>
        public readonly string ConfigMapRef;
        /// <summary>
        /// Label selector used to find the resource defined in the `config_map_ref`. Alternative to `name`.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorClusterDecisionResourceLabelSelector? LabelSelector;
        /// <summary>
        /// Resource name of the kind, group and version, defined in the `config_map_ref`.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// How often to check for changes (in seconds). Default: 3min.
        /// </summary>
        public readonly string? RequeueAfterSeconds;
        /// <summary>
        /// Generator template. Used to override the values of the spec-level template.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorClusterDecisionResourceTemplate? Template;
        /// <summary>
        /// Arbitrary string key-value pairs which are passed directly as parameters to the template.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Values;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorClusterDecisionResource(
            string configMapRef,

            Outputs.ApplicationSetSpecGeneratorClusterDecisionResourceLabelSelector? labelSelector,

            string? name,

            string? requeueAfterSeconds,

            Outputs.ApplicationSetSpecGeneratorClusterDecisionResourceTemplate? template,

            ImmutableDictionary<string, string>? values)
        {
            ConfigMapRef = configMapRef;
            LabelSelector = labelSelector;
            Name = name;
            RequeueAfterSeconds = requeueAfterSeconds;
            Template = template;
            Values = values;
        }
    }
}
