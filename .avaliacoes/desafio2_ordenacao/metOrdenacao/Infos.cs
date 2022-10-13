using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metOrdenacao {
    internal class Infos {
        public string informacoes(int metodo) {
            string infos =  "";

            if (metodo == 0) {
                infos = "BOLHA - Bubble Sort\r\n\r\n- Estável\r\n- Memória Interna\r\n- Alta complexidade (muito esforço) - O(n^2)\r\n- A estrutura possui 2 " +
                    "partes/porções (1a é a desordenada; 2a parte é a ordenada)\r\n- Adequado para vetores e " +
                    "listas\r\n\r\n0   1   2   3   4   5   6\r\n7   1   4   2   3   9   8\r\n1   4   2   3   7   8   9\r" +
                    "\n1   2   3   4   7   8   9\r\n1   2   3   4   7   8   9\r\n\r\n- Trabalha com o conceito de trocas, ou seja, enquanto" +
                    "houver trocas, o algoritmo não para.\r\n- É considerado bolha, porque 'leva' os maiores para o final da estrutura\r\n\r\n" +
                    "Observação: se a estrutura estiver ordenada ou quase, o bolha terá excelente desempenho";
            } else if (metodo == 1) {
                infos = "SELEÇÃO - Selection Sort\r\nInstável\r\nMemória Interna\r\nAlta complexidade (muito esforço) - O(n^2)\r\nA estrutura possui 2" +
                    "partes/porções (1a é a ordenada; 2a parte é a desordenada)\r\nAdequado para vetores e" +
                    "listas\r\n\r\nTrabalha com conceito de trocas não contíguas. É considerado seleção porque ele seleciona os menores para\r\no início" +
                    "da estrutura\r\n\r\nObservação: se a estrutura estiver ordenada, o método vai funcionar/processar como se a estrutura estivesse desordenada\r\n\r\n" +
                    "0   1   2   3   4   5   6\r\n7   1   4   2   3   9   8\r\n1   7   4   2   3   9   8\r\n1   2   4   7   3   9   8\r\n" +
                    "1   2   3   7   4   9   8\r\n1   2   3   4   7   9   8\r\n1   2   3   4   7   8   9\r";
            } else if (metodo == 2) {
                infos = "INSERÇÃO - Insertion Sort - O(n^2)\r\n\r\nEstável\r\nMemória Interna\r\nAlta complexidade - O(n^2)\r\nA estrutura possui 2" +
                    "partes/porções (1a é a ordenada; 2a parte é a desordenada)\r\nAdequado para vetores e listas\r\n\r\nTrabalha com o conceito de" +
                    "inserção na porção inicial, com isso, pode diminuir o número de comparações\r\n\r\nObservação: I) se a estrutura estiver" +
                    "ordenada ou quase, o inserção terá excelente desempenho\r\nII) atenção a lista deve ser duplamente encadeada\r\n\r\n\r\n\r\n" +
                    "Qual o melhor método de ordenação?\r\nDepende: tamanho da estrutura; de como a estrutura já está previamente ordenada;";
            } else if (metodo == 3) {
                infos = "AGITAÇÃO - Shake Sort ou Cocktail\r\n\r\nÉ baseado no Bolha, ou seja, é uma tentantiva de melhorar o Bolha.\r\nEstável\r\nMemória Interna\r\n" +
                    "A estrutura possui 3 partes/porções (1a é a ordenada pelos menores; 2a é a desordenada; 3a é \r\na ordenada pelos maiores)\r\n\r\n" +
                    "De fato é a aplicação do bolha da esquerda para direita e depois da direita para esquerda\r\n\r\nHá os índices/ponteiros ini e fim que" +
                    "marcam o início e o final da estrutura\r\n\r\nObservação: I) se a estrutura estiver ordenada ou quase, o agitação terá excelente desempenho," +
                    "como o bolha\r\nII) atenção a lista deve ser duplamente encadeada";
            } else if (metodo == 4) {
                infos = "PENTE - Comb Sort\r\n\r\nÉ baseado no Bolha, ou seja, é uma tentantiva de melhorar o Bolha.\r\n\r\nATENÇÃO: a partir deste método, há COMPARAÇÕES" +
                    "a uma distância X. Isso gera uma pré-organização da estrutura,\r\n         diminuindo número de comparações e trocas.\r\n\r\nInstável\r\nMemória" +
                    "Interna\r\nA estrutura possui 2 porções/partes (1a é a ordenada; 2a é a desordenada)\r\n\r\nHá as variáveis clássicas do bolha: i, houveTroca," +
                    "tmp.\r\nHá a variável distancia que é calculada pelo tamanho da estrutura dividido por 1.3\r\n\r\nAdequado somente para vetores ou estruturas" +
                    "prontas tipo lista de uma linguagem de programação\r\nn = 7\r\n0   1   2   3   4   5   6   \r\n7   1   4   2   3   9   8    " +
                    "distancia = (int)n / 1.3 = 5\r\n7   1   4   2   3   9   8    distancia = distancia / 1.3 = 3\r\n2   1   4   7   3   9   8    " +
                    "distancia = distancia / 1.3 = 2\r\n2   1   3   7   4   9   8    distancia = distancia / 1.3 = 1\r\n1   2   3   4   7   8   9    " +
                    "distancia = 1\r\n1   2   3   4   7   8   9";
            } else if (metodo == 5) {
                infos = "SHELLSORT \r\n\r\nÉ baseado no Inserção, ou seja, é uma tentativa de melhoria via o uso da ANÁLISE A DISTÂNCIA (tipo pente)\r\nInstável" +
                    "\r\nMemória Interna\r\n\r\nNão é adequado para listas encadeadas";
            } else if (metodo == 6) {
                infos = "QUICKSORT (USA O CONCEITO DE DIVIDIR PARA CONQUISTAR)\r\n\r\nFaz parte de uma categoria de métodos de ordenação que utilizam a divisão da estrutura" +
                    "para acelerar a ordenação. Essa divisão é realizada por \r\nmeio de RECURSÃO.\r\n    - A estrutura vai possuir 2 porções: parte esquerda e parte direita," +
                    "divididas pelo PIVO. Pensar como se fosse uma ÁRVORE BINÁRIA\r\n    - O método possui duas funções: quick (processo recursivo) e" +
                    "o particiona (posiciona/ordena o pivo)";
            } else if (metodo == 7) {
                infos = "HEAPSORT (método baseado na dinâmica de árvores binárias, contudo em vetor)\r\n\r\n    - Heapmáximo: garantir que raiz da subarvore seja" +
                    "maior ou igual que seus filhos. Se isso não ocorrer, fazer as trocas\r\n        filhoEsquerda = posicaoRaiz * 2\r\n        " +
                    "filhoDireita = posicaoRaiz * 2 + 1\r\n    - Troca do primeiro com o último e diminui uma posição o vetor (fim)\r\n\r\n    " +
                    "ATENÇÃO: o vetor deve começar na posição 1\r\n\r\n    Teste para filho esquerda \r\n        -> if (vetor[raiz] < vetor[raiz * 2]) { troca }\r\n    " +
                    "Teste para o filho da direita (antes de testar, é preciso ter certeza que o filho exista)\r\n        " +
                    "-> if (raiz * 2 + 1 < n && vetor[raiz] < vetor[raiz * 2 + 1]) { troca }";
            }

            return infos;
        }
    }
}
