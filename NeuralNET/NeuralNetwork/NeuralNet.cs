using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public abstract class NeuralNet
    {
        IList<Node>     NodosEntradaValidacion;
        IList<Node>     NodosEntradaTest;
        Node            Nodosalida;

        public abstract bool setData(IData entrada, IData entrenamiento);
        public abstract IData process(IData entrada);

    }
}
