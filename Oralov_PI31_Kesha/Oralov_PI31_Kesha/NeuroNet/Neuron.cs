using static System.Math;

namespace Oralov_PI31_Kesha.NeuroNet
{
    class Neuron
    {
        // поля
        private NeuronType type; // тип нейрона - различаются по функциям активации - Leaky ReLU (утекающий ReLU)

        private double[] weights; // его веса
        private double[] inputs; // его входы
        private double output; // его выход
        private double derivativee; // производня функция активации

        // коэф-ты для функции активации (гиперболитечский тангенс - коф-т утекания)
        private double a = 0.01d;

        // нейрон должен взаимод-ать с объектами других классво поэтому мы задем ему свойства

        // свойства
        public double[] Weights { get => weights; set => weights = value; }
        public double[] Inputs { get => inputs; set => inputs = value; }
        public double Output { get => output; } // знчение output создется внутри нейрон поэтому нет -set-
        public double Derivativee { get => derivativee; }


        // консруктор
        // когда нейрон создется в кнострукторе, то при создании в нейрон мы должны передть масств синаптических связей
        // нейрон - еденичный элемент обраюотки нформации
        public Neuron(double[] memoryWeights, NeuronType typeNeuron)
        {
            type = typeNeuron;
            weights = memoryWeights;
        }

        // метод активации нейрона (нелинейные преобразования вхожного сигнала)
        public void Activator(double[] i)
        {
            inputs = i; // передача вектора входного сигланала в массив данных нейрона
            double sum = weights[0]; // аффиное преобразование через смещение (нулевой вес -)

            for (int j = 0; j < inputs.Length; j++) // цикл вычисления индуцированного поля нейрона
            {
                sum += inputs[j] * weights[j + 1]; // линейное преобразование входных сигналов
            }

            switch (type)
            {
                case NeuronType.Hidden:
                    output = LeakyReLU(sum);
                    derivativee = LeakyReLU_Derivator(sum);
                    break;

                case NeuronType.Output:
                    output = Exp(sum);
                    break;
            }
        }

        // функция активации нейрона
        private double LeakyReLU(double sum) => sum < 0 ? a * sum : sum;

        // вычисление произовднйо функции активации
        private double LeakyReLU_Derivator(double sum) => sum < 0 ? a : 1;
    }
}

// после цикла в sum - индуцированное локльное поле нейрона которое мы передаем в функцию активации
// в звисимости от нейрона мы передаем в ту или иную фун активации
