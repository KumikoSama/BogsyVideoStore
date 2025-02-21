using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Models
{
    public class GlobalConfig
    {
        public static string ConnectionString { get; } = "Data Source=DESKTOP-LIDTB5Q;Initial Catalog=BogsyVideoStoreDB;Integrated Security=True;Trust Server Certificate=True";
    }
}
