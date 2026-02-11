namespace OpenAvrilNNI
{
    public class SolutionLogic
    {
// classes.
        private Algorithm_Praise_0 _Algorithm_Praise_0;
        private Algorithm_Praise_1 _Algorithm_Praise_1;
        private Algorithm_Praise_2 _Algorithm_Praise_2;

// registers.    
        private object[] _ListOfAlgorithmSubsets;

// constructor.
        public SolutionLogic() 
        { 
            Create_ListOfAlgorithmSubsets(3);
            Create_Algorithm_Praise_0();
            Create_Algorithm_Praise_1();
            Create_Algorithm_Praise_2();
        }

// destructor
        ~SolutionLogic() 
        { 
        
        }

// public.
    // get.
        public object Get_ItemOnListOfAlgorithmSubsets(byte praiseID)
        {
            return _ListOfAlgorithmSubsets[praiseID];
        }
    // set.

// private.
        private void Create_Algorithm_Praise_0()
        {
            _Algorithm_Praise_0 = new Algorithm_Praise_0();
            while (Get_Algorithm_Praise_0() == null) { }
            Set_ListOfAlgorithmSubsets(0, Get_Algorithm_Praise_0());
        }
        private void Create_Algorithm_Praise_1()
        {
            _Algorithm_Praise_1 = new Algorithm_Praise_1();
            while (Get_Algorithm_Praise_1() == null) { }
            Set_ListOfAlgorithmSubsets(1, Get_Algorithm_Praise_1());
        }
        private void Create_Algorithm_Praise_2()
        {
            _Algorithm_Praise_2 = new Algorithm_Praise_2();
            while (Get_Algorithm_Praise_2() == null) { }
            Set_ListOfAlgorithmSubsets(2, Get_Algorithm_Praise_2());
        }
        private void Create_ListOfAlgorithmSubsets(byte praiseIDcount)
        {
            _ListOfAlgorithmSubsets = new object[praiseIDcount];
            while (Get_List_Of_Algorithms() == null) { }
            for (byte index = 0; index < praiseIDcount; index++) 
            {
                Set_ListOfAlgorithmSubsets(index, null);
            }
        }
    // get.
        private Algorithm_Praise_0 Get_Algorithm_Praise_0()
        {
            return _Algorithm_Praise_0;
        }
        private Algorithm_Praise_1 Get_Algorithm_Praise_1()
        {
            return _Algorithm_Praise_1;
        }
        private Algorithm_Praise_2 Get_Algorithm_Praise_2()
        {
            return _Algorithm_Praise_2;
        }
        private object[] Get_List_Of_Algorithms()
        {
            return _ListOfAlgorithmSubsets;
        }
    // set.
        private void Set_ListOfAlgorithmSubsets(byte praiseID, object newAlgorithmSubset)
        {
            _ListOfAlgorithmSubsets[praiseID] = newAlgorithmSubset;
        }
    }
}
