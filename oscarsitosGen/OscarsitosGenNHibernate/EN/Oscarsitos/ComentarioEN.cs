
using System;
// Definición clase ComentarioEN
namespace OscarsitosGenNHibernate.EN.Oscarsitos
{
public partial class ComentarioEN
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
 *	Atributo puntuacion
 */
private int puntuacion;



/**
 *	Atributo escritor
 */
private OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN escritor;



/**
 *	Atributo articulo
 */
private OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN articulo;



/**
 *	Atributo puntuancion
 */
private System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN> puntuancion;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Contenido {
        get { return contenido; } set { contenido = value;  }
}



public virtual int Puntuacion {
        get { return puntuacion; } set { puntuacion = value;  }
}



public virtual OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN Escritor {
        get { return escritor; } set { escritor = value;  }
}



public virtual OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN Articulo {
        get { return articulo; } set { articulo = value;  }
}



public virtual System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN> Puntuancion {
        get { return puntuancion; } set { puntuancion = value;  }
}





public ComentarioEN()
{
        puntuancion = new System.Collections.Generic.List<OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN>();
}



public ComentarioEN(int id, string contenido, int puntuacion, OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN escritor, OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN articulo, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN> puntuancion
                    )
{
        this.init (Id, contenido, puntuacion, escritor, articulo, puntuancion);
}


public ComentarioEN(ComentarioEN comentario)
{
        this.init (Id, comentario.Contenido, comentario.Puntuacion, comentario.Escritor, comentario.Articulo, comentario.Puntuancion);
}

private void init (int id
                   , string contenido, int puntuacion, OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN escritor, OscarsitosGenNHibernate.EN.Oscarsitos.ArticuloEN articulo, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.PuntuancionConectadoEN> puntuancion)
{
        this.Id = id;


        this.Contenido = contenido;

        this.Puntuacion = puntuacion;

        this.Escritor = escritor;

        this.Articulo = articulo;

        this.Puntuancion = puntuancion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ComentarioEN t = obj as ComentarioEN;
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
