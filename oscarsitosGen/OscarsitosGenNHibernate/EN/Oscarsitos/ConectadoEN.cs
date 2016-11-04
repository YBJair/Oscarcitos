
using System;
// Definición clase ConectadoEN
namespace OscarsitosGenNHibernate.EN.Oscarsitos
{
public partial class ConectadoEN                                                                    : OscarsitosGenNHibernate.EN.Oscarsitos.UserEN


{
/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo alias
 */
private string alias;



/**
 *	Atributo fechaRegistro
 */
private Nullable<DateTime> fechaRegistro;



/**
 *	Atributo password
 */
private String password;



/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo comentario
 */
private System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN> comentario;



/**
 *	Atributo suscrito
 */
private bool suscrito;



/**
 *	Atributo esFavorito
 */
private System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN> esFavorito;



/**
 *	Atributo puntuancion
 */
private System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN> puntuancion;



/**
 *	Atributo idioma
 */
private OscarsitosGenNHibernate.EN.Oscarsitos.IdiomaEN idioma;



/**
 *	Atributo imagen
 */
private string imagen;






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Alias {
        get { return alias; } set { alias = value;  }
}



public virtual Nullable<DateTime> FechaRegistro {
        get { return fechaRegistro; } set { fechaRegistro = value;  }
}



public virtual String Password {
        get { return password; } set { password = value;  }
}



public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual bool Suscrito {
        get { return suscrito; } set { suscrito = value;  }
}



public virtual System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN> EsFavorito {
        get { return esFavorito; } set { esFavorito = value;  }
}



public virtual System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN> Puntuancion {
        get { return puntuancion; } set { puntuancion = value;  }
}



public virtual OscarsitosGenNHibernate.EN.Oscarsitos.IdiomaEN Idioma {
        get { return idioma; } set { idioma = value;  }
}



public virtual string Imagen {
        get { return imagen; } set { imagen = value;  }
}





public ConectadoEN() : base ()
{
        comentario = new System.Collections.Generic.List<OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN>();
        esFavorito = new System.Collections.Generic.List<OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN>();
        puntuancion = new System.Collections.Generic.List<OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN>();
}



public ConectadoEN(int id, string nombre, string alias, Nullable<DateTime> fechaRegistro, String password, string email, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN> comentario, bool suscrito, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN> esFavorito, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN> puntuancion, OscarsitosGenNHibernate.EN.Oscarsitos.IdiomaEN idioma, string imagen

                   )
{
        this.init (Id, nombre, alias, fechaRegistro, password, email, comentario, suscrito, esFavorito, puntuancion, idioma, imagen);
}


public ConectadoEN(ConectadoEN conectado)
{
        this.init (Id, conectado.Nombre, conectado.Alias, conectado.FechaRegistro, conectado.Password, conectado.Email, conectado.Comentario, conectado.Suscrito, conectado.EsFavorito, conectado.Puntuancion, conectado.Idioma, conectado.Imagen);
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
        ConectadoEN t = obj as ConectadoEN;
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
