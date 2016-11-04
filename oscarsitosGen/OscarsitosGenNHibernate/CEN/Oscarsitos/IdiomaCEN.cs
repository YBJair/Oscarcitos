

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
 *      Definition of the class IdiomaCEN
 *
 */
public partial class IdiomaCEN
{
private IIdiomaCAD _IIdiomaCAD;

public IdiomaCEN()
{
        this._IIdiomaCAD = new IdiomaCAD ();
}

public IdiomaCEN(IIdiomaCAD _IIdiomaCAD)
{
        this._IIdiomaCAD = _IIdiomaCAD;
}

public IIdiomaCAD get_IIdiomaCAD ()
{
        return this._IIdiomaCAD;
}

public int New_ (string p_idioma)
{
        IdiomaEN idiomaEN = null;
        int oid;

        //Initialized IdiomaEN
        idiomaEN = new IdiomaEN ();
        idiomaEN.Idioma = p_idioma;

        //Call to IdiomaCAD

        oid = _IIdiomaCAD.New_ (idiomaEN);
        return oid;
}

public void Modify (int p_Idioma_OID, string p_idioma)
{
        IdiomaEN idiomaEN = null;

        //Initialized IdiomaEN
        idiomaEN = new IdiomaEN ();
        idiomaEN.Id = p_Idioma_OID;
        idiomaEN.Idioma = p_idioma;
        //Call to IdiomaCAD

        _IIdiomaCAD.Modify (idiomaEN);
}

public void Destroy (int id
                     )
{
        _IIdiomaCAD.Destroy (id);
}

public IdiomaEN ReadOID (int id
                         )
{
        IdiomaEN idiomaEN = null;

        idiomaEN = _IIdiomaCAD.ReadOID (id);
        return idiomaEN;
}

public System.Collections.Generic.IList<IdiomaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IdiomaEN> list = null;

        list = _IIdiomaCAD.ReadAll (first, size);
        return list;
}
}
}
