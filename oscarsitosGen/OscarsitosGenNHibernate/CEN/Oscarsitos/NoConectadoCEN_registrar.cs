
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using OscarsitosGenNHibernate.Exceptions;
using OscarsitosGenNHibernate.EN.Oscarsitos;
using OscarsitosGenNHibernate.CAD.Oscarsitos;


/*PROTECTED REGION ID(usingOscarsitosGenNHibernate.CEN.Oscarsitos_NoConectado_registrar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace OscarsitosGenNHibernate.CEN.Oscarsitos
{
public partial class NoConectadoCEN
{
        /*PROTECTED REGION ID(OscarsitosGenNHibernate.CEN.Oscarsitos_NoConectado_registrar) ENABLED START*/
        public bool Registrar(int p_oid, string email, string password)
        {
            /*PROTECTED REGION ID(OscarsitosGenNHibernate.CEN.Oscarsitos_NoConectado_registrar) ENABLED START*/
            NoConectadoEN noConectadoEN = null;
            ConectadoEN ConectadoEN = null;
            bool login = false;

            //SI HA INTRODUCIDO EL EMAIL Y LA CONTRASENYA Y EL ID AUN NO EXISTE EN NUESTRA BD 
            if (email != null && password != null && p_oid != ConectadoEN.Id)
            {
                noConectadoEN = _INoConectadoCAD.ReadOIDDefault(p_oid);
                if (ConectadoEN.Password == password)
                {
                    login = true;
                }
            }
            return login;
            /*PROTECTED REGION END*/
        }
    }
    /*PROTECTED REGION END*/
}
