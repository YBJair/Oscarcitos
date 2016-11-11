
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using OscarsitosGenNHibernate.EN.Oscarsitos;
using OscarsitosGenNHibernate.CEN.Oscarsitos;
using OscarsitosGenNHibernate.CAD.Oscarsitos;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\sqlexpress; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                // Insert the initilizations of entities using the CEN classes

                UserCEN userCen = new UserCEN();

                IdiomaCEN idio = new IdiomaCEN();
                idio.New_("Castellano");
                idio.New_("Ingles");
                idio.New_("Aleman");
                idio.New_("Frances");

                NoConectadoCEN nconCen = new NoConectadoCEN();
                

                ConectadoCEN conec = new ConectadoCEN();
                //idioma?
                conec.New_("John Jonero Jonancio", "JoJoJo", new DateTime(1991, 11, 13), "pass", "tripleJ@gmail.com", false, 1, http://m.memegen.com/1j7mtm.jpg);
                conec.New_("Tum Tumtum Tumtumtum", "Tumx6", new DateTime(1995, 10, 10), "tumaqueguay", "tum666@hotmail.com", true, 1, http://m.memegen.com/sg0yim.jpg);
                conec.New_("Bruno Lee", "LeeBru", new DateTime(1986, 01, 02), "leeunlibru", "BrunoBrunoBruno@gmail.com", false, 1, https://s-media-cache-ak0.pinimg.com/236x/7a/10/88/7a1088b474181b312d12b4fb2565cf7d.jpg);
                conec.New_("Maria Muffin", "LovePalomas", new DateTime(1998, 05, 24), "jajaja", "SacredMuffin@gmail.com", true, 1, http://img.desmotivaciones.es/201107/MariaMuffin.jpg);
                conec.New_("Jair Powa", "DigoJairPaReirme", new DateTime(1988, 08, 30), "garagefruit", "culonia@hotmail.com", true, 1, http://m.memegen.com/v47sxo.jpg);

                
                AdminCEN admi = new AdminCEN();
                //idioma?
                admi.New_("Paco Gonzalez Garcia", "Paconator", new DateTime(1990, 08, 03), "123456", "paconator26@hotmail.com", true, 1, http://r30.imgfast.net/users/3017/12/50/30/avatars/640-22.jpg);
                admi.New_("Laura Gutierrez Fuentes", "Larra", new DateTime(1989, 10, 12), "password", "larrarosa@gmail.com", true, 1, http://vignette3.wikia.nocookie.net/hieloyfuego/images/d/d6/A_Lyseni_noblewoman_by_Magali_Villeneuve%C2%A9.jpg/revision/latest?cb=20150214193400);
                admi.New_("Luis Sanchez Aroca", "Luis S.A.", new DateTime(1992, 02, 22), "contraseña", "luisSociedadAnonima@gmail.com", false, 1, https://s-media-cache-ak0.pinimg.com/236x/12/c4/6a/12c46a55fd7c5257f1eae1e1f49c49ac.jpg);

                RedactorCEN redCen = new RedactorCEN();
                //idioma?
                redCen.New_("Juan Lujan Fernandez", "JuanLuFer", new DateTime(1981, 09, 13), "jajajajeje", "julufe@hotmail.com", false, 1, https://kiwicdn.akamaized.net/6c10/ELxRqkM4UYyi4EQRxL2pER_150.jpg);
                redCen.New_("Fernanda Gomariz Sanchez", "GomaGoma", new DateTime(1985, 12, 12), "gomugomu", "akuma@gmail.com", true, 1, http://papels.es/gestion/imagenesges/zoom/goma-borrar-milan-430.png);
                redCen.New_("Vicente Blasco Ibanez", "MorFil", new DateTime(1970, 01, 28), "tadeloemon", "superintendentevicente@gmail.com", true, 1, http://vignette4.wikia.nocookie.net/mortadelo/images/f/f6/Se%C3%B1or_s%C3%BAper.jpg/revision/latest?cb=20110622161302&path-prefix=es);


                ArticuloCEN art = new ArticuloCEN ();
				//redacta?
				art.New_("Bla blablablablablablablablablablablabla blabla", new DateTime(2013,11,07), OscarsitosGenNHibernate.Enumerated.Oscarsitos.CategArticuloEnum.Rosa, "Paquito clavo un clavito", true, true, http://1.bp.blogspot.com/-CDKU6JbgfDs/UzqMzGs9W2I/AAAAAAAAAKc/SBoA2yBhkBg/s1600/pabl.png);
				art.New_("Blebleble bleblebleblebleblebleblebleble", new DateTime(2013,11,06), OscarsitosGenNHibernate.Enumerated.Oscarsitos.CategArticuloEnum.Estrenos, "Tom es el nuevo Bartman", true, true, http://img10.deviantart.net/e750/i/2008/170/e/0/i_am_bartman__by_leif_j.png);
				art.New_("Bla blablablablabla blobloblobloblo blablablablablablabla blabla", new DateTime(2013,11,10), OscarsitosGenNHibernate.Enumerated.Oscarsitos.CategArticuloEnum.Rumores, "Sara protagonizara Un viaje a tu casa", false, true, https://jetmarinspiraviajar.files.wordpress.com/2015/06/blog_balanza1.jpg);
				art.New_("Blublublu bliblibli blablablablablablablablablablablabla blabla", new DateTime(2013,11, 12), OscarsitosGenNHibernate.Enumerated.Oscarsitos.CategArticuloEnum.Curiosidades, "Gazapos en el rodaje de SuperShurperro", false, false, http://i47.tinypic.com/4g3jtt.jpg);

                PuntuancionConectadoCEN puntCen = new PuntuancionConectadoCEN();
                //espuntuado puntua?
                puntCen.New_(0, 0, 0);
                puntCen.New_(0, 0, 0);
                puntCen.New_(0, 0, 0);
                puntCen.New_(0, 0, 0);n

                ComentarioCEN comen = new ComentarioCEN();
                //escritor y articulo?
                comen.New_("Te odio Juan Hanks!", 256, 1,1);
                comen.New_("Yo aparqué ahí ayer", 3, 1,1);
                comen.New_("Ojalá rueden aqui y necesiten extras", 0, 1,1);
                comen.New_("Dos chicas sin blanca es una serie muy buena", -30, 1,1);


                

                /*UsuarioConectCEN usconCen = new UsuarioConectCEN();
				//comentario?
				usconCen.New_("Jose Escalejo Muniz", "joes", new DateTime(1978,12,20), "jajajojojeje", "joes@gmail.com");//attribute?
				usconCen.New_("Sara Gertrude Garcia", "saGer", new DateTime(1992,10,01), "esagerado", "saGer@hotmail.com");//attribute?
				usconCen.New_("Perico Palotes", "Palote", new DateTime(1980,04,05), "perpalo", "perpalo@hotmail.com");//attribute?
				
				
				UsuarioNoConectCen usnoconCen = new usnoconCen ();*/



                /*PROTECTED REGION END*/
            }
            catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
