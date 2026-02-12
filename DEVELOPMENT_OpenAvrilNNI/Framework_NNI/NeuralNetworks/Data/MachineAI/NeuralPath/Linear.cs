
namespace OpenAvrilNNI
{
    public class Linear
    {
// classes.
        private PraiseSet _PraiseSet;

// registers.


// constructor.
        public Linear()
        {
            //System.Console.WriteLine("entered Linear.");
            this.Create_PraiseSet();
            //System.Console.WriteLine("exiting Linear.");
        }

// destructor.
        ~Linear()
        {

        }

// public.
    // get.
        public PraiseSet Get_PraiseSet()
        {
            return _PraiseSet;
        }
    // set.

// private.
        private void Create_PraiseSet()
        {
            this.Set_PraiseSet(new PraiseSet());
            while (this.Get_PraiseSet() == null) { }
        }
    // get.
    // set
        private void Set_PraiseSet(PraiseSet newPraiseSet)
        {
            _PraiseSet = newPraiseSet;
        }
    }
}
