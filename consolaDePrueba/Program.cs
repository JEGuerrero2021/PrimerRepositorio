using System;
using System.Collections.Generic;

namespace consolaDePrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            //***EJERCICIO: SUMAR LOS ELEMENTOS DE UNA COLECCION***
            static void SumaLosElementos() { 

            List<int> coleccionDeNumeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // declaramos una coleccion de numeros que tienen elementos del 1 al 9

            int sumaTotal = 0; // declaramos una variable con valor 0

            foreach (var valor in coleccionDeNumeros) // va a recoerrer nuestra coleccion de numeros del primer elemento hasta el ultimo / cada una de las interacciones van a queda asignadas a la variable valor
            {
                sumaTotal = sumaTotal + valor;    // posteriormente sumamos la variable sumaTotal a cada uno de los elementos de una coleccion de numeros 
                                                  //cuando se complete la funcion tendra la suma total de todos los elementos
            }
            Console.WriteLine(sumaTotal);

            }

            //***EJERCICIO: IMPRIMA EN CONSOLA LA SUMA DE NUMEROS PARES***

            //***RAZONAMIENTO: preguntamos si un numero es divisible entre dos utilizando mod, si arroja 0 es divisible entre 2.

            static void SumaDeNumerosPares()
            {


                List<int> coleccionDeNumerosPares = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // declaramos una coleccion de numeros que tienen elementos del 1 al 9

                int sumaTotalDeNumerosPares = 0; // declaramos una variable con valor 0

                foreach (var valor in coleccionDeNumerosPares) // va a recoerrer nuestra coleccion de numeros del primer elemento hasta el ultimo / cada una de las interacciones van a queda asignadas a la variable valor
                {

                    if (valor % 2 == 0) // vamos a preguntar si nuestro valor mod 2 es igual a cero
                        sumaTotalDeNumerosPares = sumaTotalDeNumerosPares + valor;    // posteriormente sumamos la variable sumaTotalDeNumerosPares a cada uno de los elementos de una coleccion de numeros 
                                                                                      //cuando se complete la funcion tendra la suma total de todos los elementos
                }
                Console.WriteLine(sumaTotalDeNumerosPares);
            }



            //***RECORRA Y ORDENE LA LISTA DE MAYOR A MENOR***
            //RAZONAMIENTO: 

            static void OrdenarDescendiente()
            {
                List<int> valores = new List<int>() { 3, 6, 9, 7, 4, 1, 2, 5, 8 };

                for (var indice = 0; indice < valores.Count - 1; indice++)
                {
                    if (valores[indice] > valores[indice + 1])
                    {
                        var valorTemporal = valores[indice];

                        valores[indice] = valores[indice + 1];
                        valores[indice + 1] = valorTemporal;

                        indice = -1;

                    }
                }

                foreach (var valorOrdenado in valores)
                {
                    Console.WriteLine(valorOrdenado);
                }


            }

            //minuto 1:36











        }


    }

}
