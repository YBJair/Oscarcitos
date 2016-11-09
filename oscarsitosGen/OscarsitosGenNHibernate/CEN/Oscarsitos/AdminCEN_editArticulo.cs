
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using OscarsitosGenNHibernate.Exceptions;
using OscarsitosGenNHibernate.EN.Oscarsitos;
using OscarsitosGenNHibernate.CAD.Oscarsitos;


/*PROTECTED REGION ID(usingOscarsitosGenNHibernate.CEN.Oscarsitos_Admin_editArticulo) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace OscarsitosGenNHibernate.CEN.Oscarsitos
{
public partial class AdminCEN
{
public void EditArticulo (int p_oid)
{
            /*PROTECTED REGION ID(OscarsitosGenNHibernate.CEN.Oscarsitos_Admin_editArticulo) ENABLED START*/

            ArticuloEN articuloEN = null;
            IArticuloCAD _IArticuloEN = null;

            if (p_oid != 0)
            {
                articuloEN = _IArticuloEN.ReadOIDDefault(p_oid);//CAPTURAR EL DATO
                Articulo.Edit(articuloEN);
            }

            /*ProductoEN productoEN = null;
            CestaEN cestaEN = null;
            IProductoCAD _IProductoCAD = new ProductoCAD();

            if (idcesta != null && idproducto != null)
            {
                cestaEN = _ICestaCAD.ReadOIDDefault(idcesta);
                productoEN = _IProductoCAD.ReadOIDDefault(idproducto);
                if (!cestaEN.Producto.Contains(productoEN))
                {
                    cestaEN.Producto.Add(productoEN);
                }
            }*/
            /*PROTECTED REGION END*/
        }
    }
}
