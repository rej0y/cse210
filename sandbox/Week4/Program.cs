public class Program
{
    static void Main(string[] args)
    {
        Message m1 = new Message();
        m1._message = "Send help!";
        m1._priority = 1;
        Console.WriteLine(m1.GetMessage());

        Message m2 = new Message();
        m2._message = "Please pick some carrots at the store.";
        m2._priority = 3;
        Console.WriteLine(m2.GetMessage());
    }
}