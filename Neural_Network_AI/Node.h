#pragma once
namespace Avril_NNAI
{
	class Node
	{
	public:
		Node();
		virtual ~Node();

		class Avril_NNAI::Input* Get_Node_Input(INT64 node);
		class Avril_NNAI::NeuralPath* Get_Node_NeuralPathOfInput(INT64 node);
		class Avril_NNAI::Output* Get_Node_Output();

		void Set_Node_Input(INT64 node, class Avril_NNAI::Input* input);
		void Set_Node_NeuralPathOfInput(INT64 node, class Avril_NNAI::NeuralPath* neuralPath);
		void Set_Node_Output(class Avril_NNAI::Output* output);
		void Set_NumberOfNodeInputs(INT64 numberOfNodeInputs);

	private:

	};
}