﻿using CapaDato.Model;
using System.Linq;

namespace CapaNegocio.Negocio
{
    public class Nasiento
    {
        public int ObtenerCveAsiento(int cveSala, int numeroAsiento)
        {
            try
            {

                using (CinetmazEntities modeldb = new CinetmazEntities())
                {
                    return (int)modeldb.fnObtenerCveAsiento(cveSala, numeroAsiento).ToList().First();
                }
            }
            catch (System.Exception)
            {

                return 0;
            }
        }
    }
}
