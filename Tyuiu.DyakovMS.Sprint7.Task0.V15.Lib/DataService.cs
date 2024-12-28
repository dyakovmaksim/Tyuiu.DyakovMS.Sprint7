using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tyuiu.DyakovMS.Sprint7.Project.V15.Lib
{
    public class DataService
    {
        public List<Contract> Contracts { get; set; } = new List<Contract>();

        public void LoadFromCsv(string filePath)
        {
            if (!File.Exists(filePath)) throw new FileNotFoundException("Файл не найден.");
            var lines = File.ReadAllLines(filePath);
            Contracts = lines.Skip(1).Select(line =>
            {
                var parts = line.Split(';');
                return new Contract
                {
                    ContractCode = parts[0],
                    OrganizationName = parts[1],
                    ExecutionPeriod = parts[2],
                    ContractAmount = decimal.Parse(parts[3]),
                    Notes = parts[4],
                    ContractType = parts[5]
                };
            }).ToList();
        }

        public void SaveToCsv(string filePath)
        {
            var lines = new List<string> { "Шифр договора;Наименование организации;Сроки выполнения;Сумма договора;Примечания;Тип договора" };
            lines.AddRange(Contracts.Select(c => $"{c.ContractCode};{c.OrganizationName};{c.ExecutionPeriod};{c.ContractAmount};{c.Notes};{c.ContractType}"));
            File.WriteAllLines(filePath, lines);
        }

        public List<Contract> Search(string query)
        {
            return Contracts.Where(c => c.OrganizationName.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public (decimal Min, decimal Max, decimal Avg, decimal Sum) GetStatistics()
        {
            if (Contracts == null || Contracts.Count == 0)
            {
                return (0, 0, 0, 0);
            }

            var amounts = Contracts
                .Where(c => c.ContractAmount > 0) 
                .Select(c => c.ContractAmount)
                .ToList();

            if (amounts.Count == 0)
            {
                return (0, 0, 0, 0); 
            }

            return (
                Min: amounts.Min(),
                Max: amounts.Max(),
                Avg: amounts.Average(),
                Sum: amounts.Sum()
            );
        }
    }

    public class Contract
    {
        public string ContractCode { get; set; }
        public string OrganizationName { get; set; }
        public string ExecutionPeriod { get; set; }
        public decimal ContractAmount { get; set; }
        public string Notes { get; set; }
        public string ContractType { get; set; }
    }
}