
using System;
using OscarsitosGenNHibernate.EN.Oscarsitos;

namespace OscarsitosGenNHibernate.CAD.Oscarsitos
{
public partial interface IPuntuancionConectadoCAD
{
PuntuancionConectadoEN ReadOIDDefault (int id
                                       );
PuntuancionConectadoEN ReadUser(int id
                                       );
PuntuancionConectadoEN ReadComentario(int id
                                       );
        System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN> ReadUserComentario(int id_user, int id_coment);



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
