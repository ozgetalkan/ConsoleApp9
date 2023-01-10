namespace ConsoleApp9
{
    internal class Program
    {
        static List<String> names = new();
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                names.Add("Özge" + i.ToString());
            }
            NextPage(0);
            //String s = "Bugün hava çok sıcak";
            //var x = s.Skip(3).Take(5);
            //Console.WriteLine(String.Join(";", x)) ;
        }
        static bool NextPage(int pageIndex)
        {
            List<String> strings = names.Skip(pageIndex * 10).Take(10).ToList();
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
            return pageIndex * 10 >= names.Count;
        }
    }
}