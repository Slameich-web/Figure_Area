using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyLibrary.Tests
{
    [TestClass]
    public class MyLibraryTest
    {
        [TestMethod]
        public void Area_Circle_10()
        {
            double x = 10;
            double expected = 314;

            MyLibrary c = new MyLibrary();
            double actual = c.Area(x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Area_Circle_0()
        {
            double x = 0;
            double expected = 0;

            MyLibrary c = new MyLibrary();
            double actual = c.Area(x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Area_Circle_negative_10()
        {
            double x = -10;
            double expected = 0;

            MyLibrary c = new MyLibrary();
            double actual = c.Area(x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Area_Triangle_3_4_5()
        {
            double x = 3;
            double y = 4;
            double z = 5;
            double expected = 6;

            MyLibrary a = new MyLibrary();
            double actual = a.Area(x,y,z);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Area_Triangle_0_4_5()
        {
            double x = 0;
            double y = 4;
            double z = 5;
            double expected = 0;

            MyLibrary a = new MyLibrary();
            double actual = a.Area(x, y, z);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Area_Triangle_negative_3_4_5()
        {
            double x = -3;
            double y = 4;
            double z = 5;
            double expected = 0;

            MyLibrary a = new MyLibrary();
            double actual = a.Area(x, y, z);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Area_Triangle_9_4_5()
        {
            double x = 9;
            double y = 4;
            double z = 5;
            double expected = 0;

            MyLibrary a = new MyLibrary();
            double actual = a.Area(x, y, z);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Area_Triangle_4_4_5()
        {
            double x = 4;
            double y = 4;
            double z = 5;
            double expected = 7.81;

            MyLibrary a = new MyLibrary();
            double actual = a.Area(x, y, z);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Area_Triangle_100_4_5()
        {
            double x = 100;
            double y = 4;
            double z = 5;
            double expected = 0;

            MyLibrary a = new MyLibrary();
            double actual = a.Area(x, y, z);

            Assert.AreEqual(expected, actual);
        }
    }
}
