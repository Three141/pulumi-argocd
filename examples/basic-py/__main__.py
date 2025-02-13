import pulumi
import pulumi_argocd as argocd

cluster = argocd.Cluster.get(
    "in-cluster",
    "https://kubernetes.default.svc",
)

pulumi.export("clusterName", cluster.name)
pulumi.export("clusterServer", cluster.server)
pulumi.export("clusterConfig", cluster.config)
