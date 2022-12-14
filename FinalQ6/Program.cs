using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using Newtonsoft.Json;

/*
 *  Create a console application which defines and uses a singleton class which includes methods to 
 *  load and save the player's settings using the following JSON format to a hard drive file,
 *  serializing and deserializing the structure with the Newtonsoft JSON package:
 *  
 *  {"player_name":"dschuh","level":4,"hp":99,"inventory":["spear","water bottle","hammer",
 *  "sonic screwdriver","cannonball","wood","Scooby snack","Hydra","poisonous potato",
 *  "dead bush","repair powder"],"license_key":"DFGU99-1454"}
 */

namespace FinalQ6
{
    public class Player
    {
        private Player()
        {
           
        }

        private static Player instance;

        public static Player Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Player();
                }

                return instance;
            }
        }

        public void LoadSettings(string s)
        {

        }

        public void SaveSettings(string s)
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = Player.Instance;
            string s = null;

            player = JsonConvert.DeserializeObject<Player>(s);

            player.LoadSettings(s);
            player.SaveSettings(s);


        }
    }
}
