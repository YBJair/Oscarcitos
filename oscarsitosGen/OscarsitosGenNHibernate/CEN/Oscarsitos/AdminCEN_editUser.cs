
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using OscarsitosGenNHibernate.Exceptions;
using OscarsitosGenNHibernate.EN.Oscarsitos;
using OscarsitosGenNHibernate.CAD.Oscarsitos;


/*PROTECTED REGION ID(usingOscarsitosGenNHibernate.CEN.Oscarsitos_Admin_editUser) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace OscarsitosGenNHibernate.CEN.Oscarsitos
{
public partial class AdminCEN
{
public void EditUser (int p_oid, int p_user)
{
        /*PROTECTED REGION ID(OscarsitosGenNHibernate.CEN.Oscarsitos_Admin_editUser) ENABLED START*/
        AdminCAD _AdminCAD = new AdminCAD();
        UserCAD _IUserCAD = new UserCAD();
        UserEN userEN = new UserEN();

        AdminEN adminEN = _AdminCAD.ReadOIDDefault(p_oid);
        userEN = _IUserCAD.ReadOIDDefault(p_user);
        _IUserCAD.Modify(userEN);
        /*PROTECTED REGION END*/
        }
}
}
