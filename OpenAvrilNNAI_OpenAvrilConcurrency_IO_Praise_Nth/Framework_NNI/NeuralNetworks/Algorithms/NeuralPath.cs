
namespace OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth
{
    public class NeuralPath
    {
// definitionns.

// classes.
        private Binary _New_Boolean;
        private Constant _New_Constant;
        private Linear _New_Linear;
        private Linear_NeuralPath _New_Linear_NeuralPath;
        private Node _New_Node;

// registers.

// constructor.
        public NeuralPath() 
        {
            //System.Console.WriteLine("entered NeuralPath.");
            Create_New_Linear();
            Create_New_Constant();
            Create_New_Boolean();
            Create_New_Linear_NeuralPath();
            Create_New_Node();
            //System.Console.WriteLine("exiting NeuralPath.");
        }

// destructor
        ~NeuralPath()
        {

        }

// public.
        public void Generate_MetaData_For_Neural_Network(Framework_NNI obj, MachineAI objNNI, byte praiseID)
        {
    // io id.
            objNNI.Get_MetaData().Set_PraiseID(praiseID);
    // generate io parameters.
            objNNI.Get_MetaData().Set_NumberInputRegisters(obj.Get_NeuralNetwork().Get_Data().Get_Input().Get_Input_Praise_1().Get_NumberInputRegisters());
            objNNI.Get_MetaData().Set_NumberOfLinearInputs(obj.Get_NeuralNetwork().Get_Data().Get_Input().Get_Input_Praise_1().Get_NumberOfLinearInputs());
            objNNI.Get_MetaData().Set_NumberOfBooleanInputs(obj.Get_NeuralNetwork().Get_Data().Get_Input().Get_Input_Praise_1().Get_NumberOfBooleanInputs());
            objNNI.Get_MetaData().Set_NumberOfConstantInputs(obj.Get_NeuralNetwork().Get_Data().Get_Input().Get_Input_Praise_1().Get_NumberOfConstantInputs());
            objNNI.Get_MetaData().Set_NumberOutputRegisters(obj.Get_NeuralNetwork().Get_Data().Get_Output().Get_Output_Praise_1().Get_NumberOutputRegisters());
            objNNI.Get_MetaData().Set_NumberOfLinearOutputs(obj.Get_NeuralNetwork().Get_Data().Get_Output().Get_Output_Praise_1().Get_NumberOfLinearOutputs());
            objNNI.Get_MetaData().Set_NumberOfBooleanOutputs(obj.Get_NeuralNetwork().Get_Data().Get_Output().Get_Output_Praise_1().Get_NumberOfBooleanOutputs());
            objNNI.Get_MetaData().Set_NumberOfConstantOutputs(obj.Get_NeuralNetwork().Get_Data().Get_Output().Get_Output_Praise_1().Get_NumberOfConstantOutputs());
                   
            System.Console.WriteLine("_NumberInputRegisters = " + objNNI.Get_MetaData().Get_NumberInputRegisters());
            System.Console.WriteLine("_NumberOfLinearInputs = " + objNNI.Get_MetaData().Get_NumberOfLinearInputs());
            System.Console.WriteLine("_NumberOfBooleanInputs = " + objNNI.Get_MetaData().Get_NumberOfBooleanInputs());
            System.Console.WriteLine("_NumberOfConstantInputs = " + objNNI.Get_MetaData().Get_NumberOfConstantInputs());
            System.Console.WriteLine("_NumberOutputRegisters = " + objNNI.Get_MetaData().Get_NumberOutputRegisters());
            System.Console.WriteLine("_NumberOfLinearOutputs = " + objNNI.Get_MetaData().Get_NumberOfLinearOutputs());
            System.Console.WriteLine("_NumberOfBooleanOutputs = " + objNNI.Get_MetaData().Get_NumberOfBooleanOutputs());
            System.Console.WriteLine("_NumberOfConstantOutputs = " + objNNI.Get_MetaData().Get_NumberOfConstantOutputs());
    // generate nodes in hidden layers.
            for (Int16 layerID = 4; layerID > -1; layerID--)
            {
                byte hiddenlayerID = Convert.ToByte(layerID);
                Set_NumberOfNodesInHiddenLayer(objNNI, hiddenlayerID);
            }

		}
        public double Generate_Initial_Random_Small_Value(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
        public void Generate_REGISTERED_Inputs_List(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI obj, OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI)
        {
            objNNI.Create_list_Of_REGISTERED_Inputs(objNNI.Get_MetaData().Get_NumberInputRegisters());
            for (byte index = 0; index < objNNI.Get_MetaData().Get_NumberInputRegisters(); index++)
            {
                objNNI.Set_Item_On_List_Of_REGISTERED_Input(index, 0.0);
            }
        }
        public void Generate_REGISTERED_Outputs_List(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI obj, OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI)
        {
            objNNI.Create_list_Of_REGISTERED_Outputs(objNNI.Get_MetaData().Get_NumberOutputRegisters());
            for (byte index = 0; index < objNNI.Get_MetaData().Get_NumberOutputRegisters(); index++)
            {
                objNNI.Set_Item_On_List_Of_REGISTERED_Output(index, 0.0);
            }
        }
    // get.
        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Binary Get_New_Boolean()
        {
            return _New_Boolean;
        }
        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Constant Get_New_Constant()
        {
            return _New_Constant;
        }
        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Linear Get_New_Linear()
        {
            return _New_Linear;
        }
        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Linear_NeuralPath Get_New_Linear_NeuralPath()
        {
            return _New_Linear_NeuralPath;
        }
        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Node Get_New_Node()
        {
            return _New_Node;
        }
    // set.
        public void Set_Constant_From_Output_Subset(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI obj, OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI, byte outputID)
        {
            for (byte index = 0; index < objNNI.Get_MetaData().Get_NumberOutputRegisters(); index++)
            {
                //Todo
            }
        }
        public void Set_Linear_NeuralPath_For_Input(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI obj, OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI, byte outputID, byte layerID, byte nodeID)
        {
            System.Console.WriteLine("entered Create_Nodes.");
            byte numberOfInputsForNode = new byte();
            numberOfInputsForNode = 0;
            if (layerID == (byte)4)
            {
                numberOfInputsForNode = objNNI.Get_MetaData().Get_NumberInputRegisters();
            }
            else
            {
                numberOfInputsForNode = objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer((byte)(layerID + (byte)1));
            }
            objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(layerID, nodeID).Set_NumberOfInputs(numberOfInputsForNode);
            System.Console.WriteLine("NumberOfInputs = " + objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(layerID, nodeID).Get_NumberOfInputs());

            for (byte inputID = 0; inputID < numberOfInputsForNode; inputID++)
            {
                objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(layerID, nodeID).Set_Item_On_list_Of_Linear_NeuralPath(inputID, obj.Get_NeuralNetwork().Get_Aglorithms().Get_NeuralPath().Get_New_Linear_NeuralPath());
                objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(layerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(inputID).Set_Weight(obj.Get_NeuralNetwork().Get_Aglorithms().Get_NeuralPath().Generate_Initial_Random_Small_Value(-0.5, 0.5));
                objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(layerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(inputID).Set_Bias(obj.Get_NeuralNetwork().Get_Aglorithms().Get_NeuralPath().Generate_Initial_Random_Small_Value(-0.5, 0.5));
                System.Console.WriteLine("outputID = " + outputID + "  layerID = " + layerID + "  nodeID = " + nodeID + "  inputID = " + inputID + "  bias = " + objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(layerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(inputID).Get_bias() + "  weight = " + objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(layerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(inputID).Get_weight());
            }
            System.Console.WriteLine("exiting Create_Nodes.");
        }


// private.
        private void Create_New_Boolean()
        {
            Set_New_Boolean(new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Binary());
            while (Get_New_Boolean() == null) { }
        }
        private void Create_New_Constant()
        {
            Set_New_Constant(new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Constant());
            while (Get_New_Constant() == null) { }
        }
        private void Create_New_Linear()
        {
            Set_New_Linear(new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Linear());
            while (Get_New_Linear() == null) { }
        }
        private void Create_New_Linear_NeuralPath()
        {
            Set_New_Linear_NeuralPath(new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Linear_NeuralPath());
            while (Get_New_Linear_NeuralPath() == null) { }
        }
        private void Create_New_Node()
        {
            Set_New_Node(new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Node());
            while (Get_New_Node() == null) { }
        }
        // get.
        // set.
        private void Set_New_Boolean(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Binary newValue)
        {
            _New_Boolean = newValue;
        }
        private void Set_New_Constant(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Constant newValue)
        {
            _New_Constant = newValue;
        }
        private void Set_New_Linear(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Linear newValue)
        {
            _New_Linear = newValue;
        }
        private void Set_New_Linear_NeuralPath(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Linear_NeuralPath newValue)
        {
            _New_Linear_NeuralPath = newValue;
        }
        private void Set_New_Node(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Node newValue)
        {
            _New_Node = newValue;
        }
        private void Set_NumberOfNodesInHiddenLayer(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI, byte layerID)
        {
            byte numberOfNodesInLayer = new byte();
            numberOfNodesInLayer = 0;
            switch (layerID)
            {
                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.NodeLayer.Layer_4:
                    numberOfNodesInLayer = (byte)Math.Round((double)objNNI.Get_MetaData().Get_NumberInputRegisters() * (double)0.8);
                    break;

                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.NodeLayer.Layer_3:
                    numberOfNodesInLayer = (byte)Math.Round((double)objNNI.Get_MetaData().Get_NumberInputRegisters() * (double)0.6);
                    break;

                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.NodeLayer.Layer_2:
                    numberOfNodesInLayer = (byte)Math.Round((double)objNNI.Get_MetaData().Get_NumberInputRegisters() * (double)0.4);
                    break;

                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.NodeLayer.Layer_1:
                    numberOfNodesInLayer = (byte)Math.Round((double)objNNI.Get_MetaData().Get_NumberInputRegisters() * (double)0.2);
                    break;

                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.NodeLayer.Layer_0:
                    numberOfNodesInLayer = (byte)1;
                    break;
            }
            objNNI.Get_MetaData().Set_NumberOfNodesInHiddenLayer(layerID, numberOfNodesInLayer);
            System.Console.WriteLine("layerID == " + layerID + "  Set_NumberOfNodesInLayer = " + objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID));
        }
    }
}
