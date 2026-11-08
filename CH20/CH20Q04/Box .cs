using System;

namespace CH20Q04
{
    internal class Box
    {
        public int OuterWidth { get; }
        public int OuterLength { get; }
        public int OuterHeight { get; }
        public int OuterVolume { get; }

        public Box(int outerWidth, int outerLength, int outerHeight)
        {
            OuterWidth = Math.Max(1, outerWidth);
            OuterLength = Math.Max(1, outerLength);
            OuterHeight = Math.Max(1, outerHeight);
            OuterVolume = outerWidth * outerLength * outerHeight;
        }

    }
}
