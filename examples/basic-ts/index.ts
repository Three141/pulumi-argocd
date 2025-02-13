import * as pulumi from "@pulumi/pulumi";
import * as argocd from "@three14/pulumi-argocd";

const cluster = argocd.Cluster.get(
  "in-cluster",
  "https://kubernetes.default.svc",
);

export const clusterName = cluster.name;
export const clusterServer = cluster.server;
export const clusterConfig = cluster.config;
