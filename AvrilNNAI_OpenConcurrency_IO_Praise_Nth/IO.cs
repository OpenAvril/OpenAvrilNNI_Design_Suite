namespace AvrilNNAI_OpenConcurrency_IO_Praise_Nth
{
    public class IO
    {
// classes.

// registers.
        static private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Framework_NNAI _framework_NNAI;
        static private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI _machineAI;

// constructor.
        public IO()
        {
            Create_framework_NNAI(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Framework_NNAI());
            while (Get_framework_NNAI() == null) { }

            Create_machineAI(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI());
            while (Get_machineAI() == null) { }
        }

// destructor.
        ~IO()
        {

        }

// public.
        static public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Framework_NNAI Create_Neural_Network()
        {
            Set_framework_NNAI(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Framework_NNAI());
            while (Get_framework_NNAI() == null) { }
            return Get_framework_NNAI();

        }
        static public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI Initialise_Instance_Of_MachineAI(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Framework_NNAI obj)
        {
            Set_machineAI(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI());
            while (Get_machineAI() == null) { }
            Set_machineAI(obj.Get_Neural_Networks().Get_Aglorithms().Create_Instance_Of_MachineAI(obj, "AvrilNNAI_OpenConcurrency_IO_Praise_Nth_OpenCFSD_Praise_1_IO.nnai", (ulong)1));
            return Get_machineAI();
        }
        static public bool Run_Neural_Network_Inteligence(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI objNNAI)
        {
            return objNNAI.Run_Neural_Network_Inteligence(objNNAI);
        }
    // get.
        static public double[] Get_Output_Values(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI objNNAI)
        {
            return objNNAI.Get_List_Of_REGISTERED_Outputs();
        }
    // set.
        static public void Set_Input_Values(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI objNNAI, double[] inputValues)
        {
            for (byte inputID = 0; inputID < objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues(); inputID++)
            {
                objNNAI.Set_Item_On_List_Of_REGISTERED_Input(inputID, inputValues[inputID]);
            }
        }
// private.
        static private void Create_framework_NNAI(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Framework_NNAI newFramework)
        {
            _framework_NNAI = newFramework;
        }
        static private void Create_machineAI(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI newMachineAI)
        {
            _machineAI = newMachineAI;
        }
        // get.
        static private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Framework_NNAI Get_framework_NNAI()
        {
            return _framework_NNAI;
        }
        static private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI Get_machineAI()
        {
            return _machineAI;
        }
        // set.
        static private void Set_framework_NNAI(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Framework_NNAI newFramework)
        {
            _framework_NNAI = newFramework;
        }
        static private void Set_machineAI(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI newMachineAI)
        {
            _machineAI = newMachineAI;
        }
    }
}
