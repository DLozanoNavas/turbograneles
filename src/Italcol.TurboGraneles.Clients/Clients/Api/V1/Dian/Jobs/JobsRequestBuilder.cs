// <auto-generated/>
#pragma warning disable CS0618
using Italcol.TurboGraneles.Clients.Api.V1.Dian.Jobs.StartDianJob;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Italcol.TurboGraneles.Clients.Api.V1.Dian.Jobs
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\dian\jobs
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class JobsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The startDianJob property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Dian.Jobs.StartDianJob.StartDianJobRequestBuilder StartDianJob
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.Dian.Jobs.StartDianJob.StartDianJobRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Italcol.TurboGraneles.Clients.Api.V1.Dian.Jobs.JobsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public JobsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dian/jobs", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Italcol.TurboGraneles.Clients.Api.V1.Dian.Jobs.JobsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public JobsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dian/jobs", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
