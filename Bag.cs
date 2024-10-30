using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bag_Data_Structure
{
    public class Bag<T>
    {
        private LinkedList<T> linkedList;
        private int size;

        public Bag()
        {
            linkedList = new LinkedList<T>();
            size = 0;
        }

        public void Add(T element)
        {
            linkedList.Add(element);
            size++;
        }

        public int Size()
        {
            return size;
        }

        public BagIterator<T> Iterator()
        {
            return new BagIterator<T>(linkedList);
        }
    }

}
