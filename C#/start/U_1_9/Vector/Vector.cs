using System;
using System.Collections.Generic;
using System.Text;

namespace Vector
{
    class Vector
    {
		public float X { get; set; } // для получения ошибки доступа нужно поставить модификатор private на set
		public float Y { get; set; } // для получения ошибки доступа нужно поставить модификатор private на set
		public float Length { get; set; }

		public Vector(float x, float y)
		{
			X = x;
			Y = y;
			Length = MathF.Sqrt(X * X + Y * Y);
		}

		public override string ToString()
		{
			return $"Длина вектора ({X}, {Y}): {Length}";
		}
	}
}
