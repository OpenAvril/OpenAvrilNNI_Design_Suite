
namespace Avril_NNAI
{
    public class MachineAI
    {
// classes.
        private Avril_NNAI.MetaData _metaData;

// registers.
        private string _nameOfNNAI;
        private ulong[] _usedPraiseIDs;

// constructor.
        public MachineAI()
        {
            //System.Console.WriteLine("entered MachineAI.");
            Create_MetaData(new Avril_NNAI.MetaData());
            while (Get_MetaData() == null) { }
            //System.Console.WriteLine("ALPHA.");
            Create_NameOfNNAI(new string("nil"));
            Set_NameOfNNAI("Undefined_NNAI");
            //System.Console.WriteLine("BRAVO.");
            Create_UsedPraiseIDs(new ulong[1]);
            Set_UsedPraiseIDs(0, 0);
        }

// destructor.
        ~MachineAI()
        {
        }

// public.
    // get.
        public Avril_NNAI.MetaData Get_MetaData()
        {
            return _metaData;
        }
        public string Get_NameOfNNAI()
        {
            return _nameOfNNAI;
        }
        public ulong[] Get_UsedPraiseIDs()
        {
            return _usedPraiseIDs;
        }

    // set.
        
// private.
        private void Create_MetaData(Avril_NNAI.MetaData value)
        {
            _metaData = value;
        }
        private void Create_NameOfNNAI(string value)
        {
            _nameOfNNAI = value;
        }
        private void Create_UsedPraiseIDs(ulong[] value)
        {
            _usedPraiseIDs = value;
        }

    // get.
        private ulong[] Get_List_Of_UsedPraiseIDs()
        {
            return _usedPraiseIDs;
        }
        private ulong Get_UsedPraiseIDs(ulong index)
        {
            return _usedPraiseIDs[index];
        }
        
    // set.
        private void Set_MetaData(Avril_NNAI.MetaData metaData)
        {
            _metaData = metaData;
        }
        public void Set_NameOfNNAI(string nameOfNNAI)
        {
            _nameOfNNAI = nameOfNNAI;
        }
        private void Set_UsedPraiseIDs(ulong index, ulong praiseID)
        {
            _usedPraiseIDs[index] = praiseID;
        }
    }
}
