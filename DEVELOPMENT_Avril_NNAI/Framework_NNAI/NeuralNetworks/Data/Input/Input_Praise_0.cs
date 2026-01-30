
namespace Avril_NNAI
{
    public class Input_Praise_0
    {
// classes.

// registers.
        private enum PRAISE_0 : byte
        {
            Ping
        }
        private byte _numberOfInputValues;
        private double _Ping;

// constructor.
        public Input_Praise_0()
        {
            Create_NumberOfInputValues(new byte());
            Set_NumberOfInputValues(1);

            Create_Ping(new double());
            Set_Item_Of_Input_Praise(0, 0.0);
        }

// destructor
        ~Input_Praise_0()
        {

        }

// public.
    // get.
        public double Get_Item_Of_Input_Praise(byte index)
        {
            switch (index)
            {
                case 0:
                    return Get_Ping();
                default:
                    return 0;
            }
        }
        public ulong Get_NumberOfInputValues()
        {
            return _numberOfInputValues;
        }

    // set.
        public void Set_Item_Of_Input_Praise(byte index, double value)
        {
            switch (index)
            {
                case 0:
                    Set_Ping(value);
                    break;
                default:
                    break;
            }
        }

// private.
        private void Create_NumberOfInputValues(byte numberOfInputValues)
        {
            _numberOfInputValues = numberOfInputValues;
        }
        private void Create_Ping(double ping)
        {
            _Ping = ping;
        }

    // get.
        private double Get_Ping()
        {
            return _Ping;
        }

    // set.
        private void Set_NumberOfInputValues(byte numberOfInputValues)
        {
            _numberOfInputValues = numberOfInputValues;
        }
        private void Set_Ping(double value)
        {
            _Ping = value;
        }
    }
}
