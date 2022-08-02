
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
  <a href="#run-locally">Run locally</a> •
  <a href="#run-with-docker">Run with Docker</a> •
  <a href="#run-with-kubernetes">Run with Kubernetes</a> •
  <a href="#license">License</a>
</p>

## Key technologies

* Microservices:
  * PlatformService
  * CommandService
* Docker
* K8s
* SQL Server
* RabbitMQ
* gRPC

## Prerequisites
To clone and run this application, you'll need [Git](https://git-scm.com) and [.NET 5.0](https://dotnet.microsoft.com/en-us/download/dotnet/5.0).
<br>
If you want to run the app in a container, you'll need [Docker](https://www.docker.com/products/docker-desktop/) and a [Docker Hub Account](https://hub.docker.com/).

> **Note**
> 
> Make sure you have Docker and Kubernetes installed and running on your machine

From your command line:

```bash
# Clone this repository
$ git clone https://github.com/mishrole/netcore5-microservice.git

# Go into the repository
$ cd netcore5-microservice

# Check your net core version, make sure it's 5.0
$ dotnet --version
```

### Run locally
To run the project locally, run the following commands:

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

### Run with Docker
To run the project with Docker, run the following commands:

```bash
# Go into PlatformService
$ cd PlatformService

# Build and run PlatformService in a container
$ docker build -t <your docker hub id>/platformservice .
$ docker run -p 5001:80 -d <your docker hub id>/platformservice

# Go into CommandService
$ cd CommandService

# Build and run the CommandService in a container
$ docker build -t <your docker hub id>/commandservice .
$ docker run -p 6001:80 -d <your docker hub id>/commandservice

# Check the status of the containers
$ docker ps
```

> **Note**
> 
> You can also check my [Docker Hub Account](https://hub.docker.com/u/mishrole) to see PlatformService and CommandService images.

## Run with Kubernetes
To run the project with Kubernetes, run the following commands:

```bash
# Go into K8S
$ cd K8S

# Apply the platformService and commandService manifests
$ kubectl apply -f platforms-deploy.yaml
$ kubectl apply -f commands-deploy.yaml

# Apply the platformService and commandService services
$ kubectl apply -f platforms-nodeport-service.yaml
$ kubectl apply -f commands-nodeport-service.yaml

# Check the status of the pods
$ kubectl get pods

# Check the status of the deployments
$ kubectl get deployments

# Check the status of the services
$ kubectl get services
```

## License

[MIT](https://choosealicense.com/licenses/mit/)
