#pragma once
namespace Avril_NNAI
{
	class Data
	{
	public:
		Data();
		virtual ~Data();
		void Initialise_Control();

		std::vector<class Avril_NNAI::Input*> Get_Inputs();
		std::vector<class Avril_NNAI::Node*> Get_Nodes();
		std::vector<class Avril_NNAI::Output*> Get_Outputs();
	};
}