using System;

namespace CS_Event
{
    public class Publisher
    {
        public delegate void NotifyNews(object data);
        public NotifyNews event_news;
        public void Send()
        {
            event_news?.Invoke("Have a news!");
        }
    }

    public class SubscriberA
    {
        public void Sub(Publisher p)
        {
            p.event_news += ReceiverFromPublisher;
        }

        void ReceiverFromPublisher(object data)
        {
            Console.WriteLine("Subcriber A: " + data.ToString());
        }
    }

    public class SubscriberB{
        public void Sub(Publisher p){
            p.event_news = null;
            p.event_news += ReceiveFromPublisher;
        }

        void ReceiveFromPublisher(object data){
            Console.WriteLine("Subcriber B:" + data.ToString());
        }
    }
}