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

            int[] arr2 = new int[] { 1, 2, 3, 4, 5};
            bool result3 = Program.IsContain5(arr2);
            Assert.AreEqual(true, result3);
        }
    }
}
