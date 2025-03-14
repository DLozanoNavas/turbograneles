// <auto-generated/>
#pragma warning disable CS0618
using Italcol.TurboGraneles.Clients.AccessControl.VerifySocial;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Italcol.TurboGraneles.Clients.AccessControl
{
    /// <summary>
    /// Builds and executes requests for operations under \access-control
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AccessControlRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The verifySocial property</summary>
        public global::Italcol.TurboGraneles.Clients.AccessControl.VerifySocial.VerifySocialRequestBuilder VerifySocial
        {
            get => new global::Italcol.TurboGraneles.Clients.AccessControl.VerifySocial.VerifySocialRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Italcol.TurboGraneles.Clients.AccessControl.AccessControlRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccessControlRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/access-control", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Italcol.TurboGraneles.Clients.AccessControl.AccessControlRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccessControlRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/access-control", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
