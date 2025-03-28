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
    public partial class GetGateOutDto : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Cargo weight</summary>
        public double? CargoWeight { get; set; }
        /// <summary>Departure date and time</summary>
        public DateTimeOffset? DepartureDateTime { get; set; }
        /// <summary>Truck gross weight</summary>
        public double? TruckGrossWeight { get; set; }
        /// <summary>Truck plate number</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TruckPlate { get; set; }
#nullable restore
#else
        public string TruckPlate { get; set; }
#endif
        /// <summary>Truck transaction identifier</summary>
        public double? TruckTransaction { get; set; }
        /// <summary>Weight bridge identifier</summary>
        public double? WeightBridgeId { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Italcol.TurboGraneles.Clients.Models.GetGateOutDto"/> and sets the default values.
        /// </summary>
        public GetGateOutDto()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Italcol.TurboGraneles.Clients.Models.GetGateOutDto"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Italcol.TurboGraneles.Clients.Models.GetGateOutDto CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Italcol.TurboGraneles.Clients.Models.GetGateOutDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "cargoWeight", n => { CargoWeight = n.GetDoubleValue(); } },
                { "departureDateTime", n => { DepartureDateTime = n.GetDateTimeOffsetValue(); } },
                { "truckGrossWeight", n => { TruckGrossWeight = n.GetDoubleValue(); } },
                { "truckPlate", n => { TruckPlate = n.GetStringValue(); } },
                { "truckTransaction", n => { TruckTransaction = n.GetDoubleValue(); } },
                { "weightBridgeId", n => { WeightBridgeId = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("cargoWeight", CargoWeight);
            writer.WriteDateTimeOffsetValue("departureDateTime", DepartureDateTime);
            writer.WriteDoubleValue("truckGrossWeight", TruckGrossWeight);
            writer.WriteStringValue("truckPlate", TruckPlate);
            writer.WriteDoubleValue("truckTransaction", TruckTransaction);
            writer.WriteDoubleValue("weightBridgeId", WeightBridgeId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
