using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDeveloper2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HappyNumber_UnitTest()
        {
            int[] items = new int[] { 19, 36, 15, 23, 50 };
            bool[] expected = new bool[] { true, false, false, true, false };
            bool[] actual = new bool[5];

            for (int i = 0; i < 5; i++)
            {
                actual[i] = Program.HappyNumber(items[i]);
            }

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EmployeesName_UnitTest()
        {
            string[] expected = new string[] { "Maria Ruiz", "Juan Santos" };
            string[] actual = new string[2];

            Program.LocalEmployee local = new Program.LocalEmployee("Maria Ruiz");
            Program.ExternalEmployee external = new Program.ExternalEmployee("Juan Santos");

            actual[0] = local.Name();
            actual[1] = external.Name();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EmployeesSalary_UnitTest()
        {
            int[] expected = new int[] { 8500, 8400 };
            int[] actual = new int[2];

            Program.LocalEmployee local = new Program.LocalEmployee("Maria Ruiz");
            Program.ExternalEmployee external = new Program.ExternalEmployee("Juan Santos");


            actual[0] = local.Salary(5);
            actual[1] = external.Salary(5);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
