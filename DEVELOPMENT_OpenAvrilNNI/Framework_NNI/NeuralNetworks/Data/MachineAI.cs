
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
            Create_MetaData();
            Create_list_Of_REGISTERED_Inputs();
            Create_list_Of_Linear_Paths();
            Create_list_Of_Boolean_Paths();
            Create_list_Of_Constant_Paths();
            Create_list_Of_REGISTERED_Outputs();
            Create_isNewDataReady();
        }

// destructor.
        ~MachineAI()
        {
        }

        // public.
        public void Initialise_list_Of_Boolean_Paths(MachineAI objNNI, byte numberOfBinaryValues)
        {
            Binary DEFAULT_Boolean = objNNI.Get_Item_On_list_Of_Boolean_Paths(0);
            objNNI.Set_list_Of_Boolean_Paths(new Binary[numberOfBinaryValues]);
            while (objNNI.Get_list_Of_Boolean_Paths() == null) { }
            for (byte index = 0; index < numberOfBinaryValues; index++)
            {
                Set_Item_On_list_Of_Linear_Paths(index, new Linear());
                while (objNNI.Get_Item_On_list_Of_Linear_Paths(index) == null) { }
                objNNI.Set_Item_On_list_Of_Boolean_Paths(index, DEFAULT_Boolean);
            }
        }
        public void Initialise_list_Of_Constant_Paths(MachineAI objNNI, byte numberOfResetToConstantValues)
        {
            Constant DEFAULT_Constant = objNNI.Get_Item_On_list_Of_Constant_Paths(0);
            objNNI.Set_list_Of_Constant_Paths(new Constant[numberOfResetToConstantValues]);
            while (objNNI.Get_list_Of_Constant_Paths() == null) { }
            for (byte index = 0; index < numberOfResetToConstantValues; index++)
            {
                objNNI.Set_Item_On_list_Of_Constant_Paths(index, DEFAULT_Constant);
            }
        }
        public void Initialise_list_Of_REGISTERED_Inputs(byte numberOfInputValues)
        {
            Set_list_Of_REGISTERED_Inputs(new double[numberOfInputValues]);
            for (byte index = 0; index < numberOfInputValues; index++)
            {
                Set_Item_On_List_Of_REGISTERED_Input(index, 1.0);
            }
        }
        public void Initialise_list_Of_Linear_Paths(MachineAI objNNI, byte numberOfLinearPaths)
        {
            Linear DEFAULT_Linear = objNNI.Get_Item_On_list_Of_Linear_Paths(0);
            objNNI.Set_list_Of_Linear_Paths(new Linear[numberOfLinearPaths]);
            while (objNNI.Get_list_Of_Linear_Paths() == null) { }
            for (byte index = 0; index < numberOfLinearPaths; index++)
            {
                objNNI.Set_Item_On_list_Of_Linear_Paths(index, new Linear());
                while (objNNI.Get_Item_On_list_Of_Linear_Paths(index) == null) { }
                objNNI.Set_Item_On_list_Of_Linear_Paths(index, DEFAULT_Linear);
            }
        }
        public void Initialise_list_Of_REGISTERED_Outputs(byte numberOfOutputValues)
        {
            Set_list_Of_REGISTERED_Inputs(new double[numberOfOutputValues]);
            for (byte index = 0; index < numberOfOutputValues; index++)
            {
                Set_Item_On_List_Of_REGISTERED_Input(index, 1.0);
            }
        }
        public void Initialise_MachineAI_Architechure(Framework_NNI obj, MachineAI objNNI, MetaData metaData)
        {
            // io.
            objNNI.Initialise_list_Of_REGISTERED_Inputs(metaData.Get_NumberInputRegisters());
            objNNI.Initialise_list_Of_REGISTERED_Outputs(metaData.Get_NumberOutputRegisters());
            // list of Linear.
            objNNI.Initialise_list_Of_Linear_Paths(objNNI, metaData.Get_NumberOfLinearOutputs());
            for (byte linearOutputID = 0; linearOutputID < metaData.Get_NumberOfLinearOutputs(); linearOutputID++)
            {
                System.Console.WriteLine("echo loop.");
                objNNI.Get_Item_On_list_Of_Linear_Paths(linearOutputID).Get_PraiseSet().Initialise_Tree_Of_Nodes_In_PraiseSet(objNNI, linearOutputID);
                for (Int16 layerID = 4; layerID > -1; layerID--)
                {
                    byte hiddenLayerID = Convert.ToByte(layerID);
                    System.Console.WriteLine("foxtrot loop. outputID = " + linearOutputID + "  hiddenLayerID = " + hiddenLayerID);
                    for (byte nodeID = 0; nodeID < metaData.Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                    {
                        System.Console.WriteLine("giga loop.");
                        if (hiddenLayerID == (byte)(4))
                        {
                            //ToDo null refference aception. \/ \/ \/
                            objNNI.Get_Item_On_list_Of_Linear_Paths(linearOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Initialise_NumberOfInputs(metaData.Get_NumberInputRegisters());
                        }
                        else
                        {
                            objNNI.Get_Item_On_list_Of_Linear_Paths(linearOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Initialise_NumberOfInputs(metaData.Get_NumberOfNodesInHiddenLayer((byte)(hiddenLayerID + (byte)1)));
                        }
                        objNNI.Get_Item_On_list_Of_Linear_Paths(linearOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Initialise_list_Of_Linear_NeuralPath(objNNI.Get_Item_On_list_Of_Linear_Paths(linearOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_NumberOfInputs());
                        for (byte inputID = 0; inputID < objNNI.Get_Item_On_list_Of_Linear_Paths(linearOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_NumberOfInputs(); inputID++)
                        {
                            objNNI.Get_Item_On_list_Of_Linear_Paths(linearOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(linearOutputID).Initialise_Linear_NeuralPath(obj);
                            System.Console.WriteLine("outputID = " + linearOutputID + "  hiddenLayerID = " + hiddenLayerID + "  nodeID = " + nodeID + "  bias = " + objNNI.Get_Item_On_list_Of_Linear_Paths(linearOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(inputID).Get_bias() + "  weight = " + objNNI.Get_Item_On_list_Of_Linear_Paths(linearOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(inputID).Get_weight());
                        }
                    }
                }
            }
        // list of Boolean.
            objNNI.Initialise_list_Of_Boolean_Paths(objNNI, metaData.Get_NumberOfBooleanOutputs());
            for (byte booleanOutputID = 0; booleanOutputID < metaData.Get_NumberOfBooleanOutputs(); booleanOutputID++)
            {

            }
            objNNI.Initialise_list_Of_Constant_Paths(objNNI, metaData.Get_NumberOfConstantOutputs());
            for (byte constantOutputID = 0; constantOutputID < metaData.Get_NumberOfConstantOutputs(); constantOutputID++)
            {

            }
        }
        public void Initialise_MetaData(MetaData newMetaData)
        {
            Set_MetaData(newMetaData);
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
                    objNNI.Set_Item_On_List_Of_REGISTERED_Output(outputID, objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(0, 0).Get_REGISTERED_Output());
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
        private void Create_list_Of_Boolean_Paths()
        {
            Set_list_Of_Boolean_Paths(new Binary[1]);
            while (Get_list_Of_Boolean_Paths() == null) { }
            Set_Item_On_list_Of_Boolean_Paths(0, new Binary());
            while(Get_Item_On_list_Of_Boolean_Paths(0) == null) { }
        }
        private void Create_list_Of_Constant_Paths()
        {
            Set_list_Of_Constant_Paths(new Constant[1]);
            while (Get_list_Of_Constant_Paths() == null) { }
            Set_Item_On_list_Of_Constant_Paths(0, new Constant());
            while (Get_Item_On_list_Of_Constant_Paths(0) == null) { }
        }
        private void Create_list_Of_REGISTERED_Inputs()
        {
            Set_list_Of_REGISTERED_Inputs(new double[3]);
            for (byte index = 0; index < 3; index++)
            {
                Set_Item_On_List_Of_REGISTERED_Input(index, 0.0);
            }
        }
        private void Create_list_Of_Linear_Paths()
        {
            Set_list_Of_Linear_Paths(new Linear[1]);
            while (Get_list_Of_Linear_Paths() == null) { }
            Set_Item_On_list_Of_Linear_Paths(0, new Linear());
            while (Get_Item_On_list_Of_Linear_Paths(0) == null) { }
        }
        private void Create_list_Of_REGISTERED_Outputs()
        {
            Set_list_Of_REGISTERED_Outputs(new double[3]);
            for (byte index = 0; index < 3; index++)
            {
                Set_Item_On_List_Of_REGISTERED_Output(index, 0.0);
            }
        }
        private void Create_MetaData()
        {
            Set_MetaData(new OpenAvrilNNI.MetaData());
            while (Get_MetaData() == null) { }
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
