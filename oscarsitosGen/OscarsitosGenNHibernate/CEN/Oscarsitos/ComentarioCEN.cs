

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using OscarsitosGenNHibernate.Exceptions;

using OscarsitosGenNHibernate.EN.Oscarsitos;
using OscarsitosGenNHibernate.CAD.Oscarsitos;


namespace OscarsitosGenNHibernate.CEN.Oscarsitos
{
/*
 *      Definition of the class ComentarioCEN
 *
 */
public partial class ComentarioCEN
{
private IComentarioCAD _IComentarioCAD;

public ComentarioCEN()
{
        this._IComentarioCAD = new ComentarioCAD ();
}

public ComentarioCEN(IComentarioCAD _IComentarioCAD)
{
        this._IComentarioCAD = _IComentarioCAD;
}

public IComentarioCAD get_IComentarioCAD ()
{
        return this._IComentarioCAD;
}

public int New_ (string p_contenido, int p_puntuacion, int p_escritor, int p_articulo)
{
        ComentarioEN comentarioEN = null;
        int oid;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();
        comentarioEN.Contenido = p_contenido;

        comentarioEN.Puntuacion = p_puntuacion;


        if (p_escritor != -1) {
                // El argumento p_escritor -> Property escritor es oid = false
                // Lista de oids id
                comentarioEN.Escritor = new OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN ();
                comentarioEN.Escritor.Id = p_escritor;
        }


        if (p_articulo != -1) {
                // El argumento p_articulo -> Property articulo es oid = false
                // Lista de oids id
                comentarioEN.Articulo = new OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN ();
                comentarioEN.Articulo.Id = p_articulo;
        }

        //Call to ComentarioCAD

        oid = _IComentarioCAD.New_ (comentarioEN);
        return oid;
}

public void Modify (int p_Comentario_OID, string p_contenido, int p_puntuacion)
{
        ComentarioEN comentarioEN = null;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();
        comentarioEN.Id = p_Comentario_OID;
        comentarioEN.Contenido = p_contenido;
        comentarioEN.Puntuacion = p_puntuacion;
        //Call to ComentarioCAD

        _IComentarioCAD.Modify (comentarioEN);
}

public void Destroy (int id
                     )
{
        _IComentarioCAD.Destroy (id);
}

public ComentarioEN ReadOID (int id
                             )
{
        ComentarioEN comentarioEN = null;

        comentarioEN = _IComentarioCAD.ReadOID (id);
        return comentarioEN;
}

public System.Collections.Generic.IList<ComentarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ComentarioEN> list = null;

        list = _IComentarioCAD.ReadAll (first, size);
        return list;
}


public void RelPunt (int p_Comentario_OID, System.Collections.Generic.IList<int> p_puntuancion_OIDs)
{
        //Call to ComentarioCAD

        _IComentarioCAD.RelPunt (p_Comentario_OID, p_puntuancion_OIDs);
}
}
}
