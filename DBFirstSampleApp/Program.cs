using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstSampleApp
{ 
    class Program
    {
        static void Main(string[] args)
        {
            using (masterEntities1 dbContext = new masterEntities1())
            {
                /*Sql Query
                var stu = dbContext.STUDENTs.SqlQuery("SELECT * FROM STUDENT where id = 1;").SingleOrDefault();

                //Lazy Loading
                var stuFirst = dbContext.STUDENTs.First();
                var DEPT = stuFirst.DEPTs;

                //Eager Loading
                var stuFirstWithDepts = dbContext.STUDENTs.Include("DEPT.DEPTNAME").First();
                var DEPTNAME = stuFirstWithDepts.DEPTs.First().DEPTNAME.ToList();

                //Explicit Loading
                var STUDENT = dbContext.STUDENTs.Where(s => s.STDID == 1).FirstOrDefault();
                //dbContext.Entry(STUDENT).Collection(s => s.STDNAME).Load();

                //Extension Methods
                var STUDENTFirst = dbContext.STUDENTs.First();
                //var DiscountedAmount = STUDENTFirst.GetDiscountedAmount();

                //Group By
                var STUDENTGroupBySTDID = dbContext.STUDENTs.GroupBy(s => s.STDID).ToList();

                STUDENTGroupBySTDID.ForEach(x => {Console.WriteLine($"STDID:{x.Key},having count of { x.Count()}"); });
                STUDENTGroupBySTDID.ForEach(x => {Console.WriteLine($"STDID:{x.Key},having count of { x.Sum(o => o.Amount)}"); });

                //Create
                Person1 createPerson1 = new Person1();
                createPerson1.FirstName = "Suyash";
                createPerson1.LastName = "Dalvi";
                createPerson1.City = "panvel";
                dbContext.Person1.Add(createPerson1);

                //Create Multiple
                Person1 createPerson2 = new Person1();
                createPerson2.FirstName = "Kunal";
                createPerson2.LastName = "Tembe";
                createPerson2.City = "Lonere";

                Person1 createPerson3 = new Person1();
                createPerson3.FirstName = "Pranay";
                createPerson3.LastName = "Salvi";
                createPerson3.City = "Mahad";

                List<Person1> lstperson1 = new List<Person1>();
                lstperson1.Add(createPerson2);
                lstperson1.Add(createPerson3);
                dbContext.SaveChanges();

                //Find
                Person1 persPerson1 = dbContext.Person1.Find(1);

                //retrieve
                dbContext.Person1.ToList().ForEach(pers => { Console.WriteLine($"Name {pers.FirstName}, City: {pers.City}"); });

                //retrieve specific record
                var Person1 = dbContext.Person1.Where(pers => pers.City == "Vashi").SingleOrDefault();
                Console.WriteLine($"Person1 Name:{Person1.FirstName}, LName:{Person1.LastName}");

                //Remove
                Person1 PersRemove = dbContext.Person1.Where(x => x.FirstName == "Suyash").FirstOrDefault();
                dbContext.Person1.Remove(PersRemove);
                dbContext.SaveChanges();
                dbContext.Person1.ToList().ForEach(pers => { Console.WriteLine($"Name {pers.FirstName}, City: {pers.City}"); });*/
             }
                Console.ReadLine();
        }
    }
}
