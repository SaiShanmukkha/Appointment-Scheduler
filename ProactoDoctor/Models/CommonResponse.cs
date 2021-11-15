using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProactoDoctor.Models
{
    public class CommonResponse<T>
    {
        public int status { get; set; }

        public string message { get; set; }

        public T dataEnum { get; set; }
    }
}
