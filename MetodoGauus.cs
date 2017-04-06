using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Selas
{
    class MetodoGauus
    {
        public double[,] a = new double[5, 5];//matris com os coeficientes

        public void Gauus()
        {
            double pivo = 0; // Diagonal principal
            double m = 0; // Faz a divição com o pivo
            double[] v = new double[5]; // Vetor da troca
            int l = 0; // Variavel para fazer a torca caso pivo seja 0
            double C, L;

            Console.Write(" Informe a quantidade de linhas da matriz : ");
            L = int.Parse(Console.ReadLine());
            Console.Write("\n Informe a quantidade de colunas da matriz : ");
            C = int.Parse(Console.ReadLine());

            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    Console.Write("Informe o valor da Linha e da Coluna da Matriz : ");
                    a[i, j] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.Write("Matriz A \n\n");

            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    Console.Write(" " + a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Resposta da Matriz");
            Console.WriteLine();

            for (int i = 0; i <= C; i++)
            {
                for (int j = 0; j <= L; j++)
                {
                    if (i == j) // Parte para achar o pivo
                    {
                        pivo = a[i, j];
                        if (pivo == 0)// caso o pivo for 0 inverte com a linha de baixo
                        {
                            for (int q = 0; q <= L; q++)// Onde faz a troca com alinha de baixo
                            {
                                v[q] = a[i, q];
                                a[i, q] = a[i + l, q];
                                a[i + 1, q] = v[q];
                            }
                            pivo = a[i, j];
                            l++;

                        }
                        else if (pivo != 0)
                        {

                            for (int c = i + 1; c <= L; c++) // Calculo principal
                            {
                                m = -(a[c, j]) / pivo;
                                for (int k = j; k <= C; k++)
                                {
                                    a[c, k] = (a[i, k] * m) + a[c, k];

                                }


                            }
                        }
                    }
                }
            }
            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    Console.Write(" " + a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
