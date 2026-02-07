
namespace AvrilNNAI_OpenConcurrency_IO_Praise_Nth
{
    public class MachineAI
    {
// classes.
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Constant[] _constants;
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MetaData _metaData;
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Constant _newConstant;
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.PraiseSet _newPraiseSet;
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.PraiseSet[] _praiseSet;

// registers.
        private bool _isNewDataReady;
        private double[] _REGISTERED_Inputs;
        private double[] _REGISTERED_Outputs;

// constructor.
        public MachineAI()
        {
            //System.Console.WriteLine("entered MachineAI.");
            Create_MetaData();
            Create_New_PraiseSet();
            Create_List_Of_PraiseSet((byte)(Get_MetaData().Get_NumberOfPraiseOutputValues() - Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT()));
            Create_New_Constant();
            Create_List_Of_Constants(Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT());
            Create_List_Of_REGISTERED_Inputs(Get_MetaData().Get_NumberOfPraiseInputValues());
            Create_List_Of_REGISTERED_Outputs(Get_MetaData().Get_NumberOfPraiseOutputValues());
            Create_IsNewDataReady();
        }

// destructor.
        ~MachineAI()
        {
        }

// public.
        public void Create_List_Of_Constants(byte numberOfResetToConstantValues)
        {
            _constants = new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Constant[numberOfResetToConstantValues];
            while (Get_List_Of_Constant() == null) { }
            for(byte index = 0; index < numberOfResetToConstantValues; index++)
            {
                Set_Item_On_List_Of_Constant(index, Get_New_Constant());
            }
        }
        public void Create_List_Of_REGISTERED_Inputs(byte numberOfInputValues)
        {
            _REGISTERED_Inputs = new double[numberOfInputValues];
            for (byte index = 0; index < numberOfInputValues; index++)
            {
                Set_Item_On_List_Of_REGISTERED_Input(index, 0.0);
            }
        }
        public void Create_List_Of_REGISTERED_Outputs(byte numberOfOutputValues)
        {
            _REGISTERED_Outputs = new double[numberOfOutputValues];
            for (byte index = 0; index < numberOfOutputValues; index++)
            {
                Set_Item_On_List_Of_REGISTERED_Output(index, 0.0);
            }
        }
        public void Create_List_Of_PraiseSet( byte numberOfPraiseTrees)
        {
            _praiseSet = new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.PraiseSet[numberOfPraiseTrees];
            while (Get_List_Of_PraiseSet() == null) { }
            for (byte index = 0; index < numberOfPraiseTrees; index++)
            {
                Set_Item_On_List_Of_PraiseSets(index, Get_New_PraiseSet());
            }
        }
        public bool Run_Neural_Network_Inteligence(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI objNNAI)
        {
            if (objNNAI.Get_IsNewDataReady() == false)
            {
                byte numberOfPraiseSets = (byte)(objNNAI.Get_MetaData().Get_NumberOfPraiseOutputValues() - objNNAI.Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT());
                byte numberOfResetToConstant = objNNAI.Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT();
                for (byte outputID = 0; outputID < numberOfPraiseSets; outputID++)
                {
                    for (sbyte layerID = 4; layerID > -1; layerID--)
                    {
                        byte hiddenLayerID = Convert.ToByte(layerID);
                        for (ulong nodeID = 0; nodeID < objNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                        {
                            ulong numberOfInputsForNode = new ulong();
                            numberOfInputsForNode = 0;
                            if (layerID == (byte)4)
                            {
                                numberOfInputsForNode = objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues();
                            }
                            else
                            {
                                numberOfInputsForNode = objNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer((byte)(layerID + (byte)1));
                            }
                            objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(hiddenLayerID, nodeID).Run_Neural_Path_Calculation(objNNAI, outputID, hiddenLayerID, nodeID, numberOfInputsForNode);
                        }
                    }
                    objNNAI.Set_Item_On_List_Of_REGISTERED_Output(outputID, objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(0, 1).Get_REGISTERED_Output());
                }
            }
            objNNAI.Set_IsNewDataReady(true);
            return objNNAI.Get_IsNewDataReady();
        }
    // get.
        public bool Get_IsNewDataReady()
        {
            return _isNewDataReady;
        }
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Constant[] Get_List_Of_Constant()
        {
            return _constants;
        }
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.PraiseSet[] Get_List_Of_PraiseSet()
        {
            return _praiseSet;
        }
        public double[] Get_List_Of_REGISTERED_Inputs()
        {
            return _REGISTERED_Inputs;
        }
        public double[] Get_List_Of_REGISTERED_Outputs()
        {
            return _REGISTERED_Outputs;
        }

        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Constant Get_Item_On_List_Of_Constant(byte constantID)
        {
            return _constants[constantID];
        }
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.PraiseSet Get_Item_On_List_Of_PraiseSets(byte praiseTreeID)
        {
            return _praiseSet[praiseTreeID];
        }
        public double Get_Item_On_List_Of_REGISTERED_Inputs(ulong registerID)
        {
            return _REGISTERED_Inputs[registerID];
        }
        public double Get_Item_On_List_Of_REGISTERED_Outputs(ulong registerID)
        {
            return _REGISTERED_Outputs[registerID];
        }
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MetaData Get_MetaData()
        {
            return _metaData;
        }
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Constant Get_New_Constant()
        {
            return _newConstant;
        }
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.PraiseSet Get_New_PraiseSet()
        {
            return _newPraiseSet;
        }
    // set.
        public void Set_IsNewDataReady(bool value)
        {
            _isNewDataReady = value;
        }
        public void Set_Item_On_List_Of_Constant(byte constantID, AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Constant value)
        {
            _constants[constantID] = value;
        }
        public void Set_Item_On_List_Of_PraiseSets(byte praiseTreeID, AvrilNNAI_OpenConcurrency_IO_Praise_Nth.PraiseSet value)
        {
            _praiseSet[praiseTreeID] = value;
        }
        public void Set_Item_On_List_Of_REGISTERED_Input(ulong registerID, double value)
        {
            _REGISTERED_Inputs[registerID] = value;
        }
        public void Set_Item_On_List_Of_REGISTERED_Output(ulong registerID, double value)
        {
            _REGISTERED_Outputs[registerID] = value;
        }

// private.

        private void Create_IsNewDataReady()
        {
            _isNewDataReady = new bool();
            Set_IsNewDataReady(false);
        }
        private void Create_MetaData()
        {
            Set_MetaData(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MetaData());
            while (Get_MetaData() == null) { }
        }
        private void Create_New_Constant()
        {
            Set_New_Constant(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Constant());
            while (Get_New_Constant() == null) { }
        }
        private void Create_New_PraiseSet()
        {
            Set_New_PraiseSet(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.PraiseSet());
            while (Get_New_PraiseSet() == null) { }
        }
    // get.
    // set.
        private void Set_New_Constant(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Constant value)
        {
            _newConstant = value;
        }
        private void Set_New_PraiseSet(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.PraiseSet value)
        {
            _newPraiseSet = value;
        }
        private void Set_MetaData(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MetaData value)
        {
            _metaData = value;
        }
    }
}
