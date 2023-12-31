// NImageDLL.cpp : 定義 DLL 應用程式的匯出函式。
//
#include "NImageDLL.h"
#include "NImage.h"


// 這是匯出函式的範例。
LONG_PTR CreateNImage()
{
	return (LONG_PTR) new NImage();
}

bool DestroyNImage(LONG_PTR m_Img)
{
	NImage* Img = (NImage*) m_Img;
	
	
	if (Img) delete Img;

	return true;

}

bool LoadBMP(LONG_PTR m_Img ,char* filename)
{
	int bFlag = false;

	NImage* Img = (NImage*) m_Img;
	
	if (Img != 0)
		bFlag = Img->LoadBMP(filename);
	
	if (bFlag)
		return true;
	else
		return false;
}

HBITMAP* GetBitmap(LONG_PTR m_Img)
{
	NImage* Img = (NImage*) m_Img;
	
	return (HBITMAP*)*(Img->GetBitmap()) ;
}
