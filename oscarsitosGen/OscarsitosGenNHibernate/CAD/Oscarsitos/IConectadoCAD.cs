
using System;
using OscarsitosGenNHibernate.EN.Oscarsitos;

namespace OscarsitosGenNHibernate.CAD.Oscarsitos
{
public partial interface IConectadoCAD
{
ConectadoEN ReadOIDDefault (int id
                            );
ConectadoEN ReadAlias(string alias
                            );
ConectadoEN ReadEmail(string email
                            );
ConectadoEN ReadPassword(string password
                            );

void ModifyDefault (ConectadoEN conectado);



int New_ (ConectadoEN conectado);

void Modify (ConectadoEN conectado);


void Destroy (int id
              );


System.Collections.Generic.IList<ConectadoEN> ReadAll (int first, int size);


ConectadoEN ReadOID (int id
                     );


void RelFavorito (int p_Conectado_OID, System.Collections.Generic.IList<int> p_esFavorito_OIDs);

void DesFavorito (int p_Conectado_OID, System.Collections.Generic.IList<int> p_esFavorito_OIDs);



void RelPuntuacion (int p_Conectado_OID, System.Collections.Generic.IList<int> p_puntuancion_OIDs);

void RelComent (int p_Conectado_OID, System.Collections.Generic.IList<int> p_comentario_OIDs);

void Suscribir (ConectadoEN conectado);



void UnrelPuntuacion (int p_Conectado_OID, System.Collections.Generic.IList<int> p_puntuancion_OIDs);
}
}
