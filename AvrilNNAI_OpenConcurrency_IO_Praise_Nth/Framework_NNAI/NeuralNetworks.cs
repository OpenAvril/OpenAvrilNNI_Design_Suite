
namespace AvrilNNAI_OpenConcurrency_IO_Praise_Nth
{
    public class NeuralNetworks
    {
// classes.
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Global _global;
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Aglorithms _aglorithms;
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Data _data;
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Execute _execute;
// registers.

// constructor.
        public NeuralNetworks()
        {
            //System.Console.WriteLine("entered NeuralNetworks.");
            Create_Global(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Global());
            while (Get_Global() == null) { }

            Create_Aglorithms(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Aglorithms());
            while (Get_Aglorithms() == null) { }

            Create_Data(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Data());
            while (Get_Data() == null) { }

            Create_Execute(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Execute());
            while (Get_Execute() == null) { }
        }

// destructor
        ~NeuralNetworks()
        {
            //System.Console.WriteLine("exited NeuralNetworks.");
        }

// public.
    // get.
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Aglorithms Get_Aglorithms()
        {
            return _aglorithms;
        }
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Data Get_Data()
        {
            return _data;
        }
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Execute Get_Execute()
        {
            return _execute;
        }
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Global Get_Global()
        {
            return _global;
        }
    // set.

// private.
        private void Create_Aglorithms(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Aglorithms aglorithms)
        {
            _aglorithms = aglorithms;
        }
        private void Create_Global(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Global global)
        {
            _global = global;
        }
        private void Create_Data(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Data data)
        {
            _data = data;
        }
        private void Create_Execute(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Execute execute)
        {
            _execute = execute;
        }
    // get.
    // set.
    }
}
