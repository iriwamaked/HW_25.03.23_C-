using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_25._03._23
{
    struct Article
    {
        private ushort Id;
        private string Name;
        private float Price;
        private ArticleType Type;
        public Article (ushort id, string name, float price, ArticleType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }
        public ushort ID
        { get { return Id; }
          set { 
                if (value!=Id&&value>0)
                {
                    Id = value;
                }
            }
        }
        public string NAME
        {
            get { return Name; }
            set { 
                if (value==null||value!=Name)
                Name = value; 
            }
        }
        public float PRICE
        {
            get { return Price; }
            set { if (value!=Price) { Price= value; }  }
        }

        public ArticleType TYPE
        {
            get { return Type; }
            set { 
                if (value != Type|| Enum.IsDefined(typeof(ArticleType), value) )
                {
                    Type = value;
                }
                
                }
        }
        
        //private ArticleType ArticleID()
        //{
        //    ArticleType tmp;
        //    switch(Id) 
        //    {
        //        case 1: tmp = ArticleType.Food; break;
        //        case 2: tmp = ArticleType.Clothes; break;
        //        case 3: tmp = ArticleType.Chemestry; break;
        //        case 4: tmp = ArticleType.PersonalHygiene; break;
        //        case 5: tmp=ArticleType.Toys; break;
        //        default: return 0;
        //    }
        //    return tmp;
        //}

        public void Print()
        {
            Console.WriteLine($"\n\tПродукт {Name} с идентификатором {ID} стоит {Price} $ и относится к типу {Type}");
        }
    }

    enum ArticleType
    {
        UnTypeProduct, Food, Clothes, Chemestry, PersonalHygiene, Toys
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Article article= new Article(1, "Apple", 1.5f, ArticleType.Food);
            //article.Print();
            //Article article2 = new Article(6, "Бензин", 3.99f, ArticleType.UnTypeProduct);
            //article2.Print();
            //Console.WriteLine("\n\tВведите идентификтор продукта: ");
            //ushort id=ushort.Parse(Console.ReadLine());
            //Console.WriteLine("\n\tВведите название продукта: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("\n\tВведите цену продукта: ");
            //float price = float.Parse(Console.ReadLine());
            //Console.WriteLine("\n\tВведите категорию продукта (от 0 до 6), где" +
            //    "0 - неизвестный тип, 1 - еда, 2 - вещи, 3 - бытовая химия, 4 - личная гигена, 5 - игрушки.");
            //int tmp = Int32.Parse(Console.ReadLine());
            //if (tmp<0||tmp>5)
            //{
            //    tmp = 0;
            //}
            //ArticleType type = (ArticleType)Enum.GetValues(typeof(ArticleType)).GetValue(tmp);
            //Article newArticle= new Article(id, name, price, type);
            //newArticle.Print();
            //Console.WriteLine("\n\t" + newArticle.TYPE);
            //type = (ArticleType)Enum.GetValues(typeof(ArticleType)).GetValue(3);
            //newArticle.TYPE = type;
            //Console.WriteLine("\n\t" + newArticle.TYPE);
            //newArticle.Print();
            //Console.ReadLine();

            Student student = new Student();
            Console.Write("\n\tВведите фамилию студента: ");
            student.LastName= Console.ReadLine();
            Console.Write("\n\tВведите имя студента: ");
            student.FirstName= Console.ReadLine();
            Console.Write("\n\tВведите отчество студента: ");
            student.FatherName= Console.ReadLine();
            Console.Write("\n\tВведите группу студента: ");
            student.Group= Console.ReadLine();
            Console.Write("\n\tВведите возраст студента: ");
            student.Age=int.Parse(Console.ReadLine());
            Console.Write("\n\tВведите оценки по программированию: ");
            student.ProgrammMark=new int[] {int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())};
            Console.Write("\n\tВведите оценки по администрированию: ");
            student.AdminMark = new int[] { int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) };
            Console.Write("\n\tВведите оценки по дизайну: ");
            student.DesignMark = new int[] { int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) };
            Console.WriteLine("\n\tДанные студента: ");
            Console.WriteLine(student.ToString());
            student.SetProgrammMark(2, 12);
            Console.WriteLine("\n\tСредний бал по программированию: {0}", student.GetProgrammAverage());
            Console.ReadLine();
        }
    }
}
