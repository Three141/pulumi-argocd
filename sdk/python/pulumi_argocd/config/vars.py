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

import types

__config__ = pulumi.Config('argocd')


class _ExportableConfig(types.ModuleType):
    @property
    def auth_token(self) -> Optional[str]:
        """
        ArgoCD authentication token, takes precedence over `username`/`password`. Can be set through the `ARGOCD_AUTH_TOKEN`
        environment variable.
        """
        return __config__.get('authToken')

    @property
    def cert_file(self) -> Optional[str]:
        """
        Additional root CA certificates file to add to the client TLS connection pool.
        """
        return __config__.get('certFile')

    @property
    def client_cert_file(self) -> Optional[str]:
        """
        Client certificate.
        """
        return __config__.get('clientCertFile')

    @property
    def client_cert_key(self) -> Optional[str]:
        """
        Client certificate key.
        """
        return __config__.get('clientCertKey')

    @property
    def config_path(self) -> Optional[str]:
        """
        Override the default config path of `$HOME/.config/argocd/config`. Only relevant when `use_local_config`. Can be set
        through the `ARGOCD_CONFIG_PATH` environment variable.
        """
        return __config__.get('configPath')

    @property
    def context(self) -> Optional[str]:
        """
        Context to choose when using a local ArgoCD config file. Only relevant when `use_local_config`. Can be set through
        `ARGOCD_CONTEXT` environment variable.
        """
        return __config__.get('context')

    @property
    def core(self) -> Optional[bool]:
        """
        Configure direct access using Kubernetes API server. **Warning**: this feature works by starting a local ArgoCD API
        server that talks directly to the Kubernetes API using the **current context in the default kubeconfig**
        (`~/.kube/config`). This behavior cannot be overridden using either environment variables or the `kubernetes` block in
        the provider configuration at present). If the server fails to start (e.g. your kubeconfig is misconfigured) then the
        provider will fail as a result of the `argocd` module forcing it to exit and no logs will be available to help you debug
        this. The error message will be similar to > `The plugin encountered an error, and failed to respond to the
        plugin.(*GRPCProvider).ReadResource call. The plugin logs may contain more details.` To debug this, you will need to
        login via the ArgoCD CLI using `argocd login --core` and then running an operation. E.g. `argocd app list`.
        """
        return __config__.get_bool('core')

    @property
    def grpc_web(self) -> Optional[bool]:
        """
        Whether to use gRPC web proxy client. Useful if Argo CD server is behind proxy which does not support HTTP2.
        """
        return __config__.get_bool('grpcWeb')

    @property
    def grpc_web_root_path(self) -> Optional[str]:
        """
        Use the gRPC web proxy client and set the web root, e.g. `argo-cd`. Useful if the Argo CD server is behind a proxy at a
        non-root path.
        """
        return __config__.get('grpcWebRootPath')

    @property
    def headers(self) -> Optional[str]:
        """
        Additional headers to add to each request to the ArgoCD server.
        """
        return __config__.get('headers')

    @property
    def insecure(self) -> Optional[bool]:
        """
        Whether to skip TLS server certificate. Can be set through the `ARGOCD_INSECURE` environment variable.
        """
        return __config__.get_bool('insecure')

    @property
    def kubernetes(self) -> Optional[str]:
        """
        Kubernetes configuration overrides. Only relevant when `port_forward = true` or `port_forward_with_namespace = "foo"`.
        The kubeconfig file that is used can be overridden using the [`KUBECONFIG` environment
        variable](https://kubernetes.io/docs/concepts/configuration/organize-cluster-access-kubeconfig/#the-kubeconfig-environment-variable)).
        """
        return __config__.get('kubernetes')

    @property
    def password(self) -> Optional[str]:
        """
        Authentication password. Can be set through the `ARGOCD_AUTH_PASSWORD` environment variable.
        """
        return __config__.get('password')

    @property
    def plain_text(self) -> Optional[bool]:
        """
        Whether to initiate an unencrypted connection to ArgoCD server.
        """
        return __config__.get_bool('plainText')

    @property
    def port_forward(self) -> Optional[bool]:
        """
        Connect to a random argocd-server port using port forwarding.
        """
        return __config__.get_bool('portForward')

    @property
    def port_forward_with_namespace(self) -> Optional[str]:
        """
        Namespace name which should be used for port forwarding.
        """
        return __config__.get('portForwardWithNamespace')

    @property
    def server_addr(self) -> Optional[str]:
        """
        ArgoCD server address with port. Can be set through the `ARGOCD_SERVER` environment variable.
        """
        return __config__.get('serverAddr')

    @property
    def use_local_config(self) -> Optional[bool]:
        """
        Use the authentication settings found in the local config file. Useful when you have previously logged in using SSO.
        Conflicts with `auth_token`, `username` and `password`.
        """
        return __config__.get_bool('useLocalConfig')

    @property
    def user_agent(self) -> Optional[str]:
        """
        User-Agent request header override.
        """
        return __config__.get('userAgent')

    @property
    def username(self) -> Optional[str]:
        """
        Authentication username. Can be set through the `ARGOCD_AUTH_USERNAME` environment variable.
        """
        return __config__.get('username')

