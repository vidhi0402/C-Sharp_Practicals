using System;

namespace Inheritance
{
    class Sponsor
    {
        protected string owner = "Rakuteen";

    }
    class Team : Sponsor
    {
        private string teamnName = "Snowden";

        public void printInfo()
        {
            System.Console.WriteLine(owner +" - " +teamnName);
        }
        
    }
    class program
    {
        public static void Main(string[] args)
        {
            Team obj = new Team();
            obj.printInfo();
        }
    }


}
