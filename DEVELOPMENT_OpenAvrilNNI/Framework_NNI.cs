
namespace OpenAvrilNNI
{
    public class Framework_NNI
    {
// classes.
        private NeuralNetworks _NeuralNetwork;

// registers.

// constructor.
        public Framework_NNI()
        {
            System.Console.WriteLine("entered Framework_NNI.");
            Create_NeuralNetworks();
        }

// destructor.
        ~Framework_NNI()
        {
            //System.Console.WriteLine("exited Framework_NNI.");
        }

// public.
        public void Initialise(Framework_NNI obj, MachineAI objNNI)
        {
            Initialise_lists(obj);
            Create_And_Run_UI(obj);
        }
    // get.
        public NeuralNetworks Get_NeuralNetwork()
        {
            return _NeuralNetwork;
        }
    // set.

// private.
        private void Create_And_Run_UI(Framework_NNI obj)
        {
            obj.Get_NeuralNetwork().Get_Execute().Create_And_Run_UI();
        }
        private void Create_NeuralNetworks()
        {
            Set_NeuralNetwork(new NeuralNetworks());
            while(Get_NeuralNetwork() == null) { }
        }
        private void Initialise_lists(Framework_NNI obj)
        {
            obj.Get_NeuralNetwork().Get_Aglorithms().Initialise_Lists(obj);
        }
    // get.
    // set.
        private void Set_NeuralNetwork(NeuralNetworks newNeuralNetowrk)
        {
            _NeuralNetwork = newNeuralNetowrk;
        }
    }
}
