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
    }
}
