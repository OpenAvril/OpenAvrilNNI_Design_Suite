#include "pch.h"
#include "Node.h"

INT64 _numberOfNodeInputs = 0;
std::vector<class Avril_NNAI::Input*> _Node_Inputs;

Avril_NNAI::Node::Node()
{

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
		_Node_Inputs.resize(_numberOfNodeInputs);
	}
	
}
