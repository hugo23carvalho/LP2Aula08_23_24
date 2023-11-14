﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;

namespace Exercicio4
{
    /// <summary>
    /// Resolução do exercício 4 da aula.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Nome do ficheiro a ler.
        /// </summary>
        private const string FileName = "test.txt";

        /// <summary>
        /// URL do ficheiro de texto a descarregar da web.
        /// </summary>
        private const string TxtUrl = "http://textfiles.com/stories/roger1.txt";

        /// <summary>
        /// O programa começa aqui.
        /// </summary>
        private static void Main()
        {
            string[] lines;

            int numLinesGt30;
            double avgCharsInLines;
            bool anyWithMoreThan120Chars;
            IEnumerable<string> firstWordOfLineWithCharY;

            if (!File.Exists(FileName))
            {
                using HttpClient client = new HttpClient();
                string fileText = client.GetStringAsync(TxtUrl).Result;
                File.WriteAllText(FileName, fileText);
            }

            lines = File.ReadAllLines(FileName);

            numLinesGt30 = lines.Count(s => s.Length > 30);
            Console.WriteLine($"Linhas > 30     : {numLinesGt30}");

            avgCharsInLines = lines.Average(s => s.Length);
            Console.WriteLine($"Média nº chars  : {avgCharsInLines:f}");

            anyWithMoreThan120Chars = lines.Any(s => s.Length > 120);
            Console.WriteLine($"Algum com +120? : {anyWithMoreThan120Chars}");

            firstWordOfLineWithCharY = lines
                .Where(s => s.Contains('Y'))
                .Select(s => s.Trim().Split()[0].ToUpper());

            Console.WriteLine(
                "Primeira palavra em maiúsculas de linhas com 'Y'");
            foreach (string s in firstWordOfLineWithCharY)
            {
                Console.WriteLine($"=> {s}");
            }
        }
    }
}