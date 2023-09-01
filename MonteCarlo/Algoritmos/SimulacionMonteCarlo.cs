using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MonteCarlo.Algoritmos;

namespace MonteCarlo.Algoritmos
{
    public class SimulacionMonteCarlo
    {
    public (double avg, double var) Algoritmo(int rows,  int cols, double lim_inf, double lim_sup)
        {
            Random random = new Random(); // se crea la lista con nums random

            List <double> randomNumbersList = new List<double>(); // Lista en donde se guardaran los numeros
            for (int i = 0; i < cols; i++)
            {
                double randomValue = random.NextDouble() * (lim_sup - lim_inf) + lim_inf; // generar nums que esten dentro del rango
                randomNumbersList.Add(randomValue);
            }

            List<int> selectedColumnsList = new List<int>(); // se crea la lista con los num random de cols
            for (int i = 0; i < rows; i++)
            {
                int colSelec = random.Next(1, cols + 1); // el num random debe esatr entre 1 y la ultima columna (incluyendola)
                selectedColumnsList.Add(colSelec);
            }

            double sumaCols = 0; // se inicializa la variable en donde se guardara la suma
            double colSelecCuadrado = 0; // se inicializa la variable para calcular la varianza
            for(int i = 0; i < rows; i++)
            {
                int colSelec = selectedColumnsList[i] -1 ;
                sumaCols += randomNumbersList[colSelec];
                colSelecCuadrado += Math.Pow(randomNumbersList[colSelec], 2);
            }

            double avg = sumaCols / rows; // calculo el promedio
            double var = (colSelecCuadrado / rows-1) - Math.Pow(avg, 2); //calculo la varianza
            


            return (avg, var);
        }
    }
}
