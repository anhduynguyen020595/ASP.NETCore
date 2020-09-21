using System;

namespace CS_Event
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Publisher p = new Publisher();
            //    SubscriberA sa = new SubscriberA();
            //    SubscriberB sb = new SubscriberB();

            //    sa.Sub(p);
            //    sb.Sub(p);

            //    p.Send();

            ClassA sa = new ClassA();
            ClassB sb = new ClassB();
            ClassC sc = new ClassC();

            sb.Sub(sa);
            sc.Sub(sa);

            sa.Send();
        }
    }
}
