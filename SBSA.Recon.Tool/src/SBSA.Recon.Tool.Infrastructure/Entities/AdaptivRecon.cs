using SBSA.Recon.Tool.Infrastructure.Common;
using System;
using System.Collections.Generic;

namespace SBSA.Recon.Tool.Infrastructure.Entities
{
    public partial class AdaptivRecon : IReadReconEntity
    {
        public int AdaptivReconId { get; set; }
        public string Source { get; set; }
        public string CdsbusinessDate { get; set; }
        public string CdsbusinessDateSkey { get; set; }
        public string Reference { get; set; }
        public string SourceReference { get; set; }
        public string TradeDate { get; set; }
        public string ExpiryDate { get; set; }
        public string SettlementDate { get; set; }
        public string Counterparty { get; set; }
        public string Product { get; set; }
        public string Notional { get; set; }
        public string MarketToMarket { get; set; }
        public string AdaptivLogEvent { get; set; }
        public string AdaptivLogComment { get; set; }
        public string Aggregation { get; set; }
        public string SecondGeneration { get; set; }
        public string ItemInSource { get; set; }
        public string MiddlewareLogFilter { get; set; }
        public string MiddlewareErrException { get; set; }
        public string MiddlewareCiferrException { get; set; }
        public string MiddlewareLogDelivered { get; set; }
        public string ItemInTarget { get; set; }
        public string InsertUser { get; set; }
        public string ItemLogDeliveredNotInTarget { get; set; }
        public string MarkToMarketCurrency { get; set; }
        public string Currency { get; set; }
        public string MaturityDate { get; set; }
    }
}
