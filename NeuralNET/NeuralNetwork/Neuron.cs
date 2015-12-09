using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public class Neuron :Inputable, Outputable
    {
        public Data data;
        public List<Neuron> conexions;              

       
        public Neuron()
        {
            conexions = new List<Neuron>();
        }
        public Data FuncionPropagacion()
        {
            return data;
        }
        public Data FuncionActivacion()
        {
            return data;
        }
        public Data FuncionTransferencia()
        {
            return data;
        }
        public void FeedData(Data input)
        {
            data = input;
        }
        public void AddConexion(Neuron following)
        {
            conexions.Add(following);
        }
        public Data ReturnData()
        {
            return data;
        }
    }
}
