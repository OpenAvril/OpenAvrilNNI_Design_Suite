
namespace AvrilNNAI_OpenConcurrency_IO_Praise_Nth
{
    public class Data
    {
// classes.
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI[] _AvrilNNAI_OpenCFSD_Praise_IO;
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Input _input;
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI _newMachineAI;
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Output _output;

// registers.
        private bool _isFirstSave;

// constructor.
        public Data()
        {
            //System.Console.WriteLine("entered Data.");
            Create_Input(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Input());
            while (Get_Input() == null) { }
            //System.Console.WriteLine("ALPHA.");
            Create_Output(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Output());
            while (Get_Output() == null) { }
            //System.Console.WriteLine("BRAVO.");
            Create_NewMachineAI(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI());
            while (Get_NewMachineAI() == null) { }
            //System.Console.WriteLine("CHARLIE.");
            Create_Neural_Network_Preservation_List(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI[1]);
            while (Get_List_Of_Neural_Network_Preservation() == null) { }
            Set_NewMachineAI(0, Get_NewMachineAI());
            //System.Console.WriteLine("ECHO.");
            Create_IsFirstSave(new bool());
            Set_IsFirstSave(true);
        }

// destructor.
        ~Data()
        {
            //System.Console.WriteLine("exited Data.");
        }

// public.
        public void Preserve_New_Neural_Network(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI newNeuralNetwork)
        {
            if (Get_IsFirstSave())
            {
                Set_Item_Of_Neural_Network_Preservation(0, newNeuralNetwork);
                Set_IsFirstSave(false);
            }
            else
            {
                AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI[] old_NeuralNetworkList = Get_List_Of_Neural_Network_Preservation();
                Create_Neural_Network_Preservation_List(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI[(ulong)(Get_List_Of_Neural_Network_Preservation().LongLength + (long)1)]);
                for (ulong index = 0; index < (ulong)old_NeuralNetworkList.LongLength; index++)
                {
                    Set_Item_Of_Neural_Network_Preservation(index, old_NeuralNetworkList[index]);
                }
                Set_Item_Of_Neural_Network_Preservation((ulong)Get_List_Of_Neural_Network_Preservation().LongLength, newNeuralNetwork);
            }
        }
    
    // get.
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI Get_Item_On_List_Of_Neural_Network_Preservation(ulong praiseID)
        {
            return _AvrilNNAI_OpenCFSD_Praise_IO[praiseID];
        }
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Input Get_Input()
        {
            return _input;
        }
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI[] Get_List_Of_Neural_Network_Preservation()
        {
            return _AvrilNNAI_OpenCFSD_Praise_IO;
        }
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI Get_NewMachineAI()
        {
            return _newMachineAI;
        }
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Output Get_Output()
        {
            return _output;
        }

    // set.


// private.
        private void Create_Neural_Network_Preservation_List(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI[] machineAIs)
        {
            _AvrilNNAI_OpenCFSD_Praise_IO = machineAIs;
        }
        private void Create_IsFirstSave(bool isFirstSave)
        {
            _isFirstSave = isFirstSave;
        }
        private void Create_Input(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Input input)
        {
            _input = input;
        }
        private void Create_NewMachineAI(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI machineAI)
        {
            _newMachineAI = machineAI;
        }
        private void Create_Output(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Output output)
        {
            _output = output;
        }
    // get.
        private bool Get_IsFirstSave()
        {
            return _isFirstSave;
        }
        
    // set.
        private void Set_Item_Of_Neural_Network_Preservation(ulong praiseID, AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI machineAI)
        {
            _AvrilNNAI_OpenCFSD_Praise_IO[praiseID] = machineAI;
        }
        private void Set_IsFirstSave(bool isFirstSave)
        {
            _isFirstSave = isFirstSave;
        }
        private void Set_NewMachineAI(ulong index, AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI machineAI)
        {
            _AvrilNNAI_OpenCFSD_Praise_IO[index] = machineAI;
        }
    }
}
