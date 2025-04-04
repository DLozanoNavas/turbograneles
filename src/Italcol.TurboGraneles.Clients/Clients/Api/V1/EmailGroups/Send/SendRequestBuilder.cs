// <auto-generated/>
#pragma warning disable CS0618
using Italcol.TurboGraneles.Clients.Api.V1.EmailGroups.Send.Item;
using Italcol.TurboGraneles.Clients.Api.V1.EmailGroups.Send.ProcessState;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Italcol.TurboGraneles.Clients.Api.V1.EmailGroups.Send
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\email-groups\send
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SendRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The processState property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.EmailGroups.Send.ProcessState.ProcessStateRequestBuilder ProcessState
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.EmailGroups.Send.ProcessState.ProcessStateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Italcol.TurboGraneles.Clients.api.v1.emailGroups.send.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Italcol.TurboGraneles.Clients.Api.V1.EmailGroups.Send.Item.WithGroupItemRequestBuilder"/></returns>
        public global::Italcol.TurboGraneles.Clients.Api.V1.EmailGroups.Send.Item.WithGroupItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("groupId", position);
                return new global::Italcol.TurboGraneles.Clients.Api.V1.EmailGroups.Send.Item.WithGroupItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Italcol.TurboGraneles.Clients.Api.V1.EmailGroups.Send.SendRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SendRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/email-groups/send", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Italcol.TurboGraneles.Clients.Api.V1.EmailGroups.Send.SendRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SendRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/email-groups/send", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
