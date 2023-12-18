using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Linq;
using System.Data.SqlClient;
using CalcClassBr;
using System.Diagnostics;

namespace YourNamespace.Tests
{

    [TestClass]
    public class AnalyzerTests
    {
        public TestContext TestContext { get; set; }

        [DataSource("System.Data.SqlClient", "Server = DESKTOP-AHSORMQ\\SQLEXPRESS;Integrated Security = True;Database = Test", "TestData", DataAccessMethod.Sequential)]

        [TestMethod]
        public void DivideTest()
        {
            int num1 = (int)TestContext.DataRow["Number1"];
            int num2 = (int)TestContext.DataRow["Number2"];
            int res = (int)TestContext.DataRow["Fraction"];

            // Act
            int result = CalcClass.Div(num1, num2);
            Debug.WriteLine($"Expected: {res}, Actual: {result}");
            // Assert
            Assert.AreEqual(res, result, $"Expected: {res}, Actual: {result}");
        }
    }
}
