#pragma once

#include "NImage_src/NImage.h"

#ifdef NIMGPROCESS_EXPORTS
#define MYDLL_API __declspec(dllexport)
#else
#define MYDLL_API __declspec(dllimport)
#endif

#ifdef __cplusplus
extern "C" {
#endif

MYDLL_API void __cdecl OtsuThreshold(NImage* pImg);
MYDLL_API void __cdecl KSW_EntropicThreshold(NImage* pImg);
MYDLL_API void __cdecl MomentThreshold(NImage* pImg);

void Threshold(NImage* pImg, int (*func)(long* pg));
int KSW_Entropic(long* pg);
int Moment(long* pg);
int   Otsu(long *pg);
void  histog(BYTE **list,long *pg,int x, int y, int Dx, int Dy);  
int   MaxMin(double *tab,int flag);
int   Ptile(long *pg,double nn); 
void  Sobel0(BYTE** list0, BYTE** list1, int Dx, int Dy, char ch);
void  Sobel(BYTE** list0, BYTE** list1, int Dx, int Dy);

#ifdef __cplusplus
}
#endif
