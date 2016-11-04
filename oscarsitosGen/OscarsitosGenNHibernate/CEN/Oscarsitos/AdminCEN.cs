

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
 *      Definition of the class AdminCEN
 *
 */
public partial class AdminCEN
{
private IAdminCAD _IAdminCAD;

public AdminCEN()
{
        this._IAdminCAD = new AdminCAD ();
}

public AdminCEN(IAdminCAD _IAdminCAD)
{
        this._IAdminCAD = _IAdminCAD;
}

public IAdminCAD get_IAdminCAD ()
{
        return this._IAdminCAD;
}

public int New_ (string p_nombre, string p_alias, Nullable<DateTime> p_fechaRegistro, String p_password, string p_email, bool p_suscrito, int p_idioma, string p_imagen)
{
        AdminEN adminEN = null;
        int oid;

        //Initialized AdminEN
        adminEN = new AdminEN ();
        adminEN.Nombre = p_nombre;

        adminEN.Alias = p_alias;

        adminEN.FechaRegistro = p_fechaRegistro;

        adminEN.Password = Utils.Util.GetEncondeMD5 (p_password);

        adminEN.Email = p_email;

        adminEN.Suscrito = p_suscrito;


        if (p_idioma != -1) {
                // El argumento p_idioma -> Property idioma es oid = false
                // Lista de oids id
                adminEN.Idioma = new OscarsitosGenNHibernate.EN.Oscarsitos.IdiomaEN ();
                adminEN.Idioma.Id = p_idioma;
        }

        adminEN.Imagen = p_imagen;

        //Call to AdminCAD

        oid = _IAdminCAD.New_ (adminEN);
        return oid;
}

public void Modify (int p_Admin_OID, string p_nombre, string p_alias, Nullable<DateTime> p_fechaRegistro, String p_password, string p_email, bool p_suscrito, string p_imagen)
{
        AdminEN adminEN = null;

        //Initialized AdminEN
        adminEN = new AdminEN ();
        adminEN.Id = p_Admin_OID;
        adminEN.Nombre = p_nombre;
        adminEN.Alias = p_alias;
        adminEN.FechaRegistro = p_fechaRegistro;
        adminEN.Password = Utils.Util.GetEncondeMD5 (p_password);
        adminEN.Email = p_email;
        adminEN.Suscrito = p_suscrito;
        adminEN.Imagen = p_imagen;
        //Call to AdminCAD

        _IAdminCAD.Modify (adminEN);
}

public void Destroy (int id
                     )
{
        _IAdminCAD.Destroy (id);
}

public AdminEN ReadOID (int id
                        )
{
        AdminEN adminEN = null;

        adminEN = _IAdminCAD.ReadOID (id);
        return adminEN;
}

public System.Collections.Generic.IList<AdminEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AdminEN> list = null;

        list = _IAdminCAD.ReadAll (first, size);
        return list;
}
}
}
