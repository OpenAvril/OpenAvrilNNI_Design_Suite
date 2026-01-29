// The following ifdef block is the standard way of creating macros which make exporting
// from a DLL simpler. All files within this DLL are compiled with the AVRILNNAIOPENCONCURRENCYIOPRAISENTH_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see
// AVRILNNAIOPENCONCURRENCYIOPRAISENTH_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef AVRILNNAIOPENCONCURRENCYIOPRAISENTH_EXPORTS
#define AVRILNNAIOPENCONCURRENCYIOPRAISENTH_API __declspec(dllexport)
#else
#define AVRILNNAIOPENCONCURRENCYIOPRAISENTH_API __declspec(dllimport)
#endif

// This class is exported from the dll
class AVRILNNAIOPENCONCURRENCYIOPRAISENTH_API CAvrilNNAIOpenConcurrencyIOPraiseNth {
public:
	CAvrilNNAIOpenConcurrencyIOPraiseNth(void);
	// TODO: add your methods here.
};

extern AVRILNNAIOPENCONCURRENCYIOPRAISENTH_API int nAvrilNNAIOpenConcurrencyIOPraiseNth;

AVRILNNAIOPENCONCURRENCYIOPRAISENTH_API int fnAvrilNNAIOpenConcurrencyIOPraiseNth(void);
