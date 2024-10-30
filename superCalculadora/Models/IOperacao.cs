using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalculadora.Modelos
{
    public interface IOperacao
    {
        double Calcular(double numero1, double numero2);
    }   
}
