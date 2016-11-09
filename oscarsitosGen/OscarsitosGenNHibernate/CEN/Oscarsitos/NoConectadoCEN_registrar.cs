
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


/*PROTECTED REGION ID(usingOscarsitosGenNHibernate.CEN.Oscarsitos_NoConectado_registrar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace OscarsitosGenNHibernate.CEN.Oscarsitos
{
public partial class NoConectadoCEN
{
        /*PROTECTED REGION ID(OscarsitosGenNHibernate.CEN.Oscarsitos_NoConectado_registrar) ENABLED START*/
        public bool Registrar(string email, string password, string alias, string nombre, string imagen, Nullable<DateTime> fechRegistro, int idioma, bool suscrito)
        {
            /*PROTECTED REGION ID(OscarsitosGenNHibernate.CEN.Oscarsitos_NoConectado_registrar) ENABLED START*/
            //NoConectadoEN noConectadoEN = new NoConectadoEN();
            ConectadoEN conectadoEN = new ConectadoEN();
            bool login = false;

            //REGISTRAR LLAMA A NEW DE CONECTADO
            //CREAR CUENTA NUEVA Y METERLA EN LA BASE DE DATOS
            IConectadoCAD _IConectadoCAD = new ConectadoCAD();
            conectadoEN = _IConectadoCAD.ReadEmail(email);
            if (conectadoEN==null){
                ConectadoEN = ConectadoCEN.New_(nombre, alias, fechRegistro, password, email, suscrito, idioma, imagen);
                login = true;
            }
            return login;
            /*PROTECTED REGION END*/
        }
    }
    /*PROTECTED REGION END*/
}
