
namespace Avril_NNAI
{
    public class Aglorithms
    {
        private Avril_NNAI.NeuralPath _NeuralPath;
        private Avril_NNAI.SolutionLogic _SolutionLogic;

        public Aglorithms()
        {
            Set_NeuralPath(new Avril_NNAI.NeuralPath());
            while (Get_NeuralPath() == null) { }

            Set_SolutionLogic(new Avril_NNAI.SolutionLogic());
            while (Get_SolutionLogic() == null) { }
        }

        public void ConstructNeuralNetworkAI_Frame(Avril_NNAI.Framework_NNAI obj, ulong numberOfTotalInputs)
        {
            obj.Get_Neural_Networks().Get_Data().Set_NumberOfTotalInputs(numberOfTotalInputs);
            obj.Get_Neural_Networks().Get_Data().Create_Nodes(obj);
        }

        public Avril_NNAI.NeuralPath Get_NeuralPath()
        {
            return _NeuralPath;
        }

        public Avril_NNAI.SolutionLogic Get_SolutionLogic()
        {
            return _SolutionLogic;
        }

        private void Set_NeuralPath(Avril_NNAI.NeuralPath neuralPath)
        {
            _NeuralPath = neuralPath;
        }

        private void Set_SolutionLogic(Avril_NNAI.SolutionLogic solutionLogic)
        {
            _SolutionLogic = solutionLogic;
        }
    }
}
