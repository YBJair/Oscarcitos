
using System;
// Definición clase AdminEN
namespace OscarsitosGenNHibernate.EN.Oscarsitos
{
public partial class AdminEN                                                                        : OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN


{
public AdminEN() : base ()
{
}



public AdminEN(int id,
               string nombre, string alias, Nullable<DateTime> fechaRegistro, String password, string email, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN> comentario, bool suscrito, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN> esFavorito, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN> puntuancion, OscarsitosGenNHibernate.EN.Oscarsitos.IdiomaEN idioma, string imagen

               )
{
        this.init (Id, nombre, alias, fechaRegistro, password, email, comentario, suscrito, esFavorito, puntuancion, idioma, imagen);
}


public AdminEN(AdminEN admin)
{
        this.init (Id, admin.Nombre, admin.Alias, admin.FechaRegistro, admin.Password, admin.Email, admin.Comentario, admin.Suscrito, admin.EsFavorito, admin.Puntuancion, admin.Idioma, admin.Imagen);
}

private void init (int id
                   , string nombre, string alias, Nullable<DateTime> fechaRegistro, String password, string email, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN> comentario, bool suscrito, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN> esFavorito, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN> puntuancion, OscarsitosGenNHibernate.EN.Oscarsitos.IdiomaEN idioma, string imagen)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Alias = alias;

        this.FechaRegistro = fechaRegistro;

        this.Password = password;

        this.Email = email;

        this.Comentario = comentario;

        this.Suscrito = suscrito;

        this.EsFavorito = esFavorito;

        this.Puntuancion = puntuancion;

        this.Idioma = idioma;

        this.Imagen = imagen;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AdminEN t = obj as AdminEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
