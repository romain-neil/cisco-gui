namespace CiscoGui.util.Function.Routing
{
    public class StaticRoute : AbstractRoute
    {

        public StaticRoute(string network, string nextHop)
        {
            //
        }
        
        public override string TearUp()
        {
            return "ip" + (IsIpv6 ? "6" : "") +" route add " + Network;
        }

        public override string TearDown()
        {
            throw new System.NotImplementedException();
        }
    }
}