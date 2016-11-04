

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
 *      Definition of the class UserCEN
 *
 */
public partial class UserCEN
{
private IUserCAD _IUserCAD;

public UserCEN()
{
        this._IUserCAD = new UserCAD ();
}

public UserCEN(IUserCAD _IUserCAD)
{
        this._IUserCAD = _IUserCAD;
}

public IUserCAD get_IUserCAD ()
{
        return this._IUserCAD;
}

public int New_ ()
{
        UserEN userEN = null;
        int oid;

        //Initialized UserEN
        userEN = new UserEN ();
        //Call to UserCAD

        oid = _IUserCAD.New_ (userEN);
        return oid;
}

public void Modify (int p_User_OID)
{
        UserEN userEN = null;

        //Initialized UserEN
        userEN = new UserEN ();
        userEN.Id = p_User_OID;
        //Call to UserCAD

        _IUserCAD.Modify (userEN);
}

public void Destroy (int id
                     )
{
        _IUserCAD.Destroy (id);
}
}
}
