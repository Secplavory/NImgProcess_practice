#ifdef MYDLL_EXPORTS
#define MYDLL_API __declspec(dllexport)
#else
#define MYDLL_API __declspec(dllimport)
#endif // MYDLL_EXPORTS

#ifdef __cplusplus
extern "C" {
#endif

	MYDLL_API int __cdecl Add(int a, int b);
	MYDLL_API int __cdecl Subtract(int a, int b);
	MYDLL_API int __cdecl Multiply(int a, int b);
	MYDLL_API int __cdecl Divide(int a, int b);

#ifdef __cplusplus
}
#endif // __cplusplus
