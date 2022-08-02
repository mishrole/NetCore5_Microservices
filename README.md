
<h1 align="center">
  <br>
  .Net Core 5.0 Web API Microservice
  <br>
</h1>

<h4 align="center">
  A simple .Net Core 5.0 Web API Microservice with Docker, K8s, SQL Server, RabbitMQ and gRPC
</h4>

<p align="center">
  <a href="#key-technologies">Key technologies</a> •
  <a href="#prerequisites">Prerequisites</a> •
  <a href="#test-independently">Test Independently</a> •
  <a href="#run-with-kubernetes">Run with Kubernetes</a> •
  <a href="#license">License</a>
</p>

## Key technologies

* Microservices:
  * PlatformService
  * CommandService
* Docker
* K8s
* Ingress Nginx
* SQL Server
* RabbitMQ
* gRPC

## Prerequisites
To clone and run this application, you'll need [Git](https://git-scm.com) and [.NET 5.0](https://dotnet.microsoft.com/en-us/download/dotnet/5.0).
<br>
If you want to run the app in a container, you'll need [Docker](https://www.docker.com/products/docker-desktop/) and a [Docker Hub Account](https://hub.docker.com/).
<br>
Also, you'll need to check out [Ingress Nginx](https://github.com/kubernetes/ingress-nginx) LoadBalancer and [gRPC](https://grpc.io/).

> **Note**
> 
> Make sure you have Docker installed and running on your machine. Don't forget to [enable Kubernetes on Docker Desktop](https://docs.docker.com/docker-desktop/kubernetes/).
> 
> Depending on your OS, you'll need to install [Kubernetes](https://kubernetes.io/) and [Kubectl](https://kubectl.io/).

From your command line:

```bash
# Clone this repository
$ git clone https://github.com/mishrole/netcore5-microservice.git

# Go into the repository
$ cd netcore5-microservice

# Check your net core version, make sure it's 5.0
$ dotnet --version
```

## Test independently

### Locally
To test each service locally, run the following commands:

```bash
# Go into a service
$ cd PlatformService
# or
$ cd CommandService

# Build and run it
$ dotnet restore
$ dotnet build
$ dotnet run
```

> **Note**
> 
> To stop the app, press Ctrl+C

### Docker
To test each service with Docker, run the following commands:

```bash
# Go into PlatformService
$ cd PlatformService

# Build and run PlatformService in a container
$ docker build -t <your Docker Hub Id>/platformservice .
$ docker run -p 5001:80 -d <your Docker Hub Id>/platformservice

# Go into CommandService
$ cd CommandService

# Build and run the CommandService in a container
$ docker build -t <your Docker Hub Id>/commandservice .
$ docker run -p 6001:80 -d <your Docker Hub Id>/commandservice

# Check the status of the containers
$ docker ps
```

> **Note**
> 
> You can also check [my Docker Hub account](https://hub.docker.com/u/mishrole) to see PlatformService and CommandService images.

## Run with Kubernetes
To run the project with Kubernetes, run the following commands:

```bash
# Go into K8S
$ cd K8S

# Apply the platformService and commandService manifests
$ kubectl apply -f platforms-deploy.yaml
$ kubectl apply -f commands-deploy.yaml

# Apply the platformService NodePort service
$ kubectl apply -f platforms-nodeport-service.yaml

# Check the status of the pods
$ kubectl get pods

# Check the status of the deployments
$ kubectl get deployments

# Check the status of the services
$ kubectl get services

# Get Ingress Nginx Controller
$ kubectl apply -f https://raw.githubusercontent.com/kubernetes/ingress-nginx/controller-v1.3.0/deploy/static/provider/cloud/deploy.yaml

# Check Ingress Nginx pods
$ kubectl get namespaces
$ kubectl get pods --namespace ingress-nginx

```

> **Note**
> 
> If you make changes to an image and push it to the Docker Hub, you'll need to update and apply the K8S manifest, and rollout the active deployment to use latest image.
>
> Apply the manifest:
>
> ```$ kubectl apply -f platforms-deploy.yaml```
>
> Rollout the active deployment:
>
> ```$ kubectl rollout restart deployment platforms-deploy```

## License

[MIT](https://choosealicense.com/licenses/mit/)
