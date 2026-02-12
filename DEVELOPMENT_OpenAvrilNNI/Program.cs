/*
*  Class Tree.
* -----------------
* | * -> register |
* -----------------
* 
*			    Program
*					|
*                   |
*                   |
*   		Framework_NNI
*					|
*					|
*					|        
*			NeuralNetworks
*					|
*			   _____|_____________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
*			   |                    |																         |																												                                                                              |
* 			Global				Algorithms															        Data																											                                                                            Execute
*			   |					|																         |                                                                                                                                                                                            |
*			   |					|____________________________________________					         |______________________________________________________________________________                                                                                                              |                              
*			   |					|											|					         |									  |										    |                                                                                                             |                          
*			MyEnumExtensions    SolutionLogic								NeuralPath				        Input								Output									MachineAI (Data File)                                                                                           FileReadWrite (.nni)
*									|											|					          |									  |										    |				
*									L------------	Algorithms_Praise_0		    |_____________________		  L------------	Input_Praise_0		  L------------	Output_Praise_0			    |_______________________________________________________________________________
*									L------------	Algorithms_Praise_1		    |		    |		  |       L------------	Input_Praise_1		  L------------	Output_Praise_1			    |                  |                   |                    |                   |
*									L------------	Algorithms_Praise_2	    Linear		Constant    Binary	  L------------	Intput_Praise_1		  L------------	Output_Praise_1		    MetaData        *ListOfLinear       *ListOfConstant         *ListOfBinary
*																			    |                                               
*													                            |           
*                   													        |                       
*					                    		                            PraiseSet   
*					                    					                    |
*					                    							            |
*					                    							            |
*					                    									  Node                 
*										                    																																		           			
*															                    																													           
*																				                    																								           
* 																									                       																			        		
*/
namespace OpenAvrilNNI
{
    public static class Program
    {
// definitions.

// classes.

// registers.
        static private Framework_NNI _instance_Of_Framework_NNI = null;

// main.
        static void Main()
        {
            System.Console.WriteLine("started program entry.");
            Create_Framework_NNI();
            var obj = Get_Framework_NNI();
            var objNNI_DEFAULT = obj.Get_NeuralNetwork().Get_Data().Get_New_MachineAI();
            System.Console.WriteLine("created DEFAULT datafile .nni (class MachineAI).");
    // SIMULATION - output testbench.
            for (byte outputID = 0; outputID < objNNI_DEFAULT.Get_MetaData().Get_NumberOfLinearOutputs(); outputID++)
            {
                for (Int16 layerID = 4; layerID > -1; layerID--)
                {
                    byte hiddenLayerID = Convert.ToByte(layerID);
                    for (byte nodeID = 0; nodeID < objNNI_DEFAULT.Get_MetaData().Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                    {
                        if (hiddenLayerID == (byte)(4))
                        {
                            objNNI_DEFAULT.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Set_NumberOfInputs(objNNI_DEFAULT.Get_MetaData().Get_NumberInputRegisters());
                        }
                        else
                        {
                            objNNI_DEFAULT.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Set_NumberOfInputs(objNNI_DEFAULT.Get_MetaData().Get_NumberOfNodesInHiddenLayer((byte)(hiddenLayerID + (byte)1)));
                        }
                        for (byte inputID = 0; inputID < objNNI_DEFAULT.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_NumberOfInputs(); inputID++)
                        {
                            objNNI_DEFAULT.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(outputID).Initialise_Linear_NeuralPath(obj);
                            System.Console.WriteLine("outputID = " + outputID + "  hiddenLayerID = " + hiddenLayerID + "  nodeID = " + nodeID + "  inputID = " + inputID + "  bias = " + objNNI_DEFAULT.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(outputID).Get_bias() + "  weight = " + objNNI_DEFAULT.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(outputID).Get_weight());
                        }
                    }
                }
            }
    // end SIMULATION - output testbench.
            //ToDo: boolean preperation.
            MachineAI objNNI = obj.Get_NeuralNetwork().Get_Aglorithms().Initialise_instance_Of_MachineAI(obj, "OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1", (byte)1);
    // SIMULATION - output testbench.
            for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfLinearOutputs(); outputID++)
            {
                for (Int16 layerID = 4; layerID > -1; layerID--)
                {
                    byte hiddenLayerID = Convert.ToByte(layerID);
                    for (byte nodeID = 0; nodeID < objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                    {
                        if (hiddenLayerID == (byte)(4))
                        {
                            objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Set_NumberOfInputs(objNNI.Get_MetaData().Get_NumberInputRegisters());
                        }
                        else
                        {
                            objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Set_NumberOfInputs(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer((byte)(hiddenLayerID + (byte)1)));
                        }
                        for (byte inputID = 0; inputID < objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_NumberOfInputs(); inputID++)
                        {
                            objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(outputID).Initialise_Linear_NeuralPath(obj);
                            System.Console.WriteLine("outputID = " + outputID + "  hiddenLayerID = " + hiddenLayerID + "  nodeID = " + nodeID + "  inputID = " + inputID + "  bias = " + objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(outputID).Get_bias() + "  weight = " + objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(outputID).Get_weight());
                        }
                    }
                }
            }

            //obj.Get_NeuralNetwork().Get_Data().Preserve_New_Neural_Network(objNNI);
            //obj.Initialise(obj, objNNI.Get_MetaData());
            //ToDO: train network
            //obj.Get_NeuralNetwork().Get_Execute().Get_FileReadWrite().WriteValuesToFile(obj, obj.Get_NeuralNetwork().Get_Data().Get_Item_On_list_Of_Neural_Network_Preservation(0), objNNI.Get_MetaData().Get_NameOfNNI());
        }

        // public.
        static private void Create_Framework_NNI()
        {
            Set_Framework_NNI(new Framework_NNI());
            while (Get_Framework_NNI() == null) { }
        }
    // get.
        static public Framework_NNI Get_Framework_NNI()
        {
                return _instance_Of_Framework_NNI;
        }
    // set.

// private.
    // get.
    // set.
        static private Framework_NNI Set_Framework_NNI(Framework_NNI newFramework)
        {
            return _instance_Of_Framework_NNI = newFramework;
        }
    }
}