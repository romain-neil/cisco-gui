using System.Collections.Generic;

namespace CiscoGui.util.Function.Routing
{
    public class Extractor
    {
        public static List<AbstractRoute> ExtractFromRouter(Ssh ssh)
        {
            var routes = new List<AbstractRoute>();
            
            //get routes output from router
            var result = ssh.Send("show ip route");

            //Transform the result into something exploitable
            
            //loop over all routes
            foreach (var route in Transform(result))
            {
                if (route.StartsWith("S"))
                {
                    //Route statique
                    routes.Add(new StaticRoute("", ""));
                }

                if (route.StartsWith("O"))
                {
                    routes.Add(new OspfRoute());
                }
            }

            //Create corresponding objects

            return routes;
        }

        /// <summary>
        /// Transform the routes into multi lines
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static IEnumerable<string> Transform(string text)
        {
            return new[] {""};
        }
    }
}