

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
 *      Definition of the class UsuarioConectCEN
 *
 */
public partial class UsuarioConectCEN
{
private IUsuarioConectCAD _IUsuarioConectCAD;

public UsuarioConectCEN()
{
        this._IUsuarioConectCAD = new UsuarioConectCAD ();
}

public UsuarioConectCEN(IUsuarioConectCAD _IUsuarioConectCAD)
{
        this._IUsuarioConectCAD = _IUsuarioConectCAD;
}

public IUsuarioConectCAD get_IUsuarioConectCAD ()
{
        return this._IUsuarioConectCAD;
}

public int New_ (string p_nombre, string p_alias, Nullable<DateTime> p_fechaRegistro, String p_password, string p_email, string p_attribute, int p_comentario)
{
        UsuarioConectEN usuarioConectEN = null;
        int oid;

        //Initialized UsuarioConectEN
        usuarioConectEN = new UsuarioConectEN ();
        usuarioConectEN.Nombre = p_nombre;

        usuarioConectEN.Alias = p_alias;

        usuarioConectEN.FechaRegistro = p_fechaRegistro;

        usuarioConectEN.Password = Utils.Util.GetEncondeMD5 (p_password);

        usuarioConectEN.Email = p_email;

        usuarioConectEN.Attribute = p_attribute;


        if (p_comentario != -1) {
                // El argumento p_comentario -> Property comentario es oid = false
                // Lista de oids id
                usuarioConectEN.Comentario = new OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN ();
                usuarioConectEN.Comentario.Id = p_comentario;
        }

        //Call to UsuarioConectCAD

        oid = _IUsuarioConectCAD.New_ (usuarioConectEN);
        return oid;
}

public void Modify (int p_UsuarioConect_OID, string p_nombre, string p_alias, Nullable<DateTime> p_fechaRegistro, String p_password, string p_email, string p_attribute)
{
        UsuarioConectEN usuarioConectEN = null;

        //Initialized UsuarioConectEN
        usuarioConectEN = new UsuarioConectEN ();
        usuarioConectEN.Id = p_UsuarioConect_OID;
        usuarioConectEN.Nombre = p_nombre;
        usuarioConectEN.Alias = p_alias;
        usuarioConectEN.FechaRegistro = p_fechaRegistro;
        usuarioConectEN.Password = Utils.Util.GetEncondeMD5 (p_password);
        usuarioConectEN.Email = p_email;
        usuarioConectEN.Attribute = p_attribute;
        //Call to UsuarioConectCAD

        _IUsuarioConectCAD.Modify (usuarioConectEN);
}

public void Destroy (int id
                     )
{
        _IUsuarioConectCAD.Destroy (id);
}

public System.Collections.Generic.IList<UsuarioConectEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<UsuarioConectEN> list = null;

        list = _IUsuarioConectCAD.ReadAll (first, size);
        return list;
}
public UsuarioConectEN ReadOID (int id
                                )
{
        UsuarioConectEN usuarioConectEN = null;

        usuarioConectEN = _IUsuarioConectCAD.ReadOID (id);
        return usuarioConectEN;
}

public System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.UsuarioConectEN> ReadFilter ()
{
        return _IUsuarioConectCAD.ReadFilter ();
}
}
}
