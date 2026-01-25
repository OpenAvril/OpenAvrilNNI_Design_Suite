#pragma once
namespace Avril_NNAI
{
	class Algorithms
	{
	public:
		Algorithms();
		virtual ~Algorithms();
		void Initialise_Control();

		class Avril_NNAI::NeuralPath* Get_NeuralPath();
	};
}