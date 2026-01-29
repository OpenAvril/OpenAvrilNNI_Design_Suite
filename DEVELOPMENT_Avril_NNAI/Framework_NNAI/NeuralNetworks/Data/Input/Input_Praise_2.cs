// classes.
// registers.
// constructor.
// destructor
// public.
// get.
// set.
// private.
// get.
// set.

namespace Avril_NNAI
{
    public class Input_Praise_2
    {
        enum PRAISE_2
        {
            Direction_X,
            Direction_Y,
            Direction_Z,
            Period
        }
        private byte _numberOfInputValues;
        private double _direction_X;
        private double _direction_y;
        private double _direction_Z;
        private double _period;

        public Input_Praise_2()
        {
            Set_NumberOfInputValues(4);
        }

        public double Get_Item_Of_Input_Praise(byte index)
        {
            switch(index)
            {
                case 0:
                    return Get_Direction_X();
                    break;
                case 1:
                    return Get_Direction_Y();
                    break;
                case 2:
                    return Get_Direction_Z();
                    break;
                case 3:
                    return Get_Period();
                    
                default:
                    return 0;
                    break;
            }
        }
        public double Get_Direction_X()
        {
            return _direction_X;
        }
        public double Get_Direction_Y()
        {
            return _direction_y;
        }
        public double Get_Direction_Z()
        {
            return _direction_Z;
        }
        public double Get_Period()
        {
            return _period;
        }
        public ulong Get_NumberOfInputValues()
        {
            return _numberOfInputValues;
        }

        public void Set_Direction_X(double value)
        {
            _direction_X = value;
        }
        public void Set_Direction_Y(double value)
        {
            _direction_y = value;
        }
        public void Set_Direction_Z(double value)
        {
            _direction_Z = value;
        }
        public void Set_Item_Of_Input_Praise(byte index, double value)
        {
            switch (index)
            {
                case 0:
                    Set_Direction_X(value);
                    break;
                
                case 1:
                    Set_Direction_Y(value);
                    break;
                
                case 2:
                    Set_Direction_Z(value);
                    break;
                
                default:
                    break;
            }
        }
        private void Set_NumberOfInputValues(byte numberOfInputValues)
        {
            _numberOfInputValues = numberOfInputValues;
        }
    }
}
