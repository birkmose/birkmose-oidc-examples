# Basic Idp Example

This basic example illustrates how to build an OpenID Connect provider with the ASP.NET Core MVC Framework, using Heimdall as the backend.

## Running the Example

The example can be run using `docker-compose`, which will start all the necessary components to run the example: 

```bash
docker-compose up
```

Once the containers have started, you can access the example OIDC example in your browser at `http://localhost:3000`.

## Example Structure

The example runs several containers:

* `heimdall`, which is the Heimdall backend itself. The configuration files for Heimdall are stored in the [HeimdallConfig](./HeimdallConfig) folder.
