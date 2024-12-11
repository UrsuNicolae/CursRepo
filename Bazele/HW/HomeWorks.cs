namespace Bazele.HW
{
    public struct Angajat
    {
        public string nume;
        public string departament;
        public int salariu;
    }
    public static class HomeWorks
    {
        public static void StudentsGrades()
        {
            int n = int.Parse(Console.ReadLine());
            var stringGrades = Console.ReadLine();
            var note = Array.ConvertAll(stringGrades.Split(" "), int.Parse);
            if (note.Length != n)
            {
                Console.WriteLine("Input invalid");
            }
            Console.WriteLine($"Media notelor este: {note.Sum() / note.Length}");
            Console.WriteLine(stringGrades);

        }

        public static void GestiuneaAngajatilor()
        {
            var avg = 0;
            var sum = 0;
            var angajati = new Angajat[3];
            Console.WriteLine("Dati numele angajatului 1");
            angajati[0].nume = Console.ReadLine();
            Console.WriteLine("Dati departamentul angajatului 1");
            angajati[0].departament = Console.ReadLine();
            Console.WriteLine("Dati salariul angajatului 1");
            angajati[0].salariu = int.Parse(Console.ReadLine());
            sum += angajati[0].salariu;

            Console.WriteLine("Dati numele angajatului 2");
            angajati[1].nume = Console.ReadLine();
            Console.WriteLine("Dati departamentul angajatului 2");
            angajati[1].departament = Console.ReadLine();
            Console.WriteLine("Dati salariul angajatului 2");
            angajati[1].salariu = int.Parse(Console.ReadLine());
            sum += angajati[1].salariu;

            Console.WriteLine("Dati numele angajatului 3");
            angajati[2].nume = Console.ReadLine();
            Console.WriteLine("Dati departamentul angajatului 3");
            angajati[2].departament = Console.ReadLine();
            Console.WriteLine("Dati salariul angajatului 3");
            angajati[2].salariu = int.Parse(Console.ReadLine());
            sum += angajati[2].salariu;
            avg = sum / 3;
            if(angajati[2].salariu > avg)
            {
                Console.WriteLine($"Angajaturl {angajati[2].nume} are salariul peste medie");
            }
        }

        
    }
}