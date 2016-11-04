
using System;
// Definición clase ArticuloEN
namespace OscarsitosGenNHibernate.EN.Oscarsitos
{
public partial class ArticuloEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo contenido
 */
private string contenido;



/**
 *	Atributo fechaPubli
 */
private Nullable<DateTime> fechaPubli;



/**
 *	Atributo categoria
 */
private OscarsitosGenNHibernate.Enumerated.Oscarsitos.CategArticuloEnum categoria;



/**
 *	Atributo titulo
 */
private string titulo;



/**
 *	Atributo redacta
 */
private OscarsitosGenNHibernate.EN.Oscarsitos.RedactorEN redacta;



/**
 *	Atributo comentario
 */
private System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN> comentario;



/**
 *	Atributo favorito
 */
private System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN> favorito;



/**
 *	Atributo titular
 */
private bool titular;



/**
 *	Atributo visible
 */
private bool visible;



/**
 *	Atributo imagen
 */
private string imagen;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Contenido {
        get { return contenido; } set { contenido = value;  }
}



public virtual Nullable<DateTime> FechaPubli {
        get { return fechaPubli; } set { fechaPubli = value;  }
}



public virtual OscarsitosGenNHibernate.Enumerated.Oscarsitos.CategArticuloEnum Categoria {
        get { return categoria; } set { categoria = value;  }
}



public virtual string Titulo {
        get { return titulo; } set { titulo = value;  }
}



public virtual OscarsitosGenNHibernate.EN.Oscarsitos.RedactorEN Redacta {
        get { return redacta; } set { redacta = value;  }
}



public virtual System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN> Favorito {
        get { return favorito; } set { favorito = value;  }
}



public virtual bool Titular {
        get { return titular; } set { titular = value;  }
}



public virtual bool Visible {
        get { return visible; } set { visible = value;  }
}



public virtual string Imagen {
        get { return imagen; } set { imagen = value;  }
}





public ArticuloEN()
{
        comentario = new System.Collections.Generic.List<OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN>();
        favorito = new System.Collections.Generic.List<OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN>();
}



public ArticuloEN(int id, string contenido, Nullable<DateTime> fechaPubli, OscarsitosGenNHibernate.Enumerated.Oscarsitos.CategArticuloEnum categoria, string titulo, OscarsitosGenNHibernate.EN.Oscarsitos.RedactorEN redacta, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN> comentario, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN> favorito, bool titular, bool visible, string imagen
                  )
{
        this.init (Id, contenido, fechaPubli, categoria, titulo, redacta, comentario, favorito, titular, visible, imagen);
}


public ArticuloEN(ArticuloEN articulo)
{
        this.init (Id, articulo.Contenido, articulo.FechaPubli, articulo.Categoria, articulo.Titulo, articulo.Redacta, articulo.Comentario, articulo.Favorito, articulo.Titular, articulo.Visible, articulo.Imagen);
}

private void init (int id
                   , string contenido, Nullable<DateTime> fechaPubli, OscarsitosGenNHibernate.Enumerated.Oscarsitos.CategArticuloEnum categoria, string titulo, OscarsitosGenNHibernate.EN.Oscarsitos.RedactorEN redacta, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN> comentario, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN> favorito, bool titular, bool visible, string imagen)
{
        this.Id = id;


        this.Contenido = contenido;

        this.FechaPubli = fechaPubli;

        this.Categoria = categoria;

        this.Titulo = titulo;

        this.Redacta = redacta;

        this.Comentario = comentario;

        this.Favorito = favorito;

        this.Titular = titular;

        this.Visible = visible;

        this.Imagen = imagen;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ArticuloEN t = obj as ArticuloEN;
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
