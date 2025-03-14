// <auto-generated/>
#pragma warning disable CS0618
using Italcol.TurboGraneles.Clients.Api.V1.Cafeteros.Health;
using Italcol.TurboGraneles.Clients.Api.V1.Cafeteros.WeighingToSap;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Italcol.TurboGraneles.Clients.Api.V1.Cafeteros
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\cafeteros
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CafeterosRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The health property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Cafeteros.Health.HealthRequestBuilder Health
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.Cafeteros.Health.HealthRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The weighingToSap property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Cafeteros.WeighingToSap.WeighingToSapRequestBuilder WeighingToSap
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.Cafeteros.WeighingToSap.WeighingToSapRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Italcol.TurboGraneles.Clients.Api.V1.Cafeteros.CafeterosRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CafeterosRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/cafeteros", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Italcol.TurboGraneles.Clients.Api.V1.Cafeteros.CafeterosRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CafeterosRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/cafeteros", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
