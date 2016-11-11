
using System;
using OscarsitosGenNHibernate.EN.Oscarsitos;

namespace OscarsitosGenNHibernate.CAD.Oscarsitos
{
public partial interface IArticuloCAD
{
ArticuloEN ReadOIDDefault (int id
                           );

void ModifyDefault (ArticuloEN articulo);



int New_ (ArticuloEN articulo);

void Destroy (int id
              );


void Modify (ArticuloEN articulo);


System.Collections.Generic.IList<ArticuloEN> ReadAll (int first, int size);


ArticuloEN ReadOID (int id
                    );



System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN> ReadPublisher (int p_publisher_oid);


void RelComentario (int p_Articulo_OID, System.Collections.Generic.IList<int> p_comentario_OIDs);

void UnrelComentario (int p_Articulo_OID, System.Collections.Generic.IList<int> p_comentario_OIDs);
}
}
