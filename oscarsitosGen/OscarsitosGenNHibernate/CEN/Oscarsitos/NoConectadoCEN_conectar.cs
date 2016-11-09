
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
public bool Conectar (string password, string texto)
{
            /*PROTECTED REGION ID(OscarsitosGenNHibernate.CEN.Oscarsitos_NoConectado_conectar) ENABLED START*/
            ConectadoEN conectadoEN = new ConectadoEN();
            IConectadoCAD _IConectadoCAD = new ConectadoCAD();
            bool login = false;
            //SI EL ID TIENE UN VALOR Y ID COINCIDE CON UN USUARIO CONECTADO
            
            conectadoEN = _IConectadoCAD.ReadAlias(texto);
            if (conectadoEN == null) {
                conectadoEN = _IConectadoCAD.ReadEmail(texto);
            }
            if (conectadoEN != null && conectadoEN.Password == password) {
                login = true;
            }
            
            return (login);

            /*PROTECTED REGION END*/
        }
}
}
