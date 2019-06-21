//using ConsoleApp.db.AdventureWorks2017.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace ConsoleApp.Queries
//{
//    public class MetodosBasicos
//    {
//        private readonly ConsoleAppContext db2; 
//        public MetodosBasicos()
//        {
//            var db2 = new ConsoleAppContext();
//        }
//        public void ContadorDeRegistros()
//        {
//            // Metodo 1
//            using (var db = new ConsoleAppContext())
//            {
//                Console.WriteLine("Total de Registros: " + db.Person.Count());
//            }
//            // Metodo 2
//            Console.WriteLine("Total de Registros: " + db2.Person.Count());
//        }
//    }
//}
