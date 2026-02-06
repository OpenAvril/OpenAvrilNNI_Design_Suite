
namespace AvrilNNAI_OpenConcurrency_IO_Praise_Nth
{
    public class Data
    {
// classes.
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Input _input;
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI _newMachineAI;
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Output _output;

// registers.

// constructor.
        public Data()
        {
            //System.Console.WriteLine("entered Data.");
            Create_Input(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Input());
            while (Get_Input() == null) { }
            //System.Console.WriteLine("ALPHA.");
            Create_Output(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Output());
            while (Get_Output() == null) { }
            //System.Console.WriteLine("BRAVO.");
            Create_NewMachineAI(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI());
            while (Get_NewMachineAI() == null) { }
        }

// destructor.
        ~Data()
        {
            //System.Console.WriteLine("exited Data.");
        }

// public.
    
    // get.
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI Get_NewMachineAI()
        {
            return _newMachineAI;
        }
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Input Get_Input()
        {
            return _input;
        }
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Output Get_Output()
        {
            return _output;
        }

    // set.


// private.
        private void Create_Input(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Input input)
        {
            _input = input;
        }
        private void Create_NewMachineAI(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI machineAI)
        {
            _newMachineAI = machineAI;
        }
        private void Create_Output(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Output output)
        {
            _output = output;
        }
    // get.
        
    // set.

    }
}
