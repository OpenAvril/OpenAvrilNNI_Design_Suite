using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avril_NNAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String input_text = numberOfInputValues.Text;
            Avril_NNAI.Framework_NNAI obj = Avril_NNAI.Program.Get_Framework_NNAI();
            obj.Get_Neural_Networks().Get_Aglorithms().ConstructNeuralNetworkAI_Frame(obj, (ulong)Convert.ToUInt64(input_text));
        }
    }
}
