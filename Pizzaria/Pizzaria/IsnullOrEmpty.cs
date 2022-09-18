namespace Pizzaria
{
    public class IsnullOrEmpty
    {
        public string EmptyST(string input)
        {
            while (input == string.Empty)
            {
                Console.WriteLine("Digite algo");
                input = Console.ReadLine();
            }
            return input;
        }
        public int EmptyINT(int input)
        {
            while (input == 0)
            {
                Console.WriteLine("Digite algo");
                input = Convert.ToInt32(Console.ReadLine());
            }
            return input;
        }
    }
}
