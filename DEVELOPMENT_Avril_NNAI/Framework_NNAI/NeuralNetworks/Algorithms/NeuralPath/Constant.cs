namespace Avril_NNAI
{
    public class Constant
    {
// classes.

// registers.
        private double _constant;

// constructor.
        public Constant()
        {
            //System.Console.WriteLine("entered Constant.");
            Create_Constant(new double());
            Set_Constant(0.0);
            //System.Console.WriteLine("exiting Constant.");
        }

// destructor.
        ~Constant()
        {

        }

// public.
    // get.
        public double Get_Constant()
        {
            return _constant;
        }
        
    // set.
        public void Set_Constant(double constant)
        {
            _constant = constant;
        }
        
// private.
        private void Create_Constant(double constant)
        {
            _constant = constant;
        }   

    // get.
    
    // set

    }
}
