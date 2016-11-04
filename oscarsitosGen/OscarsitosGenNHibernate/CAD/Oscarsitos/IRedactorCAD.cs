
using System;
using OscarsitosGenNHibernate.EN.Oscarsitos;

namespace OscarsitosGenNHibernate.CAD.Oscarsitos
{
public partial interface IRedactorCAD
{
RedactorEN ReadOIDDefault (int id
                           );

void ModifyDefault (RedactorEN redactor);



int New_ (RedactorEN redactor);

void Modify (RedactorEN redactor);


void Destroy (int id
              );




RedactorEN ReadOID (int id
                    );


System.Collections.Generic.IList<RedactorEN> ReadAll (int first, int size);


void RelArticulo (int p_Redactor_OID, System.Collections.Generic.IList<int> p_redactado_OIDs);
}
}
