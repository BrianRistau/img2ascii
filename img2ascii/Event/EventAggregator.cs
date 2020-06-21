using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace img2ascii.Event
{
    public class EventAggregator : IEventAggregator
    {
        private static IEventAggregator instance;
        public static IEventAggregator Instance
        {
            get { 
                if (instance == null) {
                    instance = new EventAggregator();
                }
                return instance;
            }
        }

        private readonly ConcurrentDictionary<Type, List<object>> subscriptions;

        private EventAggregator()
        {
            subscriptions = new ConcurrentDictionary<Type, List<object>>();
        }

        public void Publish<T>(T message) where T : IApplicationEvent
        {
            if (subscriptions.TryGetValue(typeof(T), out List<object> subscribers))
            {
                foreach (var subscriber in subscribers.ToArray())
                {
                    ((Action<T>) subscriber)(message);
                }
            }
        }

        public void Subscribe<T>(Action<T> action) where T : IApplicationEvent
        {
            var subscribers = subscriptions.GetOrAdd(typeof(T), t => new List<object>());
            lock (subscribers)
            {
                subscribers.Add(action);
            }
        }

        public void Unsubscribe<T>(Action<T> action) where T : IApplicationEvent
        {
            if (subscriptions.TryGetValue(typeof(T), out List<object> subscribers))
            {
                lock (subscribers)
                {
                    subscribers.Remove(action);
                }
            }
        }

        public void Dispose()
        {
            subscriptions.Clear();
        }
    }
}
