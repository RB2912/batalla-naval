// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tablero = new int[5, 5];
            void paso1_crear_tablero()
            {
                for (int f = 0; f < tablero.GetLength(0); f++)
                {
                    for (int c = 0; c < tablero.GetLength(1); c++)
                    {
                        tablero[f, c] = 0;
                    }
                }
            }
            void paso2_colocar_barcos()
            {
                tablero[4, 1] = 0;
                tablero[1, 3] = 0;
                tablero[2, 4] = 0;
                tablero[2, 0] = 0;

            }
            void paso3_imprimir_tablero()
            {
                String Caracter_a_imprimir = "";
                for (int f = 0; f < tablero.GetLength(0); f++)
                {
                    for (int c = 0; c < tablero.GetLength(1); c++)
                    {

                        switch (tablero[f, c])
                        {
                            case 0:
                                Caracter_a_imprimir = "~";
                                break;
                            case 1:
                                Caracter_a_imprimir = "B";
                                break;
                            case -1:
                                Caracter_a_imprimir = "*";
                                break;
                            case -2:
                                Caracter_a_imprimir = "X";
                                break;
                            default:
                                Caracter_a_imprimir = "~";
                                break;
                        }
                        Console.Write(Caracter_a_imprimir + "");

                    }
                    Console.WriteLine();
                }

                void paso4_ingreso_coordenadas()
                {
                    int fila, columna = 0;
                    Console.Clear();
                    do
                    {
                        Console.Write("Ingresa la fila:");
                        fila = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingresa la columna:");
                        columna = Convert.ToInt32(Console.ReadLine());
                        if (tablero[fila, columna] == 1)
                        {
                            Console.Beep();
                            tablero[fila, columna] = -1;

                        }
                        else
                        {
                            tablero[fila, columna] = -2;
                        }
                    } while (true);


                    Console.ReadKey();
                }

                paso1_crear_tablero();
                Console.ReadKey();

                paso2_colocar_barcos();
                paso3_imprimir_tablero();
                paso4_ingreso_coordenadas();

            }
        }
    }
}

