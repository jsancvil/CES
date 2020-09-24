using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES.DB
{

    public class resultTransaction
    {
        public string idOut;
        public int? idOutInt;
        public bool? hasError;
        public int? noError;
        public string messageError;
        public DataTable dtResult;

        public resultTransaction()
        {

        }
    }
}
