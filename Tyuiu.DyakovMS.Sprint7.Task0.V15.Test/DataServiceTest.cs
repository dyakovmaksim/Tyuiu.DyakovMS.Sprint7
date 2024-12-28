using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Tyuiu.DyakovMS.Sprint7.Project.V15.Lib;

namespace Tyuiu.DyakovMS.Sprint7.Project.V15.Test
{
    [TestClass]
    public class DataServiceTests
    {
        private DataService dataService;

        // Инициализация перед каждым тестом
        [TestInitialize]
        public void Setup()
        {
            dataService = new DataService
            {
                Contracts = new List<Contract>
                {
                    new Contract { ContractCode = "001", OrganizationName = "Орг1", ExecutionPeriod = "2023", ContractAmount = 1000, Notes = "Примечание 1", ContractType = "Тип1" },
                    new Contract { ContractCode = "002", OrganizationName = "Орг2", ExecutionPeriod = "2024", ContractAmount = 500, Notes = "Примечание 2", ContractType = "Тип2" },
                    new Contract { ContractCode = "003", OrganizationName = "Орг1", ExecutionPeriod = "2025", ContractAmount = 2000, Notes = "Примечание 3", ContractType = "Тип1" }
                }
            };
        }

        [TestMethod]
        public void TestLoadFromCsv()
        {
            // Тестируем загрузку из CSV
            var filePath = "test.csv";
            var lines = new[]
            {
                "Шифр договора;Наименование организации;Сроки выполнения;Сумма договора;Примечания;Тип договора",
                "004;Орг3;2026;3000;Примечание 4;Тип3"
            };
            System.IO.File.WriteAllLines(filePath, lines);

            dataService.LoadFromCsv(filePath);

            Assert.AreEqual(1, dataService.Contracts.Count);
            Assert.AreEqual("004", dataService.Contracts[0].ContractCode);

            System.IO.File.Delete(filePath); // Удаляем временный файл
        }

        [TestMethod]
        public void TestSaveToCsv()
        {
            // Тестируем сохранение в CSV
            var filePath = "test_output.csv";
            dataService.SaveToCsv(filePath);

            var lines = System.IO.File.ReadAllLines(filePath);
            Assert.AreEqual(4, lines.Length); // 1 заголовок + 3 записи

            System.IO.File.Delete(filePath); // Удаляем временный файл
        }

        [TestMethod]
        public void TestSearch()
        {
            // Тестируем поиск записей по организации
            var results = dataService.Search("Орг1");
            Assert.AreEqual(2, results.Count);
            Assert.IsTrue(results.All(c => c.OrganizationName == "Орг1"));
        }

        [TestMethod]
        public void TestGetStatistics()
        {
            // Тестируем получение статистики
            var stats = dataService.GetStatistics();

            Assert.AreEqual(500, stats.min);
            Assert.AreEqual(2000, stats.max);
            Assert.AreEqual(1166.67m, stats.avg, 0.01m); // Точность до двух знаков
            Assert.AreEqual(3500, stats.sum);
        }

        [TestMethod]
        public void TestSortContractsByAmount()
        {
            // Тестируем сортировку по сумме договора
            var sorted = dataService.Contracts.OrderBy(c => c.ContractAmount).ToList();

            Assert.AreEqual(500, sorted[0].ContractAmount); // Минимальная сумма
            Assert.AreEqual(2000, sorted[2].ContractAmount); // Максимальная сумма
        }

        [TestMethod]
        public void TestFilterContractsByAmount()
        {
            // Тестируем фильтрацию по минимальной сумме договора
            var filtered = dataService.Contracts.Where(c => c.ContractAmount > 1000).ToList();

            Assert.AreEqual(1, filtered.Count);
            Assert.AreEqual(2000, filtered[0].ContractAmount);
        }
    }
}