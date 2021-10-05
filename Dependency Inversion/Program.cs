using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{

    interface IDataFormatter
    {
        void Convert();
    }
    class JsonFormatter : IDataFormatter
    {
        public void Convert()
        {
            Console.WriteLine("Json Formatina Cevrildi");
        }
    }
    class XMLFormatter : IDataFormatter
    {
        public void Convert()
        {
            Console.WriteLine("XML Formatina Cevrildi");
        }
    }

    class FormatConverter
    {
        public IDataFormatter Format { get; set; }
        public FormatConverter(IDataFormatter Format)
        {
            this.Format = Format;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            FormatConverter jsonConvert= new FormatConverter(new JsonFormatter());
            jsonConvert.Format.Convert();


            FormatConverter XmlConvert = new FormatConverter(new XMLFormatter());
            XmlConvert.Format.Convert();

        }


    }
}
