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
    public partial class UnidadCargaRecibidaDto : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Cargo agent or consignee</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AgenteCargaConsignatario { get; set; }
#nullable restore
#else
        public string AgenteCargaConsignatario { get; set; }
#endif
        /// <summary>Number of packages</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CantidadBultos { get; set; }
#nullable restore
#else
        public string CantidadBultos { get; set; }
#endif
        /// <summary>Cargo type code</summary>
        public double? CodTipoCarga { get; set; }
        /// <summary>Type of travel document</summary>
        public double? CodTipoDocumentoViaje { get; set; }
        /// <summary>Transport document date</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FechaDocumentoTransporte { get; set; }
#nullable restore
#else
        public string FechaDocumentoTransporte { get; set; }
#endif
        /// <summary>Transport document number</summary>
        public double? NumDocumentoTransporte { get; set; }
        /// <summary>Gross weight in kilograms</summary>
        public double? PesoBrutoKg { get; set; }
        /// <summary>Received cargo units</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Italcol.TurboGraneles.Clients.Models.UnidadDto>? Unidades { get; set; }
#nullable restore
#else
        public List<global::Italcol.TurboGraneles.Clients.Models.UnidadDto> Unidades { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Italcol.TurboGraneles.Clients.Models.UnidadCargaRecibidaDto"/> and sets the default values.
        /// </summary>
        public UnidadCargaRecibidaDto()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Italcol.TurboGraneles.Clients.Models.UnidadCargaRecibidaDto"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Italcol.TurboGraneles.Clients.Models.UnidadCargaRecibidaDto CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Italcol.TurboGraneles.Clients.Models.UnidadCargaRecibidaDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "agenteCargaConsignatario", n => { AgenteCargaConsignatario = n.GetStringValue(); } },
                { "cantidadBultos", n => { CantidadBultos = n.GetStringValue(); } },
                { "codTipoCarga", n => { CodTipoCarga = n.GetDoubleValue(); } },
                { "CodTipoDocumentoViaje", n => { CodTipoDocumentoViaje = n.GetDoubleValue(); } },
                { "fechaDocumentoTransporte", n => { FechaDocumentoTransporte = n.GetStringValue(); } },
                { "numDocumentoTransporte", n => { NumDocumentoTransporte = n.GetDoubleValue(); } },
                { "pesoBrutoKg", n => { PesoBrutoKg = n.GetDoubleValue(); } },
                { "unidades", n => { Unidades = n.GetCollectionOfObjectValues<global::Italcol.TurboGraneles.Clients.Models.UnidadDto>(global::Italcol.TurboGraneles.Clients.Models.UnidadDto.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("agenteCargaConsignatario", AgenteCargaConsignatario);
            writer.WriteStringValue("cantidadBultos", CantidadBultos);
            writer.WriteDoubleValue("codTipoCarga", CodTipoCarga);
            writer.WriteDoubleValue("CodTipoDocumentoViaje", CodTipoDocumentoViaje);
            writer.WriteStringValue("fechaDocumentoTransporte", FechaDocumentoTransporte);
            writer.WriteDoubleValue("numDocumentoTransporte", NumDocumentoTransporte);
            writer.WriteDoubleValue("pesoBrutoKg", PesoBrutoKg);
            writer.WriteCollectionOfObjectValues<global::Italcol.TurboGraneles.Clients.Models.UnidadDto>("unidades", Unidades);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
