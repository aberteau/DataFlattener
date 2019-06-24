using System;
using System.Data;
using System.IO;
using DataFlattener.Core;

namespace DataFlattener.TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string p = Path.Combine(currentDirectory, @"..\..\..\..\DataSamples\Json\sample01.json");
            String jsonFilePath = Path.GetFullPath(p);

            string outputPath = @"E:\Temp\DataFlattener";
            
            string json = File.ReadAllText(jsonFilePath);

            DataTableMap dataTableMap = DataTableMapFactory.CreateTestMap();

            Json.DataMapper dataMapper = new Json.DataMapper();
            DataTable dataTable = dataMapper.ToDataTable(json, dataTableMap);

            Json.DataTableConverter dataTableJsonConverter = new Json.DataTableConverter();
            string jsonOutput = dataTableJsonConverter.ToString(dataTable);
            string jsonOutputFilePath = GetFilePath(outputPath, "json");
            File.WriteAllText(jsonOutputFilePath, jsonOutput);

            Xml.DataTableConverter dataTableXmlConverter = new Xml.DataTableConverter();
            string xmlOutput = dataTableXmlConverter.ToString(dataTable);
            string xmlOutputFilePath = GetFilePath(outputPath, "xml");
            File.WriteAllText(xmlOutputFilePath, xmlOutput);

            Csv.DataTableConverter dataTableCsvConverter = new Csv.DataTableConverter();
            string csvOutput = dataTableCsvConverter.ToString(dataTable);
            string csvOutputFilePath = GetFilePath(outputPath, "csv");
            File.WriteAllText(csvOutputFilePath, csvOutput);

            Console.WriteLine("End");
            Console.WriteLine("Press [Enter] to exit...");
            Console.ReadLine();
        }

        private static string GetFilePath(string jsonOutputPath, string extension)
        {
            string chrono = DateTime.Now.ToString("yyMMdd HHmmss");
            string jsonFileName = $"{chrono}.{extension}";

            string jsonPath = Path.Combine(jsonOutputPath, jsonFileName);
            return jsonPath;
        }
    }
}
