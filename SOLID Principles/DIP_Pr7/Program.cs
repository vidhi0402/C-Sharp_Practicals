using System;

namespace DIP_Pr7
{
    interface Developer
    {
        public void develop();
    }
    class BackEndDeveloper : Developer
    {
        public void develop()
        {
            this.Java();
        }
        public void Java()
        {
            Console.WriteLine("JAVA is BackEnd Language");
        }
    }
    class FrontEndDeveloper : Developer
    {
        public void develop()
        {
            this.JavaScript();
        }
        public void JavaScript()
        {
            Console.WriteLine("JAVASCRIPT is FrontEnd Language");
        }
    }
    class project
    {
        public void implement(Developer d)
        {
            d.develop();
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            project p = new project();
            p.implement(new BackEndDeveloper());
            p.implement(new FrontEndDeveloper());
        }
    }
}