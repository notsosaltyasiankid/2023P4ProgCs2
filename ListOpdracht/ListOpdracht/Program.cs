namespace ListOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<string> birds = new List<string>{"uil", "kraai" ,"hond" ,"papegaai"};
            List<string> birds2 = new List<string> { "meeuw", "duif" };

            birds2.AddRange(birds);

            birds2.RemoveAt(4);
            foreach (string i in birds2)
            {
                Console.WriteLine(i);
            }
          
        }



    }
}
