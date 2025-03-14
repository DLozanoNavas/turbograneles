// <auto-generated/>
#pragma warning disable CS0618
using Italcol.TurboGraneles.Clients.Api.V1.Dian.ConsultManifest.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Italcol.TurboGraneles.Clients.Api.V1.Dian.ConsultManifest
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\dian\consult-manifest
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ConsultManifestRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Italcol.TurboGraneles.Clients.api.v1.dian.consultManifest.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Italcol.TurboGraneles.Clients.Api.V1.Dian.ConsultManifest.Item.WithManifiestoItemRequestBuilder"/></returns>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Dian.ConsultManifest.Item.WithManifiestoItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("manifiesto", position);
                return new global::Italcol.TurboGraneles.Clients.Api.V1.Dian.ConsultManifest.Item.WithManifiestoItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Italcol.TurboGraneles.Clients.Api.V1.Dian.ConsultManifest.ConsultManifestRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConsultManifestRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dian/consult-manifest", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Italcol.TurboGraneles.Clients.Api.V1.Dian.ConsultManifest.ConsultManifestRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConsultManifestRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dian/consult-manifest", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
