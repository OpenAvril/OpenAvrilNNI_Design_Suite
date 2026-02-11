
namespace OpenAvrilNNI
{
    public class NeuralNetworks
    {
// classes.
        private Global _Global;
        private Aglorithms _Aglorithms;
        private Data _Data;
        private Execute _Execute;
// registers.

// constructor.
        public NeuralNetworks()
        {
            System.Console.WriteLine("entered NeuralNetworks.");
            Create_Global();
            Create_Aglorithms();
            Create_Data();
            Create_Execute();
            System.Console.WriteLine("exiting NeuralNetworks.");
        }

// destructor
        ~NeuralNetworks()
        {
            //System.Console.WriteLine("exited NeuralNetworks.");
        }

// public.
    // get.
        public Aglorithms Get_Aglorithms()
        {
            return _Aglorithms;
        }
        public Data Get_Data()
        {
            return _Data;
        }
        public Execute Get_Execute()
        {
            return _Execute;
        }
        public Global Get_Global()
        {
            return _Global;
        }
    // set.

// private.
        private void Create_Aglorithms()
        {
            Set_Aglorithms(new Aglorithms());
            while (Get_Aglorithms() == null) { }
        }
        private void Create_Global()
        {
            Set_Global(new Global());
            while (Get_Global() == null) { }
        }
        private void Create_Data()
        {
            Set_Data(new Data());
            while (Get_Data() == null) { }
        }
        private void Create_Execute()
        {
            Set_Execute(new Execute());
            while (Get_Execute() == null) { }
        }
    // get.
    // set.
        private void Set_Aglorithms(Aglorithms newAglorithms)
        {
            _Aglorithms = newAglorithms;
        }
        private void Set_Data(Data newData)
        {
            _Data = newData;
        }
        private void Set_Execute(Execute newExecute)
        {
            _Execute = newExecute;
        }
        private void Set_Global(Global newGlobal)
        {
            _Global = newGlobal;
        }
    }
}
