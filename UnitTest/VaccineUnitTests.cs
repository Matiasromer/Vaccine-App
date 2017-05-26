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
    public class VaccineUnitTests
    {
        [TestMethod]
        public void TestForName()
        {
            //Tester Navnet - Vil teste forkert.
            //arrange
            Vaccine TestVacc = new Vaccine(1, "TestVaccine", "Brugt til Test");
            string expected = "VaccineTest";
            string actual = TestVacc.Vac_Navn;
            //act
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForInfo()
        {
            //Tester Vaccinenes Information
            //arrange
            Vaccine TestVacc = new Vaccine(1, "TestVaccine", "Brugt til Test");
            string expected = "Brugt til Test";
            string actual = TestVacc.Vac_Info;
            //act
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForToString()
        {
            //Tester ToString Metoden - Hvad der vises i View/liste
            //arrange
            Vaccine TestVacc = new Vaccine(1, "TestVaccine", "Brugt til Test");
            string expected = $"1  -  TestVaccine  ";
            string actual = TestVacc.ToString();
            //act
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
