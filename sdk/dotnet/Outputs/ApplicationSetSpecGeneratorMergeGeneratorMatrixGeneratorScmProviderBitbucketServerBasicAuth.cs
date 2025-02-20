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
    public sealed class ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorScmProviderBitbucketServerBasicAuth
    {
        /// <summary>
        /// Password (or personal access token) reference.
        /// </summary>
        public readonly Outputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorScmProviderBitbucketServerBasicAuthPasswordRef? PasswordRef;
        /// <summary>
        /// Username for Basic auth.
        /// </summary>
        public readonly string? Username;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorScmProviderBitbucketServerBasicAuth(
            Outputs.ApplicationSetSpecGeneratorMergeGeneratorMatrixGeneratorScmProviderBitbucketServerBasicAuthPasswordRef? passwordRef,

            string? username)
        {
            PasswordRef = passwordRef;
            Username = username;
        }
    }
}
