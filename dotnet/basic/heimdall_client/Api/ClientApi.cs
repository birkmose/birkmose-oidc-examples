/*
 * Heimdall
 *
 * # Introduction    The Heimdall backchannel API is a [RESTful](https://wikipedia.org/wiki/Representational_state_transfer) API that allows you to do authorizations, manage sessions, do CRUD on various objects, etc.          
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using heimdall_client.Client;
using heimdall_client.Model;

namespace heimdall_client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IClientApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete client
        /// </summary>
        /// <remarks>
        /// CRUD operation to delete a client.
        /// </remarks>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client Id</param>
        /// <returns></returns>
        void ClientDelete(string clientId);

        /// <summary>
        /// Delete client
        /// </summary>
        /// <remarks>
        /// CRUD operation to delete a client.
        /// </remarks>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ClientDeleteWithHttpInfo(string clientId);
        /// <summary>
        /// Get all clients
        /// </summary>
        /// <remarks>
        /// CRUD operation to read all OAuth2/OIDC clients.
        /// </remarks>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;ModelClient&gt;</returns>
        List<ModelClient> Clients();

        /// <summary>
        /// Get all clients
        /// </summary>
        /// <remarks>
        /// CRUD operation to read all OAuth2/OIDC clients.
        /// </remarks>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;ModelClient&gt;</returns>
        ApiResponse<List<ModelClient>> ClientsWithHttpInfo();
        /// <summary>
        /// Save client
        /// </summary>
        /// <remarks>
        /// CRUD operation to save an OAuth2/OIDC client.
        /// </remarks>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient"></param>
        /// <returns></returns>
        void CreateClient(ModelClient modelClient);

        /// <summary>
        /// Save client
        /// </summary>
        /// <remarks>
        /// CRUD operation to save an OAuth2/OIDC client.
        /// </remarks>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CreateClientWithHttpInfo(ModelClient modelClient);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IClientApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Delete client
        /// </summary>
        /// <remarks>
        /// CRUD operation to delete a client.
        /// </remarks>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client Id</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ClientDeleteAsync(string clientId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete client
        /// </summary>
        /// <remarks>
        /// CRUD operation to delete a client.
        /// </remarks>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client Id</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ClientDeleteWithHttpInfoAsync(string clientId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get all clients
        /// </summary>
        /// <remarks>
        /// CRUD operation to read all OAuth2/OIDC clients.
        /// </remarks>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ModelClient&gt;</returns>
        System.Threading.Tasks.Task<List<ModelClient>> ClientsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get all clients
        /// </summary>
        /// <remarks>
        /// CRUD operation to read all OAuth2/OIDC clients.
        /// </remarks>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ModelClient&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ModelClient>>> ClientsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Save client
        /// </summary>
        /// <remarks>
        /// CRUD operation to save an OAuth2/OIDC client.
        /// </remarks>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CreateClientAsync(ModelClient modelClient, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Save client
        /// </summary>
        /// <remarks>
        /// CRUD operation to save an OAuth2/OIDC client.
        /// </remarks>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateClientWithHttpInfoAsync(ModelClient modelClient, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IClientApi : IClientApiSync, IClientApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ClientApi : IClientApi
    {
        private heimdall_client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ClientApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ClientApi(string basePath)
        {
            this.Configuration = heimdall_client.Client.Configuration.MergeConfigurations(
                heimdall_client.Client.GlobalConfiguration.Instance,
                new heimdall_client.Client.Configuration { BasePath = basePath }
            );
            this.Client = new heimdall_client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new heimdall_client.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = heimdall_client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ClientApi(heimdall_client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = heimdall_client.Client.Configuration.MergeConfigurations(
                heimdall_client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new heimdall_client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new heimdall_client.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = heimdall_client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ClientApi(heimdall_client.Client.ISynchronousClient client, heimdall_client.Client.IAsynchronousClient asyncClient, heimdall_client.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = heimdall_client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public heimdall_client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public heimdall_client.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public heimdall_client.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public heimdall_client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Delete client CRUD operation to delete a client.
        /// </summary>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client Id</param>
        /// <returns></returns>
        public void ClientDelete(string clientId)
        {
            ClientDeleteWithHttpInfo(clientId);
        }

        /// <summary>
        /// Delete client CRUD operation to delete a client.
        /// </summary>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public heimdall_client.Client.ApiResponse<Object> ClientDeleteWithHttpInfo(string clientId)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
            {
                throw new heimdall_client.Client.ApiException(400, "Missing required parameter 'clientId' when calling ClientApi->ClientDelete");
            }

            heimdall_client.Client.RequestOptions localVarRequestOptions = new heimdall_client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = heimdall_client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = heimdall_client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("client_id", heimdall_client.Client.ClientUtils.ParameterToString(clientId)); // path parameter

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-KEY")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-KEY", this.Configuration.GetApiKeyWithPrefix("X-API-KEY"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/clients/{client_id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ClientDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete client CRUD operation to delete a client.
        /// </summary>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client Id</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ClientDeleteAsync(string clientId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ClientDeleteWithHttpInfoAsync(clientId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete client CRUD operation to delete a client.
        /// </summary>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client Id</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<heimdall_client.Client.ApiResponse<Object>> ClientDeleteWithHttpInfoAsync(string clientId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
            {
                throw new heimdall_client.Client.ApiException(400, "Missing required parameter 'clientId' when calling ClientApi->ClientDelete");
            }


            heimdall_client.Client.RequestOptions localVarRequestOptions = new heimdall_client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = heimdall_client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = heimdall_client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("client_id", heimdall_client.Client.ClientUtils.ParameterToString(clientId)); // path parameter

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-KEY")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-KEY", this.Configuration.GetApiKeyWithPrefix("X-API-KEY"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/clients/{client_id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ClientDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all clients CRUD operation to read all OAuth2/OIDC clients.
        /// </summary>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;ModelClient&gt;</returns>
        public List<ModelClient> Clients()
        {
            heimdall_client.Client.ApiResponse<List<ModelClient>> localVarResponse = ClientsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all clients CRUD operation to read all OAuth2/OIDC clients.
        /// </summary>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;ModelClient&gt;</returns>
        public heimdall_client.Client.ApiResponse<List<ModelClient>> ClientsWithHttpInfo()
        {
            heimdall_client.Client.RequestOptions localVarRequestOptions = new heimdall_client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = heimdall_client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = heimdall_client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-KEY")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-KEY", this.Configuration.GetApiKeyWithPrefix("X-API-KEY"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<ModelClient>>("/clients", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Clients", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all clients CRUD operation to read all OAuth2/OIDC clients.
        /// </summary>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ModelClient&gt;</returns>
        public async System.Threading.Tasks.Task<List<ModelClient>> ClientsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            heimdall_client.Client.ApiResponse<List<ModelClient>> localVarResponse = await ClientsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all clients CRUD operation to read all OAuth2/OIDC clients.
        /// </summary>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ModelClient&gt;)</returns>
        public async System.Threading.Tasks.Task<heimdall_client.Client.ApiResponse<List<ModelClient>>> ClientsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            heimdall_client.Client.RequestOptions localVarRequestOptions = new heimdall_client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = heimdall_client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = heimdall_client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-KEY")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-KEY", this.Configuration.GetApiKeyWithPrefix("X-API-KEY"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<ModelClient>>("/clients", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Clients", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save client CRUD operation to save an OAuth2/OIDC client.
        /// </summary>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient"></param>
        /// <returns></returns>
        public void CreateClient(ModelClient modelClient)
        {
            CreateClientWithHttpInfo(modelClient);
        }

        /// <summary>
        /// Save client CRUD operation to save an OAuth2/OIDC client.
        /// </summary>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public heimdall_client.Client.ApiResponse<Object> CreateClientWithHttpInfo(ModelClient modelClient)
        {
            // verify the required parameter 'modelClient' is set
            if (modelClient == null)
            {
                throw new heimdall_client.Client.ApiException(400, "Missing required parameter 'modelClient' when calling ClientApi->CreateClient");
            }

            heimdall_client.Client.RequestOptions localVarRequestOptions = new heimdall_client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = heimdall_client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = heimdall_client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = modelClient;

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-KEY")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-KEY", this.Configuration.GetApiKeyWithPrefix("X-API-KEY"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/client", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateClient", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save client CRUD operation to save an OAuth2/OIDC client.
        /// </summary>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CreateClientAsync(ModelClient modelClient, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await CreateClientWithHttpInfoAsync(modelClient, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Save client CRUD operation to save an OAuth2/OIDC client.
        /// </summary>
        /// <exception cref="heimdall_client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<heimdall_client.Client.ApiResponse<Object>> CreateClientWithHttpInfoAsync(ModelClient modelClient, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'modelClient' is set
            if (modelClient == null)
            {
                throw new heimdall_client.Client.ApiException(400, "Missing required parameter 'modelClient' when calling ClientApi->CreateClient");
            }


            heimdall_client.Client.RequestOptions localVarRequestOptions = new heimdall_client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = heimdall_client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = heimdall_client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = modelClient;

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-KEY")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-KEY", this.Configuration.GetApiKeyWithPrefix("X-API-KEY"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/client", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateClient", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
