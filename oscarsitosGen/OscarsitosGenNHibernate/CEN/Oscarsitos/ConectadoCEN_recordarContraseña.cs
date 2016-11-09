
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


/*PROTECTED REGION ID(usingOscarsitosGenNHibernate.CEN.Oscarsitos_Conectado_recordarContraseña) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace OscarsitosGenNHibernate.CEN.Oscarsitos
{
public partial class ConectadoCEN
{
        //Se le pasa el id del usuario
        public string RecordarContraseña (int p_oid)
{
            /*PROTECTED REGION ID(OscarsitosGenNHibernate.CEN.Oscarsitos_Conectado_recordarContraseña) ENABLED START*/
            string pass = null;

            ConectadoEN conectadoEN = _IConectadoCAD.ReadOIDDefault(p_oid);
            pass = conectadoEN.Password;

            return (pass);

        /*PROTECTED REGION END*/
}
}
}
