using System;
using System.Collections.Generic;
using System.Text;

namespace Bitfox.Freshworks
{
    public class Result<T>
    {

        
        public Result(T value)
        {
            this.Value = value;
        }

        public Result(string errorMessage)
        {
            this.ErrorMessage = errorMessage;
        }

        public T Value { get; set; }

        public string ErrorMessage { get; set; }


        public bool IsSuccces => String.IsNullOrEmpty(ErrorMessage);

        public bool HasError => !IsSuccces;

    }
}
