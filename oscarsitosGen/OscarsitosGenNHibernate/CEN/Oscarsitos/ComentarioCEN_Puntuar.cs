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

        public void Puntuar(int p_comentario_OID, int p_user_OID,int voto)
        {
            PuntuancionConectadoCAD _IPunConCAD = new PuntuancionConectadoCAD();
            PuntuancionConectadoEN PunConEN = new PuntuancionConectadoEN();
            PuntuancionConectadoCEN PunConCEN = new PuntuancionConectadoCEN();

            ComentarioEN comentEN = _IComentarioCAD.ReadOID(p_comentario_OID);
            
            if(_IPunConCAD.ReadUserComentario(p_user_OID,p_comentario_OID) == null )
            {
                PunConCEN.New_(voto, p_comentario_OID, p_user_OID);
                comentEN.Puntuacion += voto;
                
            } else
            {
                PunConEN = _IPunConCAD.ReadUserComentario(p_user_OID, p_comentario_OID)[0];
                if (PunConEN.Puntuacion == voto)
                {
                    PunConCEN.Destroy(PunConEN.Id);
                    comentEN.Puntuacion -= voto;
                }
                else
                {
                    PunConCEN.Destroy(PunConEN.Id);
                    PunConCEN.New_(voto, p_comentario_OID, p_user_OID);
                    comentEN.Puntuacion += voto;
                }
            }

            


            //Call to ComentarioCAD

            _IComentarioCAD.Puntuar(comentEN);
        }
    }
}
