using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HareketSorgulama
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-F20JGOS\SQLSERVER1;Initial Catalog=DboHareketSorgulama;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
