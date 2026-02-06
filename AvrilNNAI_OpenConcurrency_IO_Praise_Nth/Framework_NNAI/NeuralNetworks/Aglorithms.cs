
namespace AvrilNNAI_OpenConcurrency_IO_Praise_Nth
{
    public class Aglorithms
    {
// classes.

// registers.

// constructor.
        public Aglorithms()
        {

        }

// destructor.
        ~Aglorithms()
        {
            //System.Console.WriteLine("exited Aglorithms.");
        }

        // public.
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI Create_Instance_Of_MachineAI_From_nnai_File(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Framework_NNAI obj, string nameOfNNAI)
        {
            System.Console.WriteLine("entering ConstructNeuralNetworkAI_Frame.");
            AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI _AvrilNNAI = obj.Get_Neural_Networks().Get_Data().Get_NewMachineAI();
            while (_AvrilNNAI == null) { }
            _AvrilNNAI = obj.Get_Neural_Networks().Get_Execute().Get_FileRead().ReadValuesFromFile(obj, nameOfNNAI);
            return _AvrilNNAI;
        }
        // get.

        // set.

        // private.

        // get.
        // set.
    }
}
