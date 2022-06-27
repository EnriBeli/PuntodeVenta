using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PuntodeVenta.Models
{
    public class Response
    {
            public string result { get; set; }
            public Object errors { get; set; }
            public bool error { get; set; }
        
    }
}
