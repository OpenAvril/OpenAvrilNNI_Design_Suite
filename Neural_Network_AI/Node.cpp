#include "pch.h"
#include "Node.h"

class Avril_NNAI::MetaData* ptr_MetaData = NULL;
INT64 _numberOfNodeInputs;
std::vector<class Avril_NNAI::Input*> ptr_Node_Inputs;
std::vector<class Avril_NNAI::NeuralPath*> ptr_NeuralPathOfInput;
class Avril_NNAI::Output* ptr_Node_Output = NULL;

Avril_NNAI::Node::Node()
{
	ptr_MetaData = new class Avril_NNAI::MetaData();
	while (ptr_MetaData == NULL) {}

	_numberOfNodeInputs = 0;

	ptr_Node_Inputs.clear();

	ptr_NeuralPathOfInput.clear();

	ptr_Node_Output = new class Avril_NNAI::Output();
	while (ptr_Node_Output == NULL) {}
}

Avril_NNAI::Node::~Node()
{
	//delete ;
}

void Avril_NNAI::Node::Set_NumberOfNodeInputs(INT64 numberOfNodeInputs)
{
	_numberOfNodeInputs = numberOfNodeInputs;
	if ((_numberOfNodeInputs > INT64(0)) && (_numberOfNodeInputs < INT64(9223372036854775807)))
	{
		ptr_Node_Inputs.resize(_numberOfNodeInputs);
		//todo
		ptr_NeuralPathOfInput.resize(_numberOfNodeInputs);
		//todo
	}
	
}
