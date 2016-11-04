
using System;
using OscarsitosGenNHibernate.EN.Oscarsitos;

namespace OscarsitosGenNHibernate.CAD.Oscarsitos
{
public partial interface INoConectadoCAD
{
NoConectadoEN ReadOIDDefault (int id
                              );

void ModifyDefault (NoConectadoEN noConectado);



int New_ (NoConectadoEN noConectado);

void Destroy (int id
              );
}
}
