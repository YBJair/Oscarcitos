
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using OscarsitosGenNHibernate.Exceptions;
using OscarsitosGenNHibernate.EN.Oscarsitos;
using OscarsitosGenNHibernate.CAD.Oscarsitos;
using OscarsitosGenNHibernate.CEN.Oscarsitos;


namespace OscarsitosGenNHibernate.CP.Oscarsitos
{
public partial class PuntuancionConectadoCP : BasicCP
{
public PuntuancionConectadoCP() : base ()
{
}

public PuntuancionConectadoCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
