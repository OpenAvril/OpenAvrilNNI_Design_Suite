#include "pch.h"
#include "Algorithms.h"

class Avril_NNAI::NeuralPath* ptr_NeuralPaths = NULL;

Avril_NNAI::Algorithms::Algorithms()
{
    ptr_NeuralPaths = new class Avril_NNAI::NeuralPath();
    while (ptr_NeuralPaths == NULL) {}
}

Avril_NNAI::Algorithms::~Algorithms()
{
    //delete ;
}

void Avril_NNAI::Algorithms::Initialise_Control()
{
  
}

Avril_NNAI::NeuralPath* Avril_NNAI::Algorithms::Get_NeuralPath()
{
    return ptr_NeuralPaths;
}
