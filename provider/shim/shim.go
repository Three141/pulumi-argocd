package shim

import (
	"github.com/argoproj-labs/terraform-provider-argocd/argocd"
	"github.com/hashicorp/terraform-plugin-sdk/v2/helper/schema"
)

func Provider() *schema.Provider {
	provider := argocd.Provider()
	return provider
}
