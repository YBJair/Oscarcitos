
using System;
using OscarsitosGenNHibernate.EN.Oscarsitos;

namespace OscarsitosGenNHibernate.CAD.Oscarsitos
{
public partial interface IImagenCAD
{
ImagenEN ReadOIDDefault (int id
                         );

void ModifyDefault (ImagenEN imagen);
}
}
