using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassDemoRestPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoRestPerson.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void GetPersonerTest()
        {
            Service1 service = new Service1();

            List<Person> personer = service.GetPersoner();

            Assert.AreEqual(3, personer.Count);
        }
    }
}