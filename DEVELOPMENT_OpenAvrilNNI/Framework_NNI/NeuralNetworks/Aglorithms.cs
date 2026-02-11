

namespace OpenAvrilNNI
{
    public class Aglorithms
    {
        // classes.
        private NeuralPath _NeuralPath;

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
        public MachineAI Initialise_instance_Of_MachineAI(Framework_NNI obj, string nameOfNNI, byte praiseID)
        {
            System.Console.WriteLine("entering Create_Instance_Of_instance_Of_MachineAI.");
            MachineAI objNNI = obj.Get_NeuralNetwork().Get_Data().Get_New_MachineAI();
            System.Console.WriteLine("alpha");
            objNNI.Get_MetaData().Set_NameOfNNI(nameOfNNI);
            System.Console.WriteLine("bravo");
            obj.Get_NeuralNetwork().Get_Aglorithms().Get_NeuralPath().Generate_MetaData_For_Neural_Network(obj, objNNI, praiseID);
            System.Console.WriteLine("charlie");
            objNNI.Initialise_MachineAI_Architechure(obj, objNNI);
            System.Console.WriteLine("delta");
            objNNI.Initialise_Linear_Paths_With_Data(obj, objNNI);
            //ToDO:



            for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfBooleanOutputs(); outputID++)
            {

            }
            for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfConstantOutputs(); outputID++)
            {

            }
            return objNNI;
        }
        public void Initialise_Lists(Framework_NNI obj)
        {
            obj.Get_NeuralNetwork().Get_Data().Initialise_list_Of_Neural_Network(obj, 1);
            var objNNI = obj.Get_NeuralNetwork().Get_Data().Get_Item_On_list_Of_Neural_Network_Preservation(0);
            objNNI.Initialise_MachineAI_Architechure(obj, objNNI);
            for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfLinearOutputs(); outputID++)
            {
                objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Initialise_Tree_Of_Nodes(objNNI, outputID);
                for (Int16 layerID = 4; layerID > -1; layerID--)
                {
                    byte hiddenLayerID = Convert.ToByte(layerID);
                    for (byte nodeID = 0; nodeID < objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                    {
                        objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(nodeID, hiddenLayerID).Initialise_list_Of_Node(obj, objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(nodeID, hiddenLayerID).Get_NumberOfInputs());
                    }
                }
            }
        }
        public void Save_Instance_Of_instance_Of_MachineAI_To_File(Framework_NNI obj, MachineAI objNNI)
        {
            obj.Get_NeuralNetwork().Get_Execute().Get_FileReadWrite().WriteValuesToFile(obj, objNNI, objNNI.Get_MetaData().Get_NameOfNNI());
        }
    // get.
        public NeuralPath Get_NeuralPath()
        {
            return _NeuralPath;
        }
    // set.

// private.
        private void Create_NeuralPath()
        {
            Set_NeuralPath(new NeuralPath());
            while (Get_NeuralPath() == null) { }
        }
    // get.
    // set.
        private void Set_IO_Defaults(MachineAI objNNI, byte praiseID)
        {
            switch (praiseID)
            {
                case (byte)Global.PraiseID.Praise_0:

                    break;

                case (byte)Global.PraiseID.Praise_1:
                    objNNI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1_I.Mouse_Screen_X, 0.0);
                    objNNI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1_I.Mouse_Screen_Y, 0.0);
                    objNNI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1_I.Capsule_Fowards_X, 1.0);
                    objNNI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1_I.Capsule_Fowards_Y, 0.0);
                    objNNI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1_I.Capsule_Fowards_Z, 0.0);
                    objNNI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1_I.Capsule_Up_X, 0.0);
                    objNNI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1_I.Capsule_Up_Y, 1.0);
                    objNNI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1_I.Capsule_Up_Z, 0.0);
                    objNNI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1_I.Capsule_Right_X, 0.0);
                    objNNI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1_I.Capsule_Right_Y, 0.0);
                    objNNI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1_I.Capsule_Right_Z, 1.0);
                    break;


                case (byte)Global.PraiseID.Praise_2:

                    break;
            }
        }
        private void Set_NeuralPath(NeuralPath newNeuralPath)
        {
            _NeuralPath = newNeuralPath;
        }
    }
}
