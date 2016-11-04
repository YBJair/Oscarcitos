
using System;
// Definición clase ImagenEN
namespace OscarsitosGenNHibernate.EN.Oscarsitos
{
public partial class ImagenEN
{
/**
 *	Atributo id
 */
private int id;






public virtual int Id {
        get { return id; } set { id = value;  }
}





public ImagenEN()
{
}



public ImagenEN(int id
                )
{
        this.init (Id);
}


public ImagenEN(ImagenEN imagen)
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
        ImagenEN t = obj as ImagenEN;
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
