namespace OpenAvrilNNI
{
    public class PraiseSet
    {
// definitions.

// classes.

// registers.
    // instance.
        private Node _New_Node;
    // lists.
        private Node[] _List_Of_Layer4_Nodes;
        private Node[] _List_Of_Layer3_Nodes;
        private Node[] _List_Of_Layer2_Nodes;
        private Node[] _List_Of_Layer1_Nodes;
        private Node _Layer0_Node;

// constructor.
        public PraiseSet()
        {
            //System.Console.WriteLine("entered MetaData.");
            Create_New_Node();
            Create_List_Of_Layer4_Nodes();
            Create_List_Of_Layer3_Nodes();
            Create_List_Of_Layer2_Nodes();
            Create_List_Of_Layer1_Nodes();
            Create_Layer0_Node();
        }

// destructor.
        ~PraiseSet()
        {

        }

// public.
        public void Initialise_Tree_Of_Nodes_In_PraiseSet(MachineAI objNNI, byte outputID)
        {
            objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Initialise_List_Of_Layer4_Nodes(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(4));
            objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Initialise_List_Of_Layer3_Nodes(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(3));
            objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Initialise_List_Of_Layer2_Nodes(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(2));
            objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Initialise_List_Of_Layer1_Nodes(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(1));
            objNNI.Get_Item_On_list_Of_Linear_Paths(outputID).Get_PraiseSet().Initialise_Layer0_Node();
        }
    // get.
        public Node Get_Node(byte layer, byte nodeID)
        {
            switch (layer)
            {
                case (byte)Global.NodeLayer.Layer_4:
                    return Get_Item_On_List_Of_Layer4_Node(nodeID);

                case (byte)Global.NodeLayer.Layer_3:
                    return Get_Item_On_List_Of_Layer3_Node(nodeID);

                case (byte)Global.NodeLayer.Layer_2:
                    return Get_Item_On_List_Of_Layer2_Node(nodeID);

                case (byte)Global.NodeLayer.Layer_1:
                    return Get_Item_On_List_Of_Layer1_Node(nodeID);

                case (byte)Global.NodeLayer.Layer_0:
                    if (nodeID == 0) return Get_Layer0_Node();
                    else return null;

                default:
                    return null;
            }
        }
    // set.
        public void Set_Node(byte layerID, byte nodeID, OpenAvrilNNI.Node node)
        {
            switch (layerID)
            {
                case (byte)Global.NodeLayer.Layer_4:
                    Set_Item_On_List_Of_Layer4_Node(nodeID, node);
                    break;

                case (byte)Global.NodeLayer.Layer_3:
                    Set_Item_On_List_Of_Layer3_Node(nodeID, node);
                    break;

                case (byte)Global.NodeLayer.Layer_2:
                    Set_Item_On_List_Of_Layer3_Node(nodeID, node);
                    break;

                case (byte)Global.NodeLayer.Layer_1:
                    Set_Item_On_List_Of_Layer2_Node(nodeID, node);
                    break;

                case (byte)Global.NodeLayer.Layer_0:
                    Set_Layer0_Node(node);
                    break;

                default:
                    break;
            }
        }

// private.
        private void Create_List_Of_Layer4_Nodes()
        {
            Set_List_Of_Layer4_Node(new Node[5]);
            while (Get_List_Of_Layer4_Nodes() == null) { }
            for (byte index = 0; index < 5; index++)
            {
                Set_Item_On_List_Of_Layer4_Node(index, Get_New_Node());
            }
        }
        private void Create_List_Of_Layer3_Nodes()
        {
            Set_List_Of_Layer3_Node(new Node[4]);
            while (Get_List_Of_Layer3_Nodes() == null) { }
            for (byte index = 0; index < 4; index++)
            {
                Set_Item_On_List_Of_Layer3_Node(index, Get_New_Node());
            }
        }
        private void Create_List_Of_Layer2_Nodes()
        {
            Set_List_Of_Layer2_Node(new Node[3]);
            while (Get_List_Of_Layer2_Nodes() == null) { }
            for (byte index = 0; index < 3; index++)
            {
                Set_Item_On_List_Of_Layer2_Node(index, Get_New_Node());
            }
        }
        private void Create_List_Of_Layer1_Nodes()
        {
            Set_List_Of_Layer1_Node(new Node[2]);
            while (Get_List_Of_Layer1_Nodes() == null) { }
            for (byte index = 0; index < 2; index++)
            {
                Set_Item_On_List_Of_Layer1_Node(index, Get_New_Node());
            }
        }
        private void Create_Layer0_Node()
        {
            Set_Layer0_Node(new Node());
            while (Get_Layer0_Node() == null) { }
        }
        private void Create_New_Node()
        {
            Set_New_Node(new Node());
            while (Get_New_Node() == null) { }
        }
        private void Initialise_List_Of_Layer4_Nodes(byte numberOfNodes)
        {
            Set_List_Of_Layer4_Node(new Node[numberOfNodes]);
            while (Get_List_Of_Layer4_Nodes() == null) { }
            for (byte index = 0; index < numberOfNodes; index++)
            {
                Set_Item_On_List_Of_Layer4_Node(index, Get_New_Node());
            }
        }
        private void Initialise_List_Of_Layer3_Nodes(byte numberOfNodes)
        {
            Set_List_Of_Layer3_Node(new Node[numberOfNodes]);
            while (Get_List_Of_Layer3_Nodes() == null) { }
            for (byte index = 0; index < numberOfNodes; index++)
            {
                Set_Item_On_List_Of_Layer3_Node(index, Get_New_Node());
            }
        }
        private void Initialise_List_Of_Layer2_Nodes(byte numberOfNodes)
        {
            Set_List_Of_Layer2_Node(new Node[numberOfNodes]);
            while (Get_List_Of_Layer2_Nodes() == null) { }
            for (byte index = 0; index < numberOfNodes; index++)
            {
                Set_Item_On_List_Of_Layer2_Node(index, Get_New_Node());
            }
        }
        private void Initialise_List_Of_Layer1_Nodes(byte numberOfNodes)
        {
            Set_List_Of_Layer1_Node(new Node[numberOfNodes]);
            while (Get_List_Of_Layer1_Nodes() == null) { }
            for (byte index = 0; index < numberOfNodes; index++)
            {
                Set_Item_On_List_Of_Layer1_Node(index, Get_New_Node());
            }
        }
        private void Initialise_Layer0_Node()
        {
            Set_Layer0_Node(new Node());
            while (Get_Layer0_Node() == null) { }
            Set_Layer0_Node(Get_New_Node());
        }
    // get.
        private Node Get_Item_On_List_Of_Layer4_Node(byte nodeID)
        {
            return _List_Of_Layer4_Nodes[nodeID];
        }
        private Node Get_Item_On_List_Of_Layer3_Node(byte nodeID)
        {
            return _List_Of_Layer3_Nodes[nodeID];
        }
        private Node Get_Item_On_List_Of_Layer2_Node(byte nodeID)
        {
            return _List_Of_Layer2_Nodes[nodeID];
        }
        private Node Get_Item_On_List_Of_Layer1_Node(byte nodeID)
        {
            return _List_Of_Layer1_Nodes[nodeID];
        }
        private Node Get_Layer0_Node()
        {
            return _Layer0_Node;
        }
        private Node[] Get_List_Of_Layer4_Nodes()
        {
            return _List_Of_Layer4_Nodes;
        }
        private Node[] Get_List_Of_Layer3_Nodes()
        {
            return _List_Of_Layer3_Nodes;
        }
        private Node[] Get_List_Of_Layer2_Nodes()
        {
            return _List_Of_Layer2_Nodes;
        }
        private Node[] Get_List_Of_Layer1_Nodes()
        {
            return _List_Of_Layer1_Nodes;
        }
        private Node Get_New_Node()
        {
            return _New_Node;
        }
    // set.
        private void Set_Item_On_List_Of_Layer4_Node(byte nodeID, Node node)
        {
            _List_Of_Layer4_Nodes[nodeID] = node;
        }
        private void Set_Item_On_List_Of_Layer3_Node(byte nodeID, Node node)
        {
            _List_Of_Layer3_Nodes[nodeID] = node;
        }
        private void Set_Item_On_List_Of_Layer2_Node(byte nodeID, Node node)
        {
            _List_Of_Layer2_Nodes[nodeID] = node;
        }
        private void Set_Item_On_List_Of_Layer1_Node(byte nodeID, Node node)
        {
            _List_Of_Layer1_Nodes[nodeID] = node;
        }
        private void Set_Layer0_Node(Node node)
        {
            _Layer0_Node = node;
        }
        private void Set_List_Of_Layer4_Node(Node[] newList)
        {
            _List_Of_Layer4_Nodes = newList;
        }
        private void Set_List_Of_Layer3_Node(Node[] newList)
        {
            _List_Of_Layer3_Nodes = newList;
        }
        private void Set_List_Of_Layer2_Node(Node[] newList)
        {
            _List_Of_Layer2_Nodes = newList;
        }
        private void Set_List_Of_Layer1_Node(Node[] newList)
        {
            _List_Of_Layer1_Nodes = newList;
        }
        private void Set_New_Node(Node newNode)
        {
            _New_Node = newNode;
        }
    }
}