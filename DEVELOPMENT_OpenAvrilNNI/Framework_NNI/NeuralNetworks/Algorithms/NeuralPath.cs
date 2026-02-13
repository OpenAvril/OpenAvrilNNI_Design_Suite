
namespace OpenAvrilNNI
{
    public class NeuralPath
    {
// definitionns.

// classes.
        private SolutionLogic _SolutionLogic;

// registers.

// constructor.
        public NeuralPath()
        {
            //System.Console.WriteLine("entered NeuralPath.");
            Create_SolutionLogic();
            //System.Console.WriteLine("exiting NeuralPath.");
        }

// destructor
        ~NeuralPath()
        {

        }

// public.
        public double Generate_Initial_Random_Small_Value(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
        public void Gernerate_Lists_From_MetaData_For_MachineAI(Framework_NNI obj, MachineAI objNNI, MetaData metaData)
        {
            System.Console.WriteLine("entered Gernerate_Lists_From_MetaData_For_MachineAI.");
        // class MachaineAI.
            objNNI.Initialise_list_Of_REGISTERED_Inputs(metaData.Get_NumberInputRegisters());// i registers.
            objNNI.Initialise_list_Of_REGISTERED_Outputs(metaData.Get_NumberOutputRegisters());// o registers.
            objNNI.Initialise_list_Of_Linear_Paths(objNNI, metaData.Get_NumberOfLinearOutputs());// list of Linear.
            // class Linear.
            for (byte linearOutputID = 0; linearOutputID < metaData.Get_NumberOfLinearOutputs(); linearOutputID++)
            {
                // class PraiseSet.
                objNNI.Get_Item_On_list_Of_Linear_Paths(linearOutputID).Get_PraiseSet().Initialise_Tree_Of_Nodes_In_PraiseSet(objNNI, linearOutputID);// list layer(s) of nodes.
                for (Int16 layerID = 4; layerID > -1; layerID--)
                {
                    // class Node.
                    byte hiddenLayerID = Convert.ToByte(layerID);
                    for (byte nodeID = 0; nodeID < metaData.Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                    {
                        var numberofInputsForNode = (byte)0;
                        if (hiddenLayerID == (byte)(4))
                        {
                            objNNI.Get_Item_On_list_Of_Linear_Paths(linearOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Initialise_NumberOfInputs(metaData.Get_NumberInputRegisters());// set _NumberOfInputs for node.
                        }
                        else
                        {
                            objNNI.Get_Item_On_list_Of_Linear_Paths(linearOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Initialise_NumberOfInputs(metaData.Get_NumberOfNodesInHiddenLayer((byte)(hiddenLayerID + (byte)1)));// set _NumberOfInputs for node.
                        }
                        // class Linear_NeuralPath.
                        objNNI.Get_Item_On_list_Of_Linear_Paths(linearOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Initialise_list_Of_Linear_NeuralPath(objNNI.Get_Item_On_list_Of_Linear_Paths(linearOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_NumberOfInputs());// list of Linear_NeuralPath(s).
                    }
                }
            }
            // class Boolean.
            objNNI.Initialise_list_Of_Boolean_Paths(objNNI, metaData.Get_NumberOfBooleanOutputs());
            for (byte booleanOutputID = 0; booleanOutputID < metaData.Get_NumberOfBooleanOutputs(); booleanOutputID++)
            {

            }
            // class Constant.
            objNNI.Initialise_list_Of_Constant_Paths(objNNI, metaData.Get_NumberOfConstantOutputs());
            for (byte constantOutputID = 0; constantOutputID < metaData.Get_NumberOfConstantOutputs(); constantOutputID++)
            {

            }
            System.Console.WriteLine("exiting Gernerate_Lists_From_MetaData_For_MachineAI.");
        }
        public void Generate_MetaData_For_MachineAI(OpenAvrilNNI.Framework_NNI obj, OpenAvrilNNI.MachineAI objNNI, byte praiseID)
        {
            // io id.
            objNNI.Get_MetaData().Set_PraiseID(praiseID);
            // generate io parameters.
            switch (objNNI.Get_MetaData().Get_PraiseID())
            {
                case (byte)OpenAvrilNNI.Global.PraiseID.Praise_0:
                    OpenAvrilNNI.Input_Praise_0 objValue_Praise0_I = (OpenAvrilNNI.Input_Praise_0)obj.Get_NeuralNetwork().Get_Data().Get_Input().Get_Item_On_List_Of_Input_Subsets(0);
                    objNNI.Get_MetaData().Set_NumberOfInputRegisters(objValue_Praise0_I.Get_NumberInputRegisters());
                    objNNI.Get_MetaData().Set_NumberOfLinearInputs(objValue_Praise0_I.Get_NumberOfLinearInputs());
                    objNNI.Get_MetaData().Set_NumberOfBooleanInputs(objValue_Praise0_I.Get_NumberOfBooleanInputs());
                    objNNI.Get_MetaData().Set_NumberOfConstantInputs(objValue_Praise0_I.Get_NumberOfConstantInputs());
                    OpenAvrilNNI.Output_Praise_0 objValue_Praise0_O = (OpenAvrilNNI.Output_Praise_0)obj.Get_NeuralNetwork().Get_Data().Get_Output().Get_Item_On_List_Of_OutputSubsets(0);
                    objNNI.Get_MetaData().Set_NumberOfOutputRegisters(objValue_Praise0_O.Get_NumberOutputRegisters());
                    objNNI.Get_MetaData().Set_NumberOfLinearOutputs(objValue_Praise0_O.Get_NumberOfLinearOutputs());
                    objNNI.Get_MetaData().Set_NumberOfBooleanOutputs(objValue_Praise0_O.Get_NumberOfBooleanOutputs());
                    objNNI.Get_MetaData().Set_NumberOfConstantOutputs(objValue_Praise0_O.Get_NumberOfConstantOutputs());
                    break;

                case (byte)OpenAvrilNNI.Global.PraiseID.Praise_1:
                    OpenAvrilNNI.Input_Praise_1 objValue_Praise1_I = (OpenAvrilNNI.Input_Praise_1)obj.Get_NeuralNetwork().Get_Data().Get_Input().Get_Item_On_List_Of_Input_Subsets(1);
                    objNNI.Get_MetaData().Set_NumberOfInputRegisters(objValue_Praise1_I.Get_NumberInputRegisters());
                    objNNI.Get_MetaData().Set_NumberOfLinearInputs(objValue_Praise1_I.Get_NumberOfLinearInputs());
                    objNNI.Get_MetaData().Set_NumberOfBooleanInputs(objValue_Praise1_I.Get_NumberOfBooleanInputs());
                    objNNI.Get_MetaData().Set_NumberOfConstantInputs(objValue_Praise1_I.Get_NumberOfConstantInputs());
                    OpenAvrilNNI.Output_Praise_1 objValue_Praise1_O = (OpenAvrilNNI.Output_Praise_1)obj.Get_NeuralNetwork().Get_Data().Get_Output().Get_Item_On_List_Of_OutputSubsets(1);
                    objNNI.Get_MetaData().Set_NumberOfOutputRegisters(objValue_Praise1_O.Get_NumberOutputRegisters());
                    objNNI.Get_MetaData().Set_NumberOfLinearOutputs(objValue_Praise1_O.Get_NumberOfLinearOutputs());
                    objNNI.Get_MetaData().Set_NumberOfBooleanOutputs(objValue_Praise1_O.Get_NumberOfBooleanOutputs());
                    objNNI.Get_MetaData().Set_NumberOfConstantOutputs(objValue_Praise1_O.Get_NumberOfConstantOutputs());
                    break;

                case (byte)OpenAvrilNNI.Global.PraiseID.Praise_2:
                    OpenAvrilNNI.Input_Praise_2 objValue_Praise2_I = (OpenAvrilNNI.Input_Praise_2)obj.Get_NeuralNetwork().Get_Data().Get_Input().Get_Item_On_List_Of_Input_Subsets(2);
                    objNNI.Get_MetaData().Set_NumberOfInputRegisters(objValue_Praise2_I.Get_NumberInputRegisters());
                    objNNI.Get_MetaData().Set_NumberOfLinearInputs(objValue_Praise2_I.Get_NumberOfLinearInputs());
                    objNNI.Get_MetaData().Set_NumberOfBooleanInputs(objValue_Praise2_I.Get_NumberOfBooleanInputs());
                    objNNI.Get_MetaData().Set_NumberOfConstantInputs(objValue_Praise2_I.Get_NumberOfConstantInputs());
                    OpenAvrilNNI.Output_Praise_2 objValue_Praise2_O = (OpenAvrilNNI.Output_Praise_2)obj.Get_NeuralNetwork().Get_Data().Get_Output().Get_Item_On_List_Of_OutputSubsets(2);
                    objNNI.Get_MetaData().Set_NumberOfOutputRegisters(objValue_Praise2_O.Get_NumberOutputRegisters());
                    objNNI.Get_MetaData().Set_NumberOfLinearOutputs(objValue_Praise2_O.Get_NumberOfLinearOutputs());
                    objNNI.Get_MetaData().Set_NumberOfBooleanOutputs(objValue_Praise2_O.Get_NumberOfBooleanOutputs());
                    objNNI.Get_MetaData().Set_NumberOfConstantOutputs(objValue_Praise2_O.Get_NumberOfConstantOutputs());
                    break;

                case byte.MaxValue:
                    objNNI.Get_MetaData().Set_NumberOfInputRegisters(3);
                    objNNI.Get_MetaData().Set_NumberOfLinearInputs(1);
                    objNNI.Get_MetaData().Set_NumberOfBooleanInputs(1);
                    objNNI.Get_MetaData().Set_NumberOfConstantInputs(1);
                    objNNI.Get_MetaData().Set_NumberOfOutputRegisters(3);
                    objNNI.Get_MetaData().Set_NumberOfLinearOutputs(1);
                    objNNI.Get_MetaData().Set_NumberOfBooleanOutputs(1);
                    objNNI.Get_MetaData().Set_NumberOfConstantOutputs(1);
                    break;
            }
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
    // get.
    // set.

// private.
        private void Create_SolutionLogic()
        {
            Set_SolutionLogic(new SolutionLogic());
            while (Get_SolutionLogic() == null) { }
        }
    // get.
        public SolutionLogic Get_SolutionLogic()
        {
            return _SolutionLogic;
        }
        public Linear Get_New_Linear()
        {
            return new Linear();
        }
    // set.
        private void Set_NumberOfNodesInHiddenLayer(OpenAvrilNNI.MachineAI objNNI, byte layerID)
        {
            byte numberOfNodesInLayer = new byte();
            numberOfNodesInLayer = 0;
            if(objNNI.Get_MetaData().Get_NumberInputRegisters() <= 5)
            {
                switch (layerID)
                {
                    case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_4:
                        numberOfNodesInLayer = (byte)5;
                        break;

                    case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_3:
                        numberOfNodesInLayer = (byte)4;
                        break;

                    case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_2:
                        numberOfNodesInLayer = (byte)3;
                        break;

                    case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_1:
                        numberOfNodesInLayer = (byte)2;
                        break;

                    case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_0:
                        numberOfNodesInLayer = (byte)1;
                        break;
                }
            }
            else
            {
                switch (layerID)
                {
                    case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_4:
                        numberOfNodesInLayer = (byte)Math.Round((double)objNNI.Get_MetaData().Get_NumberInputRegisters() * (double)0.8);
                        break;

                    case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_3:
                        numberOfNodesInLayer = (byte)Math.Round((double)objNNI.Get_MetaData().Get_NumberInputRegisters() * (double)0.6);
                        break;

                    case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_2:
                        numberOfNodesInLayer = (byte)Math.Round((double)objNNI.Get_MetaData().Get_NumberInputRegisters() * (double)0.4);
                        break;

                    case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_1:
                        numberOfNodesInLayer = (byte)Math.Round((double)objNNI.Get_MetaData().Get_NumberInputRegisters() * (double)0.2);
                        break;

                    case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_0:
                        numberOfNodesInLayer = (byte)1;
                        break;
                }
            }
                
            objNNI.Get_MetaData().Set_NumberOfNodesInHiddenLayer(layerID, numberOfNodesInLayer);
            System.Console.WriteLine("layerID == " + layerID + "  Set_NumberOfNodesInLayer = " + objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID));
        }
        private void Set_SolutionLogic(SolutionLogic value)
        {
            _SolutionLogic = value;
        }
    }
}
