
using System;
using OscarsitosGenNHibernate.EN.Oscarsitos;

namespace OscarsitosGenNHibernate.CAD.Oscarsitos
{
public partial interface IPuntuancionConectadoCAD
{
PuntuancionConectadoEN ReadOIDDefault (int id
                                       );

void ModifyDefault (PuntuancionConectadoEN puntuancionConectado);



int New_ (PuntuancionConectadoEN puntuancionConectado);

void Modify (PuntuancionConectadoEN puntuancionConectado);


void Destroy (int id
              );


PuntuancionConectadoEN ReadOID (int id
                                );


System.Collections.Generic.IList<PuntuancionConectadoEN> ReadAll (int first, int size);
}
}
