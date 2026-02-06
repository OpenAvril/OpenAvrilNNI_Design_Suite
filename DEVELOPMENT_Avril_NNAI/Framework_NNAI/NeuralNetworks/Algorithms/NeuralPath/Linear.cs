
namespace Avril_NNAI
{
    public class Linear
    {
// classes.

// registers.
        private double _bias;
        private double _weight;

// constructor.
        public Linear()
        {
            //System.Console.WriteLine("entered Linear.");
            Create_Weight(new double());
            Set_Weight(0.0);

            Create_Bias(new double());
            Set_Bias(0.0);
            //System.Console.WriteLine("exiting Linear.");
        }

// destructor.
        ~Linear()
        {

        }

// public.
        public double Calculate_Node_Output(double[] nodeInputs, double nodeOutput)
        {
            double sum = 0.0;
            double bias = 0.0;
            for (ulong index = 0; index < (ulong)nodeInputs.LongLength; index++)
            {
                double temp = 0.0;
                temp = (_weight * nodeInputs[index]);
                sum = sum + temp;
                sum = sum + bias;
            }
            return sum;
        }
        public double Run_Neural_Path_Calculation(Avril_NNAI.MachineAI objNNAI, byte outputID, byte hiddenLayerID, ulong nodeID, ulong inputID)
        {
            double inputValue = 0.0;
            double temp = 0.0;
            if(hiddenLayerID == (byte)Avril_NNAI.Global.NodeLayer.Layer_4)
            {
                inputValue = objNNAI.Get_Item_On_List_Of_REGISTERED_Inputs(inputID);
            }
            else
            {
                inputValue = objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node((byte)(hiddenLayerID + (byte)1), nodeID).Get_REGISTERED_Output();
            }
            temp = Get_Bias();
            temp = temp + (inputValue * Get_Weight());
            return temp;
        }
    // get.
        public double Get_Bias()
        {
            return _bias;
        }
        public double Get_Weight()
        {
            return _weight;
        }

    // set.
        public void Set_Bias(double bias)
        {
            _bias = bias;
        }
        public void Set_Weight(double weight)
        {
            _weight = weight;
        }

// private.
        private void Create_Bias(double bias)
        {
            _bias = bias;
        }
        private void Create_Weight(double weight)
        {
            _weight = weight;
        }


    // get.
    // set
    }
}
