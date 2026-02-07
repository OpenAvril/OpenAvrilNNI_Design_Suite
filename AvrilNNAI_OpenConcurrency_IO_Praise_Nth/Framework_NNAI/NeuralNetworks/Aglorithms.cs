
using System.ComponentModel;

namespace AvrilNNAI_OpenConcurrency_IO_Praise_Nth
{
    public class Aglorithms
    {
// classes.
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.NeuralPath _NeuralPath;

// registers.

// constructor.
        public Aglorithms()
        {
            System.Console.WriteLine("entered Aglorithms.");
            Create_NeuralPath();
        }

// destructor.
        ~Aglorithms()
        {
            //System.Console.WriteLine("exited Aglorithms.");
        }

// public.
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI Create_Instance_Of_MachineAI(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Framework_NNAI obj, string nameOfNNAI, ulong praiseID)
        {
            System.Console.WriteLine("entering ConstructNeuralNetworkAI_Frame.");
            AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI _AvrilNNAI = obj.Get_Neural_Networks().Get_Data().Get_NewMachineAI();
            while (_AvrilNNAI == null) { }
            _AvrilNNAI.Get_MetaData().Set_NameOfNNAI(nameOfNNAI);

            obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Calculate_Neural_Network_Parameters(obj, _AvrilNNAI, praiseID);
            System.Console.WriteLine("alpha");
            obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_REGISTERED_Inputs_List(obj, _AvrilNNAI, praiseID);
            obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_REGISTERED_Outputs_List(obj, _AvrilNNAI, praiseID);
            System.Console.WriteLine("bravo");
            byte numberOfPraiseSets = (byte)(_AvrilNNAI.Get_MetaData().Get_NumberOfPraiseOutputValues() - _AvrilNNAI.Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT());
            byte numberOfResetToConstant = _AvrilNNAI.Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT();
            System.Console.WriteLine("charlie");
            _AvrilNNAI.Create_List_Of_PraiseSet(numberOfPraiseSets);
            while (_AvrilNNAI.Get_List_Of_PraiseSet() == null) { }
            System.Console.WriteLine("delta");
            for (byte outputID_A = 0; outputID_A < numberOfPraiseSets; outputID_A++)
            {
                System.Console.WriteLine("echo");

                _AvrilNNAI.Set_Item_On_List_Of_PraiseSets(outputID_A, new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.PraiseSet());
                while (_AvrilNNAI.Get_List_Of_PraiseSet()[outputID_A] == null) { }

                for (sbyte layerID = 4; layerID > -1; layerID--)
                {
                    byte hiddenLayerID = Convert.ToByte(layerID);
                    System.Console.WriteLine("foxtrot");
                    //obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Set_NumberOfNodesInHiddenLayer(_AvrilNNAI, hiddenLayerID);
                    obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Create_Layer_Nodes(_AvrilNNAI, outputID_A, hiddenLayerID);

                    for (ulong nodeID = 0; nodeID < _AvrilNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                    {
                        System.Console.WriteLine("delta");
                        if (layerID == (byte)(4))
                        {
                            _AvrilNNAI.Get_Item_On_List_Of_PraiseSets(outputID_A).Get_Node(hiddenLayerID, nodeID).Create_List_Of_NeuralPathOfNodeInputs(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Linear[_AvrilNNAI.Get_MetaData().Get_NumberOfPraiseInputValues()]);
                            while (_AvrilNNAI.Get_List_Of_PraiseSet()[outputID_A].Get_Node(hiddenLayerID, nodeID).Get_List_Of_NeuralPathOfInput() == null) { }
                        }
                        else
                        {
                            _AvrilNNAI.Get_Item_On_List_Of_PraiseSets(outputID_A).Get_Node(hiddenLayerID, nodeID).Create_List_Of_NeuralPathOfNodeInputs(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Linear[_AvrilNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer((byte)(hiddenLayerID + (byte)1))]);
                            while (_AvrilNNAI.Get_List_Of_PraiseSet()[outputID_A].Get_Node(hiddenLayerID, nodeID).Get_List_Of_NeuralPathOfInput() == null) { }
                        }
                        _AvrilNNAI.Get_Item_On_List_Of_PraiseSets(outputID_A).Get_Node(hiddenLayerID, nodeID).Set_NeuralPathOfInput_SubSet(hiddenLayerID, obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Get_New_Linear());
                        System.Console.WriteLine("outputID_A = " + outputID_A + "  hiddenLayerID = " + hiddenLayerID + "  nodeID = " + nodeID);
                        obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Set_Neural_Path_For_Input(obj, _AvrilNNAI, outputID_A, hiddenLayerID, nodeID);
                    }
                }
            }
            for (byte outputID_B = 0; outputID_B < numberOfResetToConstant; outputID_B++)
            {
                _AvrilNNAI.Create_List_Of_Constants(numberOfResetToConstant);
                while (_AvrilNNAI.Get_List_Of_Constant() == null) { }
                _AvrilNNAI.Set_Item_On_List_Of_Constant(outputID_B, obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Get_New_Constant());
                obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Set_Constant_From_Output_Subset(obj, _AvrilNNAI, outputID_B);
            }
            return _AvrilNNAI;
        }
        public void Save_Instance_Of_MachineAI_To_File(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Framework_NNAI obj, AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI objNNAI)
        {
            obj.Get_Neural_Networks().Get_Execute().Get_FileReader().ReadValuesFromFile(obj, objNNAI.Get_MetaData().Get_NameOfNNAI());
        }
    // get.
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.NeuralPath Get_NeuralPath()
        {
            return _NeuralPath;
        }
    // set.

// private.
        private void Create_NeuralPath()
        {
            _NeuralPath = new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.NeuralPath();
            while (Get_NeuralPath() == null) { }
        }
    // get.
    // set.
        private void Set_IO_Defaults(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI objNNAI, ulong praiseID)
        {
            switch (praiseID)
            {
                case (byte)Global.PraiseID.Praise_0:

                    break;

                case (byte)Global.PraiseID.Praise_1:
                    objNNAI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1.Mouse_Screen_X, 0.0);
                    objNNAI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1.Mouse_Screen_Y, 0.0);
                    objNNAI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1.Capsule_Fowards_X, 1.0);
                    objNNAI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1.Capsule_Fowards_Y, 0.0);
                    objNNAI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1.Capsule_Fowards_Z, 0.0);
                    objNNAI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1.Capsule_Up_X, 0.0);
                    objNNAI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1.Capsule_Up_Y, 1.0);
                    objNNAI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1.Capsule_Up_Z, 0.0);
                    objNNAI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1.Capsule_Right_X, 0.0);
                    objNNAI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1.Capsule_Right_Y, 0.0);
                    objNNAI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1.Capsule_Right_Z, 1.0);
                    break;


                case (byte)Global.PraiseID.Praise_2:

                    break;
            }
        }
    }
}
