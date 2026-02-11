namespace OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1
{
    public class IO
    {
// classes.

// registers.
        static private Framework_NNI _Framework_NNI;
        static private MachineAI _instance_Of_MachineAI;

// constructor.
        public IO()
        {
            Create_Framework_NNI();
            Create_instance_Of_MachineAI();
        }

// destructor.
        ~IO()
        {

        }

// public.
        static public Framework_NNI Create_Neural_Network()
        {
            Set_Framework_NNI(new Framework_NNI());
            while (Get_Framework_NNI() == null) { }
            return Get_Framework_NNI();

        }
        static public MachineAI Initialise_Instance_Of_instance_Of_MachineAI(Framework_NNI obj)
        {
            Set_instance_Of_MachineAI(new MachineAI());
            while (Get_instance_Of_MachineAI() == null) { }
            Set_instance_Of_MachineAI(obj.Get_NeuralNetwork().Get_Aglorithms().Create_Instance_Of_instance_Of_MachineAI(obj, "OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1", (byte)1));
            return Get_instance_Of_MachineAI();
        }
        static public bool Run_Neural_Network_Inteligence(MachineAI objNNI)
        {
            return objNNI.Run_Neural_Network_Inteligence(objNNI);
        }
    // get.
        static public double[] Get_Output_Values(MachineAI objNNI)
        {
            return objNNI.Get_list_Of_REGISTERED_Outputs();
        }
    // set.
        static public void Set_Input_Values(MachineAI objNNI, double[] inputValues)
        {
            for (byte inputID = 0; inputID < objNNI.Get_MetaData().Get_NumberInputRegisters(); inputID++)
            {
                objNNI.Set_Item_On_List_Of_REGISTERED_Input(inputID, inputValues[inputID]);
            }
        }
// private.
        static private void Create_Framework_NNI()
        {
            _Framework_NNI = new Framework_NNI();
            while (Get_Framework_NNI() == null) { }
        }
        static private void Create_instance_Of_MachineAI()
        {
            _instance_Of_MachineAI = new MachineAI();
            while (Get_instance_Of_MachineAI() == null) { }
        }
    // get.
        static private Framework_NNI Get_Framework_NNI()
        {
            return _Framework_NNI;
        }
        static private MachineAI Get_instance_Of_MachineAI()
        {
            return _instance_Of_MachineAI;
        }
    // set.
        static private void Set_Framework_NNI(Framework_NNI newFramework)
        {
            _Framework_NNI = newFramework;
        }
        static private void Set_instance_Of_MachineAI(MachineAI newMachineAI)
        {
            _instance_Of_MachineAI = newMachineAI;
        }
    }
}
