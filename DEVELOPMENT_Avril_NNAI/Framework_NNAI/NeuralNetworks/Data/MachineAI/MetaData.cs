
namespace Avril_NNAI
{
    public class MetaData
    {
// classes.

// registers.
        public enum NodeLayer : ulong
        {
            Layer_4 = (ulong)0,
            Layer_3 = (ulong)1,
            Layer_2 = (ulong)2,
            Layer_1 = (ulong)3,
            Layer_0 = (ulong)4,
        }
        public enum PraiseID : ulong
        {
            Praise_0 = (ulong)0,
            Praise_1 = (ulong)1,
            Praise_2 = (ulong)2
        }
        Avril_NNAI.Node[] _Layer4_Nodes;
        Avril_NNAI.Node[] _Layer3_Nodes;
        Avril_NNAI.Node[] _Layer2_Nodes;
        Avril_NNAI.Node[] _Layer1_Nodes;
        Avril_NNAI.Node _Layer0_Node;
        ulong _NumberOfPraises;
        ulong _NumberOfPraiseInputValues;
        double[] _REGISTERED_Inputs;


// constructor.
        public MetaData() 
        {
            System.Console.WriteLine("entered MetaData.");

            Avril_NNAI.Node newEmpty = new Avril_NNAI.Node();
            while (newEmpty == null) { }

            Create_Layer4_Nodes(1, new Avril_NNAI.Node());
            while (Get_Layer4_Node(0) == null) { }
            Set_Layer4_Nodes(0, newEmpty);

            Create_Layer3_Nodes(1, new Avril_NNAI.Node());
            while (Get_Layer3_Nodes() == null) { }
            Set_Layer3_Nodes(0, newEmpty);

            Create_Layer2_Nodes(1, new Avril_NNAI.Node());
            while (Get_Layer2_Nodes() == null) { }
            Set_Layer2_Nodes(0, newEmpty);

            Create_Layer1_Nodes(1, new Avril_NNAI.Node());
            while (Get_Layer1_Nodes() == null) { }
            Set_Layer1_Nodes(0, newEmpty);

            Create_Layer0_Node(new Avril_NNAI.Node());
            while (Get_Layer0_Node() == null) { }
            Set_Layer0_Node(newEmpty);

            Create_NumberOfPraises(new ulong());
            Set_NumberOfPraises(0);

            Create_NumberOfPraiseInputValues(new ulong());
            Set_NumberOfPraiseInputValues(0);

            Create_REGISTERED_Inputs(new double[1]);
            Set_REGISTERED_Inputs(0, 0.0);
        }

// destructor.
        ~MetaData()
        {

        }

// public.
        public void Create_Nodes(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong numberOfPraiseInputValues)
        {   // layer 4.
            var newEmpty_Node_For_Layer4 = new Avril_NNAI.Node();
            while (newEmpty_Node_For_Layer4 == null) { }

            ulong numberOfNodesForLayer_4;
            if (objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues() <= 5) numberOfNodesForLayer_4 = 5;
            else numberOfNodesForLayer_4 = (ulong)(numberOfPraiseInputValues * (double)(4 / 5));

            newEmpty_Node_For_Layer4.Set_NumberOfInputs(numberOfPraiseInputValues);

            newEmpty_Node_For_Layer4.Create_REGISTERED_Inputs(new double[numberOfPraiseInputValues]);
            for (ulong index = 0; index < numberOfPraiseInputValues; index++)
            {
                newEmpty_Node_For_Layer4.Set_REGISTERED_Inputs(index, 0.0);
            }

            var newLinearPathway = new Avril_NNAI.Linear();
            newLinearPathway.Set_NumberOfAlgorithmInputs(numberOfPraiseInputValues);

            newEmpty_Node_For_Layer4.Create_NeuralPathOfInput_SubSet(new Avril_NNAI.Linear[numberOfPraiseInputValues]);
            for (ulong index = 0; index < numberOfPraiseInputValues; index++)
            {
                newEmpty_Node_For_Layer4.Set_NeuralPathOfInput_SubSet(index, newLinearPathway);
            }

            objNNAI.Get_MetaData().Create_Layer4_Nodes(numberOfNodesForLayer_4, newEmpty_Node_For_Layer4);


            // layer 3.
            var newEmpty_Node_For_Layer3 = new Avril_NNAI.Node();
            while (newEmpty_Node_For_Layer3 == null) { }

            ulong numberOfNodesForLayer_3;
            if (objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues() < 5) numberOfNodesForLayer_3 = 4;
            else numberOfNodesForLayer_3 = (ulong)(numberOfPraiseInputValues * (double)(3 / 5));

            newEmpty_Node_For_Layer3.Set_NumberOfInputs(numberOfNodesForLayer_4);
            newEmpty_Node_For_Layer3.Create_REGISTERED_Inputs(new double[numberOfNodesForLayer_4]);
            for (ulong index = 0; index < numberOfNodesForLayer_4; index++)
            {
                newEmpty_Node_For_Layer3.Set_REGISTERED_Inputs(index, 0.0);
            }

            newLinearPathway = new Avril_NNAI.Linear();
            newLinearPathway.Set_NumberOfAlgorithmInputs(numberOfNodesForLayer_4);
            for (ulong index = 0; index < numberOfNodesForLayer_4; index++)
            {
                // assigne bias and weight default values.
            }

            newEmpty_Node_For_Layer4.Create_NeuralPathOfInput_SubSet(new Avril_NNAI.Linear[numberOfNodesForLayer_4]);
            for (ulong index = 0; index < numberOfNodesForLayer_4; index++)
            {
                newEmpty_Node_For_Layer4.Set_NeuralPathOfInput_SubSet(index, newLinearPathway);
            }

            objNNAI.Get_MetaData().Create_Layer3_Nodes(numberOfNodesForLayer_3, newEmpty_Node_For_Layer3);

            // layer 2.
            var newEmpty_Node_For_Layer2 = new Avril_NNAI.Node();
            while (newEmpty_Node_For_Layer2 == null) { }

            ulong numberOfNodesForLayer_2;
            if (objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues() < 5) numberOfNodesForLayer_2 = 3;
            else numberOfNodesForLayer_2 = (ulong)(numberOfPraiseInputValues * (double)(2 / 5));

            newEmpty_Node_For_Layer2.Set_NumberOfInputs(numberOfNodesForLayer_3);
            newEmpty_Node_For_Layer2.Create_REGISTERED_Inputs(new double[numberOfNodesForLayer_3]);
            for (ulong index = 0; index < numberOfNodesForLayer_3; index++)
            {
                newEmpty_Node_For_Layer2.Set_REGISTERED_Inputs(index, 0.0);
            }

            newLinearPathway = new Avril_NNAI.Linear();
            newLinearPathway.Set_NumberOfAlgorithmInputs(numberOfNodesForLayer_3);
            for (ulong index = 0; index < numberOfNodesForLayer_3; index++)
            {
                // assigne bias and weight default values.
            }

            newEmpty_Node_For_Layer2.Create_NeuralPathOfInput_SubSet(new Avril_NNAI.Linear[numberOfNodesForLayer_3]);
            for (ulong index = 0; index < numberOfNodesForLayer_3; index++)
            {
                newEmpty_Node_For_Layer2.Set_NeuralPathOfInput_SubSet(index, newLinearPathway);
            }

            objNNAI.Get_MetaData().Create_Layer2_Nodes(numberOfNodesForLayer_2, newEmpty_Node_For_Layer2);

            // layer 1.
            var newEmpty_Node_For_Layer1 = new Avril_NNAI.Node();
            while (newEmpty_Node_For_Layer1 == null) { }

            ulong numberOfNodesForLayer_1;
            if (objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues() < 5) numberOfNodesForLayer_1 = 2;
            else numberOfNodesForLayer_1 = (ulong)(numberOfPraiseInputValues * (double)(1 / 5));

            newEmpty_Node_For_Layer1.Set_NumberOfInputs(numberOfNodesForLayer_2);
            newEmpty_Node_For_Layer1.Create_REGISTERED_Inputs(new double[numberOfNodesForLayer_2]);
            for (ulong index = 0; index < numberOfNodesForLayer_2; index++)
            {
                newEmpty_Node_For_Layer1.Set_REGISTERED_Inputs(index, 0.0);
            }

            newLinearPathway = new Avril_NNAI.Linear();
            newLinearPathway.Set_NumberOfAlgorithmInputs(numberOfNodesForLayer_2);
            for (ulong index = 0; index < numberOfNodesForLayer_2; index++)
            {
                // assigne bias and weight default values.
            }

            newEmpty_Node_For_Layer1.Create_NeuralPathOfInput_SubSet(new Avril_NNAI.Linear[numberOfNodesForLayer_2]);
            for (ulong index = 0; index < numberOfNodesForLayer_2; index++)
            {
                newEmpty_Node_For_Layer1.Set_NeuralPathOfInput_SubSet(index, newLinearPathway);
            }

            objNNAI.Get_MetaData().Create_Layer1_Nodes(numberOfNodesForLayer_1, newEmpty_Node_For_Layer1);

            // layer 0.
            var newEmpty_Node_For_Layer0 = new Avril_NNAI.Node();
            while (newEmpty_Node_For_Layer0 == null) { }

            //ulong numberOfNodesForLayer_0 = 1;

            newEmpty_Node_For_Layer0.Set_NumberOfInputs(numberOfNodesForLayer_1);
            newEmpty_Node_For_Layer0.Create_REGISTERED_Inputs(new double[numberOfNodesForLayer_1]);
            for (ulong index = 0; index < numberOfNodesForLayer_1; index++)
            {
                newEmpty_Node_For_Layer0.Set_REGISTERED_Inputs(index, 0.0);
            }

            newLinearPathway = new Avril_NNAI.Linear();
            newLinearPathway.Set_NumberOfAlgorithmInputs(numberOfNodesForLayer_1);
            for (ulong index = 0; index < numberOfNodesForLayer_1; index++)
            {
                // assigne bias and weight default values.
            }

            newEmpty_Node_For_Layer0.Create_NeuralPathOfInput_SubSet(new Avril_NNAI.Linear[numberOfNodesForLayer_1]);
            for (ulong index = 0; index < numberOfNodesForLayer_1; index++)
            {
                newEmpty_Node_For_Layer0.Set_NeuralPathOfInput_SubSet(index, newLinearPathway);
            }

            objNNAI.Get_MetaData().Create_Layer0_Node(newEmpty_Node_For_Layer0);
        }
        public void Calculate_NumberOfPraiseInputValues(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong[] praiseID)
        {
            objNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(0);
            for (ulong index = 0; index < (ulong)praiseID.LongLength; index++)
            {
                switch (praiseID[index])
                {
                    case 0:
                        var objValue_Praise0 = (Avril_NNAI.Input_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(0);
                        objNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(_NumberOfPraiseInputValues + objValue_Praise0.Get_NumberOfInputValues());
                        break;

                    case 1:
                        var objValue_Praise1= (Avril_NNAI.Input_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(1);
                        objNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(_NumberOfPraiseInputValues + objValue_Praise1.Get_NumberOfInputValues());
                        break;

                    case 2:
                        var objValue_Praise2 = (Avril_NNAI.Input_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(2);
                        objNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(_NumberOfPraiseInputValues + objValue_Praise2.Get_NumberOfInputValues());
                        break;
                    default:
                        break;
                }
            }
        }
        public void Generate_REGISTERED_Inputs_List(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong[] praiseID)
        {
            objNNAI.Get_MetaData().Create_REGISTERED_Inputs(new double[objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues()]);

            for (ulong index_A = 0; index_A < (ulong)praiseID.LongLength; index_A++)
            {
                switch (praiseID[index_A])
                {
                    case (ulong)PraiseID.Praise_0:
                        Avril_NNAI.Input_Praise_0 subsetOfInput_Praise_0 = (Avril_NNAI.Input_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(0);
                        for (byte index = 0; index < objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues(); index++)
                        {
                            subsetOfInput_Praise_0.Set_Item_Of_Input_Praise(index, 0);
                        }
                        break;

                    case (ulong)PraiseID.Praise_1:
                        Avril_NNAI.Input_Praise_1 subsetOfInput_Praise_1 = (Avril_NNAI.Input_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(1);
                        for (byte index = 0; index < subsetOfInput_Praise_1.Get_NumberOfInputValues(); index++)
                        {
                            subsetOfInput_Praise_1.Set_Item_Of_Input_Praise(index, 0);
                        }
                        break;

                    case (ulong)PraiseID.Praise_2:
                        Avril_NNAI.Input_Praise_2 subsetOfInput_Praise_2 = (Avril_NNAI.Input_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(2);
                        for (byte index = 0; index < subsetOfInput_Praise_2.Get_NumberOfInputValues(); index++)
                        {
                            subsetOfInput_Praise_2.Set_Item_Of_Input_Praise(index, 0);
                        }
                        break;

                    default:
                        break;
                }
            }
        }
        public void Initialise_Node_WEIGHT_and_BIAS(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI _AvrilNNAI)
        {
            for (ulong index_A = 0; index_A < (ulong)_AvrilNNAI.Get_MetaData().Get_Layer4_Nodes().LongLength; index_A++)
            {
                for (ulong index_B = 0; index_B < _AvrilNNAI.Get_MetaData().Get_NumberOfPraiseInputValues(); index_B++)
                {
                    _AvrilNNAI.Get_MetaData().Get_Layer4_Node(index_A).Get_NeuralPathOfInput_SubSet(index_B).Set_Weight(obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_Initial_BIAS_Value(-0.5, 0.5));
                    _AvrilNNAI.Get_MetaData().Get_Layer4_Node(index_A).Get_NeuralPathOfInput_SubSet(index_B).Set_Bias(obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_Initial_BIAS_Value(-0.5, 0.5));
                }
            }

            for (ulong index_A = 0; index_A < (ulong)_AvrilNNAI.Get_MetaData().Get_Layer3_Nodes().LongLength; index_A++)
            {
                for (ulong index_B = 0; index_B < (ulong)_AvrilNNAI.Get_MetaData().Get_Layer4_Nodes().LongLength; index_B++)
                {
                    _AvrilNNAI.Get_MetaData().Get_Layer3_Node(index_A).Get_NeuralPathOfInput_SubSet(index_B).Set_Weight(obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_Initial_BIAS_Value(-0.5, 0.5));
                    _AvrilNNAI.Get_MetaData().Get_Layer3_Node(index_A).Get_NeuralPathOfInput_SubSet(index_B).Set_Bias(obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_Initial_BIAS_Value(-0.5, 0.5));
                }
            }

            for (ulong index_A = 0; index_A < (ulong)_AvrilNNAI.Get_MetaData().Get_Layer2_Nodes().LongLength; index_A++)
            {
                for (ulong index_B = 0; index_B < (ulong)_AvrilNNAI.Get_MetaData().Get_Layer3_Nodes().LongLength; index_B++)
                {
                    _AvrilNNAI.Get_MetaData().Get_Layer2_Node(index_A).Get_NeuralPathOfInput_SubSet(index_B).Set_Weight(obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_Initial_BIAS_Value(-0.5, 0.5));
                    _AvrilNNAI.Get_MetaData().Get_Layer2_Node(index_A).Get_NeuralPathOfInput_SubSet(index_B).Set_Bias(obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_Initial_BIAS_Value(-0.5, 0.5));
                }
            }

            for (ulong index_A = 0; index_A < (ulong)_AvrilNNAI.Get_MetaData().Get_Layer1_Nodes().LongLength; index_A++)
            {
                for (ulong index_B = 0; index_B < (ulong)_AvrilNNAI.Get_MetaData().Get_Layer2_Nodes().LongLength; index_B++)
                {
                    _AvrilNNAI.Get_MetaData().Get_Layer1_Node(index_A).Get_NeuralPathOfInput_SubSet(index_B).Set_Weight(obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_Initial_BIAS_Value(-0.5, 0.5));
                    _AvrilNNAI.Get_MetaData().Get_Layer1_Node(index_A).Get_NeuralPathOfInput_SubSet(index_B).Set_Bias(obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_Initial_BIAS_Value(-0.5, 0.5));
                }
            }

            //for (ulong index_A = 0; index_A < (ulong)1; index_A++)
            //{
                for (ulong index_B = 0; index_B < (ulong)_AvrilNNAI.Get_MetaData().Get_Layer1_Nodes().LongLength; index_B++)
                {
                    _AvrilNNAI.Get_MetaData().Get_Layer0_Node().Get_NeuralPathOfInput_SubSet(index_B).Set_Weight(obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_Initial_BIAS_Value(-0.5, 0.5));
                    _AvrilNNAI.Get_MetaData().Get_Layer0_Node().Get_NeuralPathOfInput_SubSet(index_B).Set_Bias(obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_Initial_BIAS_Value(-0.5, 0.5));
                }
            //}
        }
    
    // get.
        public Avril_NNAI.Node Get_Node(byte layer, ulong nodeID)
        {
            switch (layer)
            {
                case (byte)NodeLayer.Layer_4:
                    return Get_Layer4_Node(nodeID);

                case (byte)NodeLayer.Layer_3:
                    return Get_Layer3_Node(nodeID);

                case (byte)NodeLayer.Layer_2:
                    return Get_Layer2_Node(nodeID);

                case (byte)NodeLayer.Layer_1:
                    return Get_Layer1_Node(nodeID);

                case (byte)NodeLayer.Layer_0:
                    return Get_Layer0_Node();

                default:
                    return null;
            }
        }
        public ulong Get_NumberOfPraises()
        {
            return _NumberOfPraises;
        }
        public ulong Get_NumberOfPraiseInputValues()
        {
            return _NumberOfPraiseInputValues;
        }
        public double[] Get_List_Of_REGISTERED_Inputs()
        {
            return _REGISTERED_Inputs;
        }

    // set.
        public void Set_Node(byte layer, ulong nodeID, Avril_NNAI.Node node)
        {
            switch (layer)
            {
                case (byte)NodeLayer.Layer_4:
                    Set_Layer4_Nodes(nodeID, node);
                    break;

                case (byte)NodeLayer.Layer_3:
                    Set_Layer3_Nodes(nodeID, node);
                    break;

                case (byte)NodeLayer.Layer_2:
                    Set_Layer2_Nodes(nodeID, node);
                    break;

                case (byte)NodeLayer.Layer_1:
                    Set_Layer1_Nodes(nodeID, node);
                    break;

                case (byte)NodeLayer.Layer_0:
                    Set_Layer0_Node(node);
                    break;

                default:
                    break;
            }
        }
        public void Set_NumberOfPraises(ulong numberOfPraiseInputs)
        {
            _NumberOfPraises = numberOfPraiseInputs;
        }

// private.
        private void Create_Layer4_Nodes(ulong numberOfNodes, Avril_NNAI.Node newEmpty_Node)
        {
            _Layer4_Nodes = new Avril_NNAI.Node[numberOfNodes];
            for (ulong index = 0; index < numberOfNodes; index++)
            {
                _Layer4_Nodes[index] = newEmpty_Node;
            }
        }
        private void Create_Layer3_Nodes(ulong numberOfNodes, Avril_NNAI.Node newEmpty_Node)
        {
            _Layer3_Nodes = new Avril_NNAI.Node[numberOfNodes];
            for (ulong index = 0; index < numberOfNodes; index++)
            {
                _Layer3_Nodes[index] = newEmpty_Node;
            }
        }
        private void Create_Layer2_Nodes(ulong numberOfNodes, Avril_NNAI.Node newEmpty_Node)
        {
            _Layer2_Nodes = new Avril_NNAI.Node[numberOfNodes];
            for (ulong index = 0; index < numberOfNodes; index++)
            {
                _Layer2_Nodes[index] = newEmpty_Node;
            }
        }
        private void Create_Layer1_Nodes(ulong numberOfNodes, Avril_NNAI.Node newEmpty_Node)
        {
            _Layer1_Nodes = new Avril_NNAI.Node[numberOfNodes];
            for (ulong index = 0; index < numberOfNodes; index++)
            {
                _Layer1_Nodes[index] = newEmpty_Node;
            }
        }
        private void Create_Layer0_Node(Avril_NNAI.Node newEmpty_Node)
        {
            _Layer0_Node = newEmpty_Node;
        }
        private void Create_NumberOfPraises(ulong value)
        {
            _NumberOfPraises = value;
        }
        private void Create_NumberOfPraiseInputValues(ulong value)
        {
            _NumberOfPraiseInputValues = value;
        }
        private void Create_REGISTERED_Inputs(double[] value)
        {
            _REGISTERED_Inputs = value;
        }

    // get.
        private Avril_NNAI.Node Get_Layer4_Node(ulong nodeID)
        {
            return _Layer4_Nodes[nodeID];
        }
        private Avril_NNAI.Node[] Get_Layer4_Nodes()
        {
            return _Layer4_Nodes;
        }
        private Avril_NNAI.Node Get_Layer3_Node(ulong nodeID)
        {
            return _Layer3_Nodes[nodeID];
        }
        private Avril_NNAI.Node[] Get_Layer3_Nodes()
        {
            return _Layer3_Nodes;
        }
        private Avril_NNAI.Node Get_Layer2_Node(ulong nodeID)
        {
            return _Layer2_Nodes[nodeID];
        }
        private Avril_NNAI.Node[] Get_Layer2_Nodes()
        {
            return _Layer2_Nodes;
        }
        private Avril_NNAI.Node Get_Layer1_Node(ulong nodeID)
        {
            return _Layer1_Nodes[nodeID];
        }
        private Avril_NNAI.Node[] Get_Layer1_Nodes()
        {
            return _Layer1_Nodes;
        }
        private Avril_NNAI.Node Get_Layer0_Node()
        {
            return _Layer0_Node;
        }
        private void Get_NumberOfPraises(ulong numberOfPraiseInputs)
        {
            _NumberOfPraises = numberOfPraiseInputs;
        }
        private void Get_NumberOfPraiseInputValues(ulong numberOfPraiseInputValues)
        {
            _NumberOfPraiseInputValues = numberOfPraiseInputValues;
        }
        private double Get_REGISTERED_Inputs(ulong registerID)
        {
            return _REGISTERED_Inputs[registerID];
        }

    // set.
        private void Set_Layer4_Nodes(ulong nodeID, Avril_NNAI.Node node)
        {
            _Layer4_Nodes[nodeID] = node;
        }
        private void Set_Layer3_Nodes(ulong nodeID, Avril_NNAI.Node node)
        {
            _Layer3_Nodes[nodeID] = node;
        }
        private void Set_Layer2_Nodes(ulong nodeID, Avril_NNAI.Node node)
        {
            _Layer2_Nodes[nodeID] = node;
        }
        private void Set_Layer1_Nodes(ulong nodeID, Avril_NNAI.Node node)
        {
            _Layer1_Nodes[nodeID] = node;
        }
        private void Set_Layer0_Node(Avril_NNAI.Node node)
        {
            _Layer0_Node = node;
        }
        private void Set_NumberOfPraiseInputValues(ulong numberOfPraiseInputValues)
        {
            _NumberOfPraiseInputValues = numberOfPraiseInputValues;
        }
        private void Set_REGISTERED_Inputs(ulong registerID, double value)
        {
            _REGISTERED_Inputs[registerID] = value;
        }
    }
}