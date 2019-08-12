using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraJuros
{
    class FuncaoCalc
    {
        //double vf, vp, nPer, taxa;

        public double CalcularVf(double vp,int nPer, double taxa)
        {
            double vf = (vp * (1 + taxa * nPer));
            return vf;
        }
        public double CalcularTaxa(double vp, int nPer, double valorFinal)
        {
            double valorJuros = valorFinal - vp;
            double aux = vp * nPer ;
            double taxa = valorJuros / aux;
            return taxa;
        }
        public double CalcularTempo(double vp, double taxa, double valorFinal)
        {
            double valorJuros = valorFinal - vp;
            double aux = vp * taxa;
            double tempo = valorJuros / aux;
            return tempo;
        }

        public double CalcularValorCapital(double nPer, double taxa, double valorFinal)
        {
            
            double aux = nPer * taxa;
            double valorCapital = valorFinal / aux;
            return valorCapital;
        }

        public double CalcularValorFinalComposto(double vp, int nPer, double taxa)
        {
            double vf = vp * Math.Pow(1+taxa,nPer);
            return vf;
        }
    }
}
