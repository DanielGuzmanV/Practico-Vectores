using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class numerosEnteros
    {
        private int numeros;
        public numerosEnteros()
        {
            numeros = 0;
        }
        // Cargar ***********
        public void cargarDatos(int dato)
        {
            numeros = dato;
        }
        // Descargar *********
        public int descargarDatos()
        {
            return numeros;
        }
        // Cargar Random **********
        public void cargarRandom(int num1, int num2)
        {
            Random rand = new Random();
            this.numeros = rand.Next(num1, num2);
        }
        // Verificar numeros pares **************
        public bool verifcarPar()
        {
            int residuo;
            bool boleano;   
            residuo = this.numeros % 2;
            if (residuo == 0)
            {
                boleano = true;
            }
            else
            {
                boleano = false;
            }
            return boleano;
        }
        // Verificar numero Primos ****************
        public bool verifPrimo()
        {
            int contador, idx, residuo;
            bool boleano;

            contador = 0;
            for (idx = 1; idx <= this.numeros; idx++)
            {
                residuo = this.numeros % idx;
                if (residuo == 0)
                {
                    contador++;
                }
            }
            if (contador == 2)
            {
                boleano = true;
            }
            else
            {
                boleano = false;
            }
            return boleano;
        }
        // Invertir numeros enteros ********************
        public void invertirNum()
        {
            int number = 0;
            int digito;
            while(this.numeros > 0)
            {
                digito = this.numeros % 10;
                number = number * 10 + digito;
                this.numeros = this.numeros / 10;
            }
            this.numeros =  number;
        }
        // Verificar Capicua ***********************
        public bool verifCapicua()
        {
            numerosEnteros newNumber;
            newNumber = new numerosEnteros();

            newNumber.cargarDatos(this.numeros);
            newNumber.invertirNum();
            return (this.numeros == newNumber.numeros);
        }
        // Verificar si pertenece
        public bool numPertenece(int varNumber)
        {
            int auxi, digito; bool respuesta = false;
            auxi = this.numeros;
            do
            {
                digito = this.numeros % 10;
                this.numeros = this.numeros / 10;

            } while (!((digito == varNumber) || (this.numeros == 0)));
            if(digito == varNumber)
            {
                respuesta = true;
            }

            this.numeros = auxi;
            return respuesta;
        }
        // Verificar si pertenece de la segunda forma
        public bool belongs(int number)
        {
            bool respuesta;
            int auxiliar, digit;
            auxiliar = this.numeros;
            respuesta = false;

            while ((this.numeros > 0) && (respuesta == false))
            {
                digit = this.numeros % 10;
                this.numeros = numeros / 10;
                if (digit == number)
                    respuesta = true;
            }
            this.numeros = auxiliar;
            return respuesta;
        }
        // Verificar la intercepcion
        public void numInterseccion(numerosEnteros numUno, ref numerosEnteros numResi)
        {
            int digito, auxi;
            numResi.numeros = 0; // almacen de los numeros

            auxi = this.numeros; // el numero principal cargado en menu 1 y guardado en auxi
            while(this.numeros > 0)
            {
                digito = this.numeros % 10;
                this.numeros = this.numeros / 10;

                if(numUno.numPertenece(digito) == true)
                {
                    numResi.numeros = numResi.numeros * 10 + digito;
                }
            }
            this.numeros = auxi;
        }
    }
