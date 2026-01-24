#include "pch.h"
#include "MetaData.h"

INT64 _numberOfInputs = 0;
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