import * as pulumi from "@pulumi/pulumi";
import * as argocd from "@three14/pulumi-argocd";

const provider = new argocd.Provider("argocd", {
  serverAddr: "localhost:8080",
  insecure: true,
  username: "admin",
  password: "12345678",
});

const cluster = argocd.Cluster.get(
  "in-cluster",
  "https://kubernetes.default.svc",
  {},
  { provider }
);

export const clusterName = cluster.name;
export const clusterServer = cluster.server;
export const clusterConfig = cluster.config;
