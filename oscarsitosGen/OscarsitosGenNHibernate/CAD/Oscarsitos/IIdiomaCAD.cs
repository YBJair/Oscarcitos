
using System;
using OscarsitosGenNHibernate.EN.Oscarsitos;

namespace OscarsitosGenNHibernate.CAD.Oscarsitos
{
public partial interface IIdiomaCAD
{
IdiomaEN ReadOIDDefault (int id
                         );

void ModifyDefault (IdiomaEN idioma);



int New_ (IdiomaEN idioma);

void Modify (IdiomaEN idioma);


void Destroy (int id
              );


IdiomaEN ReadOID (int id
                  );


System.Collections.Generic.IList<IdiomaEN> ReadAll (int first, int size);
}
}
