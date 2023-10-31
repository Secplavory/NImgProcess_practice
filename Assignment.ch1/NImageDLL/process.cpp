#include "../NImage/NImage.h"
#include "process.h"

LONG_PTR CreateNImage() {
	return (LONG_PTR) new NImage();
}

bool DestroyNImage(LONG_PTR m_img) {
	NImage* Img = (NImage*) m_img;
	if (Img) delete Img;
	return true;
}

bool LoadBMP(LONG_PTR m_img, char* filename) {
	NImage* img = (NImage*) m_img;
	if (img == 0) return 0;
	return img->LoadBMP(filename);
}

bool SaveBMP(LONG_PTR m_img, char* filename) {
	NImage* img = (NImage*) m_img;
	if (img == 0) return 0;
	return img->SaveBMP(filename);
}

HBITMAP* GetBitmap(LONG_PTR m_img) {
	NImage* img = (NImage*) m_img;
	return (HBITMAP*)*(img->GetBitmap());
}