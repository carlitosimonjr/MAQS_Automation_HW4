using CognizantSoftvision.Maqs.BaseDatabaseTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    /// <summary>
    /// Tests test class with VSUnit
    /// </summary>
    [TestClass]
    public class DatabaseTestVSUnit : BaseDatabaseTest
    {
        /// <summary>
        /// Get number of products
        /// </summary>
        [TestMethod]
        public void GetNumberOfProducts()
        {
            IEnumerable<dynamic> table = DatabaseDriver.Query("SELECT * FROM products");
            Assert.AreEqual(5, table.Count(), "Expected 5 rows");
        }
    }
}
