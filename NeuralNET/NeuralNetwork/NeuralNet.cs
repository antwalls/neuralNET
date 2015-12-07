using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public class NeuralNet
    {
        IList<Node>     NodosEntradaValidacion;
        IList<Node>     NodosEntradaTest;
        Node            Nodosalida;
        IList<Example>  testSet;
        IList<Example>  evaluationSet;
        IList<Example>  validationSet;

        public NeuralNet(IList<Example> examples)
        {
            int examples_count  = examples.Count;
            testSet             = examples.Select(p => p)
                                          .Where( p => p.exampleId < p.exampleId / (examples_count * 0.8) )
                                          .ToList();
            testSet             = examples.Select(p => p)
                                         .Where(p => p.exampleId > p.exampleId / (examples_count * 0.8))
                                         .ToList();

        }

        public abstract bool setData(Data entrada, Data entrenamiento);
        public abstract Data process(Data entrada);

    }
}
