
using System;
// Definición clase RedactorEN
namespace OscarsitosGenNHibernate.EN.Oscarsitos
{
public partial class RedactorEN                                                                     : OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN


{
/**
 *	Atributo redactado
 */
private System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN> redactado;






public virtual System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN> Redactado {
        get { return redactado; } set { redactado = value;  }
}





public RedactorEN() : base ()
{
        redactado = new System.Collections.Generic.List<OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN>();
}



public RedactorEN(int id, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN> redactado,
                  string nombre, string alias, Nullable<DateTime> fechaRegistro, String password, string email, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN> comentario, bool suscrito, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN> esFavorito, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN> puntuancion, OscarsitosGenNHibernate.EN.Oscarsitos.IdiomaEN idioma, string imagen

                  )
{
        this.init (Id, redactado, nombre, alias, fechaRegistro, password, email, comentario, suscrito, esFavorito, puntuancion, idioma, imagen);
}


public RedactorEN(RedactorEN redactor)
{
        this.init (Id, redactor.Redactado, redactor.Nombre, redactor.Alias, redactor.FechaRegistro, redactor.Password, redactor.Email, redactor.Comentario, redactor.Suscrito, redactor.EsFavorito, redactor.Puntuancion, redactor.Idioma, redactor.Imagen);
}

private void init (int id
                   , System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN> redactado, string nombre, string alias, Nullable<DateTime> fechaRegistro, String password, string email, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN> comentario, bool suscrito, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN> esFavorito, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN> puntuancion, OscarsitosGenNHibernate.EN.Oscarsitos.IdiomaEN idioma, string imagen)
{
        this.Id = id;


        this.Redactado = redactado;

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
        RedactorEN t = obj as RedactorEN;
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
