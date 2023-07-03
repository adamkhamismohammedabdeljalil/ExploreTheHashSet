namespace ExploreTheHashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a HashSet
            HashSet<string> foods = new HashSet<string>();
            //add unique values
            foods.Add("pizza");
            foods.Add("burger");
            foods.Add("salad");
            //Does a HashSet consider strings with different capitalisations unique?
            foods.Add("Burger");
            foods.Add("PIZZA");
            Console.WriteLine(foods.Add("SALaD"));
            // strings with different capitalizations are unique and could be added to hashset


        }
    }
}