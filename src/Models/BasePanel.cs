using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class BasePanel<T>: NetworkModel
    {
        protected readonly string BaseURL;
        protected readonly string ApiKey;

        public BasePanel(string baseURL, string apikey)
        {
            BaseURL = baseURL;
            ApiKey = apikey;
        }

        //public T Create(T data)
        //{
        //    return null;
        //}

        //public T GetOnID(long id)
        //{
        //    return null;
        //}

        //public T GetAll()
        //{
        //    return null;
        //}

        //public T UpdateOnID()
        //{
        //    return null;
        //}

        //public T DeleteOnID()
        //{
        //    return null;
        //}
    }
}
