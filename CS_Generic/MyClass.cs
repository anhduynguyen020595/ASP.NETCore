namespace CS_Generic
{
    public class MyClass<T>
    {
        private T variable;

        public MyClass(T value)
        {
            variable = value;
        }

        public T TestMethod(T parameter)
        {
            System.Console.WriteLine(parameter);
            System.Console.WriteLine(variable);
            return variable;
        }

        public T property { get; set; }
    }
}