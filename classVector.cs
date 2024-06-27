using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicoVectores2
{
    class classVector
    {
        const int dimension = 100;
        private int[] vector;
        private int cantidad;
        public classVector()
        {
            vector = new int[dimension];
            cantidad = 0;
        }
        // ------------------------------------------------------
        // Operaciones para el vector ***************************
        public void cargarRandom(int cant, int inicio, int fin)
        {
            Random rand = new Random();
            this.cantidad = cant;
            for (int ter = 1; ter <= this.cantidad; ter++)
            {
                vector[ter] = rand.Next(inicio, fin + 1);
            }
        }
        public string descargar()
        {
            string separador = "";
            for (int ter = 1; ter <= this.cantidad; ter++)
            {
                separador = separador + vector[ter] + "|";
            }
            return separador;
        }
        public void cargarElexEle(int dato)
        {
            this.cantidad++;
            vector[this.cantidad] = dato;
        }
        // Funciones auxilares para los ejercicios *************************
        // *****************************************************************

        // Funcion auxiliar para un vector fibonacci
        public void fibonacci(int dato)
        {
            int varA, varB, varR;
            varA = -1; varB = 1;
            this.cantidad = dato;

            for (int ter = 1; ter <= this.cantidad; ter++)
            {
                varR = varA + varB;
                vector[ter] = varR;
                varA = varB; varB = varR;
            }
        }
        // Funcion auxialiar para una busqueda de elemento
        public bool busqueSecuencial(int dato)
        {
            bool respuesta = false;
            int posi = 1;
            while (posi <= this.cantidad && respuesta == false)
            {
                if (vector[posi] == dato)
                {
                    respuesta = true;
                }
                posi++;
            }
            return respuesta;
        }

        // funcion auxiliar para intercambio 
        public void intercambio(int date1, int date2)
        {
            int aux = vector[date2];
            vector[date2] = vector[date1];
            vector[date1] = aux;
        }
        // Funciona auxiliar para ordenamiento
        public void ordenamientoBurbuja()
        {
            for (int ter1 = this.cantidad; ter1 > 1; ter1--)
            {
                for (int ter2 = 1; ter2 < this.cantidad; ter2++)
                {
                    if (vector[ter2] > vector[ter2 + 1])
                    {
                        this.intercambio((ter2), (ter2 + 1));
                    }
                }
            }
        }
        // Funcion auxiliar para ordenamiento 2
        public void ordenIntercambio()
        {
            for (int ter1 = 1; ter1 < this.cantidad; ter1++)
            {
                for (int ter2 = ter1 + 1; ter2 <= this.cantidad; ter2++)
                {
                    if (vector[ter2] < vector[ter1])
                    {
                        this.intercambio(ter2, ter1);
                    }
                }
            }
        }
        // Funcion auxiliar para ordenamiento por parametros
        public void ordenParmetros(int date1, int date2)
        {
            for (int ter1 = date1; ter1 < date2; ter1++)
            {
                for (int ter2 = ter1 + 1; ter2 <= date2; ter2++)
                {
                    if (vector[ter2] > vector[ter1])
                    {
                        this.intercambio(ter2, ter1);
                    }
                }
            }
        }
        // Funcion auxiliar para encontrar el elemento frecuente por parametros
        public int elemFrecuParam(int number, int inicio, int fin)
        {
            int conta = 0;
            for (int ter = inicio; ter <= fin; ter++)
            {
                if (vector[ter] == number)
                {
                    conta++;
                }
            }
            return conta;
        }


        // ************************************************************
        // ----- Practico 1: primera parte -----
        // Pregunta 1 *******************************
        // Cargar Elementos con la serie fibonacci de derecha a izquierda *****
        public void fibonaccInvertir(int number)
        {
            int varA, varB, varR;
            varA = -1; varB = 1;
            this.cantidad = number;
            for (int ter = this.cantidad; ter > 0; ter--)
            {
                varR = varA + varB;
                vector[ter] = varR;
                varA = varB; varB = varR;
            }
        }
        // Pregunta 2 *****************************
        // Realiza una operacion de suma y resta de fracciones (revisar el practico 1)
        public double fraccionFibonacci(int number)
        {
            double sumadorSum = 0;
            double sumadorRes = 0;
            bool bandera = true;
            double respuesta = 0;

            for (int ter = 1; ter <= this.cantidad; ter++)
            {
                int numerador = vector[ter];
                int denominador = number * ter;

                if (bandera == true)
                {
                    sumadorSum += ((double)numerador / (double)denominador);
                    bandera = false;
                }
                else
                {
                    sumadorRes -= ((double)numerador / (double)denominador);
                    bandera = true;
                }
                respuesta = sumadorSum + sumadorRes;
            }
            return respuesta;
        }
        // Pregunta 3 ***b ********************************
        // Buscar elemento mayor de posiciones multiplos de number. Ejem 2,3,4,5,etc.
        public int elementoMayor(int number)
        {
            int posicion = 1;
            int posMax = vector[posicion * number];

            int cant2 = this.cantidad / number;

            for (posicion = 1; posicion <= cant2; posicion++)
            {
                if (vector[posicion * number] > posMax)
                {
                    posMax = vector[posicion * number];
                }
            }
            return posMax;
        }
        // Pregunta 4 *******************************
        // Encontrar la media de posiciones multiplos de number *******
        public double multiplosPosicion(int number)
        {
            double suma = 0;
            double cant2 = this.cantidad / number;

            for (int ter = 1; ter <= cant2; ter++)
            {
                suma = suma + vector[ter * number];
            }

            double resultado = suma / cant2;
            return resultado;
        }
        // Pregunta 5 ****************************
        // Seleccionar elementos multiplos y no multiplos *******
        public void multiplsoNoMultiplos(int number, ref classVector vtr1, ref classVector vtr2)
        {
            vtr1.cantidad = 0;
            vtr2.cantidad = 0;

            for (int ter = 1; ter <= this.cantidad; ter++)
            {
                int verdad = vector[ter] % number;
                if (verdad == 0)
                {
                    vtr1.cargarElexEle(vector[ter]);
                }
                else
                {
                    vtr2.cargarElexEle(vector[ter]);
                }
            }
        }
        // Pregunta 6 ************************
        // Invertir los elementos del vector (sin usar objeto vector auxiliar)
        public void invertirVector()
        {
            int number1;
            int cant = this.cantidad;
            for (int ter = 1; ter <= this.cantidad / 2; ter++)
            {
                number1 = vector[ter];
                vector[ter] = vector[cant];
                vector[cant] = number1;

                cant--;

            }
        }
        // Pregunta 7 ************************
        // Verificar si todos los elementos son iguales ********
        public bool elementosIguales()
        {
            bool bandera = true;
            int ter = 1;
            while (ter < this.cantidad && bandera == true)
            {
                if (!(vector[ter] <= vector[ter + 1]))
                {
                    bandera = false;
                }
                ter++;
            }
            return bandera;
        }
        // Pregunta 8 ************************
        // Encontra la union de elementos de dos vectores en un tercer vector
        // (El resultado no puede tener elementos repetidos)
        public void unioElementos(classVector vect2, ref classVector vectResultado)
        {
            vectResultado.cantidad = 0;
            for (int ter = 1; ter <= this.cantidad; ter++)
            {
                vectResultado.cargarElexEle(vector[ter]);
            }
            for (int ter2 = 1; ter2 <= vect2.cantidad; ter2++)
            {
                if (this.busqueSecuencial(vect2.vector[ter2]) == true)
                {
                    vectResultado.cargarElexEle(vect2.vector[ter2]);
                }
            }
        }
        // Pregunta 9 ************************
        // Encontrar la diferencia de elementos 
        //(Elementos del vector 1 que no estan en el vector 2)
        public void diferenciaElementos(classVector vect2, ref classVector vectR)
        {
            vectR.cantidad = 0;
            for (int ter = 1; ter <= this.cantidad; ter++)
            {
                if (vect2.busqueSecuencial(vector[ter]) == false)
                {
                    vectR.cargarElexEle(vector[ter]);
                }
            }
        }

        // Pregunta 10 ***********************
        // verificar si el segmento A y B estan ordenados
        public bool segmentoOrdenado(int inicio, int fin)
        {
            bool respuesta = true;
            int ter = inicio;
            while (ter < fin && respuesta == true)
            {
                if (!(vector[ter] <= vector[ter + 1]))
                {
                    respuesta = false;
                }
                ter++;
            }
            return respuesta;
        }

        // ----- Practico 1: segunda parte -------
        // Pregunta 1 ******************************
        // Eliminar los elementos no primos del vector en el mismo vector
        public void elimElemNoPrimos()
        {
            numerosEnteros number = new numerosEnteros();
            int ele, cant;
            cant = this.cantidad;
            this.cantidad = 0;
            for (int ter = 1; ter <= cant; ter++)
            {
                number.cargarDatos(vector[ter]);
                if (number.verifPrimo() == true)
                {
                    this.cantidad++;
                    vector[this.cantidad] = vector[ter];
                }
            }
        }

        // Pregunta 2 *****************************
        // Ordenar los elementos de posiciones multipos de n: 2,3,4,5, etc.
        public void ordenElemPos(int number)
        {
            int media = this.cantidad / number;
            for (int ter = 1; ter < media; ter++)
            {
                for (int ter2 = ter + 1; ter2 <= media; ter2++)
                {
                    if (vector[ter * number] > vector[ter2 * number])
                    {
                        this.intercambio((ter2 * number), (ter * number));
                    }
                }
            }
        }
        // Pregunta 3 ********************************
        // Ordenar en sentido de espiral el vector
        public void ordenEspiral()
        {
            this.ordenIntercambio();

            int cant = this.cantidad;
            int media = this.cantidad / 2;
            int ter1 = 1;
            int auxi;

            while (ter1 <= media)
            {
                auxi = vector[ter1 + 1];
                for (int ter2 = ter1; ter2 < cant - 2; ter2++)
                {
                    vector[ter2 + 1] = vector[ter2 + 2];
                }
                vector[cant] = auxi;
                cant--; ter1++;
            }
        }
        // Pregunta 4 ****************************
        // Contar elementos diferentes  en el rango a y b
        public int contElemDiferent(int number1, int number2)
        {
            int conta, ele, ter1;
            conta = 0; ter1 = number1;
            this.ordenParmetros(ter1, number2);

            while (ter1 <= number2)
            {
                ele = vector[ter1];
                while (ter1 <= number2 && vector[ter1] == ele)
                {
                    ter1++;
                }
                conta++;
            }
            return conta;
        }
        // Pregunta 5 *******************************************
        // Encontra elemento mas repetido por segmentos
        public void encontrarElemRepetido(int number1, int number2, ref classVector vectEle, ref classVector vectFrecu)
        {
            vectEle.cantidad = 0;
            vectFrecu.cantidad = 0;
            int ter, conta, ele, frecu, max;
            conta = 0; max = 0; ter = number1;

            this.ordenParmetros(ter, number2);
            while (ter <= number2)
            {
                frecu = 0;
                ele = vector[ter];
                while ((ter <= number2) && (vector[ter] == ele))
                {
                    ter++; frecu++;
                }
                if ((frecu > max) && (frecu != 1))
                {
                    max = frecu;
                    conta = 0;
                    conta++;

                    vectEle.vector[conta] = ele;
                    vectFrecu.vector[conta] = max;
                }
                else if ((frecu >= max) && (frecu != 1))
                {
                    conta++;
                    vectEle.vector[conta] = ele;
                    vectFrecu.vector[conta] = max;
                }
            }
            vectEle.cantidad = conta;
            vectFrecu.cantidad = conta;
        }
        // Pregunta 6 *********************************
        // Encontra frecuencia de los elementos del segmento a y b
        public void encontrarFrecuElem(int number1, int number2, ref classVector vectEle, ref classVector vectFrecu)
        {
            vectEle.cantidad = 0;
            vectFrecu.cantidad = 0;

            int ter1, ele, frecu;
            ter1 = number1;
            this.ordenParmetros(ter1, number2);
            while (ter1 <= number2)
            {
                frecu = 0;
                ele = vector[ter1];
                while ((ter1 <= number2) && (vector[ter1] == ele))
                {
                    ter1++; frecu++;
                }
                vectEle.cargarElexEle(ele);
                vectFrecu.cargarElexEle(frecu);
            }
        }
        // Pregunta 7 *****************************************
        // Encontrar elemento y frecuencia de los elementos fibonacci
        public void elemFrecuFibonacci(ref classVector elefibo, ref classVector frecufibo)
        {
            elefibo.cantidad = 0;
            frecufibo.cantidad = 0;

            int ter1, ele, frecu, varfibo, varA, varB;
            ter1 = 1; varA = 0; varB = 1; varfibo = 0;
            this.ordenamientoBurbuja();
            while (ter1 <= this.cantidad)
            {
                varfibo = varA + varB;
                frecu = 0;
                ele = vector[ter1];
                if (ele == varfibo)
                {
                    while ((ter1 <= this.cantidad) && (vector[ter1] == ele))
                    {
                        ter1++; frecu++;
                    }
                    elefibo.cargarElexEle(ele);
                    frecufibo.cargarElexEle(frecu);
                    varA = varB; varB = varfibo;
                }
                else if (ele < varfibo)
                {
                    ter1++;
                }
                else if (ele > varfibo)
                {
                    varA = varB; varB = varfibo;
                }
            }
        }
        // Pregunta 8 ********************************************
        // Segmentar el vector en repetidos y no repetidos(repetidos a la izquierda y no repetidos a la derecha)
        // Ordenados descendentemente
        public void segmentarElemRepYNoRep(int ini, int fin)
        {
            for (int ter1 = ini; ter1 < fin; ter1++)
            {
                for (int ter2 = ter1 + 1; ter2 <= fin; ter2++)
                {
                    if ((elemFrecuParam(vector[ter2], ini, fin) != 1) && (!(elemFrecuParam(vector[ter1], ini, fin) != 1)) ||
                        (elemFrecuParam(vector[ter2], ini, fin) != 1) && (elemFrecuParam(vector[ter1], ini, fin) != 1) && (vector[ter2] > vector[ter1]) ||
                        (!(elemFrecuParam(vector[ter2], ini, fin) != 1)) && (!(elemFrecuParam(vector[ter1], ini, fin) != 1)) && (vector[ter2] > vector[ter1]))
                    {
                        this.intercambio(ter2, ter1);
                    }
                }
            }
        }
        // Pregunta 9 *******************************************
        // Segmentar el vector en capicuas y no capicuas
        // (capicuas ordenados ascendentemente) y (no capicuas descendentemente)
        public void segmentarCapicuasNoCapicuas()
        {
            numerosEnteros number1 = new numerosEnteros();
            numerosEnteros number2 = new numerosEnteros();

            for (int ter1 = 1; ter1 < this.cantidad; ter1++)
            {
                for (int ter2 = ter1 + 1; ter2 <= this.cantidad; ter2++)
                {
                    number1.cargarDatos(vector[ter1]);
                    number2.cargarDatos(vector[ter2]);

                    if ((number2.verifCapicua()) && (!number1.verifCapicua()) ||
                        (number2.verifCapicua()) && (number1.verifCapicua()) && (vector[ter2] < vector[ter1]) ||
                        (!number2.verifCapicua()) && (!number1.verifCapicua()) && (vector[ter2] > vector[ter1]))
                    {
                        this.intercambio(ter2, ter1);
                    }
                }
            }
        }
        // Pregunta 10 *************************************
        // Intercalar primos y no primos ordenados pro segmentos
        public void intercalarPrimYNoPirm(int ini, int fin)
        {
            numerosEnteros number1 = new numerosEnteros();
            numerosEnteros number2 = new numerosEnteros();
            bool cambio = true;

            for (int ter1 = ini; ter1 < fin; ter1++)
            {
                if (cambio == true)
                {
                    for (int ter2 = ter1 + 1; ter2 <= fin; ter2++)
                    {
                        number1.cargarDatos(vector[ter1]);
                        number2.cargarDatos(vector[ter2]);

                        if ((number2.verifPrimo()) && (!number1.verifPrimo()) ||
                        (number2.verifPrimo()) && (number1.verifPrimo()) && (vector[ter2] > vector[ter1]) ||
                        (!number2.verifPrimo()) && (!number1.verifPrimo()) && (vector[ter2] < vector[ter1]))
                        {
                            this.intercambio(ter2, ter1);
                        }
                    }
                }
                //10|14|2|5|11|11|15|2|13|8|15|
                //10|13|14|11|15|11|5|2|2|8|15|
                else
                {
                    for (int ter2 = ter1 + 1; ter2 <= fin; ter2++)
                    {
                        number1.cargarDatos(vector[ter1]);
                        number2.cargarDatos(vector[ter2]);

                        if ((!number2.verifPrimo()) && (number1.verifPrimo()) ||
                        (!number2.verifPrimo()) && (!number1.verifPrimo()) && (vector[ter2] > vector[ter1]) ||
                        (number2.verifPrimo()) && (number1.verifPrimo()) && (vector[ter2] < vector[ter1]))
                        {
                            this.intercambio(ter2, ter1);
                        }
                    }
                }
                cambio = !cambio;
            }
        }
    }
}
