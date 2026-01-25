#include "pch.h"

class Avril_NNAI::Algorithms* ptr_Algorithms = NULL;
class Avril_NNAI::Data* ptr_Data = NULL;
class Avril_NNAI::Execute* ptr_Execute = NULL;
class Avril_NNAI::MetaData* ptr_MetaData = NULL;

Avril_NNAI::NeuralNetworks::NeuralNetworks()
{
    Set_MetaData(new class Avril_NNAI::MetaData());
    while (Get_MetaData() == NULL) {}
    std::cout << "Created => Avril_NNAI::MetaData()" << std::endl;

    Set_Algorithms(new class Avril_NNAI::Algorithms());
    while (Get_Algorithms() == NULL) {}
	ptr_Algorithms->Initialise_Control();
    std::cout << "Created => Avril_NNAI::Algorithms()" << std::endl;

    Set_Data(new class Avril_NNAI::Data());
    while (Get_Data() == NULL) {}
    ptr_Data->Initialise_Control();
    std::cout << "Created => Avril_NNAI::Data()" << std::endl;

    Set_Execute(new class Avril_NNAI::Execute());
    while (Get_Execute() == NULL) {}
    Get_Execute()->Initialise_Control();
    std::cout << "Created => Avril_NNAI::Execute()" << std::endl;
}

Avril_NNAI::NeuralNetworks::~NeuralNetworks()
{
    delete ptr_Global;
    delete ptr_Algorithms;
    delete ptr_Data;
    delete ptr_Execute;
}

Avril_NNAI::Algorithms* Avril_NNAI::NeuralNetworks::Get_Algorithms()
{
    return ptr_Algorithms;
}

Avril_NNAI::Data* Avril_NNAI::NeuralNetworks::Get_Data()
{
    return ptr_Data;
}

Avril_NNAI::Execute* Avril_NNAI::NeuralNetworks::Get_Execute()
{
    return ptr_Execute;
}

Avril_NNAI::MetaData* Avril_NNAI::NeuralNetworks::Get_MetaData()
{
    return ptr_Global;
}

void Avril_NNAI::NeuralNetworks::Set_Algorithms(Avril_NNAI::Algorithms* algorithms)
{
    ptr_Algorithms = algorithms;
}
void Avril_NNAI::NeuralNetworks::Set_Data(Avril_NNAI::Data* data)
{
    ptr_Data = data;
}
void Avril_NNAI::NeuralNetworks::Set_Execute(Avril_NNAI::Execute* execute)
{
    ptr_Execute = execute;
}
void Avril_NNAI::NeuralNetworks::Set_MetaData(Avril_NNAI::MetaData* global)
{
    ptr_Global = global;
}