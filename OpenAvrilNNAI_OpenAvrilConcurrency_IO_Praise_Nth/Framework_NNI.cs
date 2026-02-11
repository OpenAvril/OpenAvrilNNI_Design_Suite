
namespace OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth
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
        public void Initialise(Framework_NNI obj)
        {
            obj.Get_NeuralNetwork().Get_Execute().Create_And_Run_UI();
        }
        // get.
        public NeuralNetworks Get_NeuralNetwork()
        {
            return _NeuralNetwork;
        }
        // set.

        // private.
        private void Create_NeuralNetworks()
        {
            Set_NeuralNetwork(new NeuralNetworks());
            while (Get_NeuralNetwork() == null) { }
        }
        // get.
        // set.
        private void Set_NeuralNetwork(NeuralNetworks newNeuralNetowrk)
        {
            _NeuralNetwork = newNeuralNetowrk;
        }
    }
}
