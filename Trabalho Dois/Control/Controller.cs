<<<<<<< Updated upstream
﻿namespace Trabalho_Dois.Control
{
    class Controller
    {
        public static int Busca(string caracter)
        {
            //int[][] letra = new int[2][];
            //letra[0] = new int[2];
            //letra[1] = new int[2];
            for (int i = 0; i < caracter.Length; i++)
            {

                if (caracter[i] == 'a' || caracter[i] == 'd')
                {

                }
                if (caracter[i] == 'e' || caracter[i] == 'f')
                {

                }
                if (caracter[i] == 'b' || caracter[i] == 'c')
                {

                }
                if (caracter[i] == 'g' || caracter[i] == 'i' || caracter[i] == 'u')
                {

                }
                if (caracter[i] == 'h' || caracter[i] == 'j' || caracter[i] == 'v')
                {

                }
                if (caracter[i] == 'k' || caracter[i] == 'l')
                {

                }
                if (caracter[i] == 'm' || caracter[i] == 'o' || caracter[i] == 'q')
                {

                }
                if (caracter[i] == 'n' || caracter[i] == 't' || caracter[i] == 'p')
                {

                }
                if (caracter[i] == 'r' || caracter[i] == 's' || caracter[i] == 'z')
                {

                }
            }






        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Dois.Control
{
    class Controller
    {
        public static int Buscar(string palavra)
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
                        switch (palavra[i])
                        {
                            case 'a':
                            case 'd':
                                if (!CasoAd(palavra, palavra[i + 1]))
                                {
                                    return -1;
                                }
                                break;
                            case 'e':
                            case 'f':
                                if (!CasoEf(palavra, palavra[i + 1]))
                                {
                                    return -1;
                                }
                                break;
                            case 'b':
                            case 'c':
                                if (!CasoBc(palavra, palavra[i + 1]))
                                {
                                    return -1;
                                }
                                break;
                            case 'g':
                            case 'i':
                            case 'u':
                                if (!CasoGiu(palavra, palavra[i + 1]))
                                {
                                    return -1;
                                }
                                break;
                            case 'k':
                            case 'l':
                                if (!CasoKl(palavra, palavra[i + 1]))
                                {
                                    return -1;
                                }
                                break;
                            case 'm':
                            case 'o':
                            case 'q':
                                if (!CasoMoq(palavra, palavra[i + 1]))
                                {
                                    return -1;
                                }
                                break;
                            case 'n':
                            case 't':
                            case 'p':
                                if (!CasoNtp(palavra, palavra[i + 1]))
                                {
                                    return -1;
                                }
                                break;
                            case 'r':
                            case 's':
                            case 'z':
                                if (!CasoRsz(palavra, palavra[i + 1]))
                                {
                                    return -1;
                                }
                                break;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        return 1;
                    }
                }
                return -1;
            }
        }
        //Funções que verificam se a próxima letra é válida.
        private static bool CasoAd(string palavra, char proxLetra)
        {
            if (proxLetra == 'e' || proxLetra == 'f' || proxLetra == 'g' || proxLetra == 'i' || proxLetra == 'u' || proxLetra == 'h' || proxLetra == 'j' || proxLetra == 'v')
            {
                return true;
            }
            else
            {
                return false;
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
            char word = palavra[0];
            for (int j = palavra.Length - 1; j > 1; j--)
            {
                if (word == palavra[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
>>>>>>> Stashed changes
