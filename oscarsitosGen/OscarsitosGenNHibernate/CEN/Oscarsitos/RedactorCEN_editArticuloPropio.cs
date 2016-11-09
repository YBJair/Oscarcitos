
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


/*PROTECTED REGION ID(usingOscarsitosGenNHibernate.CEN.Oscarsitos_Redactor_editArticuloPropio) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace OscarsitosGenNHibernate.CEN.Oscarsitos
{
public partial class RedactorCEN
{
public void EditArticuloPropio (int p_oid, string cont, Nullable<DateTime> fechPubli, OscarsitosGenNHibernate.Enumerated.Oscarsitos.CategArticuloEnum categoria, string titulo, bool titular, bool visible, string imagen)
{
            /*PROTECTED REGION ID(OscarsitosGenNHibernate.CEN.Oscarsitos_Redactor_editArticuloPropio) ENABLED START*/
            RedactorEN redactorEN = new RedactorEN();
            RedactorCEN RedactorCEN = new RedactorCEN();
            ArticuloCEN articuloCEN = new ArticuloCEN();
           
            if (p_oid != 0 && redactorEN.Id == p_oid){

                articuloCEN.Modify(p_oid, cont, fechPubli, categoria, titulo, titular, visible, imagen);
            }   
            /*PROTECTED REGION END*/
        }
}
}
