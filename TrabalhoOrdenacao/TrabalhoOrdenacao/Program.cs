using System;
using System.Diagnostics;

namespace TrabalhoOrdenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            int[] vetor1 = new int[100000];
            int[] vetor2 = new int[100000];
            int[] vetor3 = new int[100000];
            
            int j = 0;
            iniciaVetores(vetor1, vetor2, vetor3);

            Console.WriteLine("############################## INSERTION SORT #####################################\n");
            stopwatch.Start();
            OrdenacaoUtil.insertionSort(vetor1);
            stopwatch.Stop();
            Console.WriteLine("Tempo de execução da função de ordenação do Insertion Sort: " + stopwatch.Elapsed);
            stopwatch.Reset();
            stopwatch.Start();
            OrdenacaoUtil.insertionSort(vetor2);
            stopwatch.Stop();
            Console.WriteLine("Tempo de execução vetor 2 método insertion Sort: " + stopwatch.Elapsed);
            stopwatch.Reset();
            stopwatch.Start();
            OrdenacaoUtil.insertionSort(vetor3);
            stopwatch.Stop();
            Console.WriteLine("Tempo de execução vetor 3 método insertion Sort: " + stopwatch.Elapsed);
            iniciaVetores(vetor1, vetor2, vetor3);
            Console.WriteLine("############################## SELECTION SORT #####################################\n");
            stopwatch.Reset();
            stopwatch.Start();
            OrdenacaoUtil.selectionSort(vetor1);
            stopwatch.Stop();
            Console.WriteLine("Tempo de execução vetor 1 método selection Sort: " + stopwatch.Elapsed);

            stopwatch.Reset();
            stopwatch.Start();
            OrdenacaoUtil.selectionSort(vetor2);
            stopwatch.Stop();
            Console.WriteLine("Tempo de execução vetor 2 método selection Sort: " + stopwatch.Elapsed);


            stopwatch.Reset();
            stopwatch.Start();
            OrdenacaoUtil.selectionSort(vetor3);
            stopwatch.Stop();
            Console.WriteLine("Tempo de execução vetor 3 método selection Sort: " + stopwatch.Elapsed);

            Console.WriteLine("############################## BUBBLE SORT #####################################\n");
            iniciaVetores(vetor1, vetor2, vetor3);
            stopwatch.Reset();
            stopwatch.Start();
            OrdenacaoUtil.bubbleSort(vetor1);
            stopwatch.Stop();
            Console.WriteLine("Tempo de execução vetor 1 método Bubble Sort: " + stopwatch.Elapsed);

            stopwatch.Reset();
            stopwatch.Start();
            OrdenacaoUtil.bubbleSort(vetor2);
            stopwatch.Stop();
            Console.WriteLine("Tempo de execução vetor 2 método Bubble Sort: " + stopwatch.Elapsed);

            stopwatch.Reset();
            stopwatch.Start();
            OrdenacaoUtil.bubbleSort(vetor3);
            stopwatch.Stop();
            Console.WriteLine("Tempo de execução vetor 3 método Bubble Sort: " + stopwatch.Elapsed);

            Console.WriteLine("############################## QUICK SORT #####################################\n");

            stopwatch.Reset();
            stopwatch.Start();
            OrdenacaoUtil.quickSort(vetor1);
            stopwatch.Stop();
            Console.WriteLine("Tempo de execução vetor 1 método Bubble Sort: " + stopwatch.Elapsed);

            stopwatch.Reset();
            stopwatch.Start();
            OrdenacaoUtil.quickSort(vetor2);
            stopwatch.Stop();
            Console.WriteLine("Tempo de execução vetor 2 método Bubble Sort: " + stopwatch.Elapsed);

            stopwatch.Reset();
            stopwatch.Start();
            OrdenacaoUtil.quickSort(vetor3);
            stopwatch.Stop();
            Console.WriteLine("Tempo de execução vetor 3 método Bubble Sort: " + stopwatch.Elapsed);
            

            Console.WriteLine("############################## MERGE SORT #####################################\n");
            stopwatch.Reset();
            stopwatch.Start();
            OrdenacaoUtil.mergeSortNumbers(new int[vetor1.Length], 0, vetor1.Length, vetor1);
            stopwatch.Stop();
            Console.WriteLine("Tempo de execução vetor 1 método Merge Sort: " + stopwatch.Elapsed);

            stopwatch.Reset();
            stopwatch.Start();
            OrdenacaoUtil.mergeSortNumbers(new int[vetor2.Length], 0, vetor2.Length, vetor2);
            stopwatch.Stop();
            Console.WriteLine("Tempo de execução vetor 2 método Merge Sort: " + stopwatch.Elapsed);

            stopwatch.Reset();
            stopwatch.Start();
            OrdenacaoUtil.mergeSortNumbers(new int[vetor3.Length], 0, vetor3.Length, vetor3);
            stopwatch.Stop();
            Console.WriteLine("Tempo de execução vetor 3 método Merge Sort: " + stopwatch.Elapsed);

            Console.ReadLine();
        }


        public static void iniciaVetores(int[] vet1, int[] vet2, int[] vet3) {
            int j = 0;
            Random random = new Random();
            for (int i = 0; i < 100000; i++)
            {
                vet1[i] = i;
            }

            for (int i = 100000; i > 0; i--)
            {

                vet2[j++] = i;
            }

            for (int i = 0; i < 100000; i++)
            {

                int numRandom = random.Next(0, 100000);
                vet3[i] = numRandom;
            }
        }

        
    }
}
