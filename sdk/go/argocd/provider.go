// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package argocd

import (
	"context"
	"reflect"

	"github.com/Three141/pulumi-argocd/sdk/go/argocd/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// The provider type for the argocd package. By default, resources use package-wide configuration
// settings, however an explicit `Provider` instance may be created and passed during resource
// construction to achieve fine-grained programmatic control over provider settings. See the
// [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.
type Provider struct {
	pulumi.ProviderResourceState

	// ArgoCD authentication token, takes precedence over `username`/`password`. Can be set through the `ARGOCD_AUTH_TOKEN`
	// environment variable.
	AuthToken pulumi.StringPtrOutput `pulumi:"authToken"`
	// Additional root CA certificates file to add to the client TLS connection pool.
	CertFile pulumi.StringPtrOutput `pulumi:"certFile"`
	// Client certificate.
	ClientCertFile pulumi.StringPtrOutput `pulumi:"clientCertFile"`
	// Client certificate key.
	ClientCertKey pulumi.StringPtrOutput `pulumi:"clientCertKey"`
	// Override the default config path of `$HOME/.config/argocd/config`. Only relevant when `useLocalConfig`. Can be set
	// through the `ARGOCD_CONFIG_PATH` environment variable.
	ConfigPath pulumi.StringPtrOutput `pulumi:"configPath"`
	// Context to choose when using a local ArgoCD config file. Only relevant when `useLocalConfig`. Can be set through
	// `ARGOCD_CONTEXT` environment variable.
	Context pulumi.StringPtrOutput `pulumi:"context"`
	// Use the gRPC web proxy client and set the web root, e.g. `argo-cd`. Useful if the Argo CD server is behind a proxy at a
	// non-root path.
	GrpcWebRootPath pulumi.StringPtrOutput `pulumi:"grpcWebRootPath"`
	// Authentication password. Can be set through the `ARGOCD_AUTH_PASSWORD` environment variable.
	Password pulumi.StringPtrOutput `pulumi:"password"`
	// Namespace name which should be used for port forwarding.
	PortForwardWithNamespace pulumi.StringPtrOutput `pulumi:"portForwardWithNamespace"`
	// ArgoCD server address with port. Can be set through the `ARGOCD_SERVER` environment variable.
	ServerAddr pulumi.StringPtrOutput `pulumi:"serverAddr"`
	// User-Agent request header override.
	UserAgent pulumi.StringPtrOutput `pulumi:"userAgent"`
	// Authentication username. Can be set through the `ARGOCD_AUTH_USERNAME` environment variable.
	Username pulumi.StringPtrOutput `pulumi:"username"`
}

// NewProvider registers a new resource with the given unique name, arguments, and options.
func NewProvider(ctx *pulumi.Context,
	name string, args *ProviderArgs, opts ...pulumi.ResourceOption) (*Provider, error) {
	if args == nil {
		args = &ProviderArgs{}
	}

	if args.AuthToken != nil {
		args.AuthToken = pulumi.ToSecret(args.AuthToken).(pulumi.StringPtrInput)
	}
	if args.Password != nil {
		args.Password = pulumi.ToSecret(args.Password).(pulumi.StringPtrInput)
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"authToken",
		"password",
	})
	opts = append(opts, secrets)
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Provider
	err := ctx.RegisterResource("pulumi:providers:argocd", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

type providerArgs struct {
	// ArgoCD authentication token, takes precedence over `username`/`password`. Can be set through the `ARGOCD_AUTH_TOKEN`
	// environment variable.
	AuthToken *string `pulumi:"authToken"`
	// Additional root CA certificates file to add to the client TLS connection pool.
	CertFile *string `pulumi:"certFile"`
	// Client certificate.
	ClientCertFile *string `pulumi:"clientCertFile"`
	// Client certificate key.
	ClientCertKey *string `pulumi:"clientCertKey"`
	// Override the default config path of `$HOME/.config/argocd/config`. Only relevant when `useLocalConfig`. Can be set
	// through the `ARGOCD_CONFIG_PATH` environment variable.
	ConfigPath *string `pulumi:"configPath"`
	// Context to choose when using a local ArgoCD config file. Only relevant when `useLocalConfig`. Can be set through
	// `ARGOCD_CONTEXT` environment variable.
	Context *string `pulumi:"context"`
	// Configure direct access using Kubernetes API server. **Warning**: this feature works by starting a local ArgoCD API
	// server that talks directly to the Kubernetes API using the **current context in the default kubeconfig**
	// (`~/.kube/config`). This behavior cannot be overridden using either environment variables or the `kubernetes` block in
	// the provider configuration at present). If the server fails to start (e.g. your kubeconfig is misconfigured) then the
	// provider will fail as a result of the `argocd` module forcing it to exit and no logs will be available to help you debug
	// this. The error message will be similar to > `The plugin encountered an error, and failed to respond to the
	// plugin.(*GRPCProvider).ReadResource call. The plugin logs may contain more details.` To debug this, you will need to
	// login via the ArgoCD CLI using `argocd login --core` and then running an operation. E.g. `argocd app list`.
	Core *bool `pulumi:"core"`
	// Whether to use gRPC web proxy client. Useful if Argo CD server is behind proxy which does not support HTTP2.
	GrpcWeb *bool `pulumi:"grpcWeb"`
	// Use the gRPC web proxy client and set the web root, e.g. `argo-cd`. Useful if the Argo CD server is behind a proxy at a
	// non-root path.
	GrpcWebRootPath *string `pulumi:"grpcWebRootPath"`
	// Additional headers to add to each request to the ArgoCD server.
	Headers []string `pulumi:"headers"`
	// Whether to skip TLS server certificate. Can be set through the `ARGOCD_INSECURE` environment variable.
	Insecure *bool `pulumi:"insecure"`
	// Kubernetes configuration overrides. Only relevant when `portForward = true` or `portForwardWithNamespace = "foo"`. The
	// kubeconfig file that is used can be overridden using the [`KUBECONFIG` environment
	// variable](https://kubernetes.io/docs/concepts/configuration/organize-cluster-access-kubeconfig/#the-kubeconfig-environment-variable)).
	Kubernetes *ProviderKubernetes `pulumi:"kubernetes"`
	// Authentication password. Can be set through the `ARGOCD_AUTH_PASSWORD` environment variable.
	Password *string `pulumi:"password"`
	// Whether to initiate an unencrypted connection to ArgoCD server.
	PlainText *bool `pulumi:"plainText"`
	// Connect to a random argocd-server port using port forwarding.
	PortForward *bool `pulumi:"portForward"`
	// Namespace name which should be used for port forwarding.
	PortForwardWithNamespace *string `pulumi:"portForwardWithNamespace"`
	// ArgoCD server address with port. Can be set through the `ARGOCD_SERVER` environment variable.
	ServerAddr *string `pulumi:"serverAddr"`
	// Use the authentication settings found in the local config file. Useful when you have previously logged in using SSO.
	// Conflicts with `authToken`, `username` and `password`.
	UseLocalConfig *bool `pulumi:"useLocalConfig"`
	// User-Agent request header override.
	UserAgent *string `pulumi:"userAgent"`
	// Authentication username. Can be set through the `ARGOCD_AUTH_USERNAME` environment variable.
	Username *string `pulumi:"username"`
}

// The set of arguments for constructing a Provider resource.
type ProviderArgs struct {
	// ArgoCD authentication token, takes precedence over `username`/`password`. Can be set through the `ARGOCD_AUTH_TOKEN`
	// environment variable.
	AuthToken pulumi.StringPtrInput
	// Additional root CA certificates file to add to the client TLS connection pool.
	CertFile pulumi.StringPtrInput
	// Client certificate.
	ClientCertFile pulumi.StringPtrInput
	// Client certificate key.
	ClientCertKey pulumi.StringPtrInput
	// Override the default config path of `$HOME/.config/argocd/config`. Only relevant when `useLocalConfig`. Can be set
	// through the `ARGOCD_CONFIG_PATH` environment variable.
	ConfigPath pulumi.StringPtrInput
	// Context to choose when using a local ArgoCD config file. Only relevant when `useLocalConfig`. Can be set through
	// `ARGOCD_CONTEXT` environment variable.
	Context pulumi.StringPtrInput
	// Configure direct access using Kubernetes API server. **Warning**: this feature works by starting a local ArgoCD API
	// server that talks directly to the Kubernetes API using the **current context in the default kubeconfig**
	// (`~/.kube/config`). This behavior cannot be overridden using either environment variables or the `kubernetes` block in
	// the provider configuration at present). If the server fails to start (e.g. your kubeconfig is misconfigured) then the
	// provider will fail as a result of the `argocd` module forcing it to exit and no logs will be available to help you debug
	// this. The error message will be similar to > `The plugin encountered an error, and failed to respond to the
	// plugin.(*GRPCProvider).ReadResource call. The plugin logs may contain more details.` To debug this, you will need to
	// login via the ArgoCD CLI using `argocd login --core` and then running an operation. E.g. `argocd app list`.
	Core pulumi.BoolPtrInput
	// Whether to use gRPC web proxy client. Useful if Argo CD server is behind proxy which does not support HTTP2.
	GrpcWeb pulumi.BoolPtrInput
	// Use the gRPC web proxy client and set the web root, e.g. `argo-cd`. Useful if the Argo CD server is behind a proxy at a
	// non-root path.
	GrpcWebRootPath pulumi.StringPtrInput
	// Additional headers to add to each request to the ArgoCD server.
	Headers pulumi.StringArrayInput
	// Whether to skip TLS server certificate. Can be set through the `ARGOCD_INSECURE` environment variable.
	Insecure pulumi.BoolPtrInput
	// Kubernetes configuration overrides. Only relevant when `portForward = true` or `portForwardWithNamespace = "foo"`. The
	// kubeconfig file that is used can be overridden using the [`KUBECONFIG` environment
	// variable](https://kubernetes.io/docs/concepts/configuration/organize-cluster-access-kubeconfig/#the-kubeconfig-environment-variable)).
	Kubernetes ProviderKubernetesPtrInput
	// Authentication password. Can be set through the `ARGOCD_AUTH_PASSWORD` environment variable.
	Password pulumi.StringPtrInput
	// Whether to initiate an unencrypted connection to ArgoCD server.
	PlainText pulumi.BoolPtrInput
	// Connect to a random argocd-server port using port forwarding.
	PortForward pulumi.BoolPtrInput
	// Namespace name which should be used for port forwarding.
	PortForwardWithNamespace pulumi.StringPtrInput
	// ArgoCD server address with port. Can be set through the `ARGOCD_SERVER` environment variable.
	ServerAddr pulumi.StringPtrInput
	// Use the authentication settings found in the local config file. Useful when you have previously logged in using SSO.
	// Conflicts with `authToken`, `username` and `password`.
	UseLocalConfig pulumi.BoolPtrInput
	// User-Agent request header override.
	UserAgent pulumi.StringPtrInput
	// Authentication username. Can be set through the `ARGOCD_AUTH_USERNAME` environment variable.
	Username pulumi.StringPtrInput
}

func (ProviderArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*providerArgs)(nil)).Elem()
}

type ProviderInput interface {
	pulumi.Input

	ToProviderOutput() ProviderOutput
	ToProviderOutputWithContext(ctx context.Context) ProviderOutput
}

func (*Provider) ElementType() reflect.Type {
	return reflect.TypeOf((**Provider)(nil)).Elem()
}

func (i *Provider) ToProviderOutput() ProviderOutput {
	return i.ToProviderOutputWithContext(context.Background())
}

func (i *Provider) ToProviderOutputWithContext(ctx context.Context) ProviderOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProviderOutput)
}

type ProviderOutput struct{ *pulumi.OutputState }

func (ProviderOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Provider)(nil)).Elem()
}

func (o ProviderOutput) ToProviderOutput() ProviderOutput {
	return o
}

func (o ProviderOutput) ToProviderOutputWithContext(ctx context.Context) ProviderOutput {
	return o
}

// ArgoCD authentication token, takes precedence over `username`/`password`. Can be set through the `ARGOCD_AUTH_TOKEN`
// environment variable.
func (o ProviderOutput) AuthToken() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.AuthToken }).(pulumi.StringPtrOutput)
}

// Additional root CA certificates file to add to the client TLS connection pool.
func (o ProviderOutput) CertFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.CertFile }).(pulumi.StringPtrOutput)
}

// Client certificate.
func (o ProviderOutput) ClientCertFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.ClientCertFile }).(pulumi.StringPtrOutput)
}

// Client certificate key.
func (o ProviderOutput) ClientCertKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.ClientCertKey }).(pulumi.StringPtrOutput)
}

// Override the default config path of `$HOME/.config/argocd/config`. Only relevant when `useLocalConfig`. Can be set
// through the `ARGOCD_CONFIG_PATH` environment variable.
func (o ProviderOutput) ConfigPath() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.ConfigPath }).(pulumi.StringPtrOutput)
}

// Context to choose when using a local ArgoCD config file. Only relevant when `useLocalConfig`. Can be set through
// `ARGOCD_CONTEXT` environment variable.
func (o ProviderOutput) Context() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.Context }).(pulumi.StringPtrOutput)
}

// Use the gRPC web proxy client and set the web root, e.g. `argo-cd`. Useful if the Argo CD server is behind a proxy at a
// non-root path.
func (o ProviderOutput) GrpcWebRootPath() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.GrpcWebRootPath }).(pulumi.StringPtrOutput)
}

// Authentication password. Can be set through the `ARGOCD_AUTH_PASSWORD` environment variable.
func (o ProviderOutput) Password() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.Password }).(pulumi.StringPtrOutput)
}

// Namespace name which should be used for port forwarding.
func (o ProviderOutput) PortForwardWithNamespace() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.PortForwardWithNamespace }).(pulumi.StringPtrOutput)
}

// ArgoCD server address with port. Can be set through the `ARGOCD_SERVER` environment variable.
func (o ProviderOutput) ServerAddr() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.ServerAddr }).(pulumi.StringPtrOutput)
}

// User-Agent request header override.
func (o ProviderOutput) UserAgent() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.UserAgent }).(pulumi.StringPtrOutput)
}

// Authentication username. Can be set through the `ARGOCD_AUTH_USERNAME` environment variable.
func (o ProviderOutput) Username() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.Username }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ProviderInput)(nil)).Elem(), &Provider{})
	pulumi.RegisterOutputType(ProviderOutput{})
}
