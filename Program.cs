using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace UsporedaDvaXML
{
    public class Books_Class
    {
        public string Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
    }
    /*public class XML1
    {
        public static List<Books_Class> CreateBookList()
        {
            List<Books_Class> lista_klijenata = new List<Books_Class>
            {
                new Books_Class
                {
                    Id = "20504",
                    Image = "C01",
                    Name = "C# in Depth"
                },
                new Books_Class
                {
                    Id = "20505",
                    Image = "C02",
                    Name = "ASP.NET"
                },
                new Books_Class
                {
                    Id = "20506",
                    Image = "C03",
                    Name = "LINQ in Action "
                },
                new Books_Class
                {
                    Id = "20507",
                    Image = "C04",
                    Name = "Architecting Applications"
                },
            };
            return lista_klijenata;
        }
    }
    public class XML2
    {
        public static List<Books_Class> CreateBookList()
        {
            List<Books_Class> lista_klijenata = new List<Books_Class>
            {
                new Books_Class
                {
                    Id = "20504",
                    Image = "C011",
                    Name = "C# in Depth"
                },
                new Books_Class
                {
                    Id = "20505",
                    Image = "C02",
                    Name = "ASP.NET 2.0"
                },
                new Books_Class
                {
                    Id = "20506",
                    Image = "C03",
                    Name = "LINQ in Action "
                },
                new Books_Class
                {
                    Id = "20508",
                    Image = "C04",
                    Name = "Architecting Applications"
                },
            };
            return lista_klijenata;
        }
    }*/
    internal class Program
    {
        static void Main(string[] args)
        {
            //XDocument.Load();
            XElement el = XDocument.ReadFrom(new StringReader(XmlReader.Create("C:\\Users\\ucenik\\Downloads\\prvi.xml"))) as XElement;

                /*List<Books_Class> book1 = XML1.CreateBookList();

                var prviXml = new XDocument(new XElement("books",
                    from book in book1
                    select new XElement("book",
                        new XAttribute("id", book.Id),
                        new XAttribute("image", book.Image),
                        new XAttribute("name", book.Name)
                        )));

                List<Books_Class> book2 = XML2.CreateBookList();

                var drugiXml = new XDocument(new XElement("books",
                    from book in book2
                    select new XElement("book",
                        new XAttribute("id", book.Id),
                        new XAttribute("image", book.Image),
                        new XAttribute("name", book.Name)
                        )));*/

                Console.WriteLine(prviXml.ToString()+"\r\n");
            Console.WriteLine(drugiXml.ToString());

            Console.ReadLine();
        }
    }
}
