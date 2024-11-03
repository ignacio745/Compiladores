using System;

namespace Taste
{

    class Taste
    {

        public static void Main(string[] arg)
        {
            
            Scanner scanner = new Scanner("C:\\Users\\nik_c\\Downloads\\Compiladores-main\\Taste3\\Test.TAS");
            Parser parser = new Parser(scanner);
            parser.tab = new SymbolTable(parser);
            parser.gen = new CodeGenerator();
            parser.Parse();
            if (parser.errors.count == 0)
            {
                parser.gen.Decode();
                parser.gen.Interpret("C:\\Users\\nik_c\\Downloads\\Compiladores-main\\Taste3\\Taste.IN");
            }
            while (true) { }
        }

    }

} // end namespace