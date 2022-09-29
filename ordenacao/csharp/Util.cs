namespace heapSort
{
    public class Util
    {
        public static void popularLista(List<int> lista, int quantidade)
        {
            Random gerador = new Random();
            for (int i = 0; i < quantidade; i++)
            {
                lista.Add(gerador.Next(1000));
            }
        }

        public static void exibirLista(List<int> lista)
        {
            foreach (var i in lista)
            {
                Console.WriteLine(i);
            }
        }
    }
}