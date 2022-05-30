// See https://aka.ms/new-console-template for more information

using Linq;

   #region Data
List<Student> students = new List<Student>()
{
    new Student{Id=1, Name="Mustafa",SurName="Mustafayev",Date=new DateTime(2002,9,6)},
    new Student{Id=2, Name="Ilkin",SurName="Nesibli",Date=new DateTime(2003,12,21)},
    new Student{Id=3, Name="Ferid",SurName="Hebibli",Date=new DateTime(2001,10,7)},
    new Student{Id=4, Name="A",SurName="A1",Date=new DateTime(2002,7,16)},
    new Student{Id=5, Name="B",SurName="B1",Date=new DateTime(2000,3,9)},
    new Student{Id=6, Name="C",SurName="C1",Date=new DateTime(2002,9,6)},
    new Student{Id=7, Name="D",SurName="D1",Date=new DateTime(2002,9,6)},
    new Student{Id=8, Name="E",SurName="E1",Date=new DateTime(2002,9,6)},
    new Student{Id=9, Name="F",SurName="F1",Date=new DateTime(2002,9,6)},
    new Student{Id=10, Name="G",SurName="G1",Date=new DateTime(2002,9,6)}

};
#endregion

#region C# ile id si 4den boyuk olanlar
//    List<Student> StudentC = new List<Student>();

//foreach (var st in students)
//{
//    if (st.Id>4)
//    {
//        StudentC.Add(st);
//    }
//}

//foreach (var S in StudentC)
//{
//    Console.WriteLine(S.Name);
//}


#endregion



#region LINQ

//var query = from x in students
//            where x.id > 4
//            select x;

//foreach (var s in query)
//{
//    console.writeline(s.name);
//}




#endregion

#region Lambda Expression

//var q = students.Where(x => x.Id > 4);

//    foreach (var S in q)
//    {
//        Console.WriteLine(S.Name);
//    }


//Ilk herfi M olanlar

//var query = students.Where(x => x.Name[0] == 'F');

//foreach (var q in query)
//{
//    Console.WriteLine(q.Name);
//}
#endregion

Console.ReadLine();

