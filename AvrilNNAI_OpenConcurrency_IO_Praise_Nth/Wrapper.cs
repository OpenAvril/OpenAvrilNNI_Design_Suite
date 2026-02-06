namespace AvrilNNAI_OpenConcurrency_IO_Praise_Nth
{
    public class Wrapper
    {
// classes.

// registers.

// constructor.
        public Wrapper()
        {

        }

// destructor.
        ~Wrapper()
        {

        }

// public.
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI Initialise_Instance_Of_MachineAI(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Framework_NNAI obj)
        {
            return obj.Get_Neural_Networks().Get_Aglorithms().Create_Instance_Of_MachineAI_From_nnai_File(obj, "Avril_NNAI_OpenCFSD_Praise_1_IO.nnai");
        }
        public bool Run_Neural_Network_Inteligence(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI objNNAI)
        {
            if (objNNAI.Get_IsNewDataReady() == false)
            {
                objNNAI.Set_IsNewDataReady(objNNAI.Run_Neural_Network_Inteligence(objNNAI));
            }
            return objNNAI.Get_IsNewDataReady();
        }
        // get.
        public double[] Get_Output_Values(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI objNNAI)
        {
            return objNNAI.Get_List_Of_REGISTERED_Outputs();
        }
    // set.
        public void Set_Input_Values(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI objNNAI, double[] inputValues)
        {
            for (byte inputID = 0; inputID < objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues(); inputID++)
            {
                objNNAI.Set_Item_On_List_Of_REGISTERED_Input(inputID, inputValues[inputID]);
            }
        }
// private.

    // get.
    
    // set.
    }
}
