// <auto-generated/>
#pragma warning disable CS0618
using Italcol.TurboGraneles.Clients.Api.V1.Auth;
using Italcol.TurboGraneles.Clients.Api.V1.Cafeteros;
using Italcol.TurboGraneles.Clients.Api.V1.Dian;
using Italcol.TurboGraneles.Clients.Api.V1.ElectronicInvoice;
using Italcol.TurboGraneles.Clients.Api.V1.Email;
using Italcol.TurboGraneles.Clients.Api.V1.EmailGroups;
using Italcol.TurboGraneles.Clients.Api.V1.Jobs;
using Italcol.TurboGraneles.Clients.Api.V1.Logs;
using Italcol.TurboGraneles.Clients.Api.V1.Miit;
using Italcol.TurboGraneles.Clients.Api.V1.Mintransporte;
using Italcol.TurboGraneles.Clients.Api.V1.ScaleWeight;
using Italcol.TurboGraneles.Clients.Api.V1.SuperFinanciera;
using Italcol.TurboGraneles.Clients.Api.V1.Users;
using Italcol.TurboGraneles.Clients.Api.V1.Vuce;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Italcol.TurboGraneles.Clients.Api.V1
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class V1RequestBuilder : BaseRequestBuilder
    {
        /// <summary>The auth property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Auth.AuthRequestBuilder Auth
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.Auth.AuthRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cafeteros property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Cafeteros.CafeterosRequestBuilder Cafeteros
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.Cafeteros.CafeterosRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dian property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Dian.DianRequestBuilder Dian
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.Dian.DianRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The electronicInvoice property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.ElectronicInvoice.ElectronicInvoiceRequestBuilder ElectronicInvoice
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.ElectronicInvoice.ElectronicInvoiceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The email property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Email.EmailRequestBuilder Email
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.Email.EmailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The emailGroups property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.EmailGroups.EmailGroupsRequestBuilder EmailGroups
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.EmailGroups.EmailGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The jobs property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Jobs.JobsRequestBuilder Jobs
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.Jobs.JobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The logs property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Logs.LogsRequestBuilder Logs
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.Logs.LogsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The miit property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Miit.MiitRequestBuilder Miit
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.Miit.MiitRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mintransporte property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Mintransporte.MintransporteRequestBuilder Mintransporte
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.Mintransporte.MintransporteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The scaleWeight property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.ScaleWeight.ScaleWeightRequestBuilder ScaleWeight
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.ScaleWeight.ScaleWeightRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The superFinanciera property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.SuperFinanciera.SuperFinancieraRequestBuilder SuperFinanciera
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.SuperFinanciera.SuperFinancieraRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The users property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Users.UsersRequestBuilder Users
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.Users.UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The vuce property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Vuce.VuceRequestBuilder Vuce
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.Vuce.VuceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Italcol.TurboGraneles.Clients.Api.V1.V1RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V1RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Italcol.TurboGraneles.Clients.Api.V1.V1RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V1RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
