#pragma once
namespace Avril_NNAI
{
	class MetaData
	{
	public:
		MetaData();
		virtual ~MetaData();

		void Set_NumberOTotalInputs(INT64 numberOfNodeInputs);
	};
}