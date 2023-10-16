namespace FamilyTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FamilyMember Otech = new FamilyMember("Михаил", "Клапышев", "Мужской", null, null, null) ;
            FamilyMember Mama = new FamilyMember("Екатерина", "Смирнова", "Женский", null, null, null);

            Otech.setSpouse(Mama);
            Console.WriteLine(Mama.getInformation());
            Console.WriteLine(Otech.getInformation());
        }
    }
}
