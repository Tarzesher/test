using System;

namespace SBSA.OffShore.Domain.EventStore.Events
{
    public class CommentAddedEvent : Event
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int InstructionId { get; set; }
        public int ProductGroupTypeId { get; set; }
        public string TradeClassificationId { get; set; }
        public string BrokerCode { get; set; }
        public DateTime Modified { get; set; }
    }

}