
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


/*PROTECTED REGION ID(usingOscarsitosGenNHibernate.CEN.Oscarsitos_Conectado_idioma) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace OscarsitosGenNHibernate.CEN.Oscarsitos
{
public partial class ConectadoCEN
{
        //Se le pasa el id del usuario y del idioma deseado
        public void Idioma (int p_oid, int p_idioma)
{
            /*PROTECTED REGION ID(OscarsitosGenNHibernate.CEN.Oscarsitos_Conectado_idioma) ENABLED START*/
            IdiomaCAD _IdiomaCAD = new IdiomaCAD();
            

            ConectadoEN conectadoEN = _IConectadoCAD.ReadOIDDefault(p_oid);
            conectadoEN.Idioma = _IdiomaCAD.ReadOIDDefault(p_idioma);

            _IConectadoCAD.Modify(conectadoEN);
            
            /*PROTECTED REGION END*/
        }
}
}
