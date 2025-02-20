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

    public sealed class ApplicationSetSpecGeneratorClusterDecisionResourceTemplateSpecSourcePluginGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("envs")]
        private InputList<Inputs.ApplicationSetSpecGeneratorClusterDecisionResourceTemplateSpecSourcePluginEnvGetArgs>? _envs;

        /// <summary>
        /// Environment variables passed to the plugin.
        /// </summary>
        public InputList<Inputs.ApplicationSetSpecGeneratorClusterDecisionResourceTemplateSpecSourcePluginEnvGetArgs> Envs
        {
            get => _envs ?? (_envs = new InputList<Inputs.ApplicationSetSpecGeneratorClusterDecisionResourceTemplateSpecSourcePluginEnvGetArgs>());
            set => _envs = value;
        }

        /// <summary>
        /// Name of the plugin. Only set the plugin name if the plugin is defined in `argocd-cm`. If the plugin is defined as a sidecar, omit the name. The plugin will be automatically matched with the Application according to the plugin's discovery rules.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public ApplicationSetSpecGeneratorClusterDecisionResourceTemplateSpecSourcePluginGetArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorClusterDecisionResourceTemplateSpecSourcePluginGetArgs Empty => new ApplicationSetSpecGeneratorClusterDecisionResourceTemplateSpecSourcePluginGetArgs();
    }
}
