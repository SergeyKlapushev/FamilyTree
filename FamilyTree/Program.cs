namespace FamilyTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FamilyMember Otech = new FamilyMember("Михаил", "Клапышев", "Мужской");
            FamilyMember Mama = new FamilyMember("Екатерина", "Смирнова", "Женский");

            Otech.setSpouse(Mama);
            Console.WriteLine(Otech.getInformation());
            Console.WriteLine(Mama.getInformation());
        }
    }
}
