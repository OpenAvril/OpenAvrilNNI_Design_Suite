
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
            this.Create_list_Of_Linear_Paths();
            this.Create_list_Of_Boolean_Paths();
            this.Create_list_Of_Constant_Paths();
            this.Create_list_Of_REGISTERED_Outputs();
            this.Create_isNewDataReady();
        }

// destructor.
        ~MachineAI()
        {
        }

// public.
        public void Initialise_MachineAI_Architechure(Framework_NNI obj, MachineAI objNNI, MetaData metaData)
        {
        // io.
            this.Initialise_list_Of_REGISTERED_Inputs(metaData.Get_NumberInputRegisters());
            this.Initialise_list_Of_REGISTERED_Outputs(metaData.Get_NumberOutputRegisters());
        // list of Linear.
            this.Initialise_list_Of_Linear_Paths(metaData.Get_NumberOfLinearOutputs());
            for (byte outputID = 1; outputID < metaData.Get_NumberOfLinearOutputs(); outputID++)
            {
                System.Console.WriteLine("echo loop.");
                this.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Initialise_Tree_Of_Nodes(objNNI, outputID);
                for (Int16 layerID = 4; layerID > -1; layerID--)
                {
                    byte hiddenLayerID = Convert.ToByte(layerID);
                    System.Console.WriteLine("foxtrot loop. outputID = " + outputID + "  hiddenLayerID = " + hiddenLayerID);
                    for (byte nodeID = 1; nodeID < metaData.Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                    {
                        System.Console.WriteLine("giga loop.");
                        if (hiddenLayerID == (byte)(4))
                        {
                            this.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Set_NumberOfInputs(metaData.Get_NumberInputRegisters());
                        }
                        else
                        {
                            this.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Set_NumberOfInputs(metaData.Get_NumberOfNodesInHiddenLayer((byte)(hiddenLayerID + (byte)1)));
                        }
                        this.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Initialise_list_Of_Node(this.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_NumberOfInputs());
                        for (byte inputID = 1; inputID < this.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_NumberOfInputs(); inputID++)
                        {
                            this.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(outputID).Initialise_Linear_NeuralPath(obj);
                            System.Console.WriteLine("outputID = " + outputID + "  hiddenLayerID = " + hiddenLayerID + "  nodeID = " + nodeID + "  bias = " + objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(inputID).Get_bias() + "  weight = " + objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(inputID).Get_weight());
                        }
                    }
                }
            }
        // list of Boolean.
            this.Initialise_list_Of_Boolean_Paths(objNNI.Get_MetaData().Get_NumberOfBooleanOutputs());
            byte booleanOutputID = 0;
            for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfBooleanOutputs(); outputID++)
            {
                booleanOutputID = (byte)(outputID + metaData.Get_NumberOfLinearOutputs());
                System.Console.WriteLine("echo loop.");
                //this.Get_Item_On_list_Of_Boolean_Paths(outputID).Get_PraiseSet().Initialise_Tree_Of_Nodes(objNNI, booleanOutputID);
                for (Int16 layerID = 4; layerID > -1; layerID--)
                {
                    byte hiddenLayerID = Convert.ToByte(layerID);
                    System.Console.WriteLine("foxtrot loop. outputID = " + booleanOutputID + "  hiddenLayerID = " + hiddenLayerID);
                    for (byte nodeID = 0; nodeID < metaData.Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                    {
                        System.Console.WriteLine("giga loop.");
                        if (hiddenLayerID == (byte)(4))
                        {
                            //this.Get_Item_On_list_Of_Linear_Paths(booleanOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Set_NumberOfInputs(metaData.Get_NumberInputRegisters());
                        }
                        else
                        {
                            //this.Get_Item_On_list_Of_Linear_Paths(booleanOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Set_NumberOfInputs(metaData.Get_NumberOfNodesInHiddenLayer((byte)(hiddenLayerID + (byte)1)));
                        }
                        //this.Get_Item_On_list_Of_Linear_Paths(booleanOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Initialise_list_Of_Node(obj, this.Get_Item_On_list_Of_Linear_Paths(booleanOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_NumberOfInputs());
                        for (byte inputID = 0; inputID < this.Get_Item_On_list_Of_Linear_Paths(booleanOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_NumberOfInputs(); inputID++)
                        {
                            //this.Get_Item_On_list_Of_Linear_Paths(booleanOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(inputID).Initialise_Linear_NeuralPath(obj);
                            System.Console.WriteLine("outputID = " + booleanOutputID + "  hiddenLayerID = " + hiddenLayerID + "  nodeID = " + nodeID + "  bias = " + objNNI.Get_Item_On_list_Of_Linear_Paths(booleanOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(inputID).Get_bias() + "  weight = " + objNNI.Get_Item_On_list_Of_Linear_Paths(booleanOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(inputID).Get_weight());
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
        private void Create_list_Of_Boolean_Paths()
        {
            this.Set_list_Of_Boolean_Paths(new Binary[1]);
            while (this.Get_list_Of_Boolean_Paths() == null) { }
            this.Set_Item_On_list_Of_Boolean_Paths(0, new Binary());
            while(this.Get_Item_On_list_Of_Boolean_Paths(0) == null) { }
        }
        private void Create_list_Of_Constant_Paths()
        {
            this.Set_list_Of_Constant_Paths(new Constant[1]);
            while (this.Get_list_Of_Constant_Paths() == null) { }
            this.Set_Item_On_list_Of_Constant_Paths(0, new Constant());
            while (this.Get_Item_On_list_Of_Constant_Paths(0) == null) { }
        }
        private void Create_list_Of_REGISTERED_Inputs()
        {
            this.Set_list_Of_REGISTERED_Inputs(new double[3]);
            for (byte index = 0; index < 3; index++)
            {
                this.Set_Item_On_List_Of_REGISTERED_Input(index, 0.0);
            }
        }
        private void Create_list_Of_Linear_Paths()
        {
            this.Set_list_Of_Linear_Paths(new Linear[1]);
            while (this.Get_list_Of_Linear_Paths() == null) { }
            this.Set_Item_On_list_Of_Linear_Paths(0, new Linear());
            while (this.Get_Item_On_list_Of_Linear_Paths(0) == null) { }
        }
        private void Create_list_Of_REGISTERED_Outputs()
        {
            Set_list_Of_REGISTERED_Outputs(new double[3]);
            for (byte index = 0; index < 3; index++)
            {
                Set_Item_On_List_Of_REGISTERED_Output(index, 0.0);
            }
        }
        private void Initialise_list_Of_Boolean_Paths(byte numberOfBinaryValues)
        {
            numberOfBinaryValues = (byte)(numberOfBinaryValues + 1);
            this.Set_list_Of_Boolean_Paths(new Binary[numberOfBinaryValues]);
            while (this.Get_list_Of_Boolean_Paths() == null) { }
            for (byte index = 0; index < numberOfBinaryValues; index++)
            {
                this.Set_Item_On_list_Of_Boolean_Paths(index, this.Get_Item_On_list_Of_Boolean_Paths(0));
            }
        }
        private void Initialise_list_Of_Constant_Paths(byte numberOfResetToConstantValues)
        {
            numberOfResetToConstantValues = (byte)(numberOfResetToConstantValues + 1);
            this.Set_list_Of_Constant_Paths(new Constant[numberOfResetToConstantValues]);
            while (this.Get_list_Of_Constant_Paths() == null) { }
            for (byte index = 0; index < numberOfResetToConstantValues; index++)
            {
                this.Set_Item_On_list_Of_Constant_Paths(index, this.Get_Item_On_list_Of_Constant_Paths(0));
            }
        }
        private void Initialise_list_Of_REGISTERED_Inputs(byte numberOfInputValues)
        {
            Set_list_Of_REGISTERED_Inputs(new double[numberOfInputValues]);
            for (byte index = 0; index < numberOfInputValues; index++)
            {
                Set_Item_On_List_Of_REGISTERED_Input(index, 0.0);
            }
        }
        private void Initialise_list_Of_Linear_Paths(byte numberOfLinearPaths)
        {
            numberOfLinearPaths = (byte)(numberOfLinearPaths + (byte)1);
            this.Set_list_Of_Linear_Paths(new Linear[numberOfLinearPaths]);
            while (this.Get_list_Of_Linear_Paths() == null) { }
            for (byte index = 0; index < numberOfLinearPaths; index++)
            {
                this.Set_Item_On_list_Of_Linear_Paths(index, this.Get_Item_On_list_Of_Linear_Paths(0));
            }
        }
        private void Initialise_list_Of_REGISTERED_Outputs(byte numberOfOutputValues)
        {
            Set_list_Of_REGISTERED_Inputs(new double[numberOfOutputValues]);
            for (byte index = 0; index < numberOfOutputValues; index++)
            {
                Set_Item_On_List_Of_REGISTERED_Input(index, 0.0);
            }
        }
        private void Create_MetaData()
        {
            this.Set_MetaData(new OpenAvrilNNI.MetaData());
            while (this.Get_MetaData() == null) { }
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
