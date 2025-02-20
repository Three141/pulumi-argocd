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

    public sealed class ApplicationSetSpecGeneratorMatrixGeneratorMatrixGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("generators", required: true)]
        private InputList<Inputs.ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorGetArgs>? _generators;

        /// <summary>
        /// Child generator. Generators are responsible for generating parameters, which are then combined by the parent matrix generator into the template fields of the ApplicationSet resource.
        /// </summary>
        public InputList<Inputs.ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorGetArgs> Generators
        {
            get => _generators ?? (_generators = new InputList<Inputs.ApplicationSetSpecGeneratorMatrixGeneratorMatrixGeneratorGetArgs>());
            set => _generators = value;
        }

        /// <summary>
        /// Generator template. Used to override the values of the spec-level template.
        /// </summary>
        [Input("template")]
        public Input<Inputs.ApplicationSetSpecGeneratorMatrixGeneratorMatrixTemplateGetArgs>? Template { get; set; }

        public ApplicationSetSpecGeneratorMatrixGeneratorMatrixGetArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorMatrixGeneratorMatrixGetArgs Empty => new ApplicationSetSpecGeneratorMatrixGeneratorMatrixGetArgs();
    }
}
