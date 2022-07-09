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
using HeimdallClient.Client;
using HeimdallClient.Model;

namespace HeimdallClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IScopeApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Save scope
        /// </summary>
        /// <remarks>
        /// CRUD operation to save a scope that can be requested by client applications.
        /// </remarks>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <returns></returns>
        void SaveScope(Scope scope);

        /// <summary>
        /// Save scope
        /// </summary>
        /// <remarks>
        /// CRUD operation to save a scope that can be requested by client applications.
        /// </remarks>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SaveScopeWithHttpInfo(Scope scope);
        /// <summary>
        /// Delete scope
        /// </summary>
        /// <remarks>
        /// CRUD operation to delete a scope.
        /// </remarks>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Name of scope to delete</param>
        /// <returns></returns>
        void ScopeDelete(string scope);

        /// <summary>
        /// Delete scope
        /// </summary>
        /// <remarks>
        /// CRUD operation to delete a scope.
        /// </remarks>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Name of scope to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ScopeDeleteWithHttpInfo(string scope);
        /// <summary>
        /// Get all scopes
        /// </summary>
        /// <remarks>
        /// CRUD operation to read all scopes that can be requested by client applications.
        /// </remarks>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Scope&gt;</returns>
        List<Scope> Scopes();

        /// <summary>
        /// Get all scopes
        /// </summary>
        /// <remarks>
        /// CRUD operation to read all scopes that can be requested by client applications.
        /// </remarks>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Scope&gt;</returns>
        ApiResponse<List<Scope>> ScopesWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IScopeApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Save scope
        /// </summary>
        /// <remarks>
        /// CRUD operation to save a scope that can be requested by client applications.
        /// </remarks>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SaveScopeAsync(Scope scope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Save scope
        /// </summary>
        /// <remarks>
        /// CRUD operation to save a scope that can be requested by client applications.
        /// </remarks>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SaveScopeWithHttpInfoAsync(Scope scope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Delete scope
        /// </summary>
        /// <remarks>
        /// CRUD operation to delete a scope.
        /// </remarks>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Name of scope to delete</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ScopeDeleteAsync(string scope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete scope
        /// </summary>
        /// <remarks>
        /// CRUD operation to delete a scope.
        /// </remarks>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Name of scope to delete</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ScopeDeleteWithHttpInfoAsync(string scope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get all scopes
        /// </summary>
        /// <remarks>
        /// CRUD operation to read all scopes that can be requested by client applications.
        /// </remarks>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Scope&gt;</returns>
        System.Threading.Tasks.Task<List<Scope>> ScopesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get all scopes
        /// </summary>
        /// <remarks>
        /// CRUD operation to read all scopes that can be requested by client applications.
        /// </remarks>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Scope&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Scope>>> ScopesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IScopeApi : IScopeApiSync, IScopeApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ScopeApi : IScopeApi
    {
        private HeimdallClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ScopeApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ScopeApi(string basePath)
        {
            this.Configuration = HeimdallClient.Client.Configuration.MergeConfigurations(
                HeimdallClient.Client.GlobalConfiguration.Instance,
                new HeimdallClient.Client.Configuration { BasePath = basePath }
            );
            this.Client = new HeimdallClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new HeimdallClient.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = HeimdallClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ScopeApi(HeimdallClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = HeimdallClient.Client.Configuration.MergeConfigurations(
                HeimdallClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new HeimdallClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new HeimdallClient.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = HeimdallClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopeApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ScopeApi(HeimdallClient.Client.ISynchronousClient client, HeimdallClient.Client.IAsynchronousClient asyncClient, HeimdallClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = HeimdallClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public HeimdallClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public HeimdallClient.Client.ISynchronousClient Client { get; set; }

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
        public HeimdallClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public HeimdallClient.Client.ExceptionFactory ExceptionFactory
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
        /// Save scope CRUD operation to save a scope that can be requested by client applications.
        /// </summary>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <returns></returns>
        public void SaveScope(Scope scope)
        {
            SaveScopeWithHttpInfo(scope);
        }

        /// <summary>
        /// Save scope CRUD operation to save a scope that can be requested by client applications.
        /// </summary>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public HeimdallClient.Client.ApiResponse<Object> SaveScopeWithHttpInfo(Scope scope)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
            {
                throw new HeimdallClient.Client.ApiException(400, "Missing required parameter 'scope' when calling ScopeApi->SaveScope");
            }

            HeimdallClient.Client.RequestOptions localVarRequestOptions = new HeimdallClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = HeimdallClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = HeimdallClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = scope;

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-KEY")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-KEY", this.Configuration.GetApiKeyWithPrefix("X-API-KEY"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/scope", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SaveScope", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save scope CRUD operation to save a scope that can be requested by client applications.
        /// </summary>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SaveScopeAsync(Scope scope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await SaveScopeWithHttpInfoAsync(scope, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Save scope CRUD operation to save a scope that can be requested by client applications.
        /// </summary>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<HeimdallClient.Client.ApiResponse<Object>> SaveScopeWithHttpInfoAsync(Scope scope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
            {
                throw new HeimdallClient.Client.ApiException(400, "Missing required parameter 'scope' when calling ScopeApi->SaveScope");
            }


            HeimdallClient.Client.RequestOptions localVarRequestOptions = new HeimdallClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = HeimdallClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = HeimdallClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = scope;

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-KEY")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-KEY", this.Configuration.GetApiKeyWithPrefix("X-API-KEY"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/scope", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SaveScope", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete scope CRUD operation to delete a scope.
        /// </summary>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Name of scope to delete</param>
        /// <returns></returns>
        public void ScopeDelete(string scope)
        {
            ScopeDeleteWithHttpInfo(scope);
        }

        /// <summary>
        /// Delete scope CRUD operation to delete a scope.
        /// </summary>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Name of scope to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public HeimdallClient.Client.ApiResponse<Object> ScopeDeleteWithHttpInfo(string scope)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
            {
                throw new HeimdallClient.Client.ApiException(400, "Missing required parameter 'scope' when calling ScopeApi->ScopeDelete");
            }

            HeimdallClient.Client.RequestOptions localVarRequestOptions = new HeimdallClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = HeimdallClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = HeimdallClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("scope", HeimdallClient.Client.ClientUtils.ParameterToString(scope)); // path parameter

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-KEY")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-KEY", this.Configuration.GetApiKeyWithPrefix("X-API-KEY"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/scopes/{scope}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ScopeDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete scope CRUD operation to delete a scope.
        /// </summary>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Name of scope to delete</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ScopeDeleteAsync(string scope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ScopeDeleteWithHttpInfoAsync(scope, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete scope CRUD operation to delete a scope.
        /// </summary>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Name of scope to delete</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<HeimdallClient.Client.ApiResponse<Object>> ScopeDeleteWithHttpInfoAsync(string scope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
            {
                throw new HeimdallClient.Client.ApiException(400, "Missing required parameter 'scope' when calling ScopeApi->ScopeDelete");
            }


            HeimdallClient.Client.RequestOptions localVarRequestOptions = new HeimdallClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = HeimdallClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = HeimdallClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("scope", HeimdallClient.Client.ClientUtils.ParameterToString(scope)); // path parameter

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-KEY")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-KEY", this.Configuration.GetApiKeyWithPrefix("X-API-KEY"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/scopes/{scope}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ScopeDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all scopes CRUD operation to read all scopes that can be requested by client applications.
        /// </summary>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Scope&gt;</returns>
        public List<Scope> Scopes()
        {
            HeimdallClient.Client.ApiResponse<List<Scope>> localVarResponse = ScopesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all scopes CRUD operation to read all scopes that can be requested by client applications.
        /// </summary>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Scope&gt;</returns>
        public HeimdallClient.Client.ApiResponse<List<Scope>> ScopesWithHttpInfo()
        {
            HeimdallClient.Client.RequestOptions localVarRequestOptions = new HeimdallClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = HeimdallClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = HeimdallClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
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
            var localVarResponse = this.Client.Get<List<Scope>>("/scopes", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Scopes", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all scopes CRUD operation to read all scopes that can be requested by client applications.
        /// </summary>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Scope&gt;</returns>
        public async System.Threading.Tasks.Task<List<Scope>> ScopesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            HeimdallClient.Client.ApiResponse<List<Scope>> localVarResponse = await ScopesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all scopes CRUD operation to read all scopes that can be requested by client applications.
        /// </summary>
        /// <exception cref="HeimdallClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Scope&gt;)</returns>
        public async System.Threading.Tasks.Task<HeimdallClient.Client.ApiResponse<List<Scope>>> ScopesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            HeimdallClient.Client.RequestOptions localVarRequestOptions = new HeimdallClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = HeimdallClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = HeimdallClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Scope>>("/scopes", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Scopes", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}