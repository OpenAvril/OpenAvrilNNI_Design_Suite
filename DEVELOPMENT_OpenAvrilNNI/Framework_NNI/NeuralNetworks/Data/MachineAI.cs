
namespace OpenAvrilNNI
{
    public class MachineAI
    {
// classes.
        private MetaData _MetaData;

// registers.
    // lists.
        private Binary[] _list_Of_Boolean_Paths;
        private Constant[] _list_Of_Constant_Paths;
        private Linear[] _list_Of_Linear_Paths;
        private double[] _list_Of_REGISTERED_Inputs;
        private double[] _list_Of_REGISTERED_Outputs;
    // bool.
        private bool _isNewDataReady;

// constructor.
        public MachineAI()
        {
            //System.Console.WriteLine("entered MachineAI.");
            this.Create_MetaData();
            this.Create_list_Of_REGISTERED_Inputs();
            this.Create_list_Of_Linear_Paths(0);
            this.Create_list_Of_Boolean_Paths(1);
            this.Create_list_Of_Constant_Paths(0);
            this.Create_list_Of_REGISTERED_Outputs(1);
            this.Create_isNewDataReady();
        }

// destructor.
        ~MachineAI()
        {
        }

// public.
        public void Initialise_MachineAI_Architechure(Framework_NNI obj, MachineAI objNNI)
        {
            this.Create_list_Of_REGISTERED_Inputs(objNNI.Get_MetaData().Get_NumberInputRegisters());
            this.Initialise_list_Of_REGISTERED_Inputs(objNNI.Get_MetaData().Get_NumberInputRegisters(), objNNI.Get_list_Of_REGISTERED_Inputs());
            
            this.Create_list_Of_REGISTERED_Outputs(objNNI.Get_MetaData().Get_NumberOutputRegisters());
            this.Initialise_list_Of_REGISTERED_Outputs(objNNI.Get_MetaData().Get_NumberOutputRegisters(), objNNI.Get_list_Of_REGISTERED_Outputs());

            this.Initialise_list_Of_Linear_Paths(objNNI.Get_MetaData().Get_NumberOfLinearOutputs(), obj.Get_NeuralNetwork().Get_Data().Get_New_Linear());
            for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfLinearOutputs(); outputID++)
            {
                System.Console.WriteLine("echo loop.");
                objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Initialise_Tree_Of_Nodes(objNNI, outputID);
                for (Int16 layerID = 4; layerID > -1; layerID--)
                {
                    byte hiddenLayerID = Convert.ToByte(layerID);
                    System.Console.WriteLine("foxtrot loop. outputID = " + outputID + "  hiddenLayerID = " + hiddenLayerID);
                    for (byte nodeID = 0; nodeID < objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                    {
                        System.Console.WriteLine("giga loop.");
                        if (hiddenLayerID == (byte)(4))
                        {
                            objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Set_NumberOfInputs(objNNI.Get_MetaData().Get_NumberInputRegisters());
                        }
                        else
                        {
                            objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Set_NumberOfInputs(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer((byte)(hiddenLayerID + (byte)1)));
                        }
                        objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Initialise_list_Of_Node(obj, objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_NumberOfInputs());
                        for (byte inputID = 0; inputID < objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_NumberOfInputs(); inputID++)
                        {
                            objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(inputID).Initialise_Linear_NeuralPath(obj);
                        }
                    }
                }
            }
            this.Initialise_list_Of_Boolean_Paths(objNNI.Get_MetaData().Get_NumberOfBooleanOutputs(), obj.Get_NeuralNetwork().Get_Data().Get_New_Boolean());
            for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfBooleanOutputs(); outputID++)
            {

            }
            this.Initialise_list_Of_Constant_Paths(objNNI.Get_MetaData().Get_NumberOfConstantOutputs(), obj.Get_NeuralNetwork().Get_Data().Get_New_Constant());
            for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfConstantOutputs(); outputID++)
            {

            }
        }
        public void Initialise_Linear_Paths_With_Data(Framework_NNI obj, MachineAI objNNI)
        {
            for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfLinearOutputs(); outputID++)
            {
                System.Console.WriteLine("echo loop.");
                objNNI.Set_Item_On_list_Of_Linear_Paths(outputID, obj.Get_NeuralNetwork().Get_Data().Get_New_Linear());
                //objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Initialise_Tree_Of_Nodes(objNNI, outputID);
                for (Int16 layerID = 4; layerID > -1; layerID--)
                {
                    byte hiddenLayerID = Convert.ToByte(layerID);
                    System.Console.WriteLine("foxtrot loop. outputID = " + outputID + "  hiddenLayerID = " + hiddenLayerID);
                    for (byte nodeID = 0; nodeID < objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                    {
                        System.Console.WriteLine("giga loop.");
                        if (hiddenLayerID == (byte)(4))
                        {
                            objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Set_NumberOfInputs(objNNI.Get_MetaData().Get_NumberInputRegisters());
                        }
                        else
                        {
                            objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Set_NumberOfInputs(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer((byte)(hiddenLayerID + (byte)1)));
                        }
                        //objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Initialise_list_Of_Linear_NeuralPath(obj, objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_NumberOfInputs());
                        for (byte inputID = 0; inputID < objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_NumberOfInputs(); inputID++)
                        {
                            objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Set_Item_On_list_Of_Linear_NeuralPath(inputID, obj.Get_NeuralNetwork().Get_Data().Get_New_Linear_NeuralPath());
                            System.Console.WriteLine("outputID = " + outputID + "  hiddenLayerID = " + hiddenLayerID + "  nodeID = " + nodeID);
                            objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(inputID).Initialise_Linear_NeuralPath(obj);
                        }
                    }
                }
            }
        }
        public bool Run_Neural_Network_Inteligence(OpenAvrilNNI.MachineAI objNNI)
        {
            Console.WriteLine("alpha.");
            if (objNNI.Get_IsNewDataReady() == false)
            {
                Console.WriteLine("bravo.");
                for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfLinearOutputs(); outputID++)
                {
                    Console.WriteLine("charlie loop.");
                    for (Int16 layerID = 4; layerID > -1; layerID--)
                    {
                        Console.WriteLine("delta loop.");
                        byte hiddenLayerID = Convert.ToByte(layerID);
                        for (byte nodeID = 0; nodeID < objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                        {
                            Console.WriteLine("foxtrot loop.");
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
                            objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Run_All_Neural_Path_Calculations(objNNI, outputID, hiddenLayerID, nodeID, numberOfInputsForNode);
                        }
                    }
                    objNNI.Set_Item_On_List_Of_REGISTERED_Output(outputID, objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(0, 1).Get_REGISTERED_Output());
                }
                for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfBooleanOutputs(); outputID++)
                {

                    objNNI.Set_Item_On_List_Of_REGISTERED_Output(outputID, 0/*ToDo*/);
                }
                for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfConstantOutputs(); outputID++)
                {

                    objNNI.Set_Item_On_List_Of_REGISTERED_Output(outputID, 0/*ToDo*/);
                }
            }
            objNNI.Set_IsNewDataReady(true);
            return objNNI.Get_IsNewDataReady();
        }
    // get.
        public bool Get_IsNewDataReady()
        {
            return _isNewDataReady;
        }
        public Binary[] Get_list_Of_Boolean_Paths()
        {
            return _list_Of_Boolean_Paths;
        }
        public Constant[] Get_list_Of_Constant_Paths()
        {
            return _list_Of_Constant_Paths;
        }
        public Linear[] Get_list_Of_Linear_Paths()
        {
            return _list_Of_Linear_Paths;
        }
        public double[] Get_list_Of_REGISTERED_Inputs()
        {
            return _list_Of_REGISTERED_Inputs;
        }
        public double[] Get_list_Of_REGISTERED_Outputs()
        {
            return _list_Of_REGISTERED_Outputs;
        }
        public Binary Get_Item_On_list_Of_Boolean_Paths(byte binaryID)
        {
            return _list_Of_Boolean_Paths[binaryID];
        }
        public Constant Get_Item_On_list_Of_Constant_Paths(byte constantID)
        {
            return _list_Of_Constant_Paths[constantID];
        }
        public Linear Get_Item_On_list_Of_Linear_Paths(byte praiseTreeID)
        {
            return _list_Of_Linear_Paths[praiseTreeID];
        }
        public double Get_Item_On_list_Of_REGISTERED_Inputs(byte registerID)
        {
            return _list_Of_REGISTERED_Inputs[registerID];
        }
        public double Get_Item_On_list_Of_REGISTERED_Outputs(byte registerID)
        {
            return _list_Of_REGISTERED_Outputs[registerID];
        }
        public OpenAvrilNNI.MetaData Get_MetaData()
        {
            return _MetaData;
        }
    // set.
        public void Set_IsNewDataReady(bool value)
        {
            _isNewDataReady = value;
        }
        public void Set_Item_On_list_Of_Boolean_Paths(byte binaryID, Binary value)
        {
            _list_Of_Boolean_Paths[binaryID] = value;
        }
        public void Set_Item_On_list_Of_Constant_Paths(byte constantID, Constant value)
        {
            _list_Of_Constant_Paths[constantID] = value;
        }
        public void Set_Item_On_list_Of_Linear_Paths(byte praiseTreeID, Linear value)
        {
            _list_Of_Linear_Paths[praiseTreeID] = value;
        }
        public void Set_Item_On_List_Of_REGISTERED_Input(byte registerID, double value)
        {
            _list_Of_REGISTERED_Inputs[registerID] = value;
        }
        public void Set_Item_On_List_Of_REGISTERED_Output(byte registerID, double value)
        {
            _list_Of_REGISTERED_Outputs[registerID] = value;
        }

// private.
        
        private void Create_isNewDataReady()
        {
            _isNewDataReady = new bool();
            Set_IsNewDataReady(false);
        }
        private void Create_list_Of_Boolean_Paths(byte numberOfBinaryValues)
        {
            Set_list_Of_Boolean_Paths(new Binary[numberOfBinaryValues]);
            while (Get_list_Of_Boolean_Paths() == null) { }
            for (byte index = 0; index < numberOfBinaryValues; index++)
            {
                Set_Item_On_list_Of_Boolean_Paths(index, null);
            }
        }
        private void Create_list_Of_Constant_Paths(byte numberOfResetToConstantValues)
        {
            Set_list_Of_Constant_Paths(new Constant[numberOfResetToConstantValues]);
            while (Get_list_Of_Constant_Paths() == null) { }
            for (byte index = 0; index < numberOfResetToConstantValues; index++)
            {
                Set_Item_On_list_Of_Constant_Paths(index, null);
            }
        }
        private void Create_list_Of_REGISTERED_Inputs(byte numberOfInputValues)
        {
            Set_list_Of_REGISTERED_Inputs(new double[numberOfInputValues]);
            for (byte index = 0; index < numberOfInputValues; index++)
            {
                Set_Item_On_List_Of_REGISTERED_Input(index, 0.0);
            }
        }
        private void Create_list_Of_Linear_Paths(byte numberOfLinearPaths)
        {
            Set_list_Of_Linear_Paths(new Linear[numberOfLinearPaths]);
            while (Get_list_Of_Linear_Paths() == null) { }
            for (byte index = 0; index < numberOfLinearPaths; index++)
            {
                Set_Item_On_list_Of_Linear_Paths(index, null);
            }
        }
        private void Create_list_Of_REGISTERED_Outputs(byte numberOfOutputValues)
        {
            Set_list_Of_REGISTERED_Outputs(new double[numberOfOutputValues]);
            for (byte index = 0; index < numberOfOutputValues; index++)
            {
                Set_Item_On_List_Of_REGISTERED_Output(index, 0.0);
            }
        }
        private void Initialise_list_Of_Boolean_Paths(byte numberOfBinaryValues, Binary newBinary)
        {
            Set_list_Of_Boolean_Paths(new Binary[numberOfBinaryValues]);
            while (Get_list_Of_Boolean_Paths() == null) { }
            for (byte index = 0; index < numberOfBinaryValues; index++)
            {
                Set_Item_On_list_Of_Boolean_Paths(index, newBinary);
            }
        }
        private void Initialise_list_Of_Constant_Paths(byte numberOfResetToConstantValues, Constant newConstant)
        {
            Set_list_Of_Constant_Paths(new Constant[numberOfResetToConstantValues]);
            while (Get_list_Of_Constant_Paths() == null) { }
            for (byte index = 0; index < numberOfResetToConstantValues; index++)
            {
                Set_Item_On_list_Of_Constant_Paths(index, newConstant);
            }
        }
        private void Initialise_list_Of_REGISTERED_Inputs(byte numberOfInputValues, double[] newInputValues)
        {
            Set_list_Of_REGISTERED_Inputs(new double[numberOfInputValues]);
            for (byte index = 0; index < numberOfInputValues; index++)
            {
                Set_Item_On_List_Of_REGISTERED_Input(index, newInputValues[index]);
            }
        }
        private void Initialise_list_Of_Linear_Paths(byte numberOfLinearPaths, Linear newLinear)
        {
            Set_list_Of_Linear_Paths(new Linear[numberOfLinearPaths]);
            while (Get_list_Of_Linear_Paths() == null) { }
            for (byte index = 0; index < numberOfLinearPaths; index++)
            {
                Set_Item_On_list_Of_Linear_Paths(index, newLinear);
            }
        }
        private void Initialise_list_Of_REGISTERED_Outputs(byte numberOfOutputValues, double[] newOutputValues)
        {
            Set_list_Of_REGISTERED_Inputs(new double[numberOfOutputValues]);
            for (byte index = 0; index < numberOfOutputValues; index++)
            {
                Set_Item_On_List_Of_REGISTERED_Input(index, newOutputValues[index]);
            }
        }
        private void Create_MetaData()
        {
            Set_MetaData(new OpenAvrilNNI.MetaData());
            while (Get_MetaData() == null) { }
            Get_MetaData().Set_NameOfNNI("OpenNNI_" + System.DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss"));
            Get_MetaData().Set_PraiseID(byte.MaxValue);
        }
    // get.
    // set.
        private void Set_list_Of_Boolean_Paths(Binary[] value)
        {
            _list_Of_Boolean_Paths = value;
        }
        private void Set_list_Of_Constant_Paths(Constant[] value)
        {
            _list_Of_Constant_Paths = value;
        }
        private void Set_list_Of_Linear_Paths(Linear[] value)
        {
            _list_Of_Linear_Paths = value;
        }
        private void Set_list_Of_REGISTERED_Inputs(double[] value)
        {
            _list_Of_REGISTERED_Inputs = value;
        }
        private void Set_list_Of_REGISTERED_Outputs(double[] value)
        {
            _list_Of_REGISTERED_Outputs = value;
        }
        private void Set_MetaData(OpenAvrilNNI.MetaData value)
        {
            _MetaData = value;
        }
    }
}
