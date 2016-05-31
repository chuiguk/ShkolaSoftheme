using System;

namespace CarConstruction
{
    enum Colors
    {
        Black, White, Red, Blue
    }
    class Color
    {
        public Colors ColorName { get; private set; }
        public Color(Colors colorName)
        {
            this.ColorName = colorName;
        }
    }
}
