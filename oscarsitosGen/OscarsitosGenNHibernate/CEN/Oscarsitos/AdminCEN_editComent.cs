
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


/*PROTECTED REGION ID(usingOscarsitosGenNHibernate.CEN.Oscarsitos_Admin_editComent) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace OscarsitosGenNHibernate.CEN.Oscarsitos
{
public partial class AdminCEN
{
public void EditComent (int p_oid, int p_comentario)
{
        /*PROTECTED REGION ID(OscarsitosGenNHibernate.CEN.Oscarsitos_Admin_editComent) ENABLED START*/
        AdminCAD _AdminCAD = new AdminCAD();
        ComentarioCAD _IComentarioCAD = new ComentarioCAD();

        ComentarioEN comentarioEN = _IComentarioCAD.ReadOIDDefault(p_oid);
        comentarioEN = _IComentarioCAD.ReadOIDDefault(p_comentario);

        _IComentarioCAD.Modify(comentarioEN);
            
         /*PROTECTED REGION END*/
        }
}
}
