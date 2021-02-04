using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    //AreEqual
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            double a = 2;
            double b = 2;
            double c = 2;
            double x = 2;
            double exception = 0.5;

            Liora.Liora F = new Liora.Liora();
            double actuallity = F.Calc(x, a, b, c);

            Assert.AreEqual(exception, actuallity);
        }

        //AreNotEqual
        [TestMethod]
        public void TestMethod2()
        {
            double a = 2;
            double b = 2;
            double c = 2;
            double x = 2;
            double exception = 5;

            Liora.Liora F = new Liora.Liora();
            double actuallity = F.Calc(x, a, b, c);

            Assert.AreNotEqual(exception, actuallity);
        }

        //IsTrue
        [TestMethod]
        public void TestMethod3()
        {
            
            bool akk = true;
            Liora.Animal a = new Liora.Animal();
            bool actuallity = a.Boolean(akk);

            Assert.IsTrue(actuallity);
        }

        //IsFalse
        [TestMethod]
        public void TestMethod4()
        {

            bool akk = false;
            Liora.Animal a = new Liora.Animal();
            bool actuallity = a.Booleann(akk);

            Assert.IsFalse(actuallity);
        }
        //AreSame
        [TestMethod]
        public void TestMethod5()
        {
            string a = "Hello";
            string b = "Hello";

            Liora.Animal m = new Liora.Animal();
            string act = m.Same(a, b);
            Assert.AreSame(a, b);
        }
        //AreNotSame
        [TestMethod]
        public void TestMethod6()
        {
            string a = "Ayrat";
            string b = "Kekwowo";

            Liora.Animal m = new Liora.Animal();
            string act = m.Same(a, b);
            Assert.AreNotSame(a, b);
        }
        //IsNull
        [TestMethod]
        public void TestMethod7()
        {
            string a = null;
            string b = null;

            Liora.Animal m = new Liora.Animal();
            string act = m.IsNullean(a, b);
            Assert.IsNull(a, b);
        }

        //IsNotNull
        [TestMethod]
        public void TestMethod8()
        {
            string a = "aaaaaaaaa";
            string b = "jgjfgjf";
            
            Liora.Animal m = new Liora.Animal();
            string act = m.IsNullean(a, b);
            Assert.IsNotNull(a, b);
        }

        //Fail
        [TestMethod]
        public void TestMethod9()
        {
            try
            {
                try
                {
                    string rofl = "1234567";
                    string owo = "1234567";
                    Liora.Animal gg = new Liora.Animal();
                    
                    if (rofl.Length > 6)
                    {
                        string act = gg.kekw(rofl, owo);
                        Assert.Fail();
                    }
                }
                catch
                {
                    Console.WriteLine("Возникло исключение");
                    throw;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

       
            [TestMethod]
            public void TestMethod10()
            {
                int kekww = 727;

                Liora.Animal F = new Liora.Animal();

                Assert.IsInstanceOfType(F.Rui(kekww), typeof(int));
            }

        [TestMethod]
        public void TestMethod11()
        {
            int kekww = 727;

            Liora.Animal F = new Liora.Animal();

            Assert.IsNotInstanceOfType(F.Rui(kekww), typeof(float));
        }
    }
}
