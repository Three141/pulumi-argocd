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

    public sealed class ApplicationSetSpecGeneratorMatrixGeneratorListArgs : global::Pulumi.ResourceArgs
    {
        [Input("elements", required: true)]
        private InputList<ImmutableDictionary<string, string>>? _elements;

        /// <summary>
        /// List of key/value pairs to pass as parameters into the template
        /// </summary>
        public InputList<ImmutableDictionary<string, string>> Elements
        {
            get => _elements ?? (_elements = new InputList<ImmutableDictionary<string, string>>());
            set => _elements = value;
        }

        /// <summary>
        /// Generator template. Used to override the values of the spec-level template.
        /// </summary>
        [Input("template")]
        public Input<Inputs.ApplicationSetSpecGeneratorMatrixGeneratorListTemplateArgs>? Template { get; set; }

        public ApplicationSetSpecGeneratorMatrixGeneratorListArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorMatrixGeneratorListArgs Empty => new ApplicationSetSpecGeneratorMatrixGeneratorListArgs();
    }
}
