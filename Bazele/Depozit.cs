namespace Bazele
{
    public struct Depozit
    {
        public int Numar;
        public string Nume;
        public int Sold;
        public DateTime DataDeschiderii;

        public Depozit(int numar, string nume, int sold, DateTime dataDeschiderii)
        {
            Numar = numar;
            Nume = nume;
            Sold = sold;
            DataDeschiderii = dataDeschiderii;
        }

        public void Afisare()
        {
            Console.WriteLine($"Depozitul {Numar} cu numele {Nume} are un sold de {Sold} si a fost deschis la data de {DataDeschiderii}");
        }

        public void DepozitSum(int suma)
        {
            Sold += suma;
        }

        public void DepozitRetragere(int suma)
        {
            if (Sold < suma)
            {
                Console.WriteLine("Resurse insuficiente");
            }
            else
            {
                Sold -= suma;
            }
        }
    }
}
