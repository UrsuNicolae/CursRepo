namespace PascalCaseConventions
{
    public class Utilizator
    {
        private readonly string _numeUtilizator;
        public int IdUtilizator { get; set; }
        public string NumeUtilizator { get; set; }
        public string Parola { get; set; }
        public List<Rol> Roluri { get; set; }

        public Utilizator(int id, string nume, string parolaInitiala)
        {
            _numeUtilizator = nume;
            IdUtilizator = id;
            NumeUtilizator = nume;
            Parola = parolaInitiala;
            Roluri = new List<Rol>();
        }

        public void AdaugaRol(Rol rolNou)
        {
            if (!Roluri.Contains(rolNou))
                Roluri.Add(rolNou);
        }

        public bool VerificaRol(string numeRol)
        {
            foreach (var r in Roluri)
            {
                if (r.NumeRol == numeRol)
                    return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Utilizator: {NumeUtilizator}, Roluri: {string.Join(", ", Roluri)}";
        }
    }

    public class Rol
    {
        public string NumeRol { get; set; }
        public string Descriere { get; set; }

        public Rol(string nume, string descriereRol)
        {
            NumeRol = nume;
            Descriere = descriereRol;
        }

        public override string ToString()
        {
            return NumeRol;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var admin = new Rol("Administrator", "Acces complet la sistem.");
            var utilizatorObisnuit = new Rol("Utilizator", "Acces limitat.");

            var user = new Utilizator(1, "IonPopescu", "parola123");
            user.AdaugaRol(admin);
            user.AdaugaRol(utilizatorObisnuit);

            Console.WriteLine(user);
            Console.WriteLine($"Are rol de administrator? {user.VerificaRol("Administrator")}");
            Console.ReadKey();

        }
    }
}
