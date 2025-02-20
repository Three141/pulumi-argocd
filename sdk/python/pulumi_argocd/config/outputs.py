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
from .. import _utilities
from . import outputs

__all__ = [
    'Kubernetes',
    'KubernetesExec',
]

@pulumi.output_type
class Kubernetes(dict):
    def __init__(__self__, *,
                 client_certificate: Optional[str] = None,
                 client_key: Optional[str] = None,
                 cluster_ca_certificate: Optional[str] = None,
                 config_context: Optional[str] = None,
                 config_context_auth_info: Optional[str] = None,
                 config_context_cluster: Optional[str] = None,
                 exec_: Optional['outputs.KubernetesExec'] = None,
                 host: Optional[str] = None,
                 insecure: Optional[bool] = None,
                 password: Optional[str] = None,
                 token: Optional[str] = None,
                 username: Optional[str] = None):
        """
        :param str client_certificate: PEM-encoded client certificate for TLS authentication. Can be sourced from `KUBE_CLIENT_CERT_DATA`.
        :param str client_key: PEM-encoded client certificate key for TLS authentication. Can be sourced from `KUBE_CLIENT_KEY_DATA`.
        :param str cluster_ca_certificate: PEM-encoded root certificates bundle for TLS authentication. Can be sourced from `KUBE_CLUSTER_CA_CERT_DATA`.
        :param str config_context: Context to choose from the config file. Can be sourced from `KUBE_CTX`.
        :param 'KubernetesExecArgs' exec_: Configuration block to use an [exec-based credential plugin](https://kubernetes.io/docs/reference/access-authn-authz/authentication/#client-go-credential-plugins), e.g. call an external command to receive user credentials.
        :param str host: The hostname (in form of URI) of the Kubernetes API. Can be sourced from `KUBE_HOST`.
        :param bool insecure: Whether server should be accessed without verifying the TLS certificate. Can be sourced from `KUBE_INSECURE`.
        :param str password: The password to use for HTTP basic authentication when accessing the Kubernetes API. Can be sourced from `KUBE_PASSWORD`.
        :param str token: Token to authenticate an service account. Can be sourced from `KUBE_TOKEN`.
        :param str username: The username to use for HTTP basic authentication when accessing the Kubernetes API. Can be sourced from `KUBE_USER`.
        """
        if client_certificate is not None:
            pulumi.set(__self__, "client_certificate", client_certificate)
        if client_key is not None:
            pulumi.set(__self__, "client_key", client_key)
        if cluster_ca_certificate is not None:
            pulumi.set(__self__, "cluster_ca_certificate", cluster_ca_certificate)
        if config_context is not None:
            pulumi.set(__self__, "config_context", config_context)
        if config_context_auth_info is not None:
            pulumi.set(__self__, "config_context_auth_info", config_context_auth_info)
        if config_context_cluster is not None:
            pulumi.set(__self__, "config_context_cluster", config_context_cluster)
        if exec_ is not None:
            pulumi.set(__self__, "exec_", exec_)
        if host is not None:
            pulumi.set(__self__, "host", host)
        if insecure is not None:
            pulumi.set(__self__, "insecure", insecure)
        if password is not None:
            pulumi.set(__self__, "password", password)
        if token is not None:
            pulumi.set(__self__, "token", token)
        if username is not None:
            pulumi.set(__self__, "username", username)

    @property
    @pulumi.getter(name="clientCertificate")
    def client_certificate(self) -> Optional[str]:
        """
        PEM-encoded client certificate for TLS authentication. Can be sourced from `KUBE_CLIENT_CERT_DATA`.
        """
        return pulumi.get(self, "client_certificate")

    @property
    @pulumi.getter(name="clientKey")
    def client_key(self) -> Optional[str]:
        """
        PEM-encoded client certificate key for TLS authentication. Can be sourced from `KUBE_CLIENT_KEY_DATA`.
        """
        return pulumi.get(self, "client_key")

    @property
    @pulumi.getter(name="clusterCaCertificate")
    def cluster_ca_certificate(self) -> Optional[str]:
        """
        PEM-encoded root certificates bundle for TLS authentication. Can be sourced from `KUBE_CLUSTER_CA_CERT_DATA`.
        """
        return pulumi.get(self, "cluster_ca_certificate")

    @property
    @pulumi.getter(name="configContext")
    def config_context(self) -> Optional[str]:
        """
        Context to choose from the config file. Can be sourced from `KUBE_CTX`.
        """
        return pulumi.get(self, "config_context")

    @property
    @pulumi.getter(name="configContextAuthInfo")
    def config_context_auth_info(self) -> Optional[str]:
        return pulumi.get(self, "config_context_auth_info")

    @property
    @pulumi.getter(name="configContextCluster")
    def config_context_cluster(self) -> Optional[str]:
        return pulumi.get(self, "config_context_cluster")

    @property
    @pulumi.getter(name="exec")
    def exec_(self) -> Optional['outputs.KubernetesExec']:
        """
        Configuration block to use an [exec-based credential plugin](https://kubernetes.io/docs/reference/access-authn-authz/authentication/#client-go-credential-plugins), e.g. call an external command to receive user credentials.
        """
        return pulumi.get(self, "exec_")

    @property
    @pulumi.getter
    def host(self) -> Optional[str]:
        """
        The hostname (in form of URI) of the Kubernetes API. Can be sourced from `KUBE_HOST`.
        """
        return pulumi.get(self, "host")

    @property
    @pulumi.getter
    def insecure(self) -> Optional[bool]:
        """
        Whether server should be accessed without verifying the TLS certificate. Can be sourced from `KUBE_INSECURE`.
        """
        return pulumi.get(self, "insecure")

    @property
    @pulumi.getter
    def password(self) -> Optional[str]:
        """
        The password to use for HTTP basic authentication when accessing the Kubernetes API. Can be sourced from `KUBE_PASSWORD`.
        """
        return pulumi.get(self, "password")

    @property
    @pulumi.getter
    def token(self) -> Optional[str]:
        """
        Token to authenticate an service account. Can be sourced from `KUBE_TOKEN`.
        """
        return pulumi.get(self, "token")

    @property
    @pulumi.getter
    def username(self) -> Optional[str]:
        """
        The username to use for HTTP basic authentication when accessing the Kubernetes API. Can be sourced from `KUBE_USER`.
        """
        return pulumi.get(self, "username")


@pulumi.output_type
class KubernetesExec(dict):
    def __init__(__self__, *,
                 api_version: str,
                 command: str,
                 args: Optional[Sequence[str]] = None,
                 env: Optional[Mapping[str, str]] = None):
        """
        :param str api_version: API version to use when decoding the ExecCredentials resource, e.g. `client.authentication.k8s.io/v1beta1`.
        :param str command: Command to execute.
        :param Sequence[str] args: Map of environment variables to set when executing the plugin.
        :param Mapping[str, str] env: List of arguments to pass when executing the plugin.
        """
        pulumi.set(__self__, "api_version", api_version)
        pulumi.set(__self__, "command", command)
        if args is not None:
            pulumi.set(__self__, "args", args)
        if env is not None:
            pulumi.set(__self__, "env", env)

    @property
    @pulumi.getter(name="apiVersion")
    def api_version(self) -> str:
        """
        API version to use when decoding the ExecCredentials resource, e.g. `client.authentication.k8s.io/v1beta1`.
        """
        return pulumi.get(self, "api_version")

    @property
    @pulumi.getter
    def command(self) -> str:
        """
        Command to execute.
        """
        return pulumi.get(self, "command")

    @property
    @pulumi.getter
    def args(self) -> Optional[Sequence[str]]:
        """
        Map of environment variables to set when executing the plugin.
        """
        return pulumi.get(self, "args")

    @property
    @pulumi.getter
    def env(self) -> Optional[Mapping[str, str]]:
        """
        List of arguments to pass when executing the plugin.
        """
        return pulumi.get(self, "env")


