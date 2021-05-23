using System;
using System.Collections.Generic;

namespace CarPark.Core.Models
{
    public class Result
    {
        public bool Success { get; set; } = true;
        public string Message { get; set; }
    }

    public class GetOneResult<TEntity> : Result where TEntity : class, new()
    {
        public TEntity Entity { get; set; }
    }

    public class GetManyResult<TEntity> : Result where TEntity : class, new()
    {
        public IEnumerable<TEntity> Result { get; set; }
    }
}
