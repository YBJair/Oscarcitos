
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
 * Clase UsuarioConect:
 *
 */

namespace OscarsitosGenNHibernate.CAD.Oscarsitos
{
public partial class UsuarioConectCAD : BasicCAD, IUsuarioConectCAD
{
public UsuarioConectCAD() : base ()
{
}

public UsuarioConectCAD(ISession sessionAux) : base (sessionAux)
{
}



public UsuarioConectEN ReadOIDDefault (int id
                                       )
{
        UsuarioConectEN usuarioConectEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioConectEN = (UsuarioConectEN)session.Get (typeof(UsuarioConectEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioConectCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioConectEN;
}

public System.Collections.Generic.IList<UsuarioConectEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<UsuarioConectEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(UsuarioConectEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<UsuarioConectEN>();
                        else
                                result = session.CreateCriteria (typeof(UsuarioConectEN)).List<UsuarioConectEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioConectCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (UsuarioConectEN usuarioConect)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioConectEN usuarioConectEN = (UsuarioConectEN)session.Load (typeof(UsuarioConectEN), usuarioConect.Id);

                usuarioConectEN.Nombre = usuarioConect.Nombre;


                usuarioConectEN.Alias = usuarioConect.Alias;


                usuarioConectEN.FechaRegistro = usuarioConect.FechaRegistro;


                usuarioConectEN.Password = usuarioConect.Password;


                usuarioConectEN.Email = usuarioConect.Email;


                usuarioConectEN.Attribute = usuarioConect.Attribute;


                session.Update (usuarioConectEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioConectCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (UsuarioConectEN usuarioConect)
{
        try
        {
                SessionInitializeTransaction ();
                if (usuarioConect.Comentario != null) {
                        // Argumento OID y no colección.
                        usuarioConect.Comentario = (OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN)session.Load (typeof(OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN), usuarioConect.Comentario.Id);

                        usuarioConect.Comentario.Escritor
                        .Add (usuarioConect);
                }

                session.Save (usuarioConect);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioConectCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioConect.Id;
}

public void Modify (UsuarioConectEN usuarioConect)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioConectEN usuarioConectEN = (UsuarioConectEN)session.Load (typeof(UsuarioConectEN), usuarioConect.Id);

                usuarioConectEN.Nombre = usuarioConect.Nombre;


                usuarioConectEN.Alias = usuarioConect.Alias;


                usuarioConectEN.FechaRegistro = usuarioConect.FechaRegistro;


                usuarioConectEN.Password = usuarioConect.Password;


                usuarioConectEN.Email = usuarioConect.Email;


                usuarioConectEN.Attribute = usuarioConect.Attribute;

                session.Update (usuarioConectEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioConectCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioConectEN usuarioConectEN = (UsuarioConectEN)session.Load (typeof(UsuarioConectEN), id);
                session.Delete (usuarioConectEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioConectCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<UsuarioConectEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<UsuarioConectEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(UsuarioConectEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<UsuarioConectEN>();
                else
                        result = session.CreateCriteria (typeof(UsuarioConectEN)).List<UsuarioConectEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioConectCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

//Sin e: ReadOID
//Con e: UsuarioConectEN
public UsuarioConectEN ReadOID (int id
                                )
{
        UsuarioConectEN usuarioConectEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioConectEN = (UsuarioConectEN)session.Get (typeof(UsuarioConectEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioConectCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioConectEN;
}

public System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.UsuarioConectEN> ReadFilter ()
{
        System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.UsuarioConectEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UsuarioConectEN self where FROM UsuarioConectEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UsuarioConectENreadFilterHQL");

                result = query.List<OscarsitosGenNHibernate.EN.Oscarsitos.UsuarioConectEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioConectCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
