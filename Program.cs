﻿using System;

namespace EditorDeTexto
{
    class EditorDeTexto
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine(" O que deseja fazer?");
            Console.WriteLine(" 1 - Abrir o arquivo");
            Console.WriteLine(" 2 - Editar arquivo");
            Console.WriteLine(" 0 - Sair");
            short option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default:Menu(); break;
            }
            static void Abrir()
            {

            }
            static void Editar()
            {
                Console.Clear();
                Console.WriteLine("Digite o texto abaixo (ESC para sair)");
                Console.WriteLine("-------------------------------------");
                string text = "";

                while(Console.ReadKey().Key != ConsoleKey.Escape);

            }
        }
    }
}