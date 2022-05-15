/*Faça um programa para ler um arquivo contendo nomes de pessoas (um nome por
   linha), armazenando-os em uma lista. Depois, ordenar os dados dessa lista e mostra-los
  ordenadamente na tela. Nota: o caminho do arquivo pode ser informado "hardcode".*/

using System;
using System.Collections.Generic;
using System.IO;
namespace IComprableInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Temp\nomes.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path)) // Lendo o arquivo
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine()); //Adicionando as linhas em uma posicao no vetor
                    }
                    list.Sort(); //ordenando lista
                    foreach (var name in list)
                    {
                        Console.WriteLine(name);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                string a = Console.ReadLine();
            }
        }
    }
}
