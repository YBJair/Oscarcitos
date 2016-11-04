
using System;
// Definición clase IdiomaEN
namespace OscarsitosGenNHibernate.EN.Oscarsitos
{
public partial class IdiomaEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo idioma
 */
private string idioma;



/**
 *	Atributo conectado
 */
private System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN> conectado;



/**
 *	Atributo noConectado
 */
private System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.NoConectadoEN> noConectado;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Idioma {
        get { return idioma; } set { idioma = value;  }
}



public virtual System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN> Conectado {
        get { return conectado; } set { conectado = value;  }
}



public virtual System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.NoConectadoEN> NoConectado {
        get { return noConectado; } set { noConectado = value;  }
}





public IdiomaEN()
{
        conectado = new System.Collections.Generic.List<OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN>();
        noConectado = new System.Collections.Generic.List<OscarsitosGenNHibernate.EN.Oscarsitos.NoConectadoEN>();
}



public IdiomaEN(int id, string idioma, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN> conectado, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.NoConectadoEN> noConectado
                )
{
        this.init (Id, idioma, conectado, noConectado);
}


public IdiomaEN(IdiomaEN idioma)
{
        this.init (Id, idioma.Idioma, idioma.Conectado, idioma.NoConectado);
}

private void init (int id
                   , string idioma, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN> conectado, System.Collections.Generic.IList<OscarsitosGenNHibernate.EN.Oscarsitos.NoConectadoEN> noConectado)
{
        this.Id = id;


        this.Idioma = idioma;

        this.Conectado = conectado;

        this.NoConectado = noConectado;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        IdiomaEN t = obj as IdiomaEN;
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
