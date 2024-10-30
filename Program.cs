

namespace Bag_Data_Structure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Bag<int> bag = new Bag<int>();
            bag.Add(1);
            bag.Add(2);
            bag.Add(3);
            bag.Add(4);

            BagIterator<int> iterator = bag.Iterator();
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
