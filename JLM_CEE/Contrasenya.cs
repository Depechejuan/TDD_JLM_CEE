using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLM_CEE
{
    public static class Contrasenya
    {
        public static bool ContrasenyaCorrecta(string contrasenya)
        {
            if (contrasenya == null || contrasenya == string.Empty)
                return false;
            if (contrasenya.Contains("#") && contrasenya.Length >= 8)
                return true;
            return false;
        }
    }
}
