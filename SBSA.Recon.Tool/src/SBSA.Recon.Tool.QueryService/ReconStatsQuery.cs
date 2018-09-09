using AutoMapper;
namespace SBSA.Recon.Tool.QueryService
{
    public class ReconStatsQuery : Query
    {
        public ReconStatsQuery(int adaptivReconId, string source, string cdsbusinessDate, string cdsbusinessDateSkey,
            string reference, string sourceReference, string tradeDate, string expiryDate, string settlementDate,
            string counterparty, string product, string notional, string marketToMarket, string adaptivLogEvent, 
            string adaptivLogComment, string aggregation, string secondGeneration, string itemInSource, 
            string middlewareLogFilter, string middlewareErrException, string middlewareCiferrException, 
            string middlewareLogDelivered, string itemInTarget, string insertUser, string itemLogDeliveredNotInTarget,
            string markToMarketCurrency, string currency, string maturityDate) : base(adaptivReconId, 1)
        {
            AdaptivReconId = adaptivReconId;
            Source = source;
            CdsbusinessDate = cdsbusinessDate;
            CdsbusinessDateSkey = cdsbusinessDateSkey;
            Reference = reference;
            SourceReference = sourceReference;
            TradeDate = tradeDate;
            ExpiryDate = expiryDate;
            SettlementDate = settlementDate;
            Counterparty = counterparty;
            Product = product;
            Notional = notional;
            MarketToMarket = marketToMarket;
            AdaptivLogEvent = adaptivLogEvent;
            AdaptivLogComment = adaptivLogComment;
            Aggregation = aggregation;
            SecondGeneration = secondGeneration;
            ItemInSource = itemInSource;
            MiddlewareLogFilter = middlewareLogFilter;
            MiddlewareErrException = middlewareErrException;
            MiddlewareCiferrException = middlewareCiferrException;
            MiddlewareLogDelivered = middlewareLogDelivered;
            ItemInTarget = itemInTarget;
            InsertUser = insertUser;
            ItemLogDeliveredNotInTarget = itemLogDeliveredNotInTarget;
            MarkToMarketCurrency = markToMarketCurrency;
            Currency = currency;
            MaturityDate = maturityDate;
        }

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
