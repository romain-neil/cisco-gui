using System.Collections.Generic;
using CiscoGui.util.Function.Routing;

namespace CiscoGui.util
{
	public class Router
	{

		private readonly Ssh _ssh;

		private string HostName { get; set; }

		public Router()
		{
			_ssh = new Ssh();
		}

		public void SetHostName(string newHost)
		{
			HostName = newHost;
		}

		public void InitClient(string username, string password)
		{
			_ssh.Init(HostName, username, password);
		}

		public List<AbstractRoute> GetAllRoutes()
		{
			return Extractor.ExtractFromRouter(_ssh);
		}

	}
}