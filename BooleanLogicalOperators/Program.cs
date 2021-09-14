using System;

 namespace BooleanLogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja kasutajatunnust
            //programm küsib kasutaja parooli
            //programm kontrollib kas mõlemad, nii kasutajatunnus
            //kui ka parool on õiged.


            //kui mõlemad kasutajatunnus ja parool
            //kui kasutajatunnus või parool on vale, siis
            //programm kuvab "sisselogimine ebaõnnestus. Proovi Uuesti."
            //kt: admin, pr:admin1234

            Console.WriteLine("Sisesta kasutajatunnus");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta Parool");
            string UserPassword = Console.ReadLine();

            if (userName == "admin" && UserPassword == "admin1234") 
            {
                Console.WriteLine("Tere Tulemast!");
            }            
            else
            {
                Console.WriteLine("Vale parool või kasutajatunnus");       
            }












        }





}
}
