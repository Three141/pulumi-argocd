import pulumi
import pulumi_argocd as argocd

provider = argocd.Provider(
    "argocd",
    server_addr="localhost:8080",
    insecure=True,
    username="admin",
    password="12345678",
)

cluster = argocd.Cluster.get(
    "in-cluster",
    "https://kubernetes.default.svc",
    opts=pulumi.ResourceOptions(provider=provider),
)

pulumi.export("clusterName", cluster.name)
pulumi.export("clusterServer", cluster.server)
pulumi.export("clusterConfig", cluster.config)
