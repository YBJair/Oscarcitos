
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


/*PROTECTED REGION ID(usingOscarsitosGenNHibernate.CEN.Oscarsitos_NoConectado_conectar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace OscarsitosGenNHibernate.CEN.Oscarsitos
{
public partial class NoConectadoCEN
{
public void Conectar (int p_oid)
{
            /*PROTECTED REGION ID(OscarsitosGenNHibernate.CEN.Oscarsitos_NoConectado_conectar) ENABLED START*/

            NoConectadoEN noConectadoEN = null;//USUARIO
            ConectadoEN ConectadoEN = null;

            //SI EL ID TIENE UN VALOR Y ID COINCIDE CON UN USUARIO CONECTADO
            if (p_oid != 0 && p_oid == ConectadoEN.Id)
            {
                //CONECTAMOS
                noConectadoEN = _INoConectadoCAD.ReadOIDDefault(p_oid);
            }
            /*PROTECTED REGION END*/
        }
}
}
