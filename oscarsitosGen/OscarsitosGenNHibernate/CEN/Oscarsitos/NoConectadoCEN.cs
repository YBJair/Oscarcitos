

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using OscarsitosGenNHibernate.Exceptions;

using OscarsitosGenNHibernate.EN.Oscarsitos;
using OscarsitosGenNHibernate.CAD.Oscarsitos;


namespace OscarsitosGenNHibernate.CEN.Oscarsitos
{
/*
 *      Definition of the class NoConectadoCEN
 *
 */
public partial class NoConectadoCEN
{
private INoConectadoCAD _INoConectadoCAD;

public NoConectadoCEN()
{
        this._INoConectadoCAD = new NoConectadoCAD ();
}

public NoConectadoCEN(INoConectadoCAD _INoConectadoCAD)
{
        this._INoConectadoCAD = _INoConectadoCAD;
}

public INoConectadoCAD get_INoConectadoCAD ()
{
        return this._INoConectadoCAD;
}

public int New_ (int p_idioma_0)
{
        NoConectadoEN noConectadoEN = null;
        int oid;

        //Initialized NoConectadoEN
        noConectadoEN = new NoConectadoEN ();

        if (p_idioma_0 != -1) {
                // El argumento p_idioma_0 -> Property idioma_0 es oid = false
                // Lista de oids id
                noConectadoEN.Idioma_0 = new OscarsitosGenNHibernate.EN.Oscarsitos.IdiomaEN ();
                noConectadoEN.Idioma_0.Id = p_idioma_0;
        }

        //Call to NoConectadoCAD

        oid = _INoConectadoCAD.New_ (noConectadoEN);
        return oid;
}

public void Destroy (int id
                     )
{
        _INoConectadoCAD.Destroy (id);
}
}
}
