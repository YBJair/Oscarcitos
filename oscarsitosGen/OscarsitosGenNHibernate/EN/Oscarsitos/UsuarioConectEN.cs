
using System;
// Definición clase UsuarioConectEN
namespace OscarsitosGenNHibernate.EN.Oscarsitos
{
public partial class UsuarioConectEN
{
/**
 *	Atributo id
 */
private int id;



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
 *	Atributo attribute
 */
private string attribute;



/**
 *	Atributo comentario
 */
private OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN comentario;






public virtual int Id {
        get { return id; } set { id = value;  }
}



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



public virtual string Attribute {
        get { return attribute; } set { attribute = value;  }
}



public virtual OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN Comentario {
        get { return comentario; } set { comentario = value;  }
}





public UsuarioConectEN()
{
}



public UsuarioConectEN(int id, string nombre, string alias, Nullable<DateTime> fechaRegistro, String password, string email, string attribute, OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN comentario
                       )
{
        this.init (Id, nombre, alias, fechaRegistro, password, email, attribute, comentario);
}


public UsuarioConectEN(UsuarioConectEN usuarioConect)
{
        this.init (Id, usuarioConect.Nombre, usuarioConect.Alias, usuarioConect.FechaRegistro, usuarioConect.Password, usuarioConect.Email, usuarioConect.Attribute, usuarioConect.Comentario);
}

private void init (int id
                   , string nombre, string alias, Nullable<DateTime> fechaRegistro, String password, string email, string attribute, OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN comentario)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Alias = alias;

        this.FechaRegistro = fechaRegistro;

        this.Password = password;

        this.Email = email;

        this.Attribute = attribute;

        this.Comentario = comentario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioConectEN t = obj as UsuarioConectEN;
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
