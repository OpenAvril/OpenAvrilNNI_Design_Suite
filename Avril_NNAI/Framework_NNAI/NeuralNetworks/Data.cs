
using System.Linq;

namespace Avril_NNAI
{
    public class Data
    {
        private Avril_NNAI.Input _input;
        private Avril_NNAI.Output _output;
        ulong _NumberOfTotalInputs;
        Avril_NNAI.Node[] _Layer4_Node_Inputs = new Avril_NNAI.Node[1];
        Avril_NNAI.Node[] _Layer3_Node_Inputs = new Avril_NNAI.Node[1];
        Avril_NNAI.Node[] _Layer2_Node_Inputs = new Avril_NNAI.Node[1];
        Avril_NNAI.Node[] _Layer1_Node_Inputs = new Avril_NNAI.Node[1];
        Avril_NNAI.Node[] _Layer0_Node_Inputs = new Avril_NNAI.Node[1];
        long _REGISTERED_Output;

        public Data()
        {
            Set_Input(new Avril_NNAI.Input());
            while (Get_Input() == null) { }

            Set_Output(new Avril_NNAI.Output());
            while (Get_Output() == null) { }

            _NumberOfTotalInputs = 0;

            Avril_NNAI.Node newEmpty = new Avril_NNAI.Node();
            while (newEmpty == null) { }

            _Layer4_Node_Inputs = new Avril_NNAI.Node[1];
            _Layer4_Node_Inputs[0] = newEmpty;

            _Layer3_Node_Inputs = new Avril_NNAI.Node[1];
            _Layer3_Node_Inputs[0] = newEmpty;

            _Layer2_Node_Inputs = new Avril_NNAI.Node[1];
            _Layer2_Node_Inputs[0] = newEmpty;

            _Layer1_Node_Inputs = new Avril_NNAI.Node[1];
            _Layer1_Node_Inputs[0] = newEmpty;

            _Layer0_Node_Inputs = new Avril_NNAI.Node[1];
            _Layer0_Node_Inputs[0] = newEmpty;

            _REGISTERED_Output = 0;
        }

        public Avril_NNAI.Input Get_Input()
        {
            return _input;
        }

        public Avril_NNAI.Node[] Get_Layer4_Node_Inputs()
        {
            return _Layer4_Node_Inputs;
        }

        public Avril_NNAI.Node[] Get_Layer3_Node_Inputs()
        {
            return _Layer3_Node_Inputs;
        }

        public Avril_NNAI.Node[] Get_Layer2_Node_Inputs()
        {
            return _Layer2_Node_Inputs;
        }


        public Avril_NNAI.Node[] Get_Layer1_Node_Inputs()
        {
            return _Layer1_Node_Inputs;
        }

        public Avril_NNAI.Node[] Get_Layer0_Node_Input()
        {
            return _Layer0_Node_Inputs;
        }

        public long Get_REGISTERED_Output()
        {
            return _REGISTERED_Output;
        }

        public ulong Get_NumberOfTotalInputs()
        {
            return _NumberOfTotalInputs;
        }

        public Avril_NNAI.Output Get_Output()
        {
            return _output;
        }

        private void Set_Input(Avril_NNAI.Input input)
        {
            _input = input;
        }

        public void Set_NumberOfTotalInputs(Avril_NNAI.Framework_NNAI obj, ulong numberOfTotalInputs)
        {
            _NumberOfTotalInputs = numberOfTotalInputs;

            if ((Get_NumberOfTotalInputs() > 0) && (Get_NumberOfTotalInputs() <= 9223372036854775807))
            {
                _Layer4_Node_Inputs = new Avril_NNAI.Node[Get_NumberOfTotalInputs()];
                for (ulong index = 0; index < Get_NumberOfTotalInputs(); index++)
                {
                    _Layer4_Node_Inputs.ElementAt((int)index).Set_NumberOfInputs(obj, Get_NumberOfTotalInputs());
                }

                double ratio = (4 / 5);
                _Layer3_Node_Inputs = new Avril_NNAI.Node[(ulong)(Get_NumberOfTotalInputs() / ratio)];
                for (ulong index = 0; index < (ulong)(Get_NumberOfTotalInputs() / ratio); index++)
                {
                    _Layer3_Node_Inputs.ElementAt((int)index).Set_NumberOfInputs(obj, (ulong)(Get_NumberOfTotalInputs() / ratio));
                }

                ratio = (3 / 5);
                _Layer2_Node_Inputs = new Avril_NNAI.Node[(ulong)(Get_NumberOfTotalInputs() / ratio)];
                for (ulong index = 0; index < (ulong)(Get_NumberOfTotalInputs() / ratio); index++)
                {
                    _Layer2_Node_Inputs.ElementAt((int)index).Set_NumberOfInputs(obj, (ulong)(Get_NumberOfTotalInputs() / ratio));
                }

                ratio = (2 / 5);
                _Layer1_Node_Inputs = new Avril_NNAI.Node[(ulong)(Get_NumberOfTotalInputs() / ratio)];
                for (ulong index = 0; index < (ulong)(Get_NumberOfTotalInputs() / ratio); index++)
                {
                    _Layer1_Node_Inputs.ElementAt((int)index).Set_NumberOfInputs(obj, (ulong)(Get_NumberOfTotalInputs() / ratio));
                }

                ratio = (1 / 5);
                _Layer0_Node_Inputs = new Avril_NNAI.Node[(ulong)(Get_NumberOfTotalInputs() / ratio)];
                for (ulong index = 0; index < (ulong)(Get_NumberOfTotalInputs() / ratio); index++)
                {
                    _Layer0_Node_Inputs.ElementAt((int)index).Set_NumberOfInputs(obj, (ulong)(Get_NumberOfTotalInputs() / ratio));
                }
            }
        }

        private void Set_Output(Avril_NNAI.Output output)
        {
            _output = output;
        }
    }
}
