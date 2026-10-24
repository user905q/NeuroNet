namespace Oralov_PI31_Kesha.NeuroNet
{
    class Network
    {
        // все слои сети
        private InputLayer input_layer = null;
        private HiddenLayer hidden_layer1 = new HiddenLayer(70, 15, NeuronType.Hidden, nameof(hidden_layer1));
        private HiddenLayer hidden_layer2 = new HiddenLayer(30, 70, NeuronType.Hidden, nameof(hidden_layer2));
        private OutputLayer output_layer = new OutputLayer(10, 30, NeuronType.Output, nameof(output_layer));

        private double[] fact = new double[10]; // массив фактического выхода сети
        private double[] e_error_avr; // среднее значение энергии ошибки эпохи обучения

        // среднее значение энергии ошибки эпохи обучения

        //свойства 

        // массив фактического выхода сети
        public double[] Fact { get => fact; }

        // среднее значение энергии ошибки эпохи обученя
        public double[] E_erorr_avr { get => e_error_avr; set => e_error_avr = value; }

        // констурктор
        public Network() { }

        // прямой проход сети
        public void ForwardPass(double[] netInput) 
        {
            hidden_layer1.Data = netInput;
            hidden_layer1.Recognize(null, hidden_layer2);
            hidden_layer2.Recognize(null, output_layer);
            output_layer.Recognize(this, null);
        }
    }
}
