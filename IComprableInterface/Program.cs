/*Faça um programa para ler um arquivo contendo funcionários (nome e salário) no
formato .csv, armazenando-os em uma lista. Depois, ordenar a lista por nome e mostrar
o resultado na tela. Nota: o caminho do arquivo pode ser informado "hardcode".
*/

using System;
using System.Collections.Generic;
using System.IO;
using Entities;
namespace IComprableInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Temp\nomes.csv";

            try
            {
                using (StreamReader sr = File.OpenText(path)) // Lendo o arquivo
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine())); //Adicionando as linhas em uma posicao no vetor
                    }
                    list.Sort(); //ordenando lista
                    foreach (Employee emplo in list)
                    {
                        Console.WriteLine(emplo);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                string a = Console.ReadLine();
            }
        }
    }
}
