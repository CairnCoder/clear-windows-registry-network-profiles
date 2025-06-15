using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clear_Registry_Network_Profiles
{
    class NetworkProfile
    {
        public string registoryPath { get; set; }
        public string profileName { get; set; }

        public NetworkProfile(string registoryPath, string profileName)
        {
            this.registoryPath = registoryPath;
            this.profileName = profileName;
        }
    }
}
