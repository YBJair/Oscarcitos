

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
 *      Definition of the class PuntuancionConectadoCEN
 *
 */
public partial class PuntuancionConectadoCEN
{
private IPuntuancionConectadoCAD _IPuntuancionConectadoCAD;

public PuntuancionConectadoCEN()
{
        this._IPuntuancionConectadoCAD = new PuntuancionConectadoCAD ();
}

public PuntuancionConectadoCEN(IPuntuancionConectadoCAD _IPuntuancionConectadoCAD)
{
        this._IPuntuancionConectadoCAD = _IPuntuancionConectadoCAD;
}

public IPuntuancionConectadoCAD get_IPuntuancionConectadoCAD ()
{
        return this._IPuntuancionConectadoCAD;
}

public int New_ (int p_puntuacion, int p_esPuntuado, int p_puntua)
{
        PuntuancionConectadoEN puntuancionConectadoEN = null;
        int oid;

        //Initialized PuntuancionConectadoEN
        puntuancionConectadoEN = new PuntuancionConectadoEN ();
        puntuancionConectadoEN.Puntuacion = p_puntuacion;


        if (p_esPuntuado != -1) {
                // El argumento p_esPuntuado -> Property esPuntuado es oid = false
                // Lista de oids id
                puntuancionConectadoEN.EsPuntuado = new OscarsitosGenNHibernate.EN.Oscarsitos.ComentarioEN ();
                puntuancionConectadoEN.EsPuntuado.Id = p_esPuntuado;
        }


        if (p_puntua != -1) {
                // El argumento p_puntua -> Property puntua es oid = false
                // Lista de oids id
                puntuancionConectadoEN.Puntua = new OscarsitosGenNHibernate.EN.Oscarsitos.ConectadoEN ();
                puntuancionConectadoEN.Puntua.Id = p_puntua;
        }

        //Call to PuntuancionConectadoCAD

        oid = _IPuntuancionConectadoCAD.New_ (puntuancionConectadoEN);
        return oid;
}

public void Modify (int p_puntuancionConectado_OID, int p_puntuacion)
{
        PuntuancionConectadoEN puntuancionConectadoEN = null;

        //Initialized PuntuancionConectadoEN
        puntuancionConectadoEN = new PuntuancionConectadoEN ();
        puntuancionConectadoEN.Id = p_puntuancionConectado_OID;
        puntuancionConectadoEN.Puntuacion = p_puntuacion;
        //Call to PuntuancionConectadoCAD

        _IPuntuancionConectadoCAD.Modify (puntuancionConectadoEN);
}

public void Destroy (int id
                     )
{
        _IPuntuancionConectadoCAD.Destroy (id);
}

public PuntuancionConectadoEN ReadOID (int id
                                       )
{
        PuntuancionConectadoEN puntuancionConectadoEN = null;

        puntuancionConectadoEN = _IPuntuancionConectadoCAD.ReadOID (id);
        return puntuancionConectadoEN;
}

public System.Collections.Generic.IList<PuntuancionConectadoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PuntuancionConectadoEN> list = null;

        list = _IPuntuancionConectadoCAD.ReadAll (first, size);
        return list;
}
}
}
