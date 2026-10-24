namespace Oralov_PI31_Kesha.NeuroNet
{
    class OutputLayer : Layer
    {
        public OutputLayer(int non, int nopn, NeuronType nt, string type) :
            base(non, nopn, nt, type)
        { }

        //прямой проход - вычислене функции softmax
        public override void Recognize(Network net, Layer nextLayer)
        {
            double e_sum = 0;
            for (int i = 0; i < neurons.Length; i++)
                e_sum += neurons[i].Output;

            for (int i = 0; i < neurons.Length; i++)
                net.Fact[i] = neurons[i].Output / e_sum;
        }

        // обратный проход
        public override double[] BackwardPass(double[] errors)
        {
            double[] gr_sum = new double[numofprevneurons];
            return gr_sum;
        }
    }
}



//Функция активации - "softmax(X) = (Y)", X = { x1, ... , xn }, Y = { y1, ... , yn }
//функция в аргумент принимает вектор.
//Значения в функции sm также векор той же размерности что и аргумент.
//Функция softmax вычисляется в 3 шага:
//	1.e ^ (xi)
//  2.exp каждого вектора X мы суммируем (=sum_i{e^(xi)})
//	3.e ^ (xi) / sum_i{ e ^ (xi)} = yi


//  xi      e^(xi)		sum_i{e^(xi)}   yi
//  2	    4.389		    		    0,042
//  3	    20.086				        0.114
//  5	    148.413		176.391         0,841
//  -1	    0.368				        0,002
//  -2	    0.135				        0,0008

//sum_yi = 0,9998