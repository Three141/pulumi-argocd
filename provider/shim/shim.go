package shim

import (
	"github.com/argoproj-labs/terraform-provider-argocd/internal/provider"
	pfprovider "github.com/hashicorp/terraform-plugin-framework/provider"
)

func Provider(version string) *pfprovider.Provider {
	provider := provider.New(version)
	return &provider
}
