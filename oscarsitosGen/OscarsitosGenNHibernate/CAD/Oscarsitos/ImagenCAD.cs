
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
 * Clase Imagen:
 *
 */

namespace OscarsitosGenNHibernate.CAD.Oscarsitos
{
public partial class ImagenCAD : BasicCAD, IImagenCAD
{
public ImagenCAD() : base ()
{
}

public ImagenCAD(ISession sessionAux) : base (sessionAux)
{
}



public ImagenEN ReadOIDDefault (int id
                                )
{
        ImagenEN imagenEN = null;

        try
        {
                SessionInitializeTransaction ();
                imagenEN = (ImagenEN)session.Get (typeof(ImagenEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ImagenCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return imagenEN;
}

public System.Collections.Generic.IList<ImagenEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ImagenEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ImagenEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ImagenEN>();
                        else
                                result = session.CreateCriteria (typeof(ImagenEN)).List<ImagenEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ImagenCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ImagenEN imagen)
{
        try
        {
                SessionInitializeTransaction ();
                ImagenEN imagenEN = (ImagenEN)session.Load (typeof(ImagenEN), imagen.Id);
                session.Update (imagenEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OscarsitosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OscarsitosGenNHibernate.Exceptions.DataLayerException ("Error in ImagenCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
