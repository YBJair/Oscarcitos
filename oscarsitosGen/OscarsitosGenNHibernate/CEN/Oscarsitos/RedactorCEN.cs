

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
 *      Definition of the class RedactorCEN
 *
 */
public partial class RedactorCEN
{
private IRedactorCAD _IRedactorCAD;

public RedactorCEN()
{
        this._IRedactorCAD = new RedactorCAD ();
}
public RedactorCEN(IRedactorCAD _IRedactorCAD)
{
        this._IRedactorCAD = _IRedactorCAD;
}

public IRedactorCAD get_IRedactorCAD ()
{
        return this._IRedactorCAD;
}
public int New_ (string p_nombre, string p_alias, Nullable<DateTime> p_fechaRegistro, String p_password, string p_email, bool p_suscrito, int p_idioma, string p_imagen)
{
        RedactorEN redactorEN = null;
        int oid;

        //Initialized RedactorEN
        redactorEN = new RedactorEN ();
        redactorEN.Nombre = p_nombre;

        redactorEN.Alias = p_alias;

        redactorEN.FechaRegistro = p_fechaRegistro;

        redactorEN.Password = Utils.Util.GetEncondeMD5 (p_password);

        redactorEN.Email = p_email;

        redactorEN.Suscrito = p_suscrito;


        if (p_idioma != -1) {
                // El argumento p_idioma -> Property idioma es oid = false
                // Lista de oids id
                redactorEN.Idioma = new OscarsitosGenNHibernate.EN.Oscarsitos.IdiomaEN ();
                redactorEN.Idioma.Id = p_idioma;
        }

        redactorEN.Imagen = p_imagen;

        //Call to RedactorCAD

        oid = _IRedactorCAD.New_ (redactorEN);
        return oid;
}

public void Modify (int p_Redactor_OID, string p_nombre, string p_alias, Nullable<DateTime> p_fechaRegistro, String p_password, string p_email, bool p_suscrito, string p_imagen)
{
        RedactorEN redactorEN = null;

        //Initialized RedactorEN
        redactorEN = new RedactorEN ();
        redactorEN.Id = p_Redactor_OID;
        redactorEN.Nombre = p_nombre;
        redactorEN.Alias = p_alias;
        redactorEN.FechaRegistro = p_fechaRegistro;
        redactorEN.Password = Utils.Util.GetEncondeMD5 (p_password);
        redactorEN.Email = p_email;
        redactorEN.Suscrito = p_suscrito;
        redactorEN.Imagen = p_imagen;
        //Call to RedactorCAD

        _IRedactorCAD.Modify (redactorEN);
}

public void Destroy (int id
                     )
{
        _IRedactorCAD.Destroy (id);
}

public RedactorEN ReadOID (int id
                           )
{
        RedactorEN redactorEN = null;

        redactorEN = _IRedactorCAD.ReadOID (id);
        return redactorEN;
}

public System.Collections.Generic.IList<RedactorEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RedactorEN> list = null;

        list = _IRedactorCAD.ReadAll (first, size);
        return list;
}
public void RelArticulo (int p_Redactor_OID, System.Collections.Generic.IList<int> p_redactado_OIDs)
{
        //Call to RedactorCAD

        _IRedactorCAD.RelArticulo (p_Redactor_OID, p_redactado_OIDs);
}
}
}
