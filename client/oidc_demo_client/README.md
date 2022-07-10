# OIDC Demo Client

The OIDC demo client, is a simple React-based single-page app (SPA), acting as a public OIDC client that we will use to authenticate our end-users using the various Idp example in this repo.

## Client Configuration

The OIDC client configuration details for the single-page app, are stored in the [public/config/env.js](./public/config/env.js) file. 

### Docker
The examples in this repo use a pre-built docker images, based on the React code in this folder, and can be accessed using the `birkmose/oidc-demo-client` tag. When running this 