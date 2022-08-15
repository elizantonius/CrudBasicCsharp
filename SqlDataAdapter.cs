using System.Data;

namespace CrudBasicCsharp
{
    internal class SqlDataAdapter
    {
        private SqlCommand koneksi;

        public SqlDataAdapter(SqlCommand koneksi)
        {
            this.koneksi = koneksi;
        }

        internal int Fill(DataTable dt)
        {
            //throw new NotImplementedException();
            return 0;
        }
    }
}