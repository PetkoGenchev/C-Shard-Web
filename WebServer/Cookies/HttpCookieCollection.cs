using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookies
{
    public class HttpCookieCollection : IHttpCookieCollection
    {
        public ICollection<HttpCookie> Cookies = new List<HttpCookie>();

        public void AddCookie(HttpCookie cookie)
        {
            Cookies.Add(cookie);
        }

        public bool ContainsCookie(string key)
        {
            return Cookies.Any(c => c.Key == key);
        }

        public HttpCookie GetCookie(string key)
        {
            return Cookies.Where(c => c.Key == key).First();
        }

        public bool HasCookies()
        {
            return Cookies.Any();
        }

        public override string ToString()
        {
            return string.Join(HttpCookieStringSeparator, this.Cookies.Values);
        }



        public IEnumerator<HttpCookie> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
