using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproach
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "ram", StudentID = 8, Height = 6, Weight = 170 };


                ctx.Students.Add(stud);
                ctx.SaveChanges();

                var query = from b in ctx.Students
                            orderby b.StudentName
                            select b;

                Console.WriteLine("All students in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.StudentName);
                }
            }
        }


        public partial class AddAddress : DbMigration
        {
            public override void Up()
            {
                AddColumn("dbo.Students", "Address", c => c.String());
            }

            public override void Down()
            {
                DropColumn("dbo.Students", "Address");
            }
        }
    }
}