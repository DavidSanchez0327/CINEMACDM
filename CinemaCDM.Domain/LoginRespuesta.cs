using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaCDM.Domain
{
    public class LoginRespuesta
    {
        public string EsPermitido { get; set; }
        public string Mensaje { get; set; }

        public static LoginRespuesta SignIn(Login userInfo)
        {
            throw new NotImplementedException();
        }
    }
}
