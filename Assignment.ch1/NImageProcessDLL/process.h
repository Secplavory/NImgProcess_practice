#pragma once

#include "../NImage/NImage.h"

#ifdef NIMAGEPROCESSDLL_EXPORTS
#define API __declspec(dllexport)
#else
#define API __declspec(dllimport)
#endif

#ifdef __cplusplus
extern "C" {
#endif

	API void __cdecl KSW_EntropicThreshold(NImage* pImg);
	API void __cdecl MomentThreshold(NImage* pImg);
	API void __cdecl OtsuThreshold(NImage* pImg);

#ifdef __cplusplus
}
#endif

void histog(BYTE** list, long* pg, int x, int y, int Dx, int Dy);
void Sobel0(BYTE** list0, BYTE** list1, int Dx, int Dy, char ch);
bool Sobel(BYTE** list0, BYTE** list1, int Dx, int Dy);
void Threshold(NImage* pImg, int (*func)(long* pg));

int MaxMin(double* tab, int flag);
int Ptile(long* pg, double nn);
int KSW_Entropic(long* pg);
int Moment(long* pg);
int Otsu(long* pg);

