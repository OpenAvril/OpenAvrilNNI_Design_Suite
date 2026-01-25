#pragma once

namespace Avril_NNAI
{
	class NeuralPath
	{
	public:
		NeuralPath();
		virtual ~NeuralPath();

		class Object* Get_NatureOfThePath(Avril_NNAI::Framework_NNAI* obj);

		void Set_NatureOfThePath_NIL(INT8 natureOfInputEquation);
		void Set_NatureOfThePath_LINEAR(class Avril_NNAI::Linear* natureOfInputEquation);
	};
}