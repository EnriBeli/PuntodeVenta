using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PuntodeVenta.Models
{
    public class DTOResponseLogin
    {
        public string token { get; set; }
        public int idUser { get; set; }
        public string fldEmailAcount { get; set; }
        public string fldAvatar { get; set; }
        public int typeUser { get; set; }
    }
}
