
using System;
// Definición clase UsuarioNoConectEN
namespace OscarsitosGenNHibernate.EN.Oscarsitos
{
public partial class UsuarioNoConectEN
{
/**
 *	Atributo id
 */
private int id;






public virtual int Id {
        get { return id; } set { id = value;  }
}





public UsuarioNoConectEN()
{
}



public UsuarioNoConectEN(int id
                         )
{
        this.init (Id);
}


public UsuarioNoConectEN(UsuarioNoConectEN usuarioNoConect)
{
        this.init (Id);
}

private void init (int id
                   )
{
        this.Id = id;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioNoConectEN t = obj as UsuarioNoConectEN;
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
