
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


/*PROTECTED REGION ID(usingOscarsitosGenNHibernate.CEN.Oscarsitos_NoConectado_idioma) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace OscarsitosGenNHibernate.CEN.Oscarsitos
{
public partial class NoConectadoCEN
{
public void Idioma (int p_oid, int p_idioma)
{
            /*PROTECTED REGION ID(OscarsitosGenNHibernate.CEN.Oscarsitos_NoConectado_idioma) ENABLED START*/

            /*IdiomaEN idiomaEN = null;
            IIdiomaCAD _IIdiomaCAD = new IdiomaCAD();

            if (p_oid != 0)
            {
                idiomaEN = _IIdiomaCAD.ReadOIDDefault(p_oid);
                //SI EL USUARIO A SELECCIONADO UN IDIOMA LO BORRAMOS 
                
                if (NoConectadoEN.p_oid.Contains.(idiomaEN)) {
                    IdiomaCEN.Remove(idiomaEN);
                }
            }*/
            IdiomaCAD _IdiomaCAD = new IdiomaCAD();

            NoConectadoEN noConectadoEN = _INoConectadoCAD.ReadOIDDefault(p_oid);
            noConectadoEN.Idioma_0 = _IdiomaCAD.ReadOIDDefault(p_idioma);

            _INoConectadoCAD.ModifyDefault(noConectadoEN);
            /*PROTECTED REGION END*/
        }
}
}
