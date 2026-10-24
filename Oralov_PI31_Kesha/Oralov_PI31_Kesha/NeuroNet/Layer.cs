using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace Oralov_PI31_Kesha.NeuroNet
{
    abstract class Layer
    {

        // Поля
        // protected - для внутрииерархического использования членов класса 
        protected string name_Layer; // слой для для связи с одноименным файлом памяти
        string pathDirWeights;       // путь к каталогу, для файла синаптических весов для нейросети
        string pathFileWeights;      // путь к файлу синаптических весов для нейосети
        protected int numofneurons;  // число нейронов текущего слоя
        protected int numofprevneurons; // число нейронов предыдущего слоя
        protected const double learningrate = 0.087d; // скорость обучения
        protected const double momentum = 0.05d; // момент инерции 
        // нужно будет подбирать параметры
        protected double[,] lastdeltaweights; // веса предыдущих итераций обучения
        protected Neuron[] neurons; // массив нейронов текущего слоя

        // Свойства
        public double[] Data // передача вход-ых данных на нейроны слоя и активация нейронов
        {
            set
            {
                for (int i = 0; i < numofneurons; i++)
                {
                    neurons[i].Activator(value);
                }
            }
        }


        // Конструктор
        // nm_Layer - используетсЯ для сввязи с одноименным полю слоя файлом памяти  (можно увидеть в WeightInitialize)
        protected Layer(int non, int nopn, NeuronType nt, string nm_Layer)
        {
            numofneurons = non;             // кол-во нейронов текущего слоя
            numofprevneurons = nopn;        // кол-во нейронов предыдущего слоя
            neurons = new Neuron[non];      // определение  массива нейронов
            name_Layer = nm_Layer;          // наименовние слоя которое используется  для связи с о..
            pathDirWeights = AppDomain.CurrentDomain.BaseDirectory + "memory\\"; // путь к кталогу синпса
            pathFileWeights = pathDirWeights + name_Layer + "_memeory.csv";     //путь к файлу синапса

            lastdeltaweights = new double[non, nopn + 1];
            double[,] Weights; // временный мссив синаптических весов текущего слоя

            if (File.Exists(pathFileWeights)) // определяет существует ли файл - true/false
            {
                Weights = WeightInitialize(MemoryMode.INIT, pathFileWeights); // считываем файл
            }
            else
            {
                Directory.CreateDirectory(pathDirWeights);
                Weights = WeightInitialize(MemoryMode.INIT, pathFileWeights);
            }

            for (int i = 0; i < non; i++) // цикл формирования нейронов слоя и зполенния ими
            {
                double[] tmp_weights = new double[nopn + 1];
                for (int j = 0; j < nopn + 1; j++)
                {
                    tmp_weights[j] = Weights[i, j];
                }
                neurons[i] = new Neuron(tmp_weights, nt); // зполнение массива нейронов
            }
        }

        // метод работы с синаптических весов слоя
        public double[,] WeightInitialize(MemoryMode mm, string path)
        {
            // return new double[1, 1];
            char[] delim = new char[] { ';', ' ' }; // разделение слов
            string tmpStr;
            string[] tmpStrWeights;
            double[,] weights = new double[numofneurons, numofprevneurons + 1];
            switch (mm)
            {
                case MemoryMode.GET:
                    tmpStrWeights = File.ReadAllLines(path); // считываем массив строк
                    string[] memory_elemnt;
                    for (int i = 0; i < numofneurons; i++)
                    {
                        memory_elemnt = tmpStrWeights[i].Split(delim);
                        for (int j = 0; j < numofprevneurons + 1; j++)
                        {
                            weights[i, j] = double.Parse(memory_elemnt[j].Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);
                        }
                    }
                    break;

                case MemoryMode.SET:
                    tmpStrWeights = new string[numofneurons];
                    if (!File.Exists(path))
                    {
                        MessageBox.Show("Файл" + name_Layer + "_memory.csv синаптических весов" + "\n НЕ найден!!!\n После нажатия кнопки ОК автоматически создаются отсутствующий файл, и все значения весов будут сохранены в нем",
                            "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    for (int i = 0; i < numofneurons; i++)
                    {
                        tmpStr = neurons[i].Weights[0].ToString();
                        for (int j = 1; j < numofprevneurons + 1; j++)
                        {
                            tmpStr = delim[0] + neurons[i].Weights[j].ToString();
                        }
                        tmpStrWeights[i] = tmpStr;
                    }

                    File.WriteAllLines(path, tmpStrWeights);

                    break;

                case MemoryMode.INIT:
                    MessageBox.Show("!!! Внимание !!!\nФайл " + name_Layer + "_memory.csv" + " синаптических весов\n НЕ НЙАДЕН!!!" + 
                        "\nПосле нажатия ОК автоматически проинициализируется веса и создается отсутстующий файл, " +  
                        "нейросеть вернётся к исходному состоянию <<новорожденности>>, и потребуется обучать ее ЗАНОВО.",
                        "Внимние", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Random random = new Random();

                    // инициализация исходных значений синаптичских весов нейронного слоя
                    double tmpRatio; // кэф-ент
                    double tmpShift; //смещение
                    double[] tmpArr = new double[numofprevneurons + 1]; // массив весов нейронов в слое
                    tmpStrWeights = new string[numofneurons]; // массив строк синаптических весов

                    for (int i = 0; i < numofneurons; i++) // цикл перебора нейронов в слое
                    {
                        for (int j = 0; j < numofprevneurons + 1; j++)
                        {
                            weights[i, j] = random.NextDouble();
                        }
                    }


                    break;
                default: break;
            }
            return weights;
        }

        abstract public void Recognize(Network net, Layer nextLayer); // прямой обход
        abstract public double[] BackwardPass(double[] suff); // обратный обход
    }
}