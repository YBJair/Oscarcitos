
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
 * Clase Idioma:
 *
 */

namespace OscarsitosGenNHibernate.CAD.Oscarsitos
{
public partial class IdiomaCAD : BasicCAD, IIdiomaCAD
{
public IdiomaCAD() : base ()
{
}

public IdiomaCAD(ISession sessionAux) : base (sessionAux)
{
}



public IdiomaEN ReadOIDDefault (int id
                                )
{
        IdiomaEN idiomaEN = null;

        try
        {
                SessionInitializeTransaction ();
                idiomaEN = (IdiomaEN)session.Get (typeof(IdiomaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in IdiomaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return idiomaEN;
}

public System.Collections.Generic.IList<IdiomaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IdiomaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IdiomaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IdiomaEN>();
                        else
                                result = session.CreateCriteria (typeof(IdiomaEN)).List<IdiomaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in IdiomaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IdiomaEN idioma)
{
        try
        {
                SessionInitializeTransaction ();
                IdiomaEN idiomaEN = (IdiomaEN)session.Load (typeof(IdiomaEN), idioma.Id);

                idiomaEN.Idioma = idioma.Idioma;



                session.Update (idiomaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in IdiomaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (IdiomaEN idioma)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (idioma);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in IdiomaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return idioma.Id;
}

public void Modify (IdiomaEN idioma)
{
        try
        {
                SessionInitializeTransaction ();
                IdiomaEN idiomaEN = (IdiomaEN)session.Load (typeof(IdiomaEN), idioma.Id);

                idiomaEN.Idioma = idioma.Idioma;

                session.Update (idiomaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in IdiomaCAD.", ex);
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
                IdiomaEN idiomaEN = (IdiomaEN)session.Load (typeof(IdiomaEN), id);
                session.Delete (idiomaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in IdiomaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: IdiomaEN
public IdiomaEN ReadOID (int id
                         )
{
        IdiomaEN idiomaEN = null;

        try
        {
                SessionInitializeTransaction ();
                idiomaEN = (IdiomaEN)session.Get (typeof(IdiomaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in IdiomaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return idiomaEN;
}

public System.Collections.Generic.IList<IdiomaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IdiomaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(IdiomaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<IdiomaEN>();
                else
                        result = session.CreateCriteria (typeof(IdiomaEN)).List<IdiomaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in IdiomaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
