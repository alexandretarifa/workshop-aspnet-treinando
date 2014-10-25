using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memcached.ClientLibrary;

namespace memCached
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] servidores = {"127.0.0.1:11211"};

            SockIOPool pool = SockIOPool.GetInstance();
            pool.SetServers(servidores);
            pool.Initialize();

            var cache = new MemcachedClient();

            string chave = "dados";
            string retorno = "";

            if (cache.KeyExists(chave))
                retorno = cache.Get(chave).ToString();
            else
            {
                cache.Set(chave, DateTime.Now.ToString(), DateTime.Now.AddMinutes(1));
                retorno = "primeiro acesso ao cache";
            }

            Console.WriteLine(retorno);
            Console.Read();

        }
    }
}
