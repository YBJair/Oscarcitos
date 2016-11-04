
using System;
using OscarsitosGenNHibernate.EN.Oscarsitos;

namespace OscarsitosGenNHibernate.CAD.Oscarsitos
{
public partial interface IUsuarioNoConectCAD
{
UsuarioNoConectEN ReadOIDDefault (int id
                                  );

void ModifyDefault (UsuarioNoConectEN usuarioNoConect);
}
}
