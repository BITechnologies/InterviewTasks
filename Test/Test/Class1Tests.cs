using NUnit.Framework;
using System.Linq;

namespace Test
{
    [TestFixture]
    public class Class1Tests
    {
        [Test]
        public void TestReverse()
        {
            var c = new Class1();
            var arr = new[] { 'a', 'b', 'd', 'e' };
            c.Reverse(arr);
            CollectionAssert.AreEqual(new[] { 'e', 'd', 'b', 'a' }, arr);
        }

        [Test]
        public void TestLinq()
        {
            var customers = new [] {
                new Customer { Id =1, 
                    Name= "A", 
                    Addresses = new [] 
                    {
                        new Address { Id = 1, City = "Wrocław"},
                        new Address { Id = 2, City = "Kraków"},
                    }
                },
                new Customer { Id =2, 
                    Name= "B", 
                    Addresses = new [] 
                    {
                        new Address { Id = 3, City = "Warszawa"},
                    }
                },
                new Customer { Id =3, 
                    Name= "C", 
                    Addresses = new [] 
                    {
                        new Address { Id = 4, City = "wrocław"},
                    }
                }
            };

            var c = new Class1();
            var customersInWroclaw = c.GetCustomersCountIn(customers, "Wrocław");
            Assert.That(customersInWroclaw, Is.EqualTo(2));
        }

        [Test]
        public void TestBinarySearch()
        {
            var data = Enumerable.Range(1, 100);
            var divBy3 = data.Where(d => d % 3 == 0).ToArray();

            var c = new Class1();
            bool val = c.Contains(divBy3, 15);
            Assert.True(val);

            val = c.Contains(divBy3, 41);
            Assert.False(val);
        }
    }  
}