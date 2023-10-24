#include "pch.h"
#include "Unmanaged_Calculator.h"

#pragma once
#pragma comment(lib, "CH3_DLL.lib")

using namespace System;

namespace CH3CLR {
	public ref class ManagedClass
	{
	public:
		ManagedClass() : m_Impl(new Unmanaged_Calculator) {}
		~ManagedClass() {
			delete m_Impl;
		}
		int Add(int a, int b) {
			return (m_Impl->Add(a, b));
		}
	protected:
		!ManagedClass() {
			delete m_Impl;
		}
	private:
		Unmanaged_Calculator* m_Impl;
	};
}
