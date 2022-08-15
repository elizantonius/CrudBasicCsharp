namespace CrudBasicCsharp
{
    internal class SqlConnection
    {
        private string v;

        public SqlConnection()
        {
        }

        public SqlConnection(string v)
        {
            this.v = v;
        }

        internal int Open()
        {
            //throw new NotImplementedException();
            return 0;
        }

        internal int Close()
        {
            //throw new NotImplementedException();
            return 0;
        }
    }
}