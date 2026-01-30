
namespace Avril_NNAI
{
    public class Node
    {
// classes.
        private Avril_NNAI.Node_Control _Node_Control;

        // registers.
        private Avril_NNAI.Linear[] _NeuralPathOfInput_SubSet;
        private ulong _NumberOfInputs;
        private double[] _REGISTERED_Inputs;
        private double _REGISTERED_Output;

// constructor.
        public Node()
        {
            System.Console.WriteLine("entered Node.");
            Create_NeuralPathOfInput_SubSet(new Avril_NNAI.Linear[1]);
            while (Get_NeuralPathOfInput_SubSet(0) == null) { }
            Set_NeuralPathOfInput_SubSet(0, new Avril_NNAI.Linear());

            Create_NumberOfInputs(new ulong());
            Set_NumberOfInputs(1);

            Create_REGISTERED_Inputs(new double[1]);
            Set_REGISTERED_Inputs(0, 0.0);

            Create_REGISTERED_Output(new double());
            Set_REGISTERED_Output(0.0);
        }

// destructor.
        ~Node()
        {

        }

        // public.
        public void Create_NeuralPathOfInput_SubSet(Avril_NNAI.Linear[] neuralPathOfInput_SubSet)
        {
            _NeuralPathOfInput_SubSet = neuralPathOfInput_SubSet;
        }
        public void Create_REGISTERED_Inputs(double[] registered_Inputs)
        {
            _REGISTERED_Inputs = registered_Inputs;
        }
    
    // get.
        public Avril_NNAI.Linear Get_NeuralPathOfInput_SubSet(ulong nodeID)
        {
            return _NeuralPathOfInput_SubSet[nodeID];
        }
        public ulong Get_NumberOfInputs()
        {
            return _NumberOfInputs;
        }
        public double Get_REGISTERED_Input(ulong praiseID)
        {
            return _REGISTERED_Inputs[praiseID];
        }
        public double Get_REGISTERED_Output()
        {
            return _REGISTERED_Output;
        }

    // set.
        public void Set_NeuralPathOfInput_SubSet(ulong inputID, Avril_NNAI.Linear neuralPathOfInput_SubSet)
        {
            _NeuralPathOfInput_SubSet[inputID] = neuralPathOfInput_SubSet;
        }
        public void Set_NumberOfInputs(ulong numberOfInputs)
        {
            _NumberOfInputs = numberOfInputs;
        }
        public void Set_REGISTERED_Inputs(ulong praiseID, double registered_Input)
        {
            _REGISTERED_Inputs[praiseID] = registered_Input;
        }
        public void Set_REGISTERED_Output(double registered_Output)
        {
            _REGISTERED_Output = registered_Output;
        }

// private.
        private void Create_NumberOfInputs(ulong value)
        {
            _NumberOfInputs = value;
        }
        private void Create_REGISTERED_Output(double registered_Output)
        {
            _REGISTERED_Output = registered_Output;
        }

    // get.
    // set.
    }
}
