﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cdd, dia, ano, mes;
            string cdc, mesextenso;


            Console.WriteLine("1- Atibaia 2- Bragança Paulista 3- Mairiporã 4- Nazaré 5- Terra Preta 6- Extrema 7- vargem ");
            Console.WriteLine("digite o Codigo da Cidade");
            cdd = double.Parse(Console.ReadLine());

            switch (cdd)
            {
                case 1:
                    cdc = "Atibaia";
                    break;
                case 2:
                    cdc = "Bragança Paulista";
                    break;
                case 3:
                    cdc = "Mairiporã";
                    break;
                case 4:
                    cdc = "Nazaré";
                    break;
                case 5:
                    cdc = "Terra Preta";
                    break;
                case 6:
                    cdc = "Extrema";
                    break;
                case 7:
                    cdc = "Vargem";
                    break;

                default:
                    cdc = " Codigo da Cidade invalido";
                    break;
            }
            Console.WriteLine("digite o Dia");
            dia = double.Parse(Console.ReadLine());


            Console.WriteLine("digite o Mes");
            mes = double.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    mesextenso = "Janeiro";
                    break;
                case 2:
                    mesextenso = "Fevereiro";
                    break;
                case 3:
                    mesextenso = "Março";
                    break;
                case 4:
                    mesextenso = "Abril";
                    break;
                case 5:
                    mesextenso = "Maio";
                    break;
                case 6:
                    mesextenso = "Junho";
                    break;
                case 7:
                    mesextenso = "Julho";
                    break;
                case 8:
                    mesextenso = "Agosto";
                    break;
                case 9:
                    mesextenso = "Setembro";
                    break;
                case 10:
                    mesextenso = "Outubro";
                    break;
                case 11:
                    mesextenso = "Novembro";
                    break;
                case 12:
                    mesextenso = "Dezembro";
                    break;
                default:
                    mesextenso = "Mes invalido";
                    break;
            }

            Console.WriteLine("digite o Ano");
            ano = double.Parse(Console.ReadLine());

            Console.WriteLine(cdc + ", " + dia + " de " + mesextenso + " de " + ano);


            Console.ReadKey();
        }
    }
}
