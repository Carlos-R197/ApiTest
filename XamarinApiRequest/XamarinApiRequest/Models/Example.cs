using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinApiRequest.Models
{
    public class Example
    {
        public int count { get; set; }
        public object next { get; set; }
        public object previous { get; set; }
        public IList<Result> results { get; set; }
    }
}
