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
        public Article(ushort id, string name, float price, ArticleType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }
        public ushort ID
        { get { return Id; }
            set {
                if (value != Id && value > 0)
                {
                    Id = value;
                }
            }
        }
        public string NAME
        {
            get { return Name; }
            set {
                if (value == null || value != Name)
                    Name = value;
            }
        }
        public float PRICE
        {
            get { return Price; }
            set { if (value != Price) { Price = value; } }
        }

        public ArticleType TYPE
        {
            get { return Type; }
            set {
                if (value != Type || Enum.IsDefined(typeof(ArticleType), value))
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
            int choice = 1;
            do
            {
                Console.WriteLine("\n\tВведите номер задания для тестирования: ");
                Console.WriteLine("\n\t1: Структура Article+ ArticleType");
                Console.WriteLine("\n\t3: Class Student");
                Console.WriteLine("\n\t4: Abstract class Figure");
                Console.Write("\n\t4: Class Fraction. Ваш выбор: ");
                choice=Int32.Parse(Console.ReadLine());
           
            switch(choice)
            {
                case 1:
                    Article article = new Article(1, "Apple", 1.5f, ArticleType.Food);
                    article.Print();
                    Article article2 = new Article(6, "Бензин", 3.99f, ArticleType.UnTypeProduct);
                    article2.Print();
                    Console.WriteLine("\n\tВведите идентификтор продукта: ");
                    ushort id = ushort.Parse(Console.ReadLine());
                    Console.WriteLine("\n\tВведите название продукта: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("\n\tВведите цену продукта: ");
                    float price = float.Parse(Console.ReadLine());
                    Console.WriteLine("\n\tВведите категорию продукта (от 0 до 6), где" +
                        "0 - неизвестный тип, 1 - еда, 2 - вещи, 3 - бытовая химия, 4 - личная гигена, 5 - игрушки.");
                    int tmp = Int32.Parse(Console.ReadLine());
                    if (tmp < 0 || tmp > 5)
                    {
                        tmp = 0;
                    }
                    ArticleType type = (ArticleType)Enum.GetValues(typeof(ArticleType)).GetValue(tmp);
                    Article newArticle = new Article(id, name, price, type);
                    newArticle.Print();
                    Console.WriteLine("\n\t" + newArticle.TYPE);
                    type = (ArticleType)Enum.GetValues(typeof(ArticleType)).GetValue(3);
                    newArticle.TYPE = type;
                    Console.WriteLine("\n\t" + newArticle.TYPE);
                    newArticle.Print();
                    break;
                    case 2:
                    case 3:
                    Student student = new Student();
                    //Console.Write("\n\tВведите фамилию студента: ");
                    //student.LastName= Console.ReadLine();
                    //Console.Write("\n\tВведите имя студента: ");
                    //student.FirstName= Console.ReadLine();
                    //Console.Write("\n\tВведите отчество студента: ");
                    //student.FatherName= Console.ReadLine();
                    //Console.Write("\n\tВведите группу студента: ");
                    //student.Group= Console.ReadLine();
                    //Console.Write("\n\tВведите возраст студента: ");
                    //student.Age=int.Parse(Console.ReadLine());
                    //Console.Write("\n\tВведите оценки по программированию: ");
                    //student.ProgrammMark=new int[] {int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())};
                    //Console.Write("\n\tВведите оценки по администрированию: ");
                    //student.AdminMark = new int[] { int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) };
                    //Console.Write("\n\tВведите оценки по дизайну: ");
                    //student.DesignMark = new int[] { int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) };
                    Console.WriteLine("\n\tДанные студента: ");
                    Console.WriteLine(student.ToString());
                    student.SetProgrammMark(2, 12);
                    Console.WriteLine("\n\tСредний бал по программированию: {0}", student.GetProgrammAverage());
                    break;
                    case 4:
                   
                    Figure[] figures = new Figure[]
                    {
                        new Triangle(3,4,5,4),
                        new Triangle(5,9,10,4),
                        new Squere(4),
                        new Rectangle(5,7),
                        new Rhomb(3,5,4),
                        new Parallelogram(7,3,4),
                        new Trapeze(3,5,4)
                    };

                    CompoundFigure allFigures = new CompoundFigure(figures);
                    Console.WriteLine($"\n\tОбщая площадь всех фигур: {allFigures.Area()}");
                    Console.WriteLine("\n\tПлощадь каждой отдельной фигуры:");
                    foreach (Figure el in figures) { Console.WriteLine("\n\t" + el.Area()); };

                    break;
               case 5:
                    Console.WriteLine("\n\t Введите данные дроби:");
                    Console.Write("\n\tЧислитель: ");
                    int num = Int32.Parse(Console.ReadLine());
                    Fraction f;
                    int denom;

                    Console.Write("\n\tЗнаменатель: ");
                    denom = Int32.Parse(Console.ReadLine());
                    try
                    {
                        f = new Fraction(num, denom);

                    }
                    catch (DivideByZeroException mes)
                    {
                        Console.WriteLine("\n\t" + mes.Message);
                        Console.WriteLine("\n\tВведите другой знаменатель: ");
                        do
                        {
                            denom = Int32.Parse(Console.ReadLine());
                        } while (denom == 0);
                        f = new Fraction(num, denom);
                    }
                    int a = 10;
                    Fraction f1 = f * a;
                    Console.WriteLine("\n\tf1 = " + f1);
                    Fraction f2 = a * f;
                    Console.WriteLine("\n\tf2 = " + f2);
                    double d = 1.5;
                    Fraction f3 = f + d;
                    Console.WriteLine("\n\tf3 = " + f3);
                    break;

            }
            } while (choice != 0);
        }
    }
}

