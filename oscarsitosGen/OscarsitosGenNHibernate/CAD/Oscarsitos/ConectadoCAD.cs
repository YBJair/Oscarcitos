
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
 * Clase Conectado:
 *
 */

namespace OscarsitosGenNHibernate.CAD.Oscarsitos
{
public partial class ConectadoCAD : BasicCAD, IConectadoCAD
{
public ConectadoCAD() : base ()
{
}

public ConectadoCAD(ISession sessionAux) : base (sessionAux)
{
}



public ConectadoEN ReadOIDDefault (int id
                                   )
{
        ConectadoEN conectadoEN = null;

        try
        {
                SessionInitializeTransaction ();
                conectadoEN = (ConectadoEN)session.Get (typeof(ConectadoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ConectadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return conectadoEN;
}

public System.Collections.Generic.IList<ConectadoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ConectadoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ConectadoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ConectadoEN>();
                        else
                                result = session.CreateCriteria (typeof(ConectadoEN)).List<ConectadoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ConectadoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ConectadoEN conectado)
{
        try
        {
                SessionInitializeTransaction ();
                ConectadoEN conectadoEN = (ConectadoEN)session.Load (typeof(ConectadoEN), conectado.Id);

                conectadoEN.Nombre = conectado.Nombre;


                conectadoEN.Alias = conectado.Alias;


                conectadoEN.FechaRegistro = conectado.FechaRegistro;


                conectadoEN.Password = conectado.Password;


                conectadoEN.Email = conectado.Email;



                conectadoEN.Suscrito = conectado.Suscrito;





                conectadoEN.Imagen = conectado.Imagen;

                session.Update (conectadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ConectadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ConectadoEN conectado)
{
        try
        {
                SessionInitializeTransaction ();
                if (conectado.Idioma != null) {
                        // Argumento OID y no colección.
                        conectado.Idioma = (OscarsitosGenNHibernate.EN.Oscarsitos.IdiomaEN)session.Load (typeof(OscarsitosGenNHibernate.EN.Oscarsitos.IdiomaEN), conectado.Idioma.Id);

                        conectado.Idioma.Conectado
                        .Add (conectado);
                }

                session.Save (conectado);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ConectadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return conectado.Id;
}

public void Modify (ConectadoEN conectado)
{
        try
        {
                SessionInitializeTransaction ();
                ConectadoEN conectadoEN = (ConectadoEN)session.Load (typeof(ConectadoEN), conectado.Id);

                conectadoEN.Nombre = conectado.Nombre;


                conectadoEN.Alias = conectado.Alias;


                conectadoEN.FechaRegistro = conectado.FechaRegistro;


                conectadoEN.Password = conectado.Password;


                conectadoEN.Email = conectado.Email;


                conectadoEN.Suscrito = conectado.Suscrito;


                conectadoEN.Imagen = conectado.Imagen;

                session.Update (conectadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ConectadoCAD.", ex);
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
                ConectadoEN conectadoEN = (ConectadoEN)session.Load (typeof(ConectadoEN), id);
                session.Delete (conectadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ConectadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<ConectadoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ConectadoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ConectadoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ConectadoEN>();
                else
                        result = session.CreateCriteria (typeof(ConectadoEN)).List<ConectadoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ConectadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

//Sin e: ReadOID
//Con e: ConectadoEN
public ConectadoEN ReadOID (int id
                            )
{
        ConectadoEN conectadoEN = null;

        try
        {
                SessionInitializeTransaction ();
                conectadoEN = (ConectadoEN)session.Get (typeof(ConectadoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ConectadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return conectadoEN;
}

public System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN> ReadEmail(string e)
        {
            System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN> result;
            try
            {
                SessionInitializeTransaction();
                //String sql = @"FROM ConectadoEN c self where FROM c where c.email = :email";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery("ConectadoENreadAtributoHQL");
                query.setParameter("email", e);

                result = query.List<OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN>();
                SessionCommit();
            }

            catch (Exception ex)
            {
                SessionRollBack();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                    throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException("Error in ConectadoCAD.", ex);
            }


            finally
            {
                SessionClose();
            }

            return result;
        }

public System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN> ReadAlias(string e)
        {
            System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN> result;
            try
            {
                SessionInitializeTransaction();
                //String sql = @"FROM ConectadoEN c self where FROM c where c.alias = :alias";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery("ConectadoENreadAtributoHQL");
                query.setParameter("alias", e);

                result = query.List<OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN>();
                SessionCommit();
            }

            catch (Exception ex)
            {
                SessionRollBack();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                    throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException("Error in ConectadoCAD.", ex);
            }


            finally
            {
                SessionClose();
            }

            return result;
        }

public System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN> ReadPassword(string e)
        {
            System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN> result;
            try
            {
                SessionInitializeTransaction();
                //String sql = @"FROM ConectadoEN c where c.password = :password";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery("ConectadoENreadAtributoHQL");
                query.setParameter("password", e);

                result = query.List<OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN>();
                SessionCommit();
            }

            catch (Exception ex)
            {
                SessionRollBack();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                    throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException("Error in ConectadoCAD.", ex);
            }


            finally
            {
                SessionClose();
            }

            return result;
        }
       
        




        public void RelFavorito (int p_Conectado_OID, System.Collections.Generic.IList<int> p_esFavorito_OIDs)
{
        OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN conectadoEN = null;
        try
        {
                SessionInitializeTransaction ();
                conectadoEN = (ConectadoEN)session.Load (typeof(ConectadoEN), p_Conectado_OID);
                OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN esFavoritoENAux = null;
                if (conectadoEN.EsFavorito == null) {
                        conectadoEN.EsFavorito = new System.Collections.Generic.List<OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN>();
                }

                foreach (int item in p_esFavorito_OIDs) {
                        esFavoritoENAux = new OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN ();
                        esFavoritoENAux = (OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN)session.Load (typeof(OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN), item);
                        esFavoritoENAux.Favorito.Add (conectadoEN);

                        conectadoEN.EsFavorito.Add (esFavoritoENAux);
                }


                session.Update (conectadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ConectadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void DesFavorito (int p_Conectado_OID, System.Collections.Generic.IList<int> p_esFavorito_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN conectadoEN = null;
                conectadoEN = (ConectadoEN)session.Load (typeof(ConectadoEN), p_Conectado_OID);

                OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN esFavoritoENAux = null;
                if (conectadoEN.EsFavorito != null) {
                        foreach (int item in p_esFavorito_OIDs) {
                                esFavoritoENAux = (OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN)session.Load (typeof(OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN), item);
                                if (conectadoEN.EsFavorito.Contains (esFavoritoENAux) == true) {
                                        conectadoEN.EsFavorito.Remove (esFavoritoENAux);
                                        esFavoritoENAux.Favorito.Remove (conectadoEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_esFavorito_OIDs you are trying to unrelationer, doesn't exist in ConectadoEN");
                        }
                }

                session.Update (conectadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ConectadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void RelPuntuacion (int p_Conectado_OID, System.Collections.Generic.IList<int> p_puntuancion_OIDs)
{
        OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN conectadoEN = null;
        try
        {
                SessionInitializeTransaction ();
                conectadoEN = (ConectadoEN)session.Load (typeof(ConectadoEN), p_Conectado_OID);
                OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN puntuancionENAux = null;
                if (conectadoEN.Puntuancion == null) {
                        conectadoEN.Puntuancion = new System.Collections.Generic.List<OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN>();
                }

                foreach (int item in p_puntuancion_OIDs) {
                        puntuancionENAux = new OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN ();
                        puntuancionENAux = (OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN)session.Load (typeof(OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN), item);
                        puntuancionENAux.Puntua = conectadoEN;

                        conectadoEN.Puntuancion.Add (puntuancionENAux);
                }


                session.Update (conectadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ConectadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void RelComent (int p_Conectado_OID, System.Collections.Generic.IList<int> p_comentario_OIDs)
{
        OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN conectadoEN = null;
        try
        {
                SessionInitializeTransaction ();
                conectadoEN = (ConectadoEN)session.Load (typeof(ConectadoEN), p_Conectado_OID);
                OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN comentarioENAux = null;
                if (conectadoEN.Comentario == null) {
                        conectadoEN.Comentario = new System.Collections.Generic.List<OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN>();
                }

                foreach (int item in p_comentario_OIDs) {
                        comentarioENAux = new OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN ();
                        comentarioENAux = (OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN)session.Load (typeof(OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN), item);
                        comentarioENAux.Escritor = conectadoEN;

                        conectadoEN.Comentario.Add (comentarioENAux);
                }


                session.Update (conectadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ConectadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Suscribir (ConectadoEN conectado)
{
        try
        {
                SessionInitializeTransaction ();
                ConectadoEN conectadoEN = (ConectadoEN)session.Load (typeof(ConectadoEN), conectado.Id);

                conectadoEN.Nombre = conectado.Nombre;


                conectadoEN.Alias = conectado.Alias;


                conectadoEN.FechaRegistro = conectado.FechaRegistro;


                conectadoEN.Password = conectado.Password;


                conectadoEN.Email = conectado.Email;


                conectadoEN.Suscrito = conectado.Suscrito;


                conectadoEN.Imagen = conectado.Imagen;

                session.Update (conectadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ConectadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void UnrelPuntuacion (int p_Conectado_OID, System.Collections.Generic.IList<int> p_puntuancion_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN conectadoEN = null;
                conectadoEN = (ConectadoEN)session.Load (typeof(ConectadoEN), p_Conectado_OID);

                OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN puntuancionENAux = null;
                if (conectadoEN.Puntuancion != null) {
                        foreach (int item in p_puntuancion_OIDs) {
                                puntuancionENAux = (OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN)session.Load (typeof(OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN), item);
                                if (conectadoEN.Puntuancion.Contains (puntuancionENAux) == true) {
                                        conectadoEN.Puntuancion.Remove (puntuancionENAux);
                                        puntuancionENAux.Puntua = null;
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_puntuancion_OIDs you are trying to unrelationer, doesn't exist in ConectadoEN");
                        }
                }

                session.Update (conectadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ConectadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
