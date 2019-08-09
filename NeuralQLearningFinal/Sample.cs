using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralQLearningFinal
{
    class Sample
    {
        public double[] angleA;
        public double[] angleB;
        public double[] action;
        public double reward;

        [JsonConstructor]
        public Sample(double[] angleA, double[] angleB, double[] action, double reward)
        {
            this.angleA = angleA;
            this.angleB = angleB;
            this.action = action;
            this.reward = reward;
        }

        public Sample(int[] angleA, int[] angleB, int[] action, double reward)
        {
            this.angleA = ArrayToDouble(angleA);
            this.angleB = ArrayToDouble(angleB);
            this.action = ArrayToDouble(action);
            this.reward = reward;
        }

        public double[] GetInput()
        {
            double[] input = new double[angleA.Length + angleB.Length + action.Length];
            for (int i = 0; i < angleA.Length; i++)
                input[i] = angleA[i];
            for (int i = angleA.Length; i < angleB.Length + angleB.Length; i++)
                input[i] = angleB[i - angleB.Length];
            for (int i = angleA.Length + angleB.Length; i < input.Length; i++)
                input[i] = action[i - angleA.Length - angleB.Length];
            return input;
        }

        public double[] GetSmoothInput()
        {
            double[] input = new double[angleA.Length + angleB.Length + action.Length];
            double[] doubleAngleA = SmoothArray(angleA);
            double[] doubleAngleB = SmoothArray(angleB);
            double[] doubleAction = SmoothArray(action);

            for (int i = 0; i < doubleAngleA.Length; i++)
                input[i] = doubleAngleA[i];
            for (int i = angleA.Length; i < angleB.Length + angleB.Length; i++)
                input[i] = doubleAngleB[i - angleB.Length];
            for (int i = angleA.Length + angleB.Length; i < input.Length; i++)
                input[i] = doubleAction[i - angleA.Length - angleB.Length];

            return input;
        }


        double[] SmoothArray(double[] array)
        {
            var result = new double[array.Length];
            int i = Array.IndexOf(array, 1);
            if (i > 0)
                result[i - 1] = 0.5;
            if (i < array.Length - 1)
                result[i + 1] = 0.5;
            result[i] = 1;

            return result;
        }

        private double[] ArrayToDouble(int[] intArray)
        {
            double[] doubleArray = new double[intArray.Length];
            for (int i = 0; i < intArray.Length; i++)
                doubleArray[i] = intArray[i];
            return doubleArray;
        }
    }
}
