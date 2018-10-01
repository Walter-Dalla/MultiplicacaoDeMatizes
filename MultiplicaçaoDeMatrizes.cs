using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {


        static int[,] produto_matriz_int(int[,] a, int[,] b)//fazer declaraçao do metodo e variaveis a e b
        {
            
            int[,] c = new int[a.GetLength(0), b.GetLength(1)];//declarar c[numero de colunas de A , numero de linhas de B ]


           
            //variaveis para coluna das matrizes
            int colunaA = 0;
            int colunaB = 0;
            int colunaC = 0;

            //variaveis para linhas das matrizes
            int linhaA = 0;
            int linhaB = 0;
            int linhaC = 0;
            //matriz[Coluna , Linha]





            int i = 1;


            //for (colunaA = 0, linhaB = 0; colunaA < a.GetLength(0) ; colunaA++, linhaB++)
            {
                
                Console.WriteLine("Parte {0}",i++);
                for (linhaA = 0, linhaC = 0; linhaA < a.GetLength(1); linhaA++, linhaC++)
                {

                    for (colunaB = 0, colunaC = 0; colunaB < b.GetLength(0); colunaB++, colunaC++)
                    {

                        c[colunaC, linhaC] += a[colunaA, linhaA] * b[colunaB, linhaB] 
                        + a[a.GetLength(0) -colunaA - 1, linhaA] * b[colunaB, b.GetLength(1) -linhaB -1];

                        Console.WriteLine("c[{0} , {1}] = a[{2} , {3}] * b[{4} , {5} + a[{6} , {7}] * b[{8} , {9}]",
                            colunaC, linhaC , colunaA, linhaA, colunaB, linhaB
                            , a.GetLength(0) - colunaA - 1, linhaA, colunaB, b.GetLength(1) - linhaB - 1);
                        Console.WriteLine("{0} = {1} * {2} + {3} * {4}",
                            c[colunaC, linhaC] , a[colunaA, linhaA] , b[colunaB, linhaB],
                            a[a.GetLength(0) - colunaA - 1, linhaA] , b[colunaB, b.GetLength(1) - linhaB - 1]);


                    }
                }
                
            }




            return c;//retornar a variavel c

        }


        static void exibirMatriz(int[,] matriz)
        {
            for (int coluna = 0; coluna < matriz.GetLength(0); coluna++)
            {
                for (int linha = 0; linha < matriz.GetLength(1); linha++)
                {
                    Console.Write("{0:d3}|", matriz[coluna, linha]);
          

                }
                Console.WriteLine("");
            }

        }



        static void Main(string[] args)
        {

            int[,] a =
            {
                {1, 2},
                {3, 4}

            };

            int[,] b =
            {
                {5, 6},
                {7, 8},

            };

            
            

            int[,] c = new int[a.GetLength(0), b.GetLength(1)];//declarar c[numero de colunas de A , numero de linhas de B ]


            //verificar se é possivel fazer a multiplicaçao
            if (a.GetLength(0) == b.GetLength(1))
            {

                c = produto_matriz_int(a, b);//chamar o metodo e alocar na variavel "c"

                exibirMatriz(c);//mostra a matriz C




            }
            else
            {
                Console.WriteLine("!ERRO!\nO número de colunas de A nao é igual ao número de linhas de B!");//exibir erro se nao

            }

            //exibir a matriz "c" na tela

            

            Console.ReadKey();

        }





    }
}
