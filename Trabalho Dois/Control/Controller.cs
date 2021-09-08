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
        public static int Buscar(string palavra, char ad, char ef, char bc, char giu, char hjv, char kl, char moq, char ntp, char rsz, string score)
        {
            if (!RepeteOuNao(palavra))
            {
                return -2;
            }
            else
            {
                List<char> palavraPonto = new List<char>();
                for (int i = 0; i < palavra.Length; i++)
                {
                    palavraPonto.Add(palavra[i]);
                    //Se as tentativas seguirem até chegar em IndexOutOfRangeException, todas as letras são válidas.
                    try
                    {
                        //Chama a função específica de cada letra.
                        if (palavra[i] == 'a' || palavra[i] == 'd')
                        {
                            if (!CasoAd(palavra[i], palavra[i + 1], ef, giu, hjv, ad))
                            {
                                palavraPonto.RemoveAt(palavraPonto.Count);
                                score = Pontuacao(palavraPonto, Convert.ToInt32(score)).ToString(); 
                                return -1;
                            }
                        }
                        else if (palavra[i] == 'e' || palavra[i] == 'f')
                        {
                            if (!CasoEf(palavra[i], palavra[i + 1], ad, bc, hjv, kl, giu, ef))
                            {
                                palavraPonto.RemoveAt(palavraPonto.Count);
                                score = Pontuacao(palavraPonto, Convert.ToInt32(score)).ToString();
                                return -1;
                            }
                        }
                        else if (palavra[i] == 'b' || palavra[i] == 'c')
                        {
                            if (!CasoBc(palavra[i], palavra[i + 1], ef, hjv, kl, bc))
                            {
                                palavraPonto.RemoveAt(palavraPonto.Count);
                                score = Pontuacao(palavraPonto, Convert.ToInt32(score)).ToString();
                                return -1;
                            }
                        }
                        else if (palavra[i] == 'g' || palavra[i] == 'i' || palavra[i] == 'u')
                        {
                            if (!CasoGiu(palavra[i], palavra[i + 1], ad, ef, hjv, moq, ntp, giu))
                            {
                                palavraPonto.RemoveAt(palavraPonto.Count);
                                score = Pontuacao(palavraPonto, Convert.ToInt32(score)).ToString();
                                return -1;
                            }
                        }
                        else if (palavra[i] == 'k' || palavra[i] == 'l')
                        {
                            if (!CasoKl(palavra[i], palavra[i + 1], rsz, ntp, hjv, ef, bc, kl))
                            {
                                palavraPonto.RemoveAt(palavraPonto.Count);
                                score = Pontuacao(palavraPonto, Convert.ToInt32(score)).ToString();
                                return -1;
                            }
                        }
                        else if (palavra[i] == 'm' || palavra[i] == 'o' || palavra[i] == 'q')
                        {
                            if (!CasoMoq(palavra[i], palavra[i + 1], giu, hjv, ntp, moq))
                            {
                                palavraPonto.RemoveAt(palavraPonto.Count);
                                score = Pontuacao(palavraPonto, Convert.ToInt32(score)).ToString();
                                return -1;
                            }
                        }
                        else if (palavra[i] == 'n' || palavra[i] == 't' || palavra[i] == 'p')
                        {
                            if (!CasoNtp(palavra[i], palavra[i + 1], moq, kl, giu, rsz, hjv, ntp))
                            {
                                palavraPonto.RemoveAt(palavraPonto.Count);
                                score = Pontuacao(palavraPonto, Convert.ToInt32(score)).ToString();
                                return -1;
                            }
                        }
                        else if (palavra[i] == 'r' || palavra[i] == 's' || palavra[i] == 'z')
                        {
                            if (!CasoRsz(palavra[i], palavra[i + 1], ntp, hjv, kl, rsz))
                            {
                                palavraPonto.RemoveAt(palavraPonto.Count);
                                score = Pontuacao(palavraPonto, Convert.ToInt32(score)).ToString();
                                return -1;
                            }
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        score = Pontuacao(palavraPonto, Convert.ToInt32(score));
                        return 1;
                    }
                }
               return 1;
            }
        }
        //Funções que verificam se a próxima letra é válida.
        private static bool CasoAd(char letra, char proxLetra, char valido1, char valido2, char valido3, char letraBotao)
        {
            if (letra != letraBotao)
            {
                return false;
            }
            if (proxLetra == valido1 || proxLetra == valido2 || proxLetra == valido3)
            {
                return true; //A letra é válida
            }
            else
            {
                return false; //A letra não é válida
            }
        }
        private static bool CasoEf(char letra, char proxLetra, char valido1, char valido2, char valido3, char valido4, char valido5, char letraBotao)
        {
            if (letra != letraBotao)//Verifica se a letra inserida é a mesma do botão
            {
                return false;
            }
            if (proxLetra == valido1 || proxLetra == valido2 || proxLetra == valido3 || proxLetra == valido4 || proxLetra == valido5)//A variavel >valido< é a letra disponível no botão
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool CasoBc(char letra, char proxLetra, char valido1, char valido2, char valido3, char letraBotao)
        {
            if (letra != letraBotao)
            {
                return false;
            }
            if (proxLetra == valido1 || proxLetra == valido2 || proxLetra == valido3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool CasoGiu(char letra, char proxLetra, char valido1, char valido2, char valido3, char valido4, char valido5, char letraBotao)
        {
            if (letra != letraBotao)
            {
                return false;
            }
            if (proxLetra == valido1 || proxLetra == valido2 || proxLetra == valido3 || proxLetra == valido4 || proxLetra == valido5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool CasoKl(char letra, char proxLetra, char valido1, char valido2, char valido3, char valido4, char valido5, char letraBotao)
        {
            if (letra != letraBotao)
            {
                return false;
            }
            if (proxLetra == valido1 || proxLetra == valido2 || proxLetra == valido3 || proxLetra == valido4 || proxLetra == valido5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool CasoMoq(char letra, char proxLetra, char valido1, char valido2, char valido3, char letraBotao)
        {
            if (letra != letraBotao)
            {
                return false;
            }
            if (proxLetra == valido1 || proxLetra == valido2 || proxLetra == valido3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool CasoNtp(char letra, char proxLetra, char valido1, char valido2, char valido3, char valido4, char valido5, char letraBotao)
        {
            if (letra != letraBotao)
            {
                return false;
            }
            if (proxLetra == valido1 || proxLetra == valido2 || proxLetra == valido3 || proxLetra == valido4 || proxLetra == valido5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool CasoRsz(char letra, char proxLetra, char valido1, char valido2, char valido3, char letraBotao)
        {
            if (letra != letraBotao)
            {
                return false;
            }
            if (proxLetra == valido1 || proxLetra == valido2 || proxLetra == valido3)
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
                if (cb.Items[i].ToString() == novaPalavra)
                {
                    return -3;
                }
            }
            return 1;
        }
        private static string Pontuacao(List<char> palavra, int score)
        {
            for (int i = 0; i < palavra.Count; i++)
            {
                i += 1;
                try
                {
                    if (!Char.IsWhiteSpace(palavra[i]))
                    {
                        score += 1;
                    }
                }
                catch (Exception)
                {
                }
            }
            return score.ToString();
        }
    }
}