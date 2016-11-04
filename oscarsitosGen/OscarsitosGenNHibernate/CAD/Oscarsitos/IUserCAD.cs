
using System;
using OscarsitosGenNHibernate.EN.Oscarsitos;

namespace OscarsitosGenNHibernate.CAD.Oscarsitos
{
public partial interface IUserCAD
{
UserEN ReadOIDDefault (int id
                       );

void ModifyDefault (UserEN user);



int New_ (UserEN user);

void Modify (UserEN user);


void Destroy (int id
              );
}
}
