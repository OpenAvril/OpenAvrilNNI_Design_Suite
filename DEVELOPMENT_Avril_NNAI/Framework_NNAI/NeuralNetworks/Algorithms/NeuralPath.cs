
namespace Avril_NNAI
{
    public class NeuralPath
    {
// classes.
        private Avril_NNAI.Linear _New_Linear;
            
// registers.

// constructor.
        public NeuralPath() 
        {
            Create_New_Linear(new Avril_NNAI.Linear());
            while (Get_New_Linear() == null) { }
        }

// destructor
        ~NeuralPath()
        {

        }

// public.
    // get.
        public Avril_NNAI.Linear Get_New_Linear()
        {
            return _New_Linear;
        }
    // set.

// private.
        private void Create_New_Linear(Avril_NNAI.Linear linear)
        {
            _New_Linear = linear;
        }
    // get.
    // set.
    }
}
