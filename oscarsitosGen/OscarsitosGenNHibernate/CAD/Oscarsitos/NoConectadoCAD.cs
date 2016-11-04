
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
 * Clase NoConectado:
 *
 */

namespace OscarsitosGenNHibernate.CAD.Oscarsitos
{
public partial class NoConectadoCAD : BasicCAD, INoConectadoCAD
{
public NoConectadoCAD() : base ()
{
}

public NoConectadoCAD(ISession sessionAux) : base (sessionAux)
{
}



public NoConectadoEN ReadOIDDefault (int id
                                     )
{
        NoConectadoEN noConectadoEN = null;

        try
        {
                SessionInitializeTransaction ();
                noConectadoEN = (NoConectadoEN)session.Get (typeof(NoConectadoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in NoConectadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return noConectadoEN;
}

public System.Collections.Generic.IList<NoConectadoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<NoConectadoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(NoConectadoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<NoConectadoEN>();
                        else
                                result = session.CreateCriteria (typeof(NoConectadoEN)).List<NoConectadoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in NoConectadoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (NoConectadoEN noConectado)
{
        try
        {
                SessionInitializeTransaction ();
                NoConectadoEN noConectadoEN = (NoConectadoEN)session.Load (typeof(NoConectadoEN), noConectado.Id);

                session.Update (noConectadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in NoConectadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (NoConectadoEN noConectado)
{
        try
        {
                SessionInitializeTransaction ();
                if (noConectado.Idioma_0 != null) {
                        // Argumento OID y no colección.
                        noConectado.Idioma_0 = (OscarsitosGenNHibernate.EN.Oscarsitos.IdiomaEN)session.Load (typeof(OscarsitosGenNHibernate.EN.Oscarsitos.IdiomaEN), noConectado.Idioma_0.Id);

                        noConectado.Idioma_0.NoConectado
                        .Add (noConectado);
                }

                session.Save (noConectado);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in NoConectadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return noConectado.Id;
}

public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                NoConectadoEN noConectadoEN = (NoConectadoEN)session.Load (typeof(NoConectadoEN), id);
                session.Delete (noConectadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in NoConectadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
