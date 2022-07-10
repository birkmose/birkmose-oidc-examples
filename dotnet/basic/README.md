# Basic Idp Example

This basic example illustrates how to build an OpenID Connect provider with the ASP.NET Core MVC Framework, using Heimdall as the backend.

## Running the Example

The example can be run using `docker-compose`, which will start all the necessary components to run the example: 

```bash
git clone https://github.com/birkmose/birkmose-oidc-examples.git
cd birkmose-oidc-examples
cd dotnet
cd basic
docker-compose up
```

Once the containers have started (it will take a few seconds the first time you run it, as the dotnet SDK needs to be downloaded, and the example has to be compiled), you can access the example OIDC example in your browser at `http://localhost:3000`.

## Example Structure

The example runs several containers:

* `heimdall`: The Heimdall backend itself. The configuration files for Heimdall are stored in the [HeimdallConfig](./HeimdallConfig) folder.
`oidc_demo_client`: A simple React-based single-page app (SPA), that acts as a public OIDC client that we will use to authenticate our end-user using the Idp Example. The source code for this SPA can be found in the [client/OidcExampleClient](../../client/OidcExampleClient/) folder. Configuration for the SPA OIDC client is stored in the [OidcDemoClientConfig](./OidcDemoClientConfig/) folder.
* `basic_idp_example`: The Basic Idp example itself, programmed using .NET6, and the ASP.NET Core MVC Framework. The source for this example can be found in the [BasicIdpExample](./BasicIdpExample/) folder.
