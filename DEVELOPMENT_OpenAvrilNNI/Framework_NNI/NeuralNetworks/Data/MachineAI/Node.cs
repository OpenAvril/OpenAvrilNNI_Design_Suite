
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
            Set_NumberOfInputs(1);
            Create_list_Of_Linear_NeuralPath(Get_NumberOfInputs());
            Create_REGISTERED_Output();
            //System.Console.WriteLine("exiting Node.");
        }

// destructor.
        ~Node()
        {

        }

    // public.
        public void Initialise_list_Of_Node(Framework_NNI obj, byte numberOfInputs)
        {
            Set_list_Of_Linear_NeuralPath(new Linear_NeuralPath[numberOfInputs]);
            while (Get_list_Of_Linear_NeuralPath() == null) { }
            for (byte index = 0; index < numberOfInputs; index++)
            {
                Set_Item_On_list_Of_Linear_NeuralPath(index, obj.Get_NeuralNetwork().Get_Data().Get_New_Linear_NeuralPath());
                while (Get_Item_On_list_Of_Linear_NeuralPath(index) == null) { }
            }
        }
        public void Run_All_Neural_Path_Calculations(OpenAvrilNNI.MachineAI objNNI, byte outputID, byte hiddenLayerID, byte nodeID, byte numberOfInputsForNode)
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
        public OpenAvrilNNI.Linear_NeuralPath Get_Item_On_list_Of_Linear_NeuralPath(byte inputID)
        {
            return _list_Of_Linear_NeuralPath[inputID];
        }
        public OpenAvrilNNI.Linear_NeuralPath[] Get_list_Of_Linear_NeuralPath()
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
        public void Set_list_Of_Linear_NeuralPath(OpenAvrilNNI.Linear_NeuralPath[] newList)
        {
            _list_Of_Linear_NeuralPath = newList;
        }
        public void Set_Item_On_list_Of_Linear_NeuralPath(byte inputID, OpenAvrilNNI.Linear_NeuralPath newItem)
        {
            _list_Of_Linear_NeuralPath[inputID] = newItem;
        }
        public void Set_NumberOfInputs(byte numberOfInputs)
        {
            _NumberOfInputs = numberOfInputs;
        }
        public void Set_REGISTERED_Output(double registered_Output)
        {
            _REGISTERED_Output = registered_Output;
        }

// private.
        private void Create_list_Of_Linear_NeuralPath(byte numberOfInputs)
        {
            Set_list_Of_Linear_NeuralPath(new Linear_NeuralPath[numberOfInputs]);
            while (Get_list_Of_Linear_NeuralPath() == null) { }
            for (byte index = 0; index < numberOfInputs; index++)
            {
                Set_Item_On_list_Of_Linear_NeuralPath(index, null);
            }
        }
        private void Create_NumberOfInputs()
        {
            Set_NumberOfInputs(new byte());
            Set_NumberOfInputs(0);
        }
        private void Create_REGISTERED_Output()
        {
            Set_REGISTERED_Output(new double());
            Set_REGISTERED_Output(0.0);
        }
    // get.
    // set.
    }
}
