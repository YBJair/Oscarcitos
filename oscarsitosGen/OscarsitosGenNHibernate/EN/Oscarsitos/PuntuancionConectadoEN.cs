
using System;
// Definición clase PuntuancionConectadoEN
namespace OscarsitosGenNHibernate.EN.Oscarsitos
{
public partial class PuntuancionConectadoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo puntuacion
 */
private int puntuacion;



/**
 *	Atributo esPuntuado
 */
private OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN esPuntuado;



/**
 *	Atributo puntua
 */
private OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN puntua;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual int Puntuacion {
        get { return puntuacion; } set { puntuacion = value;  }
}



public virtual OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN EsPuntuado {
        get { return esPuntuado; } set { esPuntuado = value;  }
}



public virtual OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN Puntua {
        get { return puntua; } set { puntua = value;  }
}





public PuntuancionConectadoEN()
{
}



public PuntuancionConectadoEN(int id, int puntuacion, OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN esPuntuado, OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN puntua
                              )
{
        this.init (Id, puntuacion, esPuntuado, puntua);
}


public PuntuancionConectadoEN(PuntuancionConectadoEN puntuancionConectado)
{
        this.init (Id, puntuancionConectado.Puntuacion, puntuancionConectado.EsPuntuado, puntuancionConectado.Puntua);
}

private void init (int id
                   , int puntuacion, OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN esPuntuado, OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN puntua)
{
        this.Id = id;


        this.Puntuacion = puntuacion;

        this.EsPuntuado = esPuntuado;

        this.Puntua = puntua;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PuntuancionConectadoEN t = obj as PuntuancionConectadoEN;
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
