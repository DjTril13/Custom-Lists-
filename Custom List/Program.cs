using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List
{
    public class CustList<T>
    {
        static void Main(string[] args)
        { }

        //Member vars
        private int count;      // how many indexes are filled 
        private int capacity;    //how many indexes there are, empty or filled 

        //Constructors
        public CustList()
        { }

        private T[] CustomList = new T[3];
        public T this[int index]
        {
            get { return CustomList[index] ; }
            set { CustomList[index] = value; }
        }     // indexer

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        //Methods
        public void Add(T item)
        { //check if capacity can hold it 
        }
        public void Remove(T item)
        { }

       //// public void CountItemsInList()
       // {// use Ienumerable 
       //     IEnumerator<T> CountList = CustomList.GetEnumerator()
       //         { }
       // }
public void CountItemsInList()
{
            IEnumerable<T> CountList = IEnumerable < T > CustList()

}


    }
}