#include "pch.h"
#include "Data.h"
#include <cstddef>

std::vector<class Avril_NNAI::Input*> ptr_Inputs;
std::vector<class Avril_NNAI::Node*> ptr_Nodes;
std::vector<class Avril_NNAI::Output*> ptr_Outputs;

Avril_NNAI::Data::Data()
{
    ptr_Inputs.clear();
    ptr_Nodes.clear();
    ptr_Outputs.clear();
}

Avril_NNAI::Data::~Data()
{
    //delete ;
}

void Avril_NNAI::Data::Initialise_Control()
{

}

std::vector<class Avril_NNAI::Input*> Avril_NNAI::Data::Get_Inputs()
{
    return ptr_Inputs;
}

std::vector<class Avril_NNAI::Node*> Avril_NNAI::Data::Get_Nodes()
{
    return ptr_Nodes;
}

std::vector<class Avril_NNAI::Output*> Avril_NNAI::Data::Get_Outputs()
{
    return ptr_Outputs;
}