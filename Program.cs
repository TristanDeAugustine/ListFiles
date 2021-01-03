using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;

static void ListFiles()
{
    var json = File.ReadAllText(@"Omnis.json");
    try
    {
        var jObject = JObject.Parse(json);

        if (jObject != null)
        {
            Console.WriteLine("HOSTNAME :" + jObject["hostName"].ToString());
            Console.WriteLine("PACKAGEVERSION :" + jObject["packageVersion"].ToString());
            Console.WriteLine("DATE TIME: " + jObject["dateTime"].ToString());
            Console.WriteLine("TYPE: " + jObject["type"].ToString());

            JArray versionsArrary = (JArray)jObject["Versions"];
            if (versionsArrary != null)
            {
                foreach (var item in versionsArrary)
                {
                    Console.WriteLine("Version :" + item["version"]);
                }

            }
            JArray usersArrary = (JArray)jObject["Users"];
            if (usersArrary != null)
            {
                foreach (var item in usersArrary)
                {
                    Console.WriteLine("User :" + item["user"]);
                }

            }
        }
    }
    catch (Exception)
    {

        throw;
    }

}