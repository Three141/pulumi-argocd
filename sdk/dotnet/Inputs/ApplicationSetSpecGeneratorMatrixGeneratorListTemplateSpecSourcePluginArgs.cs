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

    public sealed class ApplicationSetSpecGeneratorMatrixGeneratorListTemplateSpecSourcePluginArgs : global::Pulumi.ResourceArgs
    {
        [Input("envs")]
        private InputList<Inputs.ApplicationSetSpecGeneratorMatrixGeneratorListTemplateSpecSourcePluginEnvArgs>? _envs;

        /// <summary>
        /// Environment variables passed to the plugin.
        /// </summary>
        public InputList<Inputs.ApplicationSetSpecGeneratorMatrixGeneratorListTemplateSpecSourcePluginEnvArgs> Envs
        {
            get => _envs ?? (_envs = new InputList<Inputs.ApplicationSetSpecGeneratorMatrixGeneratorListTemplateSpecSourcePluginEnvArgs>());
            set => _envs = value;
        }

        /// <summary>
        /// Name of the plugin. Only set the plugin name if the plugin is defined in `argocd-cm`. If the plugin is defined as a sidecar, omit the name. The plugin will be automatically matched with the Application according to the plugin's discovery rules.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public ApplicationSetSpecGeneratorMatrixGeneratorListTemplateSpecSourcePluginArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorMatrixGeneratorListTemplateSpecSourcePluginArgs Empty => new ApplicationSetSpecGeneratorMatrixGeneratorListTemplateSpecSourcePluginArgs();
    }
}
