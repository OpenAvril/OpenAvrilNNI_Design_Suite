
namespace OpenAvrilNNI
{
    public class Linear_NeuralPath
    {
// classes.

// registers.
    // double.
        private double _bias;
        private double _weight;

// constructor.
        public Linear_NeuralPath() 
        { 
            //System.Console.WriteLine("entered Linear.");
            this.Create_bias();
            this.Create_weight();
            //System.Console.WriteLine("exiting Linear.");
        }

// destructor.
        ~Linear_NeuralPath()
        {

        }

// public.
        public void Initialise_Linear_NeuralPath(Framework_NNI obj)
        {
            this.Initialise_bias(obj);
            this.Initialise_weight(obj);
        }
    // get.
        public double Get_bias()
        {
            return _bias;
        }
        public double Get_weight()
        {
            return _weight;
        }
    // set.
        public void Set_bias(double newBias)
        {
            _bias = newBias;
        }
        public void Set_weight(double newWeight)
        {
            _weight = newWeight;
        }

// private.
        private void Create_bias()
        {
            this.Set_bias(new double());
            this.Set_bias(0.0);
        }
        private void Create_weight()
        {
            this.Set_weight(new double());
            this.Set_weight(0.0);
        }
        private void Initialise_bias(Framework_NNI obj)
        {
            this.Set_bias(obj.Get_NeuralNetwork().Get_Aglorithms().Get_NeuralPath().Generate_Initial_Random_Small_Value(-0.5, 0.5));
        }
        private void Initialise_weight(Framework_NNI obj)
        {
            this.Set_weight(obj.Get_NeuralNetwork().Get_Aglorithms().Get_NeuralPath().Generate_Initial_Random_Small_Value(-0.5, 0.5));
        }
    // get.
    // set.
    }
}