// <auto-generated/>
#pragma warning disable CS0618
using Italcol.TurboGraneles.Clients.Api.V1.SuperFinanciera.ErpUpdateCurrencyRate.Item.Item.Item.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Italcol.TurboGraneles.Clients.Api.V1.SuperFinanciera.ErpUpdateCurrencyRate.Item.Item.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\super-financiera\erp-update-currency-rate\{company}\{currencyType}\{currencyCode}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithCurrencyCodeItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Italcol.TurboGraneles.Clients.api.v1.superFinanciera.erpUpdateCurrencyRate.item.item.item.item collection</summary>
        /// <param name="position">Valid from date (e.g., 2024-10-26)</param>
        /// <returns>A <see cref="global::Italcol.TurboGraneles.Clients.Api.V1.SuperFinanciera.ErpUpdateCurrencyRate.Item.Item.Item.Item.WithValidFromItemRequestBuilder"/></returns>
        public global::Italcol.TurboGraneles.Clients.Api.V1.SuperFinanciera.ErpUpdateCurrencyRate.Item.Item.Item.Item.WithValidFromItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("validFrom", position);
                return new global::Italcol.TurboGraneles.Clients.Api.V1.SuperFinanciera.ErpUpdateCurrencyRate.Item.Item.Item.Item.WithValidFromItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Italcol.TurboGraneles.Clients.Api.V1.SuperFinanciera.ErpUpdateCurrencyRate.Item.Item.Item.WithCurrencyCodeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCurrencyCodeItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/super-financiera/erp-update-currency-rate/{company}/{currencyType}/{currencyCode}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Italcol.TurboGraneles.Clients.Api.V1.SuperFinanciera.ErpUpdateCurrencyRate.Item.Item.Item.WithCurrencyCodeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCurrencyCodeItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/super-financiera/erp-update-currency-rate/{company}/{currencyType}/{currencyCode}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
