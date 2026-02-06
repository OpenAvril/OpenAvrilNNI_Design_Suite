
namespace AvrilNNAI_OpenConcurrency_IO_Praise_Nth
{
    public class Framework_NNAI
    {
// classes.
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.NeuralNetworks _neuralNetwork;
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Wrapper _wrapper;

// registers.

// constructor.
        public Framework_NNAI()
        {
            //System.Console.WriteLine("entered Framework_NNAI.");
            Create_NeuralNetworks(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.NeuralNetworks());
            while (Get_Neural_Networks() == null) { }

            Create_Wrapper(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Wrapper());
            while (Get_Wrapper() == null) { }
        }

// destructor.
        ~Framework_NNAI()
        {
            //System.Console.WriteLine("exited Framework_NNAI.");
        }

// public.
    // get.
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.NeuralNetworks Get_Neural_Networks()
        {
            return _neuralNetwork;
        }
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Wrapper Get_Wrapper()
        {
            return _wrapper;
        }
        // set.

        // private.
        private void Create_NeuralNetworks(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.NeuralNetworks neuralNetwork)
        {
            _neuralNetwork = neuralNetwork;
        }
        private void Create_Wrapper(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Wrapper wrapper)
        {
            _wrapper = wrapper;
        }   
    // get.
    // set.
    }
}
