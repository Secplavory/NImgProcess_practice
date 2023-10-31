#pragma once

#include "windows.h"

#ifdef NIMAGEDLL_EXPORTS
#define API __declspec(dllexport)
#else
#define API __declspec(dllimport)
#endif

#ifdef __cplusplus
extern "C" {
#endif

	API LONG_PTR __cdecl CreateNImage();
	API bool __cdecl DestroyNImage(LONG_PTR m_img);
	API bool __cdecl LoadBMP(LONG_PTR m_img, char* filename);
	API bool __cdecl SaveBMP(LONG_PTR m_img, char* filename);
	API HBITMAP* __cdecl GetBitmap(LONG_PTR m_img);

#ifdef __cplusplus
}
#endif