
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
 * Clase UsuarioNoConect:
 *
 */

namespace OscarsitosGenNHibernate.CAD.Oscarsitos
{
public partial class UsuarioNoConectCAD : BasicCAD, IUsuarioNoConectCAD
{
public UsuarioNoConectCAD() : base ()
{
}

public UsuarioNoConectCAD(ISession sessionAux) : base (sessionAux)
{
}



public UsuarioNoConectEN ReadOIDDefault (int id
                                         )
{
        UsuarioNoConectEN usuarioNoConectEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioNoConectEN = (UsuarioNoConectEN)session.Get (typeof(UsuarioNoConectEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioNoConectCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioNoConectEN;
}

public System.Collections.Generic.IList<UsuarioNoConectEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<UsuarioNoConectEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(UsuarioNoConectEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<UsuarioNoConectEN>();
                        else
                                result = session.CreateCriteria (typeof(UsuarioNoConectEN)).List<UsuarioNoConectEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioNoConectCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (UsuarioNoConectEN usuarioNoConect)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioNoConectEN usuarioNoConectEN = (UsuarioNoConectEN)session.Load (typeof(UsuarioNoConectEN), usuarioNoConect.Id);
                session.Update (usuarioNoConectEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioNoConectCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
