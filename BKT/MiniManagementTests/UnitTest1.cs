using System;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniManagement;

namespace MiniManagementTests
{
    [TestClass]
    public class UnitTest1
    {
        private Address TestAddress => new Address("Russia", "Vodka", "13374202", "Moskau", "Vladimirstraße", "69");
        private Apartment TestApartment => new Apartment(true, 4, true, 20000, false, 0, TestAddress);


        [TestMethod]
        public void ShoulCreateManagement()
        {
            //Arrange
            var rem = new RealEstateManagement();

            //Assert
            Assert.IsNotNull(rem);
        }

        [TestMethod]
        public void ShouldAddToList()
        {
            //Arrange
            var rem = new RealEstateManagement();
            Apartment x = TestApartment;
           
            // Act
            rem.Add(x);

            //Assert
            Assert.AreEqual(x, rem.Get(0));
        }

        [TestMethod]
        public void ShouldToStringAddress()
        {
            //Arrange
            string TestAddressExpected = "Country: Russia\nState: Vodka\nZip: 13374202\nCity: Moskau\nStreet: Vladimirstraße\nHouseNumber: 69\n";

            //Act
            string TestAddressActual = TestAddress.ToString();

            //Assert
            Assert.AreEqual(TestAddressExpected, TestAddressActual);

        }
    }
}
