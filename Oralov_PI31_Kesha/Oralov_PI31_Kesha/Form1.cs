//https://github.com/user905q/NeuroNet.git
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Linq;
using System.IO;
using Oralov_PI31_Kesha.NeuroNet;


namespace Oralov_PI31_Kesha
{
    public partial class MainForm : Form
    {

        private double[] inputPixels; // массив входящих данных
        private Network network;

        public MainForm()
        {
            InitializeComponent();
            inputPixels = new double[15];
            network = new Network();
        }

        private void Change_Status_buttons(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.LightGray)
            {
                ((Button)sender).BackColor = Color.Black;
                inputPixels[((Button)sender).TabIndex] = 1d;
            }
            else
            {
                ((Button)sender).BackColor = Color.LightGray;
                inputPixels[((Button)sender).TabIndex] = 0d;
            }
        }

        private void button_SaveTrainSample_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "train.txt";
            string tmpStr = numericUpDown_NecessaryOutput.Value.ToString();

            for (int i = 0; i < inputPixels.Length; i++)
            {
                tmpStr += " " + inputPixels[i].ToString();
            }
            tmpStr += "\n";

            File.AppendAllText(path, tmpStr);

        }

        private void button_SaveTestSample_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "test.txt";
            string tmpStr = numericUpDown_NecessaryOutput.Value.ToString();

            for (int i = 0; i < inputPixels.Length; i++)
            {
                tmpStr += " " + inputPixels[i].ToString();
            }
            tmpStr += "\n";

            File.AppendAllText(path, tmpStr);
        }

        private void Button_Recognize_Click(object sender, EventArgs e)
        {
            network.ForwardPass(inputPixels);
            label_Output.Text = network.Fact.ToList().IndexOf(network.Fact.Max()).ToString();
            label_Probabylity.Text = (100 * network.Fact.Max()).ToString("0,00") + " %";
        }
    }
}
