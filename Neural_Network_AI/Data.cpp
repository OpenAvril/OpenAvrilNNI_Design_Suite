#include "pch.h"
#include "Data.h"
#include <cstddef>

std::vector<class Avril_NNAI::Input*> ptr_Inputs;
std::vector<class Avril_NNAI::Node*> ptr_Nodes;
class Avril_NNAI::Output* ptr_Output;

Avril_NNAI::Data::Data()
{
    ptr_Inputs.clear();

    ptr_Nodes.clear();

	ptr_Output = new class Avril_NNAI::Output();
	while (ptr_Output == NULL) {}
}

Avril_NNAI::Data::~Data()
{
    //delete ;
}

void Avril_NNAI::Data::Initialise_Control()
{

}

class Avril_NNAI::Input* Avril_NNAI::Data::Get_Inputs(INT64 node)
{
    return ptr_Inputs.at(node);
}

class Avril_NNAI::Node* Avril_NNAI::Data::Get_Nodes(INT64 node)
{
    return ptr_Nodes.at(node);
}

class Avril_NNAI::Output* Avril_NNAI::Data::Get_Output()
{
    return ptr_Output;
}