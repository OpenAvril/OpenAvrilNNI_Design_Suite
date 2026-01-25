// Neural_Network_AI.cpp : Defines the exported functions for the DLL.
//

#include "pch.h"
#include "framework.h"
#include "Neural_Network_AI.h"

class Avril_NNAI::Framework_NNAI* _Neural_Networks_AI = NULL;

// This is an example of an exported variable
NEURALNETWORKAI_API int nNeuralNetworkAI=0;

void* Avril_NNAI::CNeuralNetworkAI::InitialiseThisNeuralNetworkAI()
{
    _Neural_Networks_AI = new class Avril_NNAI::Framework_NNAI();
    while (_Neural_Networks_AI == NULL) {}
    return (void*)_Neural_Networks_AI;
}

void Avril_NNAI::CNeuralNetworkAI::ConstructNeuralNetworkAI_Frame(Avril_NNAI::Framework_NNAI* obj, INT64 _numberOfTotalInputs)
{
	obj->Get_Neural_Networks()->Get_MetaData()->Set_NumberOTotalInputs(_numberOfTotalInputs);
    for (INT64 index_A = 0; index_A < _numberOfTotalInputs; index_A++)
    {
        //layer 4 - input layer
		obj->Get_Neural_Networks()->Get_Data()->Get_Nodes(index_A)->Set_NumberOfNodeInputs(_numberOfTotalInputs);

		//layer 3: hidden layer
        for (INT64 index_B = 0; index_B < _numberOfTotalInputs; index_B++)
        {
            obj->Get_Neural_Networks()->Get_Data()->Get_Nodes(index_A)->Set_Node_Input(index_B, obj->Get_Neural_Networks()->Get_Data()->Get_Inputs(index_B));
            obj->Get_Neural_Networks()->Get_Data()->Get_Nodes(index_A)->Set_Node_NeuralPathOfInput(index_B, obj->Get_Neural_Networks()->Get_Algorithms()->Get_NeuralPath());
			obj->Get_Neural_Networks()->Get_Data()->Get_Nodes(index_A)->Get_Node_NeuralPathOfInput(index_B)->Set_NatureOfThePath_LINEAR((Avril_NNAI::Linear*)obj->Get_Neural_Networks()->Get_Algorithms()->Get_NeuralPath()->Get_NatureOfThePath(obj));
        }

        //ToDo: layer 2: hidden layer

        //ToDo: layer 1: hidden layer

		//layer 0 - output layer
		obj->Get_Neural_Networks()->Get_Data()->Get_Nodes(index_A)->Set_Node_Output(obj->Get_Neural_Networks()->Get_Data()->Get_Output());
    }
}

// This is an example of an exported function.
NEURALNETWORKAI_API int fnNeuralNetworkAI(void)
{
    return 0;
}

// This is the constructor of a class that has been exported.
Avril_NNAI::CNeuralNetworkAI::CNeuralNetworkAI()
{
    return;
}
