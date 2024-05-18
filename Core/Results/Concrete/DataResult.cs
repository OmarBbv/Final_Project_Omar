using Core.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Results.Concrete
{
    public class DataResult<T> : Result , IDataResult<T>
    {
        public DataResult(T data,bool isSucces) : base(isSucces)
        {
            Data = data;
        }

        public DataResult(T data, string message, bool IsSuccess) : base(message, IsSuccess)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
