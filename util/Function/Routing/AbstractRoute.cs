namespace CiscoGui.util.Function.Routing
{
    public abstract class AbstractRoute
    {
        
        protected string Network { get; set; }
        
        public string Gateway { get; set; }
        
        protected bool IsIpv6 { get; set; }

        public abstract string TearUp();

        public abstract string TearDown();

    }
}