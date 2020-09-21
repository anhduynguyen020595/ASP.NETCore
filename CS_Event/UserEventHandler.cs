using System;

namespace CS_Event
{
    public class MyEventArgs : EventArgs
    {
        public MyEventArgs(string data)
        {
            this.data = data;
        }

        private string data;

        public string Data
        {
            get { return data; }
        }
    }

    public class ClassA{
        public event MyEventArgs event_news;
        public void Send(){
            event_news ?.Invoke (this, new MyEventArgs("Has a news!"));
        }
    }

    public class ClassB{
        public void Sub(ClassA p){
            p.event_news += ReceiverFromPublisher;
        }

        private void ReceiverFromPublisher(object sender, MyEventArgs e){
            Console.WriteLine("Class B: " + e.Data);
        }
    }

    public class ClassC{
        public void Sub(ClassA p){
            p.event_news += ReceiverFromPublisher;
        }

        private void ReceiverFromPublisher(object sender, MyEventArgs e){
            Console.WriteLine("Class C:" + e.Data);
        }
    }
}