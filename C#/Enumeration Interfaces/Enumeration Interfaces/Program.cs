using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerator_Interface
{
    /*
    public interface IEnumerator
    {
        bool MoveNext(); //Advances to next pos. Returns false if no more elements in collection. Must be called before returning first element (to allow for empty collection).
        object Current { get;} //Returns current element at pos. (Typically cast from object to a more specific type)
        void Reset(); //If implemented moves back to the start for the collection to be enumerated again (not universally supported)
    }
     */

    //Class which implements generic IEnumerable interface. Since IEnumerable implements IEnumerator, we have to implement both GetEnumerator() methods
    public class MyGenericCollection : IEnumerable<int>
    {
        private int[] _data = { 1, 2, 3 };

        public IEnumerator<int> GetEnumerator()
        {
            foreach (int i in _data)
            {
                yield return i; //yield will transfer control back to calling function, then will transfer back
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //GetEnumerator typically returns generic (IEnumerator<T>), with some exceptions like an array.
            //For backwards compatibility reasons, GetEnumerator for an array will return a non-generic
            int[] data = { 1, 2, 3 }; //array
            var rator = data.GetEnumerator(); //NON-Generic array enumerator
            rator = ((IEnumerable<int>)data).GetEnumerator(); //For cases like this, we can cast to a generic type safe version

            //We can more tediously enumerate through the array like this
            while (rator.MoveNext())
            {
                Console.WriteLine(rator.Current.ToString());
            }

            //We don't really need to do that though. We can more cleanly use a foreach loop
            foreach (int curr in data)
            {
                Console.WriteLine(curr.ToString());
            }



            //Implementing in class

            //MyGenericCollection test = new MyGenericCollection();
            IEnumerable<int> test = new MyGenericCollection();
            //This will call the GetEnumerator method in the generic interface
            foreach (int i in test)
            {
                Console.WriteLine(i);
            }

            //This will call the GetEnumerator method in the non-generic interface
            IEnumerable collection = new MyGenericCollection();
            foreach (object value in collection)
            {
                Console.WriteLine(value);
            }
        }
    }
}
