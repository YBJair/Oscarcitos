
using System;
// Definición clase UserEN
namespace OscarsitosGenNHibernate.EN.Oscarsitos
{
public partial class UserEN
{
/**
 *	Atributo id
 */
private int id;






public virtual int Id {
        get { return id; } set { id = value;  }
}





public UserEN()
{
}



public UserEN(int id
              )
{
        this.init (Id);
}


public UserEN(UserEN user)
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
        UserEN t = obj as UserEN;
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
