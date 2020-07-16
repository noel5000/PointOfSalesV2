using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface IPagedList<T>
    {
        int TotalItemCount { get; set; }
        int Count { get; set; }
        int PageCount { get; set; }
        int CurrentPage { get; set; }
        int Status { get; set; }
        string Message { get; set; }
        T[] Data { get; set; }

        IPagedList<TResult> TransformData<TResult>(Func<IEnumerable<T>, IEnumerable<TResult>> transform);
    }
}
