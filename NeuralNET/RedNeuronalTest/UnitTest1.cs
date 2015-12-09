using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NeuralNetwork;


namespace RedNeuronalTest
{
    [TestClass]
    public class UnitTest1
    {
        public NeuralNet brain;
        [TestMethod]
        public void ConstructStringNet()
        {
            string desired  = "abomasnow";

            string input1   = "Abomasnow";
            string input2   = "ABOMASNOW";
            string input3   = " ABOMASNOW";
            string input4   = "ABOMASNOW ";
            string input5   = "_ABOMASNOW";
            string input6   = " ABOMASNOW_";
            string input7   = " ABOMASNOW ";
            string input8   = "_ABOMASNOW_";
            string input9   = " ABOMASNOW";
            string input10  = " abomasnow";
            string input11  = "abomasnow ";
            string input12  = "_abomasnow";
            string input13  = " abomasnow_";
            string input14  = " abomasnow ";
            string input15  = "_abomasnow_";
            string input16  = " abomasnow";

            Example ex1 = new Example(  new StringData(input1),new StringData(desired) , 0 , 0);
            Example ex2 = new Example(  new StringData(input2),new StringData(desired) , 0 , 1);
            Example ex3 = new Example(new StringData(input3), new StringData(desired), 0, 2);
            Example ex4 = new Example(new StringData(input4), new StringData(desired), 0, 3);
            Example ex5 = new Example(new StringData(input5), new StringData(desired), 0, 4);
            Example ex6 = new Example(new StringData(input6), new StringData(desired), 0, 5);
            Example ex7 = new Example(new StringData(input7), new StringData(desired), 0, 6);

            List<Example> examples = new List<Example>();
            
            examples.Add(ex1);
            examples.Add(ex2);
            examples.Add(ex3);
            examples.Add(ex4);
            examples.Add(ex5);
            examples.Add(ex6);
            examples.Add(ex7);

            brain = new StringNeuralNet(examples);
        }
        //this method test the conexion of the nodes of the net with a one-to-the rest topology 
        [TestMethod]
        public void CreateConectionsNet()
        {
            int                     n_neurons   = 5;
            List<List<Boolean> >    conexions   = new List<List<bool> >(5);
            for (int i = 0; i < n_neurons; i++)
            {
                conexions[i] = new List<bool>(5);
                for (int j = 0; j < n_neurons; j++)
                {
                    conexions[i][j] = true;
                }
            }
            brain.createConexions(conexions);
        }
        [TestMethod]
        public void TrainNet()
        {

        }

        [TestMethod]
        public void BackPropagateNet()
        {

        }
    }
}

