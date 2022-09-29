using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace heapSort
{
    class Program
    {
        List<int> listaHeap = new List<int>();

        Console.Write("Quantidade números: ");
        int qtd = Int32.Parse(Console.ReadLine());

        Util.popularLista(listaHeap, qtd);

        Heap.estaHeapMaximo(listaHeap);
    }
}