using proje_base.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_base.Response
{
    public class PaginationResponse<T> : BaseResponse<T>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int? FirstPage { get; set; }
        public int? LastPage { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }
        public int? NextPage { get; set; }
        public int? PreviousPage { get; set; }


        public PaginationResponse(bool isSuccess) : base(isSuccess) { }
        public PaginationResponse(T resource) : base(resource) { }
        public PaginationResponse(string message) : base(message) { }
        public PaginationResponse(List<string> messages) : base(messages) { }
    }
}
