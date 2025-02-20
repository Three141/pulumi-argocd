// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package argocd

import (
	"context"
	"reflect"

	"errors"
	"github.com/Three141/pulumi-argocd/sdk/go/argocd/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Manages ArgoCD project role JWT tokens. See [Project Roles](https://argo-cd.readthedocs.io/en/stable/user-guide/projects/#project-roles) for more info.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/Three141/pulumi-argocd/sdk/go/argocd"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := argocd.NewProjectToken(ctx, "secret", &argocd.ProjectTokenArgs{
//				Project:     pulumi.String("someproject"),
//				Role:        pulumi.String("foobar"),
//				Description: pulumi.String("short lived token"),
//				ExpiresIn:   pulumi.String("1h"),
//				RenewBefore: pulumi.String("30m"),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
type ProjectToken struct {
	pulumi.CustomResourceState

	// Description of the token.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// If `expiresIn` is set, Unix timestamp upon which the token will expire.
	ExpiresAt pulumi.StringOutput `pulumi:"expiresAt"`
	// Duration before the token will expire. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`. E.g. `12h`, `7d`. Default: No expiration.
	ExpiresIn pulumi.StringPtrOutput `pulumi:"expiresIn"`
	// Unix timestamp at which the token was issued.
	IssuedAt pulumi.StringOutput `pulumi:"issuedAt"`
	// The raw JWT.
	Jwt pulumi.StringOutput `pulumi:"jwt"`
	// The project associated with the token.
	Project pulumi.StringOutput `pulumi:"project"`
	// Duration to control token silent regeneration based on token age. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`. If set, then the token will be regenerated if it is older than `renewAfter`. I.e. if `currentDate - issuedAt > renewAfter`.
	RenewAfter pulumi.StringPtrOutput `pulumi:"renewAfter"`
	// Duration to control token silent regeneration based on remaining token lifetime. If `expiresIn` is set, the provider will regenerate the token if `expiresAt - currentDate < renewBefore`. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`.
	RenewBefore pulumi.StringPtrOutput `pulumi:"renewBefore"`
	// The name of the role in the project associated with the token.
	Role pulumi.StringOutput `pulumi:"role"`
}

// NewProjectToken registers a new resource with the given unique name, arguments, and options.
func NewProjectToken(ctx *pulumi.Context,
	name string, args *ProjectTokenArgs, opts ...pulumi.ResourceOption) (*ProjectToken, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Project == nil {
		return nil, errors.New("invalid value for required argument 'Project'")
	}
	if args.Role == nil {
		return nil, errors.New("invalid value for required argument 'Role'")
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"jwt",
	})
	opts = append(opts, secrets)
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ProjectToken
	err := ctx.RegisterResource("argocd:index/projectToken:ProjectToken", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetProjectToken gets an existing ProjectToken resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetProjectToken(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ProjectTokenState, opts ...pulumi.ResourceOption) (*ProjectToken, error) {
	var resource ProjectToken
	err := ctx.ReadResource("argocd:index/projectToken:ProjectToken", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ProjectToken resources.
type projectTokenState struct {
	// Description of the token.
	Description *string `pulumi:"description"`
	// If `expiresIn` is set, Unix timestamp upon which the token will expire.
	ExpiresAt *string `pulumi:"expiresAt"`
	// Duration before the token will expire. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`. E.g. `12h`, `7d`. Default: No expiration.
	ExpiresIn *string `pulumi:"expiresIn"`
	// Unix timestamp at which the token was issued.
	IssuedAt *string `pulumi:"issuedAt"`
	// The raw JWT.
	Jwt *string `pulumi:"jwt"`
	// The project associated with the token.
	Project *string `pulumi:"project"`
	// Duration to control token silent regeneration based on token age. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`. If set, then the token will be regenerated if it is older than `renewAfter`. I.e. if `currentDate - issuedAt > renewAfter`.
	RenewAfter *string `pulumi:"renewAfter"`
	// Duration to control token silent regeneration based on remaining token lifetime. If `expiresIn` is set, the provider will regenerate the token if `expiresAt - currentDate < renewBefore`. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`.
	RenewBefore *string `pulumi:"renewBefore"`
	// The name of the role in the project associated with the token.
	Role *string `pulumi:"role"`
}

type ProjectTokenState struct {
	// Description of the token.
	Description pulumi.StringPtrInput
	// If `expiresIn` is set, Unix timestamp upon which the token will expire.
	ExpiresAt pulumi.StringPtrInput
	// Duration before the token will expire. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`. E.g. `12h`, `7d`. Default: No expiration.
	ExpiresIn pulumi.StringPtrInput
	// Unix timestamp at which the token was issued.
	IssuedAt pulumi.StringPtrInput
	// The raw JWT.
	Jwt pulumi.StringPtrInput
	// The project associated with the token.
	Project pulumi.StringPtrInput
	// Duration to control token silent regeneration based on token age. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`. If set, then the token will be regenerated if it is older than `renewAfter`. I.e. if `currentDate - issuedAt > renewAfter`.
	RenewAfter pulumi.StringPtrInput
	// Duration to control token silent regeneration based on remaining token lifetime. If `expiresIn` is set, the provider will regenerate the token if `expiresAt - currentDate < renewBefore`. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`.
	RenewBefore pulumi.StringPtrInput
	// The name of the role in the project associated with the token.
	Role pulumi.StringPtrInput
}

func (ProjectTokenState) ElementType() reflect.Type {
	return reflect.TypeOf((*projectTokenState)(nil)).Elem()
}

type projectTokenArgs struct {
	// Description of the token.
	Description *string `pulumi:"description"`
	// Duration before the token will expire. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`. E.g. `12h`, `7d`. Default: No expiration.
	ExpiresIn *string `pulumi:"expiresIn"`
	// The project associated with the token.
	Project string `pulumi:"project"`
	// Duration to control token silent regeneration based on token age. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`. If set, then the token will be regenerated if it is older than `renewAfter`. I.e. if `currentDate - issuedAt > renewAfter`.
	RenewAfter *string `pulumi:"renewAfter"`
	// Duration to control token silent regeneration based on remaining token lifetime. If `expiresIn` is set, the provider will regenerate the token if `expiresAt - currentDate < renewBefore`. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`.
	RenewBefore *string `pulumi:"renewBefore"`
	// The name of the role in the project associated with the token.
	Role string `pulumi:"role"`
}

// The set of arguments for constructing a ProjectToken resource.
type ProjectTokenArgs struct {
	// Description of the token.
	Description pulumi.StringPtrInput
	// Duration before the token will expire. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`. E.g. `12h`, `7d`. Default: No expiration.
	ExpiresIn pulumi.StringPtrInput
	// The project associated with the token.
	Project pulumi.StringInput
	// Duration to control token silent regeneration based on token age. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`. If set, then the token will be regenerated if it is older than `renewAfter`. I.e. if `currentDate - issuedAt > renewAfter`.
	RenewAfter pulumi.StringPtrInput
	// Duration to control token silent regeneration based on remaining token lifetime. If `expiresIn` is set, the provider will regenerate the token if `expiresAt - currentDate < renewBefore`. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`.
	RenewBefore pulumi.StringPtrInput
	// The name of the role in the project associated with the token.
	Role pulumi.StringInput
}

func (ProjectTokenArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*projectTokenArgs)(nil)).Elem()
}

type ProjectTokenInput interface {
	pulumi.Input

	ToProjectTokenOutput() ProjectTokenOutput
	ToProjectTokenOutputWithContext(ctx context.Context) ProjectTokenOutput
}

func (*ProjectToken) ElementType() reflect.Type {
	return reflect.TypeOf((**ProjectToken)(nil)).Elem()
}

func (i *ProjectToken) ToProjectTokenOutput() ProjectTokenOutput {
	return i.ToProjectTokenOutputWithContext(context.Background())
}

func (i *ProjectToken) ToProjectTokenOutputWithContext(ctx context.Context) ProjectTokenOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProjectTokenOutput)
}

// ProjectTokenArrayInput is an input type that accepts ProjectTokenArray and ProjectTokenArrayOutput values.
// You can construct a concrete instance of `ProjectTokenArrayInput` via:
//
//	ProjectTokenArray{ ProjectTokenArgs{...} }
type ProjectTokenArrayInput interface {
	pulumi.Input

	ToProjectTokenArrayOutput() ProjectTokenArrayOutput
	ToProjectTokenArrayOutputWithContext(context.Context) ProjectTokenArrayOutput
}

type ProjectTokenArray []ProjectTokenInput

func (ProjectTokenArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ProjectToken)(nil)).Elem()
}

func (i ProjectTokenArray) ToProjectTokenArrayOutput() ProjectTokenArrayOutput {
	return i.ToProjectTokenArrayOutputWithContext(context.Background())
}

func (i ProjectTokenArray) ToProjectTokenArrayOutputWithContext(ctx context.Context) ProjectTokenArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProjectTokenArrayOutput)
}

// ProjectTokenMapInput is an input type that accepts ProjectTokenMap and ProjectTokenMapOutput values.
// You can construct a concrete instance of `ProjectTokenMapInput` via:
//
//	ProjectTokenMap{ "key": ProjectTokenArgs{...} }
type ProjectTokenMapInput interface {
	pulumi.Input

	ToProjectTokenMapOutput() ProjectTokenMapOutput
	ToProjectTokenMapOutputWithContext(context.Context) ProjectTokenMapOutput
}

type ProjectTokenMap map[string]ProjectTokenInput

func (ProjectTokenMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ProjectToken)(nil)).Elem()
}

func (i ProjectTokenMap) ToProjectTokenMapOutput() ProjectTokenMapOutput {
	return i.ToProjectTokenMapOutputWithContext(context.Background())
}

func (i ProjectTokenMap) ToProjectTokenMapOutputWithContext(ctx context.Context) ProjectTokenMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProjectTokenMapOutput)
}

type ProjectTokenOutput struct{ *pulumi.OutputState }

func (ProjectTokenOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ProjectToken)(nil)).Elem()
}

func (o ProjectTokenOutput) ToProjectTokenOutput() ProjectTokenOutput {
	return o
}

func (o ProjectTokenOutput) ToProjectTokenOutputWithContext(ctx context.Context) ProjectTokenOutput {
	return o
}

// Description of the token.
func (o ProjectTokenOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ProjectToken) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// If `expiresIn` is set, Unix timestamp upon which the token will expire.
func (o ProjectTokenOutput) ExpiresAt() pulumi.StringOutput {
	return o.ApplyT(func(v *ProjectToken) pulumi.StringOutput { return v.ExpiresAt }).(pulumi.StringOutput)
}

// Duration before the token will expire. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`. E.g. `12h`, `7d`. Default: No expiration.
func (o ProjectTokenOutput) ExpiresIn() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ProjectToken) pulumi.StringPtrOutput { return v.ExpiresIn }).(pulumi.StringPtrOutput)
}

// Unix timestamp at which the token was issued.
func (o ProjectTokenOutput) IssuedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *ProjectToken) pulumi.StringOutput { return v.IssuedAt }).(pulumi.StringOutput)
}

// The raw JWT.
func (o ProjectTokenOutput) Jwt() pulumi.StringOutput {
	return o.ApplyT(func(v *ProjectToken) pulumi.StringOutput { return v.Jwt }).(pulumi.StringOutput)
}

// The project associated with the token.
func (o ProjectTokenOutput) Project() pulumi.StringOutput {
	return o.ApplyT(func(v *ProjectToken) pulumi.StringOutput { return v.Project }).(pulumi.StringOutput)
}

// Duration to control token silent regeneration based on token age. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`. If set, then the token will be regenerated if it is older than `renewAfter`. I.e. if `currentDate - issuedAt > renewAfter`.
func (o ProjectTokenOutput) RenewAfter() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ProjectToken) pulumi.StringPtrOutput { return v.RenewAfter }).(pulumi.StringPtrOutput)
}

// Duration to control token silent regeneration based on remaining token lifetime. If `expiresIn` is set, the provider will regenerate the token if `expiresAt - currentDate < renewBefore`. Valid time units are `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`.
func (o ProjectTokenOutput) RenewBefore() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ProjectToken) pulumi.StringPtrOutput { return v.RenewBefore }).(pulumi.StringPtrOutput)
}

// The name of the role in the project associated with the token.
func (o ProjectTokenOutput) Role() pulumi.StringOutput {
	return o.ApplyT(func(v *ProjectToken) pulumi.StringOutput { return v.Role }).(pulumi.StringOutput)
}

type ProjectTokenArrayOutput struct{ *pulumi.OutputState }

func (ProjectTokenArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ProjectToken)(nil)).Elem()
}

func (o ProjectTokenArrayOutput) ToProjectTokenArrayOutput() ProjectTokenArrayOutput {
	return o
}

func (o ProjectTokenArrayOutput) ToProjectTokenArrayOutputWithContext(ctx context.Context) ProjectTokenArrayOutput {
	return o
}

func (o ProjectTokenArrayOutput) Index(i pulumi.IntInput) ProjectTokenOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ProjectToken {
		return vs[0].([]*ProjectToken)[vs[1].(int)]
	}).(ProjectTokenOutput)
}

type ProjectTokenMapOutput struct{ *pulumi.OutputState }

func (ProjectTokenMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ProjectToken)(nil)).Elem()
}

func (o ProjectTokenMapOutput) ToProjectTokenMapOutput() ProjectTokenMapOutput {
	return o
}

func (o ProjectTokenMapOutput) ToProjectTokenMapOutputWithContext(ctx context.Context) ProjectTokenMapOutput {
	return o
}

func (o ProjectTokenMapOutput) MapIndex(k pulumi.StringInput) ProjectTokenOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ProjectToken {
		return vs[0].(map[string]*ProjectToken)[vs[1].(string)]
	}).(ProjectTokenOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ProjectTokenInput)(nil)).Elem(), &ProjectToken{})
	pulumi.RegisterInputType(reflect.TypeOf((*ProjectTokenArrayInput)(nil)).Elem(), ProjectTokenArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ProjectTokenMapInput)(nil)).Elem(), ProjectTokenMap{})
	pulumi.RegisterOutputType(ProjectTokenOutput{})
	pulumi.RegisterOutputType(ProjectTokenArrayOutput{})
	pulumi.RegisterOutputType(ProjectTokenMapOutput{})
}
