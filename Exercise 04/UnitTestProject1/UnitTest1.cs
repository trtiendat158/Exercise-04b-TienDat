using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise_04;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4 };
            bool result0 = Program.IsContain5(arr1);
            Assert.AreEqual(false, result0);

            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            bool result3 = Program.IsContain5(arr2);
            Assert.AreEqual(true, result3);
        }

        [TestMethod]
        public void Test5or6()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4 };
            bool result = Program.IsContain5_or_6(arr1);
            Assert.AreEqual(false, result);

            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            bool result1 = Program.IsContain5_or_6(arr2);
            Assert.AreEqual(true, result1);

            int[] arr3 = new int[] { 1, 2, 3, 4, 6 };
            bool result2 = Program.IsContain5_or_6(arr3);
            Assert.AreEqual(true, result2);

            int[] arr4 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            bool result3 = Program.IsContain5_or_6(arr4);
            Assert.AreEqual(true, result3);
        }


        [TestMethod]
        public void Test5and6()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4 };
            bool result = Program.IsContain5_and_6(arr1);
            Assert.AreEqual(false, result);

            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            bool result1 = Program.IsContain5_and_6(arr2);
            Assert.AreEqual(false, result1);

            int[] arr3 = new int[] { 1, 2, 3, 4, 6 };
            bool result2 = Program.IsContain5_and_6(arr3);
            Assert.AreEqual(false, result2);

            int[] arr4 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            bool result3 = Program.IsContain5_and_6(arr4);
            Assert.AreEqual(true, result3);
        }
    }
}