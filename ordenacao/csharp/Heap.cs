namespace heapSort
{
    public class Heap
    {
        bool estaOrdenado(List<int> lista)
        {

        }

        bool estaHeapMaximo(List<int> lista)
        {
            int i;

            for (i = 0; i < lista.Count - 1; i++)
            {
                if ((lista[i] >= lista[i * 2]) && (lista[i] >= lista[i * 2 + 1]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}