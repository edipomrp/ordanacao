using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoOrdenacao
{
    static class OrdenacaoUtil
    {
        public static int[] insertionSort(int[] vetor) {
            int i, j, atual;
            for (i = 1; i < vetor.Length; i++) {
                atual = vetor[i];
                j = i;
                while ((j > 0) && (vetor[j - 1] > atual)) {
                    vetor[j] = vetor[j - 1];
                    j = j - 1;
                }
                vetor[j] = atual;
            }

            return vetor;
        }

        public static int[] selectionSort(int[] vetor) {
            int min, aux;
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < vetor.Length; j++)
                    if (vetor[j] < vetor[min])
                        min = j;
                if (min != i)
                {
                    aux = vetor[min];
                    vetor[min] = vetor[i];
                    vetor[i] = aux;
                }
            }
            return vetor;
        }

        public static int[] bubbleSort(int[] vetor) {
            int tamanho = vetor.Length;
            int comparacoes = 0;
            int trocas = 0;
            for (int i = tamanho - 1; i >= 1; i--) {
                for (int j = 0; j < i; j++) {
                    comparacoes++;
                    if (vetor[j] > vetor[j + 1]) {
                        int aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                        trocas++;
                    }
                }
            }
            return vetor;
        }

        public static int[] quickSort(int[] vetor) {
            int inicio = 0;
            int fim = vetor.Length - 1;
            quickSort(vetor, inicio, fim);

            return vetor;

        }


        private static void quickSort(int[] vetor, int inicio, int fim)
        {

            if (inicio < fim)

            {

                int p = vetor[inicio];
                int i = inicio + 1;
                int f = fim;

                while (i <= f)

                {

                    if (vetor[i] <= p)

                    {

                        i++;

                    }

                    else if (p < vetor[f])

                    {

                        f--;

                    }

                   else
                    {
                       int troca = vetor[i];
                        vetor[i] = vetor[f];
                        vetor[f] = troca;
                        i++;
                        f--;

                    }
                }
                vetor[inicio] = vetor[f];
                vetor[f] = p;
                quickSort(vetor, inicio, f - 1);
                quickSort(vetor, f + 1, fim);

            }
        }

        public static void mergeSortNumbers(int[] B, int iStart, int iEnd, int[] A)
        {
            if ((iEnd - iStart) < 2) return;

            int iMiddle = (iStart + iEnd) / 2;
            mergeSortNumbers(A, iStart, iMiddle, B);
            mergeSortNumbers(A, iMiddle, iEnd, B);
            Merge(B, iStart, iMiddle, iEnd, A);
        }

        private static void Merge(int[] A, int iStart, int iMiddle, int iEnd, int[] B)
        {
            int i = iStart;
            int j = iMiddle;

            for (int k = iStart; k < iEnd; k++)
            {
                if (i < iMiddle && (j >= iEnd || A[i] <= A[j]))
                {
                    B[k] = A[i++];
                }
                else
                {
                    B[k] = A[j++];
                }
            }
        }
    }




}
