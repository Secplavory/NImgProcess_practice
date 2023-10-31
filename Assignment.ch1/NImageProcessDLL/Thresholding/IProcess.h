#pragma once

#include "Windows.h"
#include "../../NImage/NImage.h"

#ifndef		_INC_INIMGPROCESSH
#define		_INC_INIMGPROCESSH

struct IMAGEPARAMENT
{
	int		nWidth;
	int		nHeight;
	int		nBitCount;
	int		nBytesPerLine;
	int		nBytesPerPixel;
	int		nNumColors;
	int		nSize;
};

void  GetImageParament(NImage* pImg, struct IMAGEPARAMENT* ppImgParam);
BYTE** Create2DList(NImage* pImgm);
void  Release2DList(BYTE** list);

#endif