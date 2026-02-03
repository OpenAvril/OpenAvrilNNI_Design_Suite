
namespace Avril_NNAI
{
    public class MetaData
    {
// classes.

// registers.
        private string _nameOfNNAI;
        private byte _NumberOfPraiseInputValues;
        private byte _NumberOfPraiseOutputValues;
        private ulong _PraiseID;

// constructor.
        public MetaData()
        {
            //System.Console.WriteLine("entered MetaData.");

            Create_NameOfNNAI(new string("nil"));
            Set_NameOfNNAI("Undefined_NNAI");
            
            Create_PraiseID(new ulong());
            Set_PraiseID(ulong.MaxValue);

            Create_NumberOfPraiseInputValues(new byte());
            Set_NumberOfPraiseInputValues(2);

            Create_NumberOfPraiseOutputValues(new byte());
            Set_NumberOfPraiseOutputValues(2);
        }

// destructor.
        ~MetaData()
        {

        }

// public.
// get.
        public string Get_NameOfNNAI()
        {
            return _nameOfNNAI;
        }
        public byte Get_NumberOfPraiseInputValues()
        {
            return _NumberOfPraiseInputValues;
        }
        public byte Get_NumberOfPraiseOutputValues()
        {
            return _NumberOfPraiseOutputValues;
        }
        public ulong Get_PraiseID()
        {
            return _PraiseID;
        }

    // set.
        public void Set_NumberOfPraiseInputValues(byte value)
        {
            _NumberOfPraiseInputValues = value;
        }
        public void Set_NumberOfPraiseOutputValues(byte value)
        {
            _NumberOfPraiseOutputValues = value;
        }

// private.
        private void Create_NameOfNNAI(string value)
        {
            _nameOfNNAI = value;
        }
        private void Create_NumberOfPraiseInputValues(byte value)
        {
            _NumberOfPraiseInputValues = value;
        }
        private void Create_NumberOfPraiseOutputValues(byte value)
        {
            _NumberOfPraiseOutputValues = value;
        }

        private void Create_PraiseID(ulong value)
        {
            _PraiseID = value;
        }
        
    // get.

    // set.
        public void Set_NameOfNNAI(string nameOfNNAI)
        {
            _nameOfNNAI = nameOfNNAI;
        }
        private void Set_PraiseID(ulong praiseID)
        {
            _PraiseID = praiseID;
        }
    }
}