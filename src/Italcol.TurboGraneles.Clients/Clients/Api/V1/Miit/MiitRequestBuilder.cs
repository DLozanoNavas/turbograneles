// <auto-generated/>
#pragma warning disable CS0618
using Italcol.TurboGraneles.Clients.Api.V1.Miit.GetAppointmentInformation;
using Italcol.TurboGraneles.Clients.Api.V1.Miit.GetGateIn;
using Italcol.TurboGraneles.Clients.Api.V1.Miit.GetGateOut;
using Italcol.TurboGraneles.Clients.Api.V1.Miit.GetLoadByEachVessel;
using Italcol.TurboGraneles.Clients.Api.V1.Miit.GetVoyageandVessel;
using Italcol.TurboGraneles.Clients.Api.V1.Miit.Health;
using Italcol.TurboGraneles.Clients.Api.V1.Miit.SendCustomsReleasedCargo;
using Italcol.TurboGraneles.Clients.Api.V1.Miit.SendReceiptRecord;
using Italcol.TurboGraneles.Clients.Api.V1.Miit.SendTruckFinalizationLoading;
using Italcol.TurboGraneles.Clients.Api.V1.Miit.SendVesselStatus;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Italcol.TurboGraneles.Clients.Api.V1.Miit
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\miit
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MiitRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The GetAppointmentInformation property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Miit.GetAppointmentInformation.GetAppointmentInformationRequestBuilder GetAppointmentInformation
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.Miit.GetAppointmentInformation.GetAppointmentInformationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The GetGateIn property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Miit.GetGateIn.GetGateInRequestBuilder GetGateIn
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.Miit.GetGateIn.GetGateInRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The GetGateOut property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Miit.GetGateOut.GetGateOutRequestBuilder GetGateOut
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.Miit.GetGateOut.GetGateOutRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The GetLoadByEachVessel property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Miit.GetLoadByEachVessel.GetLoadByEachVesselRequestBuilder GetLoadByEachVessel
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.Miit.GetLoadByEachVessel.GetLoadByEachVesselRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The GetVoyageandVessel property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Miit.GetVoyageandVessel.GetVoyageandVesselRequestBuilder GetVoyageandVessel
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.Miit.GetVoyageandVessel.GetVoyageandVesselRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The health property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Miit.Health.HealthRequestBuilder Health
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.Miit.Health.HealthRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SendCustomsReleasedCargo property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Miit.SendCustomsReleasedCargo.SendCustomsReleasedCargoRequestBuilder SendCustomsReleasedCargo
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.Miit.SendCustomsReleasedCargo.SendCustomsReleasedCargoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SendReceiptRecord property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Miit.SendReceiptRecord.SendReceiptRecordRequestBuilder SendReceiptRecord
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.Miit.SendReceiptRecord.SendReceiptRecordRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SendTruckFinalizationLoading property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Miit.SendTruckFinalizationLoading.SendTruckFinalizationLoadingRequestBuilder SendTruckFinalizationLoading
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.Miit.SendTruckFinalizationLoading.SendTruckFinalizationLoadingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SendVesselStatus property</summary>
        public global::Italcol.TurboGraneles.Clients.Api.V1.Miit.SendVesselStatus.SendVesselStatusRequestBuilder SendVesselStatus
        {
            get => new global::Italcol.TurboGraneles.Clients.Api.V1.Miit.SendVesselStatus.SendVesselStatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Italcol.TurboGraneles.Clients.Api.V1.Miit.MiitRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MiitRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/miit", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Italcol.TurboGraneles.Clients.Api.V1.Miit.MiitRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MiitRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/miit", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
