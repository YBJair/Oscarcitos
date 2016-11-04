

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
 *      Definition of the class ImagenCEN
 *
 */
public partial class ImagenCEN
{
private IImagenCAD _IImagenCAD;

public ImagenCEN()
{
        this._IImagenCAD = new ImagenCAD ();
}

public ImagenCEN(IImagenCAD _IImagenCAD)
{
        this._IImagenCAD = _IImagenCAD;
}

public IImagenCAD get_IImagenCAD ()
{
        return this._IImagenCAD;
}
}
}
