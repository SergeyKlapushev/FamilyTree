using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree
{

    public class FamilyMember
    {
        public string name;

        public string surname;

        public string sex;

        public FamilyMember spouse;

        public FamilyMember mother;

        public FamilyMember father;

        public List<FamilyMember> brothers = new List<FamilyMember>();

        public List<FamilyMember> sisters = new List<FamilyMember>();

        public List<FamilyMember> children = new List<FamilyMember>();



        // Конструктры
        public FamilyMember()
        {

        }
        public FamilyMember(string name)
        {
            this.name = name;
        }
        public FamilyMember(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public FamilyMember(string name, string surname, string sex)
        {
            this.name = name;
            this.surname = surname;
            this.sex = sex;
        }
        public FamilyMember(string name, string surname, string sex, FamilyMember spouse)
        {
            this.name = name;
            this.surname = surname;
            this.sex = sex;
            this.spouse = spouse;
        }
        public FamilyMember(string name, string surname, string sex, FamilyMember spouse, FamilyMember mother)
        {
            this.name = name;
            this.surname = surname;
            this.sex = sex;
            this.spouse = spouse;
            this.mother = mother;
        }
        public FamilyMember(string name, string surname, string sex, FamilyMember spouse, FamilyMember mother, FamilyMember father)
        {
            this.name = name;
            this.surname = surname;
            this.sex = sex;
            this.spouse = spouse;
            this.mother = mother;
            this.father = father;
        }



        // get set Имя
        public string getName()
        {
            if (this.name == null)
            {
                return $"Имя: Неизветно";
            }
            else
            {
                return $"{this.name}";
            }
        }
        public void setName(string name)
        {
            this.name = name;
        }



        // get set Фамилию
        public string getSurname()
        {
            {
                if (this.surname == null)
                {
                    return $"Фамилия: !Неизветна!";
                }
                else
                {
                    return this.surname;
                }
            }
        }
        public void setSurname(string surname)
        {
            this.surname = surname;
        }



        //get set Sex
        public string getSex()
        {
            if(this.sex == "Мужской")
            {
                return $"|--------------\n|Пол: {sex}";
            }
            if (this.sex == "Женский")
            {
                return $"|--------------\n|Пол: {sex}";
            }
            else
            {
                return $"|--------------\n|!!!Пол введён не верно!!!";
            }
        }
        public void setSex(string sex)
        {
            this.sex = sex;
        }



        // get set Муж/Жена
        public string getSpouse()
        {
            if (spouse == null)
            {
                if (sex == "Мужской")
                {
                    return $"|--------------\n|Семейное положение:: Не женат";
                }
                if (sex == "Женский")
                {
                    return $"|--------------\n|Семейное положение:: Не замужем";
                }
                else
                {
                    return $"|--------------\n|Семейное положение: !!Не возможно определить пол!!";
                }
            }
            else
            {
                if (sex == "Мужской")
                {
                    return $"|--------------\n|Семейное положение: женат на {spouse.getName()} {spouse.getSurname()}";
                }
                if (sex == "Женский")
                {
                    return $"|--------------\n|Семейное положение: замужем за {spouse.getName()} {spouse.getSurname()}";
                }
                else
                {
                    return $"|--------------\n|Семейное положение: !!Не возможно определить пол!!";
                }
            }
        }
        public void setSpouse(FamilyMember spouse)
        {
            this.spouse = spouse;
            spouse.spouse = this;
        }



        // get set Мать
        public string getMother()
        {
            if (mother == null)
            {
                return $"|--------------\n|Мать: !Неизвестна!";
            }
            else
            {
                return $"|--------------\n|Мать: {mother.name} {mother.surname}";
            }
            

        }
        public void setMother(FamilyMember mother)
        {
            this.mother = mother;
        }



        // get set Отец
        public string getFather()
        {
            if(father == null)
            {
                return $"|--------------\n|Отец: !Неизвестен!\n|--------------";
            }
            else
            {
                return $"|--------------\n|Отец: {father.name} {father.surname}\n|--------------";
            }
        }
        public void setFather(FamilyMember father)
        {
            this.father = father;
        }



        // get set Brother
        public string getBrothers()
        {
            StringBuilder brothersInfo = new StringBuilder();

            if (brothers.Count == 0)
            {
                return $"|Братья: !Нет, либо Неизвестны!";
            }
            else
            {
                for (int i = 0; i < brothers.Count; i++)
                {
                    brothersInfo.Append($"{brothers[i].getName()} ");
                }
                return $"|Братья: {brothersInfo}";
            }
        }
        public void setBrothers(FamilyMember brother)
        {
            this.brothers.Add(brother);
        }



        // get set Sisters
        public string getSisters()
        {
            StringBuilder sisterssInfo = new StringBuilder();

            if (sisters.Count == 0)
            {
                return $"|Сёстры: !Нет, либо Неизвестны!";
            }
            else
            {
                for (int i = 0; i < sisters.Count; i++)
                {
                    sisterssInfo.Append($"{sisters[i].getName()} ");
                }
                return $"|Сёстры: {sisterssInfo}";
            }
        }
        public void setSister(FamilyMember sister)
        {
            this.sisters.Add(sister);
        }

        // get set Children
        public string getChildren()
        {
            StringBuilder childrenInfo = new StringBuilder();

            if (children.Count == 0)
            {
                return $"|Дети: !Нет, либо Неизвестны!";
            }
            else
            {
                for (int i = 0; i < children.Count; i++)
                { 
                    childrenInfo.Append($"{children[i].getName()} {children[i].getSurname()}");
                }
                return $"|Дети: {childrenInfo}";
            }
        }
        public void setChildren(FamilyMember child)
        {
            this.children.Add(child);
            child.setSurname(this.surname);
        }



        // get Information
        public string getInformation()
        {
            StringBuilder info = new StringBuilder();
            info.Append($"|== {getName()} {getSurname()} ==|\n");
            info.Append($"{getSex()}\n");
            info.Append($"{getSpouse()}\n");
            info.Append($"{getMother()}\n");
            info.Append($"{getFather()}\n");
            info.Append($"{getChildren()}\n");
            info.Append($"|--------------\n");
            info.Append($"{getBrothers()}\n");
            info.Append($"|--------------\n");
            info.Append($"{getSisters()}\n");
            return info.ToString();
        }
    }
}
