﻿
namespace G24W11WPFCounter;

class CounterModel
{
	private int _count = 0;

	public int Count 
	{
		get => _count; //lamda 표현식
		set { if (value >= 0) {
				_count = value;
			}
		}
	}

}
