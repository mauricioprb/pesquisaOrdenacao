using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1_ordenacao {
    internal class Agitacao {
        public static void agitacao(List<string> lista) {
            bool houveTroca;
            string tmp;
            int i, ini = 0, fim = lista.Count - 1;

            do {
                houveTroca = false;

                for (i = ini; i < fim; i++) {
                    if (string.Compare(lista[i], lista[i + 1], true) > 0) {
                        houveTroca = true;
                        tmp = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = tmp;
                    }
                }
                fim--;

                if (!houveTroca) {
                    break;
                }

                houveTroca = false;

                for (i = fim; i > ini; i--) {
                    if (string.Compare(lista[i], lista[i + 1], true) < 0) {
                        houveTroca = true;
                        tmp = lista[i];
                        lista[i] = lista[i - 1];
                        lista[i - 1] = tmp;
                    }
                }
                ini++;

            } while (houveTroca && ini <= fim);
        }

        public static string exibir(List<string> lista) {
            String nomes = "";
            for (int i = 0; i < lista.Count; i++) {
                nomes = nomes + "\n" + lista[i];
            }
            return nomes;
        }
    }
}