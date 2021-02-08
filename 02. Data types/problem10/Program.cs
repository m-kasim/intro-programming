using System;

/*
Напишете програма, която принтира фигура във формата на сърце със знака "o". 
*/
namespace problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            string ASCIIHeart = @"
                                     oooooo              ooooooo
                                    ooooooooo           oooooooooo
                                   ooooooooooo         oooooooooooo
                                  ooooooooooooooo     oooooooooooooo
                                 oooooooooooooooooo ooooooooooooooooo
                                 ooooooooooooooooooooooooooooooooooooo
                                  oooooooooooooooooooooooooooooooooooo
                                   oooooooooooooooooooooooooooooooooo
                                    oooooooooooooooooooooooooooooooo
                                      oooooooooooooooooooooooooooo
                                       ooooooooooooooooooooooooo
                                        oooooooooooooooooooooooo
                                          oooooooooooooooooooo
                                            ooooooooooooooooo
                                              ooooooooooooo
                                                ooooooooo
                                                  ooooo
                                                   oo
";
            Console.WriteLine(ASCIIHeart);
        }
    }
}
