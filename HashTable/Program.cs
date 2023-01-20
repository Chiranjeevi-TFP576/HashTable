namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash table demo");

            MyMapNode<string, int> hash = new MyMapNode<string, int>(5);

            //hash.Add("0", "To");
            //hash.Add("1", "be");
            //hash.Add("2", "or");
            //hash.Add("3", "not");
            //hash.Add("4", "to");
            //hash.Add("5", "be");
            //string hash5 = hash.Get("5");
            //Console.WriteLine("5th index value: " + hash5);
            //hash.Add("0", "Paranoids");
            //hash.Add("1", "are");
            //hash.Add("2", "not");
            //hash.Add("3", "paranoids");
            //hash.Add("4", "they");
            //hash.Add("5", "are");
            //hash.Add("6", "deliberately");
            //hash.Add("7", "keep");
            //hash.Add("8", "putting");
            //hash.Add("9", "avoidable");
            //hash.Add("10", "situations");
            //string hash11 = hash.Get("0");
            //Console.WriteLine("10th index value: " + hash11);

            //string Paragraph = "“Paranoids are not paranoid because they are " +
            //"paranoid but because they keep putting themselves deliberately into" +
            //" paranoid avoidable situations";
            //string[] letters = Paragraph.ToLower().Split(" ");

            //foreach (string word in letters)
            //{
            //    int value = hash.Get(word);
            //    if (value == default)
            //    {
            //        value = 1;
            //    }
            //    else value += 1;
            //    hash.Add(word, value);
            //}
            //int frequency1 = hash.Get("they");
            //Console.WriteLine(frequency1);

            hash.Remove("avoidable");
            int frequency2 = hash.Get("avoidable");
            Console.WriteLine(frequency2);
        }



        
    }
}