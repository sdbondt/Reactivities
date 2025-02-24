using System;

namespace Application.Core;

public class PagedList<T, TCursor>
{
    public List<T> Items = [];
    public TCursor? NextCursor { get;  set; }
}
