namespace Bazele.HW
{
    public enum AniStudii
    {
        I = 1,
        II = 2,
        III = 3,
        IV = 4
    }
    public struct Student
    {
        public string Name;
        public int Varsta;
        public string Specializare;
        public AniStudii AnStudii;

        public void Afiseaza()
        {
            Console.WriteLine($"Nume: {Name}");
            Console.WriteLine($"Varsta: {Varsta}");
            Console.WriteLine($"Specializare: {Specializare}");
            Console.WriteLine($"An studii: {AnStudii}");
        }
    }
}
