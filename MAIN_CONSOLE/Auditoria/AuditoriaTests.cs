using Microsoft.VisualStudio.TestTools.UnitTesting;
using MAIN_LIBRARY;
using System;

namespace Auditoria
{
    [TestClass]
    public class AuditoriaTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            double MinWindow = 1; double MaxWindow = 2; double Window = 1;
            double MinSeat = 1; double MaxSeat = 23; double Seat = 20;
            string Name = " ";
            MAIN_LIBRARY.Auditoria auditoria = new MAIN_LIBRARY.Auditoria( Name, Window, Seat);
            if (Window < MinWindow || Window > MaxWindow) 
            {
                Assert.Fail();
            }
            else if (Window >= MinWindow && Window <= MaxWindow)
            {
                Assert.IsNotNull( auditoria );
            }
            else { Assert.Fail(); }
        }
        [TestMethod]
        public void TestMethod2() 
        {
            double MinWindow = 1; double MaxWindow = 2; double Window = 2;
            double MinSeat = 1; double MaxSeat = 23; double Seat = 20;
            string Name = " ";
            MAIN_LIBRARY.Auditoria auditoria = new MAIN_LIBRARY.Auditoria(Name, Window, Seat);

            if (Seat < MinSeat || Seat > MaxSeat)
            {
                Assert.Fail();
            }
            else if (Seat >= MinSeat && Seat <= MaxSeat)
            {
                Assert.IsNotNull(auditoria);
            }
            else { Assert.Fail(); }
        }
        [TestMethod]
        public void TestMethod3()
        {
            double MinWindow = 1; double MaxWindow = 2; double Window = 2;
            double MinSeat = 1; double MaxSeat = 23; double Seat = 20;
            string Name = "Name";
            MAIN_LIBRARY.Auditoria auditoria = new MAIN_LIBRARY.Auditoria(Name, Window, Seat);

            if (Name == " ") { Assert.Fail(); }
            else { Assert.IsNotNull(auditoria);}
        }
    }
}
