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
    public class KalenderUnitTest
    {
        [TestMethod]
        public void TestForID()
        {
            //tester for Vaccine ID
            //arrange
            Kalender TestKalender = new Kalender(DateTime.Now, 1, 1);
            int expected = 1;
            int actual = TestKalender.Vac_id;
            //act
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForInjDate()
        {
            //Tester på forkert inj Date
            //arrange
            Kalender TestKalender = new Kalender(DateTime.Now, 1, 1);
            DateTime expected = DateTime.Now.AddMonths(2);
            DateTime actual = TestKalender.Dato;
            //act
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
