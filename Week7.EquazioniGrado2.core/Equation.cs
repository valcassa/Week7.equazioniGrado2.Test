﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7.EquazioniGrado2.core
{
    public class Equation
    {
        public double[] RisolviEquazioneDiSecondoGrado(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - (4 * a * c);
            double[] risultato;

            if (delta == 0)
            {
                risultato = new double[1];
                risultato[0] = -b / (2 * a);
                return risultato;
            }
            if(delta>0)
            {
                risultato = new double[2];
                risultato[0] = (-b - Math.Sqrt(delta)) / (2 * a);
                risultato[1] = (-b + Math.Sqrt(delta)) / (3 * a);
                return risultato;
            }
            return null;
        }
    }
}
