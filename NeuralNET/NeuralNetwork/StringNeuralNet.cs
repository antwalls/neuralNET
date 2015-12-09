using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    //This class allow us to clasify strings whatever we want
    public class StringNeuralNet : NeuralNet
    {
        public StringNeuralNet(IList<Example> examples) : base(examples){}
        public override bool setData(Data entrada, Data entrenamiento)
        {
            throw new NotImplementedException();
        }

        public override Data process(Data entrada)
        {
            throw new NotImplementedException();
        }

        public override void createConexions(List<List<bool>> conexions)
        {
            int n_neurons = conexions.Count;

            InputNodes = new List<Neuron>(n_neurons);
            outputNode = new Neuron();

            for (int i = 0; i < n_neurons; i++)
            {
                for (int j = i + 1; j < n_neurons; j++)
                {
                    InputNodes[i].AddConexion(InputNodes[j]);
                }
                
            }

        }
    }
}
