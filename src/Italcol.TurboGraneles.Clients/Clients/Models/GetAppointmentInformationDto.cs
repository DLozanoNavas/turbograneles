// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Italcol.TurboGraneles.Clients.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class GetAppointmentInformationDto : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>End date and time</summary>
        public DateTimeOffset? DateTimeEnd { get; set; }
        /// <summary>Start date and time</summary>
        public DateTimeOffset? DateTimeStart { get; set; }
        /// <summary>Destination code</summary>
        public double? DestinationCode { get; set; }
        /// <summary>Driver identifier</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DriverId { get; set; }
#nullable restore
#else
        public string DriverId { get; set; }
#endif
        /// <summary>Driver name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DriverName { get; set; }
#nullable restore
#else
        public string DriverName { get; set; }
#endif
        /// <summary>Maximum weight permitted</summary>
        public double? MaxWeightPermitted { get; set; }
        /// <summary>Bill of Lading number in the TOS</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NoBl { get; set; }
#nullable restore
#else
        public string NoBl { get; set; }
#endif
        /// <summary>Product identifier</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Product { get; set; }
#nullable restore
#else
        public string Product { get; set; }
#endif
        /// <summary>Status of the transport</summary>
        public double? Status { get; set; }
        /// <summary>Transport identifier</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransportId { get; set; }
#nullable restore
#else
        public string TransportId { get; set; }
#endif
        /// <summary>Truck plate number</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TruckPlate { get; set; }
#nullable restore
#else
        public string TruckPlate { get; set; }
#endif
        /// <summary>Vessel voyage from TOS</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Voyage { get; set; }
#nullable restore
#else
        public string Voyage { get; set; }
#endif
        /// <summary>Weight required</summary>
        public double? WeightRequired { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Italcol.TurboGraneles.Clients.Models.GetAppointmentInformationDto"/> and sets the default values.
        /// </summary>
        public GetAppointmentInformationDto()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Italcol.TurboGraneles.Clients.Models.GetAppointmentInformationDto"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Italcol.TurboGraneles.Clients.Models.GetAppointmentInformationDto CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Italcol.TurboGraneles.Clients.Models.GetAppointmentInformationDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "dateTimeEnd", n => { DateTimeEnd = n.GetDateTimeOffsetValue(); } },
                { "dateTimeStart", n => { DateTimeStart = n.GetDateTimeOffsetValue(); } },
                { "destinationCode", n => { DestinationCode = n.GetDoubleValue(); } },
                { "driverId", n => { DriverId = n.GetStringValue(); } },
                { "driverName", n => { DriverName = n.GetStringValue(); } },
                { "maxWeightPermitted", n => { MaxWeightPermitted = n.GetDoubleValue(); } },
                { "noBl", n => { NoBl = n.GetStringValue(); } },
                { "product", n => { Product = n.GetStringValue(); } },
                { "status", n => { Status = n.GetDoubleValue(); } },
                { "transportId", n => { TransportId = n.GetStringValue(); } },
                { "truckPlate", n => { TruckPlate = n.GetStringValue(); } },
                { "voyage", n => { Voyage = n.GetStringValue(); } },
                { "weightRequired", n => { WeightRequired = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("dateTimeEnd", DateTimeEnd);
            writer.WriteDateTimeOffsetValue("dateTimeStart", DateTimeStart);
            writer.WriteDoubleValue("destinationCode", DestinationCode);
            writer.WriteStringValue("driverId", DriverId);
            writer.WriteStringValue("driverName", DriverName);
            writer.WriteDoubleValue("maxWeightPermitted", MaxWeightPermitted);
            writer.WriteStringValue("noBl", NoBl);
            writer.WriteStringValue("product", Product);
            writer.WriteDoubleValue("status", Status);
            writer.WriteStringValue("transportId", TransportId);
            writer.WriteStringValue("truckPlate", TruckPlate);
            writer.WriteStringValue("voyage", Voyage);
            writer.WriteDoubleValue("weightRequired", WeightRequired);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
