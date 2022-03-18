using System;

namespace BaseMethods.Test
{
	public enum TwodimensionalArraysMockType
	{
		one,
		two,
		three,
		four,
		oneFlip,
		twoFlip,
		threeFlip,
		empty,
		emptytwo
	}


	public static class TwodimensionalArraysMock
	{
		public static int[,] GetMock(TwodimensionalArraysMockType type)
		{
			switch (type)
			{
				case TwodimensionalArraysMockType.one:
					return new int[,] {
						{1,2,3 },
						{8,3,4 },
						{3,10,5 }
					};
				
				case TwodimensionalArraysMockType.two:
					return new int[,] {
						{11,1,2,3 },
						{1,2,0,4 },
						{5,3,4,5 },
						{3,10,5,6 }
					};

				case TwodimensionalArraysMockType.three:
					return new int[,] {
						{5,20,38,-10,100 },
						{7,65,-14,9,19 },
						{3,-47,15,65,1 },
						{3,65,15,6,1 },
						{32,7,15,5,1007 }
					};

				case TwodimensionalArraysMockType.four:
					return new int[,] {
						{0, 0 },
						{0, 0},
					};

				case TwodimensionalArraysMockType.oneFlip:
					return new int[,] {
						{1,8,3 },
						{2,3,10 },
						{3,4,5 }
					};

				case TwodimensionalArraysMockType.twoFlip:
					return new int[,] {
						{11,1,5,3 },
						{1,2,3,10 },
						{2,0,4,5 },
						{3,4,5,6 }
					};

				case TwodimensionalArraysMockType.threeFlip:
					return new int[,] {
						{5,7,3,3,32 },
						{20,65,-47,65,7 },
						{38,-14,15,15,15 },
						{-10,9,65,6,5 },
						{100,19,1,1,1007 }
					};
				
				case TwodimensionalArraysMockType.empty:
					return new int[,] { };

				default:
					throw new Exception();
			}
		}
	}
}
