
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
 * Clase Redactor:
 *
 */

namespace OscarsitosGenNHibernate.CAD.Oscarsitos
{
public partial class RedactorCAD : BasicCAD, IRedactorCAD
{
public RedactorCAD() : base ()
{
}

public RedactorCAD(ISession sessionAux) : base (sessionAux)
{
}



public RedactorEN ReadOIDDefault (int id
                                  )
{
        RedactorEN redactorEN = null;

        try
        {
                SessionInitializeTransaction ();
                redactorEN = (RedactorEN)session.Get (typeof(RedactorEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in RedactorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return redactorEN;
}

public System.Collections.Generic.IList<RedactorEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<RedactorEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(RedactorEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<RedactorEN>();
                        else
                                result = session.CreateCriteria (typeof(RedactorEN)).List<RedactorEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in RedactorCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (RedactorEN redactor)
{
        try
        {
                SessionInitializeTransaction ();
                RedactorEN redactorEN = (RedactorEN)session.Load (typeof(RedactorEN), redactor.Id);

                session.Update (redactorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in RedactorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (RedactorEN redactor)
{
        try
        {
                SessionInitializeTransaction ();
                if (redactor.Idioma != null) {
                        // Argumento OID y no colección.
                        redactor.Idioma = (OscarsitosGenNHibernate.EN.Oscarsitos.IdiomaEN)session.Load (typeof(OscarsitosGenNHibernate.EN.Oscarsitos.IdiomaEN), redactor.Idioma.Id);

                        redactor.Idioma.Conectado
                        .Add (redactor);
                }

                session.Save (redactor);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in RedactorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return redactor.Id;
}

public void Modify (RedactorEN redactor)
{
        try
        {
                SessionInitializeTransaction ();
                RedactorEN redactorEN = (RedactorEN)session.Load (typeof(RedactorEN), redactor.Id);

                redactorEN.Nombre = redactor.Nombre;


                redactorEN.Alias = redactor.Alias;


                redactorEN.FechaRegistro = redactor.FechaRegistro;


                redactorEN.Password = redactor.Password;


                redactorEN.Email = redactor.Email;


                redactorEN.Suscrito = redactor.Suscrito;


                redactorEN.Imagen = redactor.Imagen;

                session.Update (redactorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in RedactorCAD.", ex);
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
                RedactorEN redactorEN = (RedactorEN)session.Load (typeof(RedactorEN), id);
                session.Delete (redactorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in RedactorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: RedactorEN
public RedactorEN ReadOID (int id
                           )
{
        RedactorEN redactorEN = null;

        try
        {
                SessionInitializeTransaction ();
                redactorEN = (RedactorEN)session.Get (typeof(RedactorEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in RedactorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return redactorEN;
}

public System.Collections.Generic.IList<RedactorEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RedactorEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(RedactorEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<RedactorEN>();
                else
                        result = session.CreateCriteria (typeof(RedactorEN)).List<RedactorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in RedactorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void RelArticulo (int p_Redactor_OID, System.Collections.Generic.IList<int> p_redactado_OIDs)
{
        OscarsitosGenNHibernate.EN.Oscarsitos.RedactorEN redactorEN = null;
        try
        {
                SessionInitializeTransaction ();
                redactorEN = (RedactorEN)session.Load (typeof(RedactorEN), p_Redactor_OID);
                OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN redactadoENAux = null;
                if (redactorEN.Redactado == null) {
                        redactorEN.Redactado = new System.Collections.Generic.List<OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN>();
                }

                foreach (int item in p_redactado_OIDs) {
                        redactadoENAux = new OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN ();
                        redactadoENAux = (OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN)session.Load (typeof(OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN), item);
                        redactadoENAux.Redacta = redactorEN;

                        redactorEN.Redactado.Add (redactadoENAux);
                }


                session.Update (redactorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in RedactorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
