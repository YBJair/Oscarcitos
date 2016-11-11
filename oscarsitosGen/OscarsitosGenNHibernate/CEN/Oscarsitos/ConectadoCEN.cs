

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
 *      Definition of the class ConectadoCEN
 *
 */
public partial class ConectadoCEN
{
private IConectadoCAD _IConectadoCAD;

public ConectadoCEN()
{
        this._IConectadoCAD = new ConectadoCAD ();
}

public ConectadoCEN(IConectadoCAD _IConectadoCAD)
{
        this._IConectadoCAD = _IConectadoCAD;
}

public IConectadoCAD get_IConectadoCAD ()
{
        return this._IConectadoCAD;
}

public int New_ (string p_nombre, string p_alias, Nullable<DateTime> p_fechaRegistro, String p_password, string p_email, bool p_suscrito, int p_idioma, string p_imagen)
{
        ConectadoEN conectadoEN = null;
        int oid;

        //Initialized ConectadoEN
        conectadoEN = new ConectadoEN ();
        conectadoEN.Nombre = p_nombre;

        conectadoEN.Alias = p_alias;

        conectadoEN.FechaRegistro = p_fechaRegistro;

        conectadoEN.Password = Utils.Util.GetEncondeMD5 (p_password);

        conectadoEN.Email = p_email;

        conectadoEN.Suscrito = p_suscrito;


        if (p_idioma != -1) {
                // El argumento p_idioma -> Property idioma es oid = false
                // Lista de oids id
                conectadoEN.Idioma = new OscarsitosGenNHibernate.EN.Oscarsitos.IdiomaEN ();
                conectadoEN.Idioma.Id = p_idioma;
        }

        conectadoEN.Imagen = p_imagen;

        //Call to ConectadoCAD

        oid = _IConectadoCAD.New_ (conectadoEN);
        return oid;
}

public void Modify (int p_Conectado_OID, string p_nombre, string p_alias, Nullable<DateTime> p_fechaRegistro, String p_password, string p_email, bool p_suscrito, string p_imagen)
{
        ConectadoEN conectadoEN = null;

        //Initialized ConectadoEN
        conectadoEN = new ConectadoEN ();
        conectadoEN.Id = p_Conectado_OID;
        conectadoEN.Nombre = p_nombre;
        conectadoEN.Alias = p_alias;
        conectadoEN.FechaRegistro = p_fechaRegistro;
        conectadoEN.Password = Utils.Util.GetEncondeMD5 (p_password);
        conectadoEN.Email = p_email;
        conectadoEN.Suscrito = p_suscrito;
        conectadoEN.Imagen = p_imagen;
        //Call to ConectadoCAD

        _IConectadoCAD.Modify (conectadoEN);
}

public void Destroy (int id
                     )
{
        _IConectadoCAD.Destroy (id);
}

public System.Collections.Generic.IList<ConectadoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ConectadoEN> list = null;

        list = _IConectadoCAD.ReadAll (first, size);
        return list;
}
public ConectadoEN ReadOID (int id
                            )
{
        ConectadoEN conectadoEN = null;

        conectadoEN = _IConectadoCAD.ReadOID (id);
        return conectadoEN;
}

public void RelFavorito (int p_Conectado_OID, System.Collections.Generic.IList<int> p_esFavorito_OIDs)
{
        //Call to ConectadoCAD

        _IConectadoCAD.RelFavorito (p_Conectado_OID, p_esFavorito_OIDs);
}
public void DesFavorito (int p_Conectado_OID, System.Collections.Generic.IList<int> p_esFavorito_OIDs)
{
        //Call to ConectadoCAD

        _IConectadoCAD.DesFavorito (p_Conectado_OID, p_esFavorito_OIDs);
}
public void RelPuntuacion (int p_Conectado_OID, System.Collections.Generic.IList<int> p_puntuancion_OIDs)
{
        //Call to ConectadoCAD

        _IConectadoCAD.RelPuntuacion (p_Conectado_OID, p_puntuancion_OIDs);
}
public void RelComent (int p_Conectado_OID, System.Collections.Generic.IList<int> p_comentario_OIDs)
{
        //Call to ConectadoCAD

        _IConectadoCAD.RelComent (p_Conectado_OID, p_comentario_OIDs);
}
public void Suscribir (int id)
{
            //Debería haber sido custom y no modify. Errores de novato
            ConectadoCEN conectadoCEN = new ConectadoCEN(_IConectadoCAD);
            ConectadoEN conectado = conectadoCEN.ReadOID(id);

            if(conectado.Suscrito == true)
               conectadoCEN.Modify(conectado.Id, conectado.Nombre, conectado.Alias, conectado.FechaRegistro, conectado.Password, conectado.Email,
                 false, conectado.Imagen);
            else
                conectadoCEN.Modify(conectado.Id, conectado.Nombre, conectado.Alias, conectado.FechaRegistro, conectado.Password, conectado.Email,
                 true, conectado.Imagen);

            _IConectadoCAD.Suscribir(conectado);

        }

public void UnrelPuntuacion (int p_Conectado_OID, System.Collections.Generic.IList<int> p_puntuancion_OIDs)
{
        //Call to ConectadoCAD

        _IConectadoCAD.UnrelPuntuacion (p_Conectado_OID, p_puntuancion_OIDs);
}
public void UnrelComent(int p_Conectado_OID, System.Collections.Generic.IList<int> p_puntuancion_OIDs)
{
            //Call to ConectadoCAD

_IConectadoCAD.UnrelPuntuacion(p_Conectado_OID, p_puntuancion_OIDs);
}
    }
}
