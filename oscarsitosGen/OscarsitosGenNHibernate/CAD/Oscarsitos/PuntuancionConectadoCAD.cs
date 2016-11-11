
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
 * Clase puntuancionConectado:
 *
 */

namespace OscarsitosGenNHibernate.CAD.Oscarsitos
{
public partial class PuntuancionConectadoCAD : BasicCAD, IPuntuancionConectadoCAD
{
public PuntuancionConectadoCAD() : base ()
{
}

public PuntuancionConectadoCAD(ISession sessionAux) : base (sessionAux)
{
}



public PuntuancionConectadoEN ReadOIDDefault (int id
                                              )
{
        PuntuancionConectadoEN puntuancionConectadoEN = null;

        try
        {
                SessionInitializeTransaction ();
                puntuancionConectadoEN = (PuntuancionConectadoEN)session.Get (typeof(PuntuancionConectadoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in PuntuancionConectadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return puntuancionConectadoEN;
}

        public PuntuancionConectadoEN ReadUser(int id
                                              )
        {
            PuntuancionConectadoEN puntuancionConectadoEN = null;

            try
            {
                SessionInitializeTransaction();
                puntuancionConectadoEN = (PuntuancionConectadoEN)session.Get(typeof(PuntuancionConectadoEN), id);
                SessionCommit();
            }

            catch (Exception ex)
            {
                SessionRollBack();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                    throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException("Error in PuntuancionConectadoCAD.", ex);
            }


            finally
            {
                SessionClose();
            }

            return puntuancionConectadoEN;
        }

        public PuntuancionConectadoEN ReadComentario(int id
                                              )
        {
            PuntuancionConectadoEN puntuancionConectadoEN = null;

            try
            {
                SessionInitializeTransaction();
                puntuancionConectadoEN = (PuntuancionConectadoEN)session.Get(typeof(PuntuancionConectadoEN), id);
                SessionCommit();
            }

            catch (Exception ex)
            {
                SessionRollBack();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                    throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException("Error in PuntuancionConectadoCAD.", ex);
            }


            finally
            {
                SessionClose();
            }

            return puntuancionConectadoEN;
        }

        public System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN> ReadUserComentario(int id_user, int id_coment)
        {
            System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN> result;
            try
            {
                SessionInitializeTransaction();
                //String sql = @"FROM PuntuancionConectadoEN pc where ((pc.EsPuntuado.Id = :id_coment) and (pc.Puntua.Id = :id_user))";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery("PepeENreadCocheHQL");
                query.setParameter("id_user", id_user);
                query.setParameter("id_coment", id_coment);


                result = query.List<OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN>();
                SessionCommit();
            }

            catch (Exception ex)
            {
                SessionRollBack();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                    throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException("Error in PuntuancionConectadoCAD.", ex);
            }


            finally
            {
                SessionClose();
            }

            return result;
        }
        public System.Collections.Generic.IList<PuntuancionConectadoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PuntuancionConectadoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PuntuancionConectadoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PuntuancionConectadoEN>();
                        else
                                result = session.CreateCriteria (typeof(PuntuancionConectadoEN)).List<PuntuancionConectadoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in PuntuancionConectadoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PuntuancionConectadoEN puntuancionConectado)
{
        try
        {
                SessionInitializeTransaction ();
                PuntuancionConectadoEN puntuancionConectadoEN = (PuntuancionConectadoEN)session.Load (typeof(PuntuancionConectadoEN), puntuancionConectado.Id);

                puntuancionConectadoEN.Puntuacion = puntuancionConectado.Puntuacion;



                session.Update (puntuancionConectadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in PuntuancionConectadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (PuntuancionConectadoEN puntuancionConectado)
{
        try
        {
                SessionInitializeTransaction ();
                if (puntuancionConectado.EsPuntuado != null) {
                        // Argumento OID y no colección.
                        puntuancionConectado.EsPuntuado = (OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN)session.Load (typeof(OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN), puntuancionConectado.EsPuntuado.Id);

                        puntuancionConectado.EsPuntuado.Puntuancion
                        .Add (puntuancionConectado);
                }
                if (puntuancionConectado.Puntua != null) {
                        // Argumento OID y no colección.
                        puntuancionConectado.Puntua = (OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN)session.Load (typeof(OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN), puntuancionConectado.Puntua.Id);

                        puntuancionConectado.Puntua.Puntuancion
                        .Add (puntuancionConectado);
                }

                session.Save (puntuancionConectado);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in PuntuancionConectadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return puntuancionConectado.Id;
}

public void Modify (PuntuancionConectadoEN puntuancionConectado)
{
        try
        {
                SessionInitializeTransaction ();
                PuntuancionConectadoEN puntuancionConectadoEN = (PuntuancionConectadoEN)session.Load (typeof(PuntuancionConectadoEN), puntuancionConectado.Id);

                puntuancionConectadoEN.Puntuacion = puntuancionConectado.Puntuacion;

                session.Update (puntuancionConectadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in PuntuancionConectadoCAD.", ex);
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
                PuntuancionConectadoEN puntuancionConectadoEN = (PuntuancionConectadoEN)session.Load (typeof(PuntuancionConectadoEN), id);
                session.Delete (puntuancionConectadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in PuntuancionConectadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: PuntuancionConectadoEN
public PuntuancionConectadoEN ReadOID (int id
                                       )
{
        PuntuancionConectadoEN puntuancionConectadoEN = null;

        try
        {
                SessionInitializeTransaction ();
                puntuancionConectadoEN = (PuntuancionConectadoEN)session.Get (typeof(PuntuancionConectadoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in PuntuancionConectadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return puntuancionConectadoEN;
}

public System.Collections.Generic.IList<PuntuancionConectadoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PuntuancionConectadoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PuntuancionConectadoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PuntuancionConectadoEN>();
                else
                        result = session.CreateCriteria (typeof(PuntuancionConectadoEN)).List<PuntuancionConectadoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in PuntuancionConectadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
