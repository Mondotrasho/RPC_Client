using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;

class Program
{
    static void Main(string[] args)
    {
        //Create Client
        TcpClientChannel channel = new TcpClientChannel();
        ChannelServices.RegisterChannel(channel, false);

        //Get a reference to the player on the server
        string playerURL = "tcp://localhost:" + 1337 + "/" + "Little";
        Player player = (Player)Activator.GetObject(typeof(Player), playerURL);

        while (true)
        {
            Console.Write("Type a message to the server or type 'quit' to exit\n");
            string text = Console.ReadLine();
            if (text == "quit")
                break;
            //RPC: Call function on server
            

            //extended functionalityVV

            if (text == "help" || text == "h" || text == "?" || text == "-h" || text == "--h" || text == "-help" || text == "--help")
            {
                //list commands
                //ls
                //login
                //quit
                string[] lsResults = new[] {
                    "----------------------------",
                    "-                          -",
                    "-         COMMANDS         -",
                    "-          -----           -",
                    "-         /ls              -",
                    "-         /login           -",
                    "-         /quit            -",
                    "-         /                -",
                    "-                          -",
                    "----------------------------" };

                player.SayHello(lsResults);
                
            }

            if (text == "ls")
            {
                //list filesystem
                string[] fileSystem = new[] {
                    "----------------------------",
                    "-                          -",
                    "-          FILES           -",
                    "-          -----           -",
                    "-         DOCUMENTS        -",
                    "-         PICTURES         -",
                    "-         MOVIES           -",
                    "-         WORK             -",
                    "-                          -",
                    "----------------------------" };

                player.SayHello(fileSystem);
                
            }

            if (text == "login")
            {
                //list filesystem
                string[] loginUI = new[] {
                    "----------------------------",
                    "-          LOGIN           -",
                    "-                          -",
                    "-          USER            -",
                    "-          ADMIN_          -",
                    "-                          -",
                    "-          PASS            -",
                    "-          ******_         -",
                    "-                          -",
                    "----------------------------" };

                player.SayHello(loginUI);
                
            }
        }
    }
}