// <auto-generated/>
#pragma warning disable CS0618
using Italcol.TurboGraneles.Clients.Scanner.Api;
using Italcol.TurboGraneles.Clients.Scanner.Health;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Italcol.TurboGraneles.Clients.Scanner
{
    /// <summary>
    /// Builds and executes requests for operations under \scanner
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ScannerRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The api property</summary>
        public global::Italcol.TurboGraneles.Clients.Scanner.Api.ApiRequestBuilder Api
        {
            get => new global::Italcol.TurboGraneles.Clients.Scanner.Api.ApiRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The health property</summary>
        public global::Italcol.TurboGraneles.Clients.Scanner.Health.HealthRequestBuilder Health
        {
            get => new global::Italcol.TurboGraneles.Clients.Scanner.Health.HealthRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Italcol.TurboGraneles.Clients.Scanner.ScannerRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScannerRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/scanner", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Italcol.TurboGraneles.Clients.Scanner.ScannerRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScannerRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/scanner", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
