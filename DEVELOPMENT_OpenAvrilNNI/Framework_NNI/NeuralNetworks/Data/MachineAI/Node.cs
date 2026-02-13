
namespace OpenAvrilNNI
{
    public class Node
    {
// classes.

// registers.
    // lists.
        private Linear_NeuralPath[] _list_Of_Linear_NeuralPath;
    // double.
        private double _REGISTERED_Output;
    // byte.
        private byte _NumberOfInputs;

// constructor.
        public Node()
        {
            //System.Console.WriteLine("entered Node.");
            Create_NumberOfInputs();
            Create_list_Of_Linear_NeuralPath();
            Create_REGISTERED_Output();
            //System.Console.WriteLine("exiting Node.");
        }

// destructor.
        ~Node()
        {

        }

// public.
        public void Initialise_list_Of_Linear_NeuralPath(byte numberOfInputs)
        {
            Linear_NeuralPath _DEFAULT_Linear_NeuralPath = Get_Item_On_list_Of_Linear_NeuralPath(0);
            Set_list_Of_Linear_NeuralPath(new Linear_NeuralPath[numberOfInputs]);
            while (Get_list_Of_Linear_NeuralPath() == null) { }
            for (byte index = 0; index < numberOfInputs; index++)
            {
                Set_Item_On_list_Of_Linear_NeuralPath(index, _DEFAULT_Linear_NeuralPath);
            }
        }
        public void Initialise_NumberOfInputs(byte numberOfInputs)
        {
            Set_NumberOfInputs(numberOfInputs);
        }

        public void Run_All_Neural_Path_Calculations(MachineAI objNNI, byte outputID, byte hiddenLayerID, byte nodeID, byte numberOfInputsForNode)
        {
            double sum_Bias = 0.0;
            double sum_weight = 0.0;
            double outputValue = 0.0;
            for (byte inputID = 0; inputID < numberOfInputsForNode; inputID++)
            {
                sum_Bias = sum_Bias + objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(inputID).Get_bias();
            }
            for (byte inputID = 0; inputID < numberOfInputsForNode; inputID++)
            {
                sum_weight = sum_weight + (objNNI.Get_Item_On_list_Of_REGISTERED_Inputs(inputID) * objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(inputID).Get_weight());
            }
            outputValue = sum_Bias + sum_weight;
            objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Set_REGISTERED_Output(outputValue);
        }
    // get.
        public Linear_NeuralPath Get_Item_On_list_Of_Linear_NeuralPath(byte outputID)
        {
            return _list_Of_Linear_NeuralPath[outputID];
        }
        public Linear_NeuralPath[] Get_list_Of_Linear_NeuralPath()
        {
            return _list_Of_Linear_NeuralPath;
        }
        public byte Get_NumberOfInputs()
        {
            return _NumberOfInputs;
        }
        public double Get_REGISTERED_Output()
        {
            return _REGISTERED_Output;
        }

    // set.
        public void Set_list_Of_Linear_NeuralPath(Linear_NeuralPath[] newList)
        {
            _list_Of_Linear_NeuralPath = newList;
        }
        public void Set_Item_On_list_Of_Linear_NeuralPath(byte inputID, Linear_NeuralPath newItem)
        {
            _list_Of_Linear_NeuralPath[inputID] = newItem;
        }
        public void Set_REGISTERED_Output(double registered_Output)
        {
            _REGISTERED_Output = registered_Output;
        }

// private.
        private void Create_list_Of_Linear_NeuralPath()
        {
            Set_list_Of_Linear_NeuralPath(new Linear_NeuralPath[1]);
            while (Get_list_Of_Linear_NeuralPath() == null) { }
            Set_Item_On_list_Of_Linear_NeuralPath(0, new Linear_NeuralPath());
            while (Get_Item_On_list_Of_Linear_NeuralPath(0) == null) { }
        }
        private void Create_NumberOfInputs()
        {
            Set_NumberOfInputs(new byte());
            Set_NumberOfInputs(3);
        }
        private void Create_REGISTERED_Output()
        {
            Set_REGISTERED_Output(new double());
            Set_REGISTERED_Output(0.0);
        }
    // get.
        private void Set_NumberOfInputs(byte numberOfInputs)
        {
            _NumberOfInputs = numberOfInputs;
        }
    }
}
