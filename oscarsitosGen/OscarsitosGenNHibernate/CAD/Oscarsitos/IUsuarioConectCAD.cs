
using System;
using OscarsitosGenNHibernate.EN.Oscarsitos;

namespace OscarsitosGenNHibernate.CAD.Oscarsitos
{
public partial interface IUsuarioConectCAD
{
UsuarioConectEN ReadOIDDefault (int id
                                );

void ModifyDefault (UsuarioConectEN usuarioConect);



int New_ (UsuarioConectEN usuarioConect);

void Modify (UsuarioConectEN usuarioConect);


void Destroy (int id
              );


System.Collections.Generic.IList<UsuarioConectEN> ReadAll (int first, int size);


UsuarioConectEN ReadOID (int id
                         );


System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.UsuarioConectEN> ReadFilter ();
}
}
