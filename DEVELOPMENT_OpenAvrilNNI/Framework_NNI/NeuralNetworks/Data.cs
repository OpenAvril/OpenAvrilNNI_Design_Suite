
namespace OpenAvrilNNI
{
    public class Data
    {
// classes.
        private Input _Input;
        private Output _Output;

// registers.
    // instances.
        // data file .nni
        private MachineAI _New_MachineAI;
    // lists.
        private MachineAI[] _list_Of_Neural_Network;
    // bool.
        private bool _isFirstSave;


// constructor.
        public Data()
        {
            System.Console.WriteLine("entered Data.");
            this.Create_Input();
            this.Create_Output();
            this.Create_New_MachineAI();
            this.Create_list_Of_Neural_Network();
            this.Create_isFirstSave();
        }

// destructor.
        ~Data()
        {
            //System.Console.WriteLine("exited Data.");
        }

// public.
        public void Initialise_list_Of_Neural_Network(byte numberOfNNI)
        {
            this.Set_list_Of_Neural_Network(new MachineAI[numberOfNNI]);
            while (this.Get_list_Of_Neural_Network_Preservation() == null) { }
            for (byte index = 0; index < numberOfNNI; index++)
            {
                this.Set_Item_On_list_Of_Neural_Network(index, this.Get_Item_On_list_Of_list_Of_Neural_Network(0));
            }
        }
        public void Preserve_New_Neural_Network(MachineAI newNeuralNetwork)
        {
            MachineAI[] oldList = Get_list_Of_Neural_Network_Preservation();
            this.Initialise_list_Of_Neural_Network((byte)(oldList.LongLength + 1));
            for (byte index = 0; index < oldList.LongLength; index++)
            {
                this.Set_Item_On_list_Of_Neural_Network(index, oldList[index]);
            }
            this.Set_Item_On_list_Of_Neural_Network((byte)oldList.LongLength, newNeuralNetwork);
        }
    // get.
        public MachineAI Get_Item_On_list_Of_list_Of_Neural_Network(byte praiseID)
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
        public MachineAI Get_New_MachineAI()
        {
            return _New_MachineAI;
        }
        public Output Get_Output()
        {
            return _Output;
        }
    // set.

// private.
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
        private void Create_New_MachineAI()
        {
            Set_New_MachineAI(new MachineAI());
            while (Get_New_MachineAI() == null) { }
        }
        private void Create_Output()
        {
            Set_Output(new Output());
            while (Get_Output() == null) { }
        }
        private void Create_list_Of_Neural_Network()
        {
            this.Set_list_Of_Neural_Network(new MachineAI[1]);
            while (Get_list_Of_Neural_Network_Preservation() == null) { }
            this.Set_Item_On_list_Of_Neural_Network(0, new MachineAI());
            while (this.Get_Item_On_list_Of_list_Of_Neural_Network(0) == null) { }

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
        private void Set_list_Of_Neural_Network(MachineAI[] newList_Of_Neural_Network)
        {
            _list_Of_Neural_Network = newList_Of_Neural_Network;
        }
        private void Set_New_MachineAI(MachineAI newMachineAI)
        {
            _New_MachineAI = newMachineAI;
        }
        private void Set_Output(Output newOutput)
        {
            _Output = newOutput;
        }
    }
}
