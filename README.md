
<h1 align="center">
  <br>
  .Net Core 5.0 Web API Microservice
  <br>
</h1>

<h4 align="center">
  A simple .Net Core 5.0 Web API Microservice with Docker, K8s, and GRPC
</h4>

<p align="center">
  <a href="#key-features">Key Features</a> •
  <a href="#how-to-use">How To Use</a> •
  <a href="#license">License</a>
</p>

## Key Features

* Microservices:
  * PlatformService
  * CommandsService (GRPC)
* Docker
* K8s

## How To Use

To clone and run this application, you'll need [Git](https://git-scm.com) and [.NET 5.0](https://dotnet.microsoft.com/en-us/download/dotnet/5.0). From your command line:

```bash
# Clone this repository
$ git clone https://github.com/mishrole/netcore5-microservice.git

# Go into the repository
$ cd netcore5-microservice

# Go into a microservice
$ cd PlatformService
# or
$ cd CommandsService

# Check your net core version
$ dotnet --version

# Build the microservice and run it
$ dotnet restore
$ dotnet build
$ dotnet run

```

## License

[MIT](https://choosealicense.com/licenses/mit/)
