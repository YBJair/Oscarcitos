

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
 *      Definition of the class UsuarioNoConectCEN
 *
 */
public partial class UsuarioNoConectCEN
{
private IUsuarioNoConectCAD _IUsuarioNoConectCAD;

public UsuarioNoConectCEN()
{
        this._IUsuarioNoConectCAD = new UsuarioNoConectCAD ();
}

public UsuarioNoConectCEN(IUsuarioNoConectCAD _IUsuarioNoConectCAD)
{
        this._IUsuarioNoConectCAD = _IUsuarioNoConectCAD;
}

public IUsuarioNoConectCAD get_IUsuarioNoConectCAD ()
{
        return this._IUsuarioNoConectCAD;
}
}
}
