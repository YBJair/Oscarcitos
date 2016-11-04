
using System;
// Definición clase NoConectadoEN
namespace OscarsitosGenNHibernate.EN.Oscarsitos
{
public partial class NoConectadoEN                                                                  : OscarsitosGenNHibernate.EN.Oscarsitos.UserEN


{
/**
 *	Atributo idioma_0
 */
private OscarsitosGenNHibernate.EN.Oscarsitos.IdiomaEN idioma_0;






public virtual OscarsitosGenNHibernate.EN.Oscarsitos.IdiomaEN Idioma_0 {
        get { return idioma_0; } set { idioma_0 = value;  }
}





public NoConectadoEN() : base ()
{
}



public NoConectadoEN(int id, OscarsitosGenNHibernate.EN.Oscarsitos.IdiomaEN idioma_0

                     )
{
        this.init (Id, idioma_0);
}


public NoConectadoEN(NoConectadoEN noConectado)
{
        this.init (Id, noConectado.Idioma_0);
}

private void init (int id
                   , OscarsitosGenNHibernate.EN.Oscarsitos.IdiomaEN idioma_0)
{
        this.Id = id;


        this.Idioma_0 = idioma_0;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        NoConectadoEN t = obj as NoConectadoEN;
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
