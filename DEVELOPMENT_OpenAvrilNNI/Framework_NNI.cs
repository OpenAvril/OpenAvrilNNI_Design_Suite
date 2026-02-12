
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
        public void Initialise_Framework_NNI(Framework_NNI obj, MetaData metaData)
        {
            
            Create_And_Run_UI(obj);
        }
        public void Initialise_MachineAI(Framework_NNI obj, string nameOfNNI, byte praiseID)
        {
            obj.Get_NeuralNetwork().Get_Aglorithms().Initialise_instance_Of_MachineAI(obj, nameOfNNI, praiseID);
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
    // get.
    // set.
        private void Set_NeuralNetwork(NeuralNetworks newNeuralNetowrk)
        {
            _NeuralNetwork = newNeuralNetowrk;
        }
    }
}
