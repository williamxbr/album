using Eniwine.Album.Copa.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Security;

namespace Eniwine.Album.Copa.Web.Gerenciador
{
    public static class GerenciadorUsuario
    {
        public static Usuario Usuario
        {
            get
            {
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    try
                    {
                        FormsIdentity id = (FormsIdentity)HttpContext.Current.User.Identity;
                        return new JavaScriptSerializer().Deserialize<Usuario>(id.Ticket.UserData);
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public static void Autentica(Usuario usuario, HttpResponseBase response)
        {
            try
            {
                string userData = new JavaScriptSerializer().Serialize(usuario);
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,
                                      usuario.Login,
                                      DateTime.Now,
                                      DateTime.Now.AddDays(30),
                                      true,
                                      userData,
                                      FormsAuthentication.FormsCookiePath);

                response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket)));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Logoff(HttpSessionStateBase session, HttpResponseBase response)
        {
            session.Abandon();
            FormsAuthentication.SignOut();
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, "");
            cookie.Expires = DateTime.Now.AddYears(-1);
            response.Cookies.Add(cookie);
        }


    }
}