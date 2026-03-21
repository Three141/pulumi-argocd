package shim

import (
	"github.com/argoproj-labs/terraform-provider-argocd/argocd"
	argocdPF "github.com/argoproj-labs/terraform-provider-argocd/internal/provider"
	pfProvider "github.com/hashicorp/terraform-plugin-framework/provider"
	"github.com/hashicorp/terraform-plugin-sdk/v2/helper/schema"
)

func Provider() *schema.Provider {
	provider := argocd.Provider()
	return provider
}

func PFProvider(version string) pfProvider.Provider {
	provider := argocdPF.New(version)
	return provider
}
