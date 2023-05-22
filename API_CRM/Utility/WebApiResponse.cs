using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace API_CRM.Utility
{
    public class WebApiResponse
    {
        public bool IsSuccess { get; set; }
        public DataTable Result { get; set; }
    }
}
