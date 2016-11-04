

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
 *      Definition of the class ArticuloCEN
 *
 */
public partial class ArticuloCEN
{
private IArticuloCAD _IArticuloCAD;

public ArticuloCEN()
{
        this._IArticuloCAD = new ArticuloCAD ();
}

public ArticuloCEN(IArticuloCAD _IArticuloCAD)
{
        this._IArticuloCAD = _IArticuloCAD;
}

public IArticuloCAD get_IArticuloCAD ()
{
        return this._IArticuloCAD;
}

public int New_ (string p_contenido, Nullable<DateTime> p_fechaPubli, OscarsitosGenNHibernate.Enumerated.Oscarsitos.CategArticuloEnum p_categoria, string p_titulo, int p_redacta, bool p_titular, bool p_visible, string p_imagen)
{
        ArticuloEN articuloEN = null;
        int oid;

        //Initialized ArticuloEN
        articuloEN = new ArticuloEN ();
        articuloEN.Contenido = p_contenido;

        articuloEN.FechaPubli = p_fechaPubli;

        articuloEN.Categoria = p_categoria;

        articuloEN.Titulo = p_titulo;


        if (p_redacta != -1) {
                // El argumento p_redacta -> Property redacta es oid = false
                // Lista de oids id
                articuloEN.Redacta = new OscarsitosGenNHibernate.EN.Oscarsitos.RedactorEN ();
                articuloEN.Redacta.Id = p_redacta;
        }

        articuloEN.Titular = p_titular;

        articuloEN.Visible = p_visible;

        articuloEN.Imagen = p_imagen;

        //Call to ArticuloCAD

        oid = _IArticuloCAD.New_ (articuloEN);
        return oid;
}

public void Destroy (int id
                     )
{
        _IArticuloCAD.Destroy (id);
}

public void Modify (int p_Articulo_OID, string p_contenido, Nullable<DateTime> p_fechaPubli, OscarsitosGenNHibernate.Enumerated.Oscarsitos.CategArticuloEnum p_categoria, string p_titulo, bool p_titular, bool p_visible, string p_imagen)
{
        ArticuloEN articuloEN = null;

        //Initialized ArticuloEN
        articuloEN = new ArticuloEN ();
        articuloEN.Id = p_Articulo_OID;
        articuloEN.Contenido = p_contenido;
        articuloEN.FechaPubli = p_fechaPubli;
        articuloEN.Categoria = p_categoria;
        articuloEN.Titulo = p_titulo;
        articuloEN.Titular = p_titular;
        articuloEN.Visible = p_visible;
        articuloEN.Imagen = p_imagen;
        //Call to ArticuloCAD

        _IArticuloCAD.Modify (articuloEN);
}

public System.Collections.Generic.IList<ArticuloEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ArticuloEN> list = null;

        list = _IArticuloCAD.ReadAll (first, size);
        return list;
}
public ArticuloEN ReadOID (int id
                           )
{
        ArticuloEN articuloEN = null;

        articuloEN = _IArticuloCAD.ReadOID (id);
        return articuloEN;
}

public System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN> ReadPublisher ()
{
        return _IArticuloCAD.ReadPublisher ();
}
public void RelComentario (int p_Articulo_OID, System.Collections.Generic.IList<int> p_comentario_OIDs)
{
        //Call to ArticuloCAD

        _IArticuloCAD.RelComentario (p_Articulo_OID, p_comentario_OIDs);
}
public void UnrelComentario (int p_Articulo_OID, System.Collections.Generic.IList<int> p_comentario_OIDs)
{
        //Call to ArticuloCAD

        _IArticuloCAD.UnrelComentario (p_Articulo_OID, p_comentario_OIDs);
}
}
}
