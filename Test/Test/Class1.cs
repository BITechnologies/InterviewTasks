using System;
using System.Collections.Generic;
using System.Linq;

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
            var leftIndex = 0;
            var rightIndex = arr.Length - 1;
            T tempValue;

            while (leftIndex < rightIndex)
            {
                tempValue = arr[leftIndex];
                arr[leftIndex] = arr[rightIndex];
                arr[rightIndex] = tempValue;
                leftIndex++;
                rightIndex--;
            }
        }

        public int GetCustomersCountIn(Customer[] customers, string city)
        {
            //Należy zaimplementować przy użyciu LINQ
            return customers.Where(x => x.Addresses.Any(z => z.City == city)).Count();
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

            var result = false;
            var leftIndex = 0;
            var rightIndex = array.Length - 1;
            var currentIndex = 0;

            while (leftIndex <= rightIndex)
            {
                currentIndex = (int)Math.Floor((leftIndex + rightIndex) / 2.0);

                if (array[currentIndex] < value)
                {
                    leftIndex = currentIndex + 1;
                }
                else if(array[currentIndex] > value)
                {
                    rightIndex = currentIndex - 1;
                }
                else
                {
                    leftIndex = rightIndex + 1 ;
                    result = true;
                }
            }

            return result;
        }
    }
}
