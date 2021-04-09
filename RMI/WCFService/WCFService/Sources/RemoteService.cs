namespace Microsoft.ServiceModel.Samples
{
    class RemoteService : IRemoteService
    {
        public string Echo(string text)
        {
            return $"Server echo with text: { text }";
        }

        public bool Login(string name, string pass)
        {
            return name == "Rostyk" && pass == "111";
        }

        public string Ping()
        {
            return "localhost";
        }
    }
}
