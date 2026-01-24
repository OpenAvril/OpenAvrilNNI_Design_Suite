#include "pch.h"
#include "MetaData.h"

INT64 _numberOfTotalInputs = 0;
std::vector<class Avril_NNAI::Node*> ptr_Layer4_Node_Inputs;
std::vector<class Avril_NNAI::Node*> ptr_Layer3_Node_Inputs;
std::vector<class Avril_NNAI::Node*> ptr_Layer2_Node_Inputs;
std::vector<class Avril_NNAI::Node*> ptr_Layer1_Node_Inputs;
class Avril_NNAI::Node* ptr_Layer0_Node_Output;

Avril_NNAI::MetaData::MetaData()
{

}

Avril_NNAI::MetaData::~MetaData()
{
    //delete  ;
}

void Avril_NNAI::MetaData::Set_NumberOTotalInputs(INT64 numberOfNodeInputs)
{
	_numberOfTotalInputs = numberOfNodeInputs;
	if ((_numberOfTotalInputs > INT64(0)) && (_numberOfTotalInputs < INT64(9223372036854775807)))
	{
		ptr_Layer4_Node_Inputs.resize(_numberOfTotalInputs / INT64(5 / 5));
		ptr_Layer3_Node_Inputs.resize(_numberOfTotalInputs / INT64(4 / 5));
		ptr_Layer2_Node_Inputs.resize(_numberOfTotalInputs / INT64(3 / 5));
		ptr_Layer1_Node_Inputs.resize(_numberOfTotalInputs / INT64(2 / 5));
		ptr_Layer0_Node_Output->Set_NumberOfNodeInputs(_numberOfTotalInputs / INT64(1 / 5));
	}
}