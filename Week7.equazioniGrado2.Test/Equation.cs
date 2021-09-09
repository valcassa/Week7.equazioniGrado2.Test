using System;
using Week7.EquazioniGrado2.core;
using Xunit;

namespace Week7.equazioniGrado2.Test
 
    {
        public class EquationTest
        {
            [Fact]
            public void Test1()
            {
                Equation equazione = new Equation();

                double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(1, -3, 2);

                Assert.True(risultato.Length == 2);
                Assert.Equal(1, risultato[0]);
                Assert.Equal(2, risultato[1]);
            }

            [Fact]
            public void TestCase2()
            {
                Equation equazione = new Equation();
                double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(1, -5, 6);
                Assert.True(risultato.Length == 2);
                Assert.Equal(2, risultato[0]);
                Assert.Equal(3, risultato[1]);
            }
            [Fact]
            public void TestCase3()
            {
                Equation equazione = new Equation();
                double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(1, 2, 1);
                Assert.True(risultato.Length == 1);
                Assert.Equal(-1, risultato[0]);
            }

            [Fact]
            public void TestCase4()
            {

                Equation equazione = new Equation();

                double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(1, -3, 10);

                Assert.Null(risultato);
            }
        }
    }

