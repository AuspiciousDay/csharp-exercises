using System;

namespace CH20Q03
{
    internal class PageDocument
    {
        public int Pages { get; }

        public PageDocument(int pages)
        {
            Pages = Math.Clamp(pages, 1, 20);
        }
    }
}
