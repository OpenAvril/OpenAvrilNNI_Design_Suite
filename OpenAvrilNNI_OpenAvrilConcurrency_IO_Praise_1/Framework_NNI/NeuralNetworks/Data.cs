
namespace OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1
{
    public class Data
    {
// classes.
        private Input _Input;
        private MachineAI _NewMachineAI;
        private Output _Output;

// registers.
    // lists.
        private MachineAI[] _list_Of_Neural_Network;
    // bool.
        private bool _isFirstSave;


// constructor.
        public Data()
        {
            System.Console.WriteLine("entered Data.");
            Create_Input();
            Create_Output();
            Create_NewMachineAI();
            Create_list_Of_Neural_Network(1);
            Create_isFirstSave();
        }

// destructor.
        ~Data()
        {
            //System.Console.WriteLine("exited Data.");
        }

// public.
        public void Preserve_New_Neural_Network(MachineAI newNeuralNetwork)
        {
            if (Get_isFirstSave())
            {
                Set_Item_On_list_Of_Neural_Network(0, newNeuralNetwork);
                Set_isFirstSave(false);
            }
            else
            {
                MachineAI[] old_NeuralNetworkList = Get_list_Of_Neural_Network_Preservation();
                Create_list_Of_Neural_Network((byte)(Get_list_Of_Neural_Network_Preservation().LongLength + (long)1));
                for (byte index = 0; index < (byte)old_NeuralNetworkList.LongLength; index++)
                {
                    Set_Item_On_list_Of_Neural_Network(index, old_NeuralNetworkList[index]);
                }
                Set_Item_On_list_Of_Neural_Network((byte)Get_list_Of_Neural_Network_Preservation().LongLength, newNeuralNetwork);
            }
        }
    // get.
        public MachineAI Get_Item_On_list_Of_Neural_Network_Preservation(byte praiseID)
        {
            return _list_Of_Neural_Network[praiseID];
        }
        public Input Get_Input()
        {
            return _Input;
        }
        public MachineAI[] Get_list_Of_Neural_Network_Preservation()
        {
            return _list_Of_Neural_Network;
        }
        public MachineAI Get_NewMachineAI()
        {
            return _NewMachineAI;
        }
        public Output Get_Output()
        {
            return _Output;
        }
    // set.

// private.
        private void Create_list_Of_Neural_Network(byte numberOfNNI)
        {
            _list_Of_Neural_Network = new OpenAvrilNNI.MachineAI[numberOfNNI];
            while (Get_list_Of_Neural_Network_Preservation() == null) { }
            for (byte index = 0; index < numberOfNNI; index++)
            {
                Set_Item_On_list_Of_Neural_Network(index, Get_NewMachineAI());
            }
        }
        private void Create_isFirstSave()
        {
            Set_isFirstSave(new bool());
            Set_isFirstSave(true);
        }
        private void Create_Input()
        {
            Set_Input(new Input());
            while (Get_Input() == null) { }
        }
        private void Create_NewMachineAI()
        {
            Set_NewMachineAI(new MachineAI());
            while (Get_NewMachineAI() == null) { }
        }
        private void Create_Output()
        {
            Set_Output(new Output());
            while (Get_Output() == null) { }
        }
    // get.
        private bool Get_isFirstSave()
        {
            return _isFirstSave;
        }
    // set.
        private void Set_Item_On_list_Of_Neural_Network(byte praiseID, MachineAI newMachineAI)
        {
            _list_Of_Neural_Network[praiseID] = newMachineAI;
        }
        private void Set_isFirstSave(bool new_isFirstSave)
        {
            _isFirstSave = new_isFirstSave;
        }
        private void Set_Input(Input newInput)
        {
            _Input = newInput;
        }
        private void Set_NewMachineAI(MachineAI newNewMachineAI)
        {
            _NewMachineAI = newNewMachineAI;
        }
        private void Set_Output(Output newOutput)
        {
            _Output = newOutput;
        }
    }
}
