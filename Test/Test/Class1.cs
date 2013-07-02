using System;
using System.Collections.Generic;

namespace Test
{
    public class Customer
    {
        public int Id;
        public string Name;
        public IEnumerable<Address> Addresses;
    }

    public class Address
    {
        public int Id;
        public string City;
    }

    internal class Class1
    {
        public void Reverse<T>(T[] arr)
        {
            //Należy zaimplementować w najbardziej optymalny sposób, bez użycia funkcji systemowych.
            throw new NotImplementedException();
        }

        public int GetCustomersCountIn(Customer[] customers, string city)
        {
            //Należy zaimplementować przy użyciu LINQ
            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks if an element is present a sorted array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns>True if the array contains the element, false otherwise</returns>
        public bool Contains(int[] array, int value)
        {
            //Należy zaimplementować przy użyciu algorytmu binary search
            throw new NotImplementedException();
        }
    }
}
