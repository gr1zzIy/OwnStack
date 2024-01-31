namespace OwnStack
{
    class Program
    {
        static void Main(string[] args)
        {
            OwnStack instance = new OwnStack();

            instance.Push(1);
            instance.Push(2);
            instance.Push(3);

            Console.WriteLine($"Останiй добавлений елемент = {instance.Peek()}\n");

            instance.Push(4);

            instance.Print();

            Console.WriteLine($"\nCount = {instance.Count}\nCapacity = {instance.Capacity}\n");

            instance.Push(5);

            instance.Print();

            Console.WriteLine($"\nCount = {instance.Count}\nCapacity = {instance.Capacity}\n");

            Console.WriteLine("\nРобимо instance.Pop()");
            
            instance.Pop();

            instance.Print();

            Console.WriteLine($"\nCount = {instance.Count}\nCapacity = {instance.Capacity}");

        }
    }
}