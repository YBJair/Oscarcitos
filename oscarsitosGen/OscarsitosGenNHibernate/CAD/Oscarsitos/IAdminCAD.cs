
using System;
using OscarsitosGenNHibernate.EN.Oscarsitos;

namespace OscarsitosGenNHibernate.CAD.Oscarsitos
{
public partial interface IAdminCAD
{
AdminEN ReadOIDDefault (int id
                        );

void ModifyDefault (AdminEN admin);



int New_ (AdminEN admin);

void Modify (AdminEN admin);


void Destroy (int id
              );





AdminEN ReadOID (int id
                 );


System.Collections.Generic.IList<AdminEN> ReadAll (int first, int size);
}
}
