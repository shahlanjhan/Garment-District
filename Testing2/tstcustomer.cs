using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstcustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clscustomer Ancustomer = new clscustomer();
            Assert.IsNotNull(Ancustomer);
        }
        [TestMethod]
        public void CustomerIDOK()

        {
            clscustomer Ancustomer = new clscustomer();
            Boolean TestData = true;
            Ancustomer.CustomerID = TestData;
            Assert.AreEqual(Ancustomer.CustomerID, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clscustomer Ancustomer = new clscustomer();
            DateTime TestData = DateTime.Now.Date;
            Ancustomer.DateAdded = TestData;
            Assert.AreEqual(Ancustomer.DateAdded, TestData);
        }
        [TestMethod]
        public void FirstnameOK()
        {
            clscustomer Ancustomer = new clscustomer();
            string TestData = "john";
            Ancustomer.Firstname = TestData;
            Assert.AreEqual(Ancustomer.Firstname, TestData);

        }
        [TestMethod]
        public void LastnameOK()
        {
            clscustomer Ancustomer = new clscustomer();
            string TestData = "wick";
            Ancustomer.Lastname = TestData;
            Assert.AreEqual(Ancustomer.Lastname, TestData);
        }
        [TestMethod]
        public void AddressNoPropertyOK()
        {
            clscustomer Ancustomer = new clscustomer();
            string TestData = "34 London road";
            Ancustomer.AddressNo = TestData;
            Assert.AreEqual(Ancustomer.AddressNo, TestData);
        }
        [TestMethod]
        public void CityNoPropertyOK()
        {
            clscustomer Ancustomer = new clscustomer();
            string TestData = "Leicester";
            Ancustomer.CityNo = TestData;
            Assert.AreEqual(Ancustomer.CityNo, TestData);
        }
        [TestMethod]
        public void PhoneNoOK()
        {
            clscustomer Ancustomer = new clscustomer();
            string TestData = "07495873485";
            Ancustomer.PhoneNo = TestData;
            Assert.AreEqual(Ancustomer.PhoneNo, TestData);
        }
    }
}





