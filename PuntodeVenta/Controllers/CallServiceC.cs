using PuntodeVenta.Models;
using System;
using System.Threading.Tasks;

namespace PuntodeVenta.Controllers
{
    internal class CallServiceC
    {
        public string FldPassword { get; set; }
        public string FldEmailAcount { get; set; }

        internal static Task<ResultPost> CallServiceLogin(string v, user user)
        {
            throw new NotImplementedException();
        }

        internal static Task<ResultPost> CallServiceLogin(string v, object user, object fldEmailAcount)
        {
            throw new NotImplementedException();
        }

        internal static Task<ResultPost> CallServiceLogin(string v, user user, object fldEmailAcount)
        {
            throw new NotImplementedException();
        }
    }
}