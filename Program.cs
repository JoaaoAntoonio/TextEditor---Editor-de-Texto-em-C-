﻿using System;
using System.Runtime.InteropServices;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer ?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());


            switch (option)
            {
                case 0:
                    System.Environment.Exit(0); break;
                case 1:
                    Abrir(); break;
                case 2:
                    Editar(); break;
                default:
                    Menu(); break;
            }
            static void Abrir()
            {
                Console.Clear();
                Console.WriteLine("Qual caminho do arquivo?");
                string path = Console.ReadLine();

                using (var file = new StreamReader(path))
                {
                    string text = file.ReadToEnd();
                    Console.WriteLine(text);

                }

                Console.WriteLine("---Fim do arquivo---");
                Console.WriteLine("Pressione ENTER para voltar ao menu");
                Console.ReadLine();
                Menu();



            }
           static void Editar()
{
    Console.Clear();
    Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
    Console.WriteLine("************************");

    string text = "";
    ConsoleKeyInfo keyInfo;

    while (true)
    {
        keyInfo = Console.ReadKey(true); // lê uma tecla sem mostrar

        if (keyInfo.Key == ConsoleKey.Escape)
            break; // sai do loop ao apertar ESC

        else if (keyInfo.Key == ConsoleKey.Enter)
        {
            text += Environment.NewLine;
            Console.WriteLine(); // pula linha no console
        }
        else if (keyInfo.Key == ConsoleKey.Backspace)
        {
            if (text.Length > 0)
            {
                text = text.Substring(0, text.Length - 1); // remove última letra da string
                Console.Write("\b \b"); // apaga do console
            }
        }
        else
        {
            text += keyInfo.KeyChar; // adiciona letra à string
            Console.Write(keyInfo.KeyChar); // mostra no console
        }
    }

    Salvar(text);
}
             
         static void Salvar(string text)
            {
                Console.Clear();
                Console.WriteLine("Qual caminho para salvar o arquivo?");
                var path = Console.ReadLine();

                using (var file = new StreamWriter(path))
                {
                    file.Write(text);
                }

                Console.WriteLine($"Arquivo {path} foi salvo com sucesso!");
                Thread.Sleep(1000);
                Console.ReadLine();
                Menu();

             }
        }
    }
}
