
<h1 align="center">
  <br>
  .Net Core 5.0 Web API Microservice
  <br>
</h1>

<h4 align="center">
  A simple .Net Core 5.0 Web API Microservice with Docker, K8s, and GRPC
</h4>

<p align="center">
  <a href="#key-technologies">Key technologies</a> •
  <a href="#prerequisites">Prerequisites</a> •
  <a href="#run-locally">Run locally</a> •
  <a href="#run-in-a-container">Run in a container</a> •
  <a href="#license">License</a>
</p>

## Key technologies

* Microservices:
  * PlatformService
  * CommandsService
* GRPC
* Docker
* K8s

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

```bash
# Go into a service
$ cd PlatformService
# or
$ cd CommandsService

# Build and run it
$ dotnet restore
$ dotnet build
$ dotnet run
```

> **Note**
> 
> To stop the app, press Ctrl+C

### Run in a container

```bash
# Go into PlatformService
$ cd PlatformService

# Build and run PlatformService in a container
$ docker build -t <your docker hub id>/platformservice .
$ docker run -p 5001:80 -d <your docker hub id>/platformservice

# Go into CommandsService
$ cd CommandsService

# Build and run the CommandsService in a container
$ docker build -t <your docker hub id>/commandsservice .
$ docker run -p 5002:80 -d <your docker hub id>/commandsservice

# Check the status of the containers
$ docker ps
```

## License

[MIT](https://choosealicense.com/licenses/mit/)
