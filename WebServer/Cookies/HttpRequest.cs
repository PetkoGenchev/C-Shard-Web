using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookies
{
    public class HttpRequest
    {
        public IHttpCookieCollection CookieCollection;

        public HttpRequest()
        {
            this.CookieCollection = new HttpCookieCollection();
        }

        public void ParseCookies()
        {

        }
    }
}
