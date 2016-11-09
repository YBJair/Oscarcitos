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

namespace OscarsitosGenNHibernate.CEN.Oscarsitos
{
    public partial class ComentarioCEN
    {

        public void Puntuar(int p_comentario_OID, int p_user_OID)
        {
            PuntuancionConectadoCAD _IPunConCAD = new PuntuancionConectadoCAD();
            PuntuancionConectadoEN PunConEN = new PuntuancionConectadoEN();
            
            if(_IPunConCAD.ReadComentario(p_comentario_OID) == null )
            {

            }

            ComentarioEN comentarioEN = _IComentarioCAD.ReadOID(p_comentario_OID);

            //Initialized ComentarioEN
            comentarioEN = new ComentarioEN();
            comentarioEN.Id = p_comentario_OID;
            //Call to ComentarioCAD

            _IComentarioCAD.Puntuar(comentarioEN);
        }
    }
}
