using System;
using System.Collections.Generic;
using System.Text;

namespace eProjectNetCore.ViewModels.Common
{
    public class PagedResult<T>
    {
        public List<T> Items { get; set; }
        public int TotalRecord { set; get; }
    }
}
