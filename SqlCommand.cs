namespace CrudBasicCsharp
{
    internal class SqlCommand
    {
        private string v;
        private object p;

        public SqlCommand(string v, SqlConnection con)
        {
            this.v = v;
        }

        public SqlCommand(object p, string v)
        {
            this.p = p;
            this.v = v;
        }

        internal int ExecuteNonQuery()
        {
            //throw new NotImplementedException();
            return 0;
        }
    }
}