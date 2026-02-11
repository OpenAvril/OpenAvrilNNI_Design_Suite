
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
            // class MachineAI.
        private Linear _New_Linear;
        private Binary _New_Boolean;
        private Constant _New_Constant;
                // class Linear.
        private PraiseSet _New_PraiseSet;
                    // class PraiseSet.
        private Node _New_Node;
                        // class Node.
        private Linear_NeuralPath _New_Linear_NeuralPath;
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
            Create_New_Linear_NeuralPath();
            Create_New_Node();
            Create_New_PraiseSet();
            Create_New_Linear();
            Create_New_Boolean();
            Create_New_Constant();
            Create_New_MachineAI();
            Create_list_Of_Neural_Network(1);
            Create_isFirstSave();
        }

// destructor.
        ~Data()
        {
            //System.Console.WriteLine("exited Data.");
        }

// public.
        public void Initialise_list_Of_Neural_Network(Framework_NNI obj, byte numberOfNNI)
        {
            Set_list_Of_Neural_Network(new MachineAI[numberOfNNI]);
            while (Get_list_Of_Neural_Network_Preservation() == null) { }
            for (byte index = 0; index < numberOfNNI; index++)
            {
                Set_Item_On_list_Of_Neural_Network(index, obj.Get_NeuralNetwork().Get_Data().Get_New_MachineAI());
            }
        }
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
        private void Create_New_Boolean()
        {
            Set_New_Boolean(new OpenAvrilNNI.Binary());
            while (Get_New_Boolean() == null) { }
        }
        private void Create_New_Constant()
        {
            Set_New_Constant(new OpenAvrilNNI.Constant());
            while (Get_New_Constant() == null) { }
        }
        private void Create_New_Linear()
        {
            Set_New_Linear(new OpenAvrilNNI.Linear());
            while (Get_New_Linear() == null) { }
        }
        private void Create_New_MachineAI()
        {
            Set_New_MachineAI(new MachineAI());
            while (Get_New_MachineAI() == null) { }
        }
        private void Create_New_Linear_NeuralPath()
        {
            Set_New_Linear_NeuralPath(new OpenAvrilNNI.Linear_NeuralPath());
            while (Get_New_Linear_NeuralPath() == null) { }
        }
        private void Create_New_Node()
        {
            Set_New_Node(new Node());
            while (Get_New_Node() == null) { }
        }
        private void Create_Output()
        {
            Set_Output(new Output());
            while (Get_Output() == null) { }
        }
        private void Create_New_PraiseSet()
        {
            Set_New_PraiseSet(new PraiseSet());
            while (Get_New_PraiseSet() == null) { }
        }
        private void Create_list_Of_Neural_Network(byte numberOfNNI)
        {
            Set_list_Of_Neural_Network(new MachineAI[numberOfNNI]);
            while (Get_list_Of_Neural_Network_Preservation() == null) { }
            for (byte index = 0; index < numberOfNNI; index++)
            {
                Set_Item_On_list_Of_Neural_Network(index, null);
            }
        }
        // get.
        private bool Get_isFirstSave()
        {
            return _isFirstSave;
        }
        public OpenAvrilNNI.Binary Get_New_Boolean()
        {
            return _New_Boolean;
        }
        public OpenAvrilNNI.Constant Get_New_Constant()
        {
            return _New_Constant;
        }
        public OpenAvrilNNI.Linear Get_New_Linear()
        {
            return _New_Linear;
        }
        public MachineAI Get_New_MachineAI()
        {
            return _New_MachineAI;
        }
        public OpenAvrilNNI.Linear_NeuralPath Get_New_Linear_NeuralPath()
        {
            return _New_Linear_NeuralPath;
        }
        public OpenAvrilNNI.Node Get_New_Node()
        {
            return _New_Node;
        }
        public PraiseSet Get_New_PraiseSet()
        {
            return _New_PraiseSet;
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
        private void Set_New_Boolean(OpenAvrilNNI.Binary newValue)
        {
            _New_Boolean = newValue;
        }
        private void Set_New_Constant(OpenAvrilNNI.Constant newValue)
        {
            _New_Constant = newValue;
        }
        private void Set_New_Linear(OpenAvrilNNI.Linear newValue)
        {
            _New_Linear = newValue;
        }
        private void Set_New_MachineAI(MachineAI newNewMachineAI)
        {
            _New_MachineAI = newNewMachineAI;
        }
        private void Set_New_Linear_NeuralPath(OpenAvrilNNI.Linear_NeuralPath newValue)
        {
            _New_Linear_NeuralPath = newValue;
        }
        private void Set_New_Node(OpenAvrilNNI.Node newValue)
        {
            _New_Node = newValue;
        }
        private void Set_Output(Output newOutput)
        {
            _Output = newOutput;
        }
        private void Set_New_PraiseSet(OpenAvrilNNI.PraiseSet newValue)
        {
            _New_PraiseSet = newValue;
        }
    }
}
