
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
public void EditArticuloPropio (int p_redactor_oid,int p_articulo_oid, string cont, Nullable<DateTime> fechPubli, OscarsitosGenNHibernate.Enumerated.Oscarsitos.CategArticuloEnum categoria, string titulo, bool titular, bool visible, string imagen)
{
            /*PROTECTED REGION ID(OscarsitosGenNHibernate.CEN.Oscarsitos_Redactor_editArticuloPropio) ENABLED START*/
            ArticuloCAD _IArticuloCAD = new ArticuloCAD();
            ArticuloCEN articuloCEN = new ArticuloCEN();

            RedactorEN redactorEN = _IRedactorCAD.ReadOIDDefault(p_redactor_oid);
            ArticuloEN articuloEN = _IArticuloCAD.ReadOIDDefault(p_articulo_oid);
           
            if (redactorEN.Id == articuloEN.Redacta.Id){

                articuloCEN.Modify(p_articulo_oid, cont, fechPubli, categoria, titulo, titular, visible, imagen);
            }   
            /*PROTECTED REGION END*/
        }
}
}
