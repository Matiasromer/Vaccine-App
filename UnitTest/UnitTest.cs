using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Windows.Devices.Input;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Vaccine_App;
using Vaccine_App.Model;
using Vaccine_App.Persistency;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NavnTest()
        {
            //arrange
            string expected = "Karl-Egon";
            Barn TestBarn= new Barn("Karl-Egon",0 , DateTime.Now, "Dreng");
            string actual = TestBarn.Barn_Navn;
            //act
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod()
        {
            //arrange

            //act

            //assert


        }
    }
}
