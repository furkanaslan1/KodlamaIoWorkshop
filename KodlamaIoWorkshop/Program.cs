using KodlamaIoWorkshop.Entities;

Teacher teacher1 = new Teacher(1, "Engin", "Demiroğ", "asdksakdklsl");

Category category1 = new Category(1, "Proglama");

Course course1 = new Course(1, ".NET", "yeni başlayanlar için .NET", "dslkdlkslf", true, teacher1);

course1.Category = category1;

Console.WriteLine(course1.Name);


