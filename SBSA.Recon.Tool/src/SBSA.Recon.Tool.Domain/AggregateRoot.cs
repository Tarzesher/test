﻿using System.Collections.Generic;
using System.Linq;
using SBSA.OffShore.Domain.EventStore.Events;
using SBSA.OffShore.Domain.EventHandler;
using ABSA.OffShore.Domain.Utils;

namespace SBSA.OffShore.Domain

{
    public abstract class AggregateRoot: IEventProvider
    {
        private readonly List<Event> _changes;

        public System.Guid Id { get; internal set; }
        public int Version { get; internal set; }
        public int EventVersion { get; protected set; }

        protected AggregateRoot()
        {
            _changes = new List<Event>();
        }

        public IEnumerable<Event> GetUncommittedChanges()
        {
            return _changes;
        }

        public void MarkChangesAsCommitted()
        {
            _changes.Clear();
        }

        public void LoadsFromHistory(IEnumerable<Event> history)
        {
            foreach (var e in history) ApplyChange(e, false);
            Version = history.Last().Version;
            EventVersion = Version;
        }

        protected void ApplyChange(Event @event)
        {
            ApplyChange(@event, true);
        }

        private void ApplyChange(Event @event, bool isNew)
        {
            dynamic d = this;
            
            d.Handle(Converter.ChangeTo(@event,@event.GetType()));
            if (isNew)
            {
                _changes.Add(@event);
            }
        }      
    }
}