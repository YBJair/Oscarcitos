
using System;
using System.Text;
using OscarsitosGenNHibernate.CEN.Oscarsitos;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using OscarsitosGenNHibernate.EN.Oscarsitos;
using OscarsitosGenNHibernate.Exceptions;


/*
 * Clase Articulo:
 *
 */

namespace OscarsitosGenNHibernate.CAD.Oscarsitos
{
public partial class ArticuloCAD : BasicCAD, IArticuloCAD
{
public ArticuloCAD() : base ()
{
}

public ArticuloCAD(ISession sessionAux) : base (sessionAux)
{
}



public ArticuloEN ReadOIDDefault (int id
                                  )
{
        ArticuloEN articuloEN = null;

        try
        {
                SessionInitializeTransaction ();
                articuloEN = (ArticuloEN)session.Get (typeof(ArticuloEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return articuloEN;
}

public System.Collections.Generic.IList<ArticuloEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ArticuloEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ArticuloEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ArticuloEN>();
                        else
                                result = session.CreateCriteria (typeof(ArticuloEN)).List<ArticuloEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ArticuloEN articulo)
{
        try
        {
                SessionInitializeTransaction ();
                ArticuloEN articuloEN = (ArticuloEN)session.Load (typeof(ArticuloEN), articulo.Id);

                articuloEN.Contenido = articulo.Contenido;


                articuloEN.FechaPubli = articulo.FechaPubli;


                articuloEN.Categoria = articulo.Categoria;


                articuloEN.Titulo = articulo.Titulo;





                articuloEN.Titular = articulo.Titular;


                articuloEN.Visible = articulo.Visible;


                articuloEN.Imagen = articulo.Imagen;

                session.Update (articuloEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ArticuloEN articulo)
{
        try
        {
                SessionInitializeTransaction ();
                if (articulo.Redacta != null) {
                        // Argumento OID y no colección.
                        articulo.Redacta = (OscarsitosGenNHibernate.EN.Oscarsitos.RedactorEN)session.Load (typeof(OscarsitosGenNHibernate.EN.Oscarsitos.RedactorEN), articulo.Redacta.Id);

                        articulo.Redacta.Redactado
                        .Add (articulo);
                }

                session.Save (articulo);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return articulo.Id;
}

public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                ArticuloEN articuloEN = (ArticuloEN)session.Load (typeof(ArticuloEN), id);
                session.Delete (articuloEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Modify (ArticuloEN articulo)
{
        try
        {
                SessionInitializeTransaction ();
                ArticuloEN articuloEN = (ArticuloEN)session.Load (typeof(ArticuloEN), articulo.Id);

                articuloEN.Contenido = articulo.Contenido;


                articuloEN.FechaPubli = articulo.FechaPubli;


                articuloEN.Categoria = articulo.Categoria;


                articuloEN.Titulo = articulo.Titulo;


                articuloEN.Titular = articulo.Titular;


                articuloEN.Visible = articulo.Visible;


                articuloEN.Imagen = articulo.Imagen;

                session.Update (articuloEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public System.Collections.Generic.IList<ArticuloEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ArticuloEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ArticuloEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ArticuloEN>();
                else
                        result = session.CreateCriteria (typeof(ArticuloEN)).List<ArticuloEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

//Sin e: ReadOID
//Con e: ArticuloEN
public ArticuloEN ReadOID (int id
                           )
{
        ArticuloEN articuloEN = null;

        try
        {
                SessionInitializeTransaction ();
                articuloEN = (ArticuloEN)session.Get (typeof(ArticuloEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return articuloEN;
}

public System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN> ReadPublisher ()
{
        System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ArticuloEN self where FROM ArticuloEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ArticuloENreadPublisherHQL");

                result = query.List<OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void RelComentario (int p_Articulo_OID, System.Collections.Generic.IList<int> p_comentario_OIDs)
{
        OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN articuloEN = null;
        try
        {
                SessionInitializeTransaction ();
                articuloEN = (ArticuloEN)session.Load (typeof(ArticuloEN), p_Articulo_OID);
                OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN comentarioENAux = null;
                if (articuloEN.Comentario == null) {
                        articuloEN.Comentario = new System.Collections.Generic.List<OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN>();
                }

                foreach (int item in p_comentario_OIDs) {
                        comentarioENAux = new OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN ();
                        comentarioENAux = (OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN)session.Load (typeof(OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN), item);
                        comentarioENAux.Articulo = articuloEN;

                        articuloEN.Comentario.Add (comentarioENAux);
                }


                session.Update (articuloEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnrelComentario (int p_Articulo_OID, System.Collections.Generic.IList<int> p_comentario_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN articuloEN = null;
                articuloEN = (ArticuloEN)session.Load (typeof(ArticuloEN), p_Articulo_OID);

                OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN comentarioENAux = null;
                if (articuloEN.Comentario != null) {
                        foreach (int item in p_comentario_OIDs) {
                                comentarioENAux = (OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN)session.Load (typeof(OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN), item);
                                if (articuloEN.Comentario.Contains (comentarioENAux) == true) {
                                        articuloEN.Comentario.Remove (comentarioENAux);
                                        comentarioENAux.Articulo = null;
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_comentario_OIDs you are trying to unrelationer, doesn't exist in ArticuloEN");
                        }
                }

                session.Update (articuloEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ArticuloCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
