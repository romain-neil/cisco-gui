using Renci.SshNet;

namespace CiscoGui.util
{
    /// <summary>
    /// Wrapper class to the SSH.NET library
    /// </summary>
    public class Ssh
    {
        private SshClient _client;

        ~Ssh()
        {
            if (!_client.IsConnected) return;

            _client.Disconnect();
            _client.Dispose();
        }

        /// <summary>
        /// Initialize the connection to the remote host
        /// </summary>
        /// <param name="host"></param>
        /// <param name="username"></param>
        /// <param name="pass"></param>
        /// <param name="port"></param>
        public void Init(string host, string username, string pass, int port = 22)
        {
            _client = new SshClient(host, port, username, pass);
            _client.Connect();
        }

        /// <summary>
        /// Send command to the remote host through ssh
        /// </summary>
        /// <param name="text"></param>
        public string Send(string text)
        {
            return _client.CreateCommand(text).Execute();
        }
    }
}