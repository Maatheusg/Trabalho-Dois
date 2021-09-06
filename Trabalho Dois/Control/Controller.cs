using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Dois.Control
{
    class Controller
    {
        public static int Buscar(string palavra, char ad, char ef, char bc, char giu, char kl, char moq, char ntp, char rsz)
        {
            if (!RepeteOuNao(palavra))
            {
                return -2;
            }
            else
            {
                for (int i = 0; i < palavra.Length; i++)
                {
                    //Se as tentativas seguirem até chegar em IndexOutOfRangeException, todas as letras são válidas.
                    try
                    {
                        //Chama a função específica de cada letra.
                        if (palavra[i] == ad)
                        {
                            if (!CasoAd(palavra, palavra[i + 1]))
                            {
                                return -1;
                            }
                        }
                        else if (palavra[i] == ef)
                        {
                            if (!CasoEf(palavra, palavra[i + 1]))
                            {
                                return -1;
                            }
                        }
                        else if (palavra[i] == bc)
                        {
                            if (!CasoBc(palavra, palavra[i + 1]))
                            {
                                return -1;
                            }
                        }
                        else if (palavra[i] == giu)
                        {
                            if (!CasoGiu(palavra, palavra[i + 1]))
                            {
                                return -1;
                            }
                        }
                        else if (palavra[i] == kl)
                        {
                            if (!CasoKl(palavra, palavra[i + 1]))
                            {
                                return -1;
                            }
                        }
                        else if (palavra[i] == moq)
                        {
                            if (!CasoMoq(palavra, palavra[i + 1]))
                            {
                                return -1;
                            }
                        }
                        else if (palavra[i] == ntp)
                        {
                            if (!CasoNtp(palavra, palavra[i + 1]))
                            {
                                return -1;
                            }
                        }
                        else if (palavra[i] == rsz)
                        {
                            if (!CasoRsz(palavra, palavra[i + 1]))
                            {
                                return -1;
                            }
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        return 1;
                    }
                }
                return 1;
            }
        }
        //Funções que verificam se a próxima letra é válida.
        private static bool CasoAd(string palavra, char proxLetra)
        {
            if (proxLetra == 'e' || proxLetra == 'f' || proxLetra == 'g' || proxLetra == 'i' || proxLetra == 'u' || proxLetra == 'h' || proxLetra == 'j' || proxLetra == 'v')
            {
                return true; //A letra é válida
            }
            else
            {
                return false; //A letra não é válida
            }
        }
        private static bool CasoEf(string palavra, char proxLetra)
        {
            if (proxLetra != 'm' || proxLetra != 'o' || proxLetra != 'q' || proxLetra != 'n' || proxLetra != 't' || proxLetra != 'p' || proxLetra != 'r' || proxLetra != 's' || proxLetra != 'z')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool CasoBc(string palavra, char proxLetra)
        {
            if (proxLetra == 'e' || proxLetra == 'f' || proxLetra == 'k' || proxLetra == 'l' || proxLetra == 'h' || proxLetra == 'j' || proxLetra == 'v')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool CasoGiu(string palavra, char proxLetra)
        {
            if (proxLetra != 'b' || proxLetra != 'c' || proxLetra != 'k' || proxLetra != 'l' || proxLetra != 'r' || proxLetra != 's' || proxLetra != 'z')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool CasoKl(string palavra, char proxLetra)
        {
            if (proxLetra == 'a' || proxLetra == 'd' || proxLetra == 'g' || proxLetra == 'i' || proxLetra == 'u' || proxLetra == 'm' || proxLetra == 'o' || proxLetra == 'q')
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool CasoMoq(string palavra, char proxLetra)
        {
            if (proxLetra == 't' || proxLetra == 'n' || proxLetra == 'p' || proxLetra == 'g' || proxLetra == 'i' || proxLetra == 'u' || proxLetra == 'h' || proxLetra == 'j' || proxLetra == 'v')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool CasoNtp(string palavra, char proxLetra)
        {
            if (proxLetra != 'b' || proxLetra != 'c' || proxLetra != 'a' || proxLetra != 'd' || proxLetra != 'e' || proxLetra != 'f')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool CasoRsz(string palavra, char proxLetra)
        {
            if (proxLetra == 'n' || proxLetra == 't' || proxLetra == 'p' || proxLetra == 'k' || proxLetra == 'l' || proxLetra == 'h' || proxLetra == 'j' || proxLetra == 'v')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool RepeteOuNao(string palavra)
        {
            for (int i = 0; i < palavra.Length; i++)
            {
                for (int j = palavra.Length - 1; j > i; j--)
                {
                    if (palavra[i] == palavra[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static int RepetePalavra(ComboBox cb, string novaPalavra)
        {
            for (int i = 0; i < cb.Items.Count; i++)
            {
                string a1 = cb.Items[i].ToString();
                for (int j = cb.Items.Count; j > i; j--)
                {
                    if (a1 == novaPalavra)
                    {
                        return -3;
                    }
                }
            }
            return 1;
        }
    }
}