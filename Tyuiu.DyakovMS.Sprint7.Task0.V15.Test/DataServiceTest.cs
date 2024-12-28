using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tyuiu.DyakovMS.Sprint7.Project.V15.Lib;

namespace Tyuiu.DyakovMS.Sprint7.Project.V15.Tests
{
    [TestClass]
    public class DataServiceTests
    {
        private DataService dataService;

        [TestInitialize]
        public void TestInitialize()
        {
            dataService = new DataService
            {
                Contracts = new List<Contract>
        {
            new Contract { ContractCode = "C001", OrganizationName = "Org1", ExecutionPeriod = "2023", ContractAmount = 500, Notes = "Note1", ContractType = "TypeA" },
            new Contract { ContractCode = "C002", OrganizationName = "Org2", ExecutionPeriod = "2024", ContractAmount = 1500, Notes = "Note2", ContractType = "TypeB" },
            new Contract { ContractCode = "C003", OrganizationName = "Org1", ExecutionPeriod = "2025", ContractAmount = 2000, Notes = "Note3", ContractType = "TypeA" }
        }
            };
        }

        [TestMethod]
        public void TestGetStatistics()
        {
            var stats = dataService.GetStatistics();

            Assert.AreEqual(500, stats.Min); 
            Assert.AreEqual(2000, stats.Max); 
            Assert.AreEqual(1333.33m, stats.Avg, 0.01m);
            Assert.AreEqual(4000, stats.Sum);
        }

        [TestMethod]
        public void TestSearch()
        {
            var results = dataService.Search("Org1");

            Assert.AreEqual(2, results.Count); 
            Assert.IsTrue(results.All(c => c.OrganizationName == "Org1")); 
        }

        [TestMethod]
        public void TestLoadFromCsv()
        {
            var csvContent = "Шифр договора;Наименование организации;Сроки выполнения;Сумма договора;Примечания;Тип договора\n" +
                             "C001;Org1;2023;500;Note1;TypeA\n" +
                             "C002;Org2;2024;1500;Note2;TypeB";

            var filePath = "test.csv";
            File.WriteAllText(filePath, csvContent);

            dataService.LoadFromCsv(filePath);

            Assert.AreEqual(2, dataService.Contracts.Count);
            Assert.AreEqual("Org1", dataService.Contracts[0].OrganizationName);
            Assert.AreEqual(500, dataService.Contracts[0].ContractAmount);

            File.Delete(filePath);
        }

        [TestMethod]
        public void TestSaveToCsv()
        {
            var filePath = "test_output.csv";

            dataService.SaveToCsv(filePath);

            Assert.IsTrue(File.Exists(filePath));

            var lines = File.ReadAllLines(filePath);
            Assert.AreEqual(4, lines.Length); 
            Assert.AreEqual("C001;Org1;2023;500;Note1;TypeA", lines[1]);

            File.Delete(filePath);
        }

        [TestMethod]
        public void TestSortContractsByAmount()
        {
            var sorted = dataService.Contracts.OrderBy(c => c.ContractAmount).ToList();

            Assert.AreEqual(500, sorted[0].ContractAmount); 
            Assert.AreEqual(2000, sorted[2].ContractAmount); 
        }
    }
}