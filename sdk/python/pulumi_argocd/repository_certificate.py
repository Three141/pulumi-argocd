# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import sys
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
if sys.version_info >= (3, 11):
    from typing import NotRequired, TypedDict, TypeAlias
else:
    from typing_extensions import NotRequired, TypedDict, TypeAlias
from . import _utilities
from . import outputs
from ._inputs import *

__all__ = ['RepositoryCertificateArgs', 'RepositoryCertificate']

@pulumi.input_type
class RepositoryCertificateArgs:
    def __init__(__self__, *,
                 https: Optional[pulumi.Input['RepositoryCertificateHttpsArgs']] = None,
                 ssh: Optional[pulumi.Input['RepositoryCertificateSshArgs']] = None):
        """
        The set of arguments for constructing a RepositoryCertificate resource.
        :param pulumi.Input['RepositoryCertificateHttpsArgs'] https: Defines a `https` certificate.
        :param pulumi.Input['RepositoryCertificateSshArgs'] ssh: Defines a `ssh` certificate.
        """
        if https is not None:
            pulumi.set(__self__, "https", https)
        if ssh is not None:
            pulumi.set(__self__, "ssh", ssh)

    @property
    @pulumi.getter
    def https(self) -> Optional[pulumi.Input['RepositoryCertificateHttpsArgs']]:
        """
        Defines a `https` certificate.
        """
        return pulumi.get(self, "https")

    @https.setter
    def https(self, value: Optional[pulumi.Input['RepositoryCertificateHttpsArgs']]):
        pulumi.set(self, "https", value)

    @property
    @pulumi.getter
    def ssh(self) -> Optional[pulumi.Input['RepositoryCertificateSshArgs']]:
        """
        Defines a `ssh` certificate.
        """
        return pulumi.get(self, "ssh")

    @ssh.setter
    def ssh(self, value: Optional[pulumi.Input['RepositoryCertificateSshArgs']]):
        pulumi.set(self, "ssh", value)


@pulumi.input_type
class _RepositoryCertificateState:
    def __init__(__self__, *,
                 https: Optional[pulumi.Input['RepositoryCertificateHttpsArgs']] = None,
                 ssh: Optional[pulumi.Input['RepositoryCertificateSshArgs']] = None):
        """
        Input properties used for looking up and filtering RepositoryCertificate resources.
        :param pulumi.Input['RepositoryCertificateHttpsArgs'] https: Defines a `https` certificate.
        :param pulumi.Input['RepositoryCertificateSshArgs'] ssh: Defines a `ssh` certificate.
        """
        if https is not None:
            pulumi.set(__self__, "https", https)
        if ssh is not None:
            pulumi.set(__self__, "ssh", ssh)

    @property
    @pulumi.getter
    def https(self) -> Optional[pulumi.Input['RepositoryCertificateHttpsArgs']]:
        """
        Defines a `https` certificate.
        """
        return pulumi.get(self, "https")

    @https.setter
    def https(self, value: Optional[pulumi.Input['RepositoryCertificateHttpsArgs']]):
        pulumi.set(self, "https", value)

    @property
    @pulumi.getter
    def ssh(self) -> Optional[pulumi.Input['RepositoryCertificateSshArgs']]:
        """
        Defines a `ssh` certificate.
        """
        return pulumi.get(self, "ssh")

    @ssh.setter
    def ssh(self, value: Optional[pulumi.Input['RepositoryCertificateSshArgs']]):
        pulumi.set(self, "ssh", value)


class RepositoryCertificate(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 https: Optional[pulumi.Input[Union['RepositoryCertificateHttpsArgs', 'RepositoryCertificateHttpsArgsDict']]] = None,
                 ssh: Optional[pulumi.Input[Union['RepositoryCertificateSshArgs', 'RepositoryCertificateSshArgsDict']]] = None,
                 __props__=None):
        """
        Manages [custom TLS certificates](https://argo-cd.readthedocs.io/en/stable/user-guide/private-repositories/#self-signed-untrusted-tls-certificates) used by ArgoCD for connecting Git repositories.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_argocd as argocd

        # HTTPS certificate
        private_git_repository_https = argocd.RepositoryCertificate("private-git-repository-https", https={
            "server_name": "private-git-repository.local",
            "cert_data": "-----BEGIN CERTIFICATE-----\\\\nfoo\\\\nbar\\\\n-----END CERTIFICATE-----\\n",
        })
        # SSH certificate
        private_git_repository_ssh = argocd.RepositoryCertificate("private-git-repository-ssh", ssh={
            "server_name": "private-git-repository.local",
            "cert_subtype": "ssh-rsa",
            "cert_data": "AAAAB3NzaC1yc2EAAAADAQABAAABgQCiPZAufKgxwRgxP9qy2Gtub0FI8qJGtL8Ldb7KatBeRUQQPn8QK7ZYjzYDvP1GOutFMaQT0rKIqaGImIBsztNCno...\\n",
        })
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Union['RepositoryCertificateHttpsArgs', 'RepositoryCertificateHttpsArgsDict']] https: Defines a `https` certificate.
        :param pulumi.Input[Union['RepositoryCertificateSshArgs', 'RepositoryCertificateSshArgsDict']] ssh: Defines a `ssh` certificate.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[RepositoryCertificateArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Manages [custom TLS certificates](https://argo-cd.readthedocs.io/en/stable/user-guide/private-repositories/#self-signed-untrusted-tls-certificates) used by ArgoCD for connecting Git repositories.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_argocd as argocd

        # HTTPS certificate
        private_git_repository_https = argocd.RepositoryCertificate("private-git-repository-https", https={
            "server_name": "private-git-repository.local",
            "cert_data": "-----BEGIN CERTIFICATE-----\\\\nfoo\\\\nbar\\\\n-----END CERTIFICATE-----\\n",
        })
        # SSH certificate
        private_git_repository_ssh = argocd.RepositoryCertificate("private-git-repository-ssh", ssh={
            "server_name": "private-git-repository.local",
            "cert_subtype": "ssh-rsa",
            "cert_data": "AAAAB3NzaC1yc2EAAAADAQABAAABgQCiPZAufKgxwRgxP9qy2Gtub0FI8qJGtL8Ldb7KatBeRUQQPn8QK7ZYjzYDvP1GOutFMaQT0rKIqaGImIBsztNCno...\\n",
        })
        ```

        :param str resource_name: The name of the resource.
        :param RepositoryCertificateArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(RepositoryCertificateArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 https: Optional[pulumi.Input[Union['RepositoryCertificateHttpsArgs', 'RepositoryCertificateHttpsArgsDict']]] = None,
                 ssh: Optional[pulumi.Input[Union['RepositoryCertificateSshArgs', 'RepositoryCertificateSshArgsDict']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = RepositoryCertificateArgs.__new__(RepositoryCertificateArgs)

            __props__.__dict__["https"] = https
            __props__.__dict__["ssh"] = ssh
        super(RepositoryCertificate, __self__).__init__(
            'argocd:index/repositoryCertificate:RepositoryCertificate',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            https: Optional[pulumi.Input[Union['RepositoryCertificateHttpsArgs', 'RepositoryCertificateHttpsArgsDict']]] = None,
            ssh: Optional[pulumi.Input[Union['RepositoryCertificateSshArgs', 'RepositoryCertificateSshArgsDict']]] = None) -> 'RepositoryCertificate':
        """
        Get an existing RepositoryCertificate resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Union['RepositoryCertificateHttpsArgs', 'RepositoryCertificateHttpsArgsDict']] https: Defines a `https` certificate.
        :param pulumi.Input[Union['RepositoryCertificateSshArgs', 'RepositoryCertificateSshArgsDict']] ssh: Defines a `ssh` certificate.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _RepositoryCertificateState.__new__(_RepositoryCertificateState)

        __props__.__dict__["https"] = https
        __props__.__dict__["ssh"] = ssh
        return RepositoryCertificate(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def https(self) -> pulumi.Output[Optional['outputs.RepositoryCertificateHttps']]:
        """
        Defines a `https` certificate.
        """
        return pulumi.get(self, "https")

    @property
    @pulumi.getter
    def ssh(self) -> pulumi.Output[Optional['outputs.RepositoryCertificateSsh']]:
        """
        Defines a `ssh` certificate.
        """
        return pulumi.get(self, "ssh")

