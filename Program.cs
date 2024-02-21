// See https://aka.ms/new-console-template for more information
using Kodlama.io.Business;
using Kodlama.io.DataAccess.Abstracts;
using Kodlama.io.DataAccess.Concretes;
using Kodlama.io.Entities;

Console.WriteLine("Hello, World!");

Console.WriteLine("\n Add işlemi öncesi Kurslar Listesi");

CourseManager courseManager = new CourseManager(new CourseDal());
List<Course> listCourses = courseManager.GetAll();
for (int i = 0; i < listCourses.Count; i++)
{
    Console.WriteLine(listCourses[i].Name);
}

//ADD İŞLEMİ: course eklenip yeniden listelenmiştir
Course course = new Course();
course.Name = "Programlamaya Giriş İçin Temel Kurs";
courseManager.Add(course);

Console.WriteLine("\n Add işlemi sonrası Kurslar Listesi ");
List<Course> courses = courseManager.GetAll();
for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name);
}
Console.WriteLine("***********");

//Delete İşlemi :course silinip yeniden listelenmiştir
Console.WriteLine("\n Delete işlemi sonrası Kuslar litesi ");

courseManager.Delete(course);
List<Course> courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name);
}

Console.WriteLine("***********");
Console.WriteLine("\n Güncelleme öncesi categori listesi ");
//UPDATE İşlemi

//güncellemeden önce category listesi 
CategoryManager categoryManager = new CategoryManager(new CategoryDal());
List<Category> categories = categoryManager.GetAll();

for (int i = 0; i < categories.Count; i++)
{
    Console.WriteLine(categories[i].CategoryName);
}

Console.WriteLine("\n Güncelleme sonrası kategori listesi.");

Category category = new Category();
category.CategoryName = "Test";
category.CategoryId = 1; //CategoryId = 1 olan yani programlmayı test olarak update edildi.
category.Courses = new List<Course>();

categoryManager.Update(category);


//güncellemeden sonra kategori listesi
List<Category> categories2 = categoryManager.GetAll();

for (int i = 0; i < categories2.Count; i++)
{
    Console.WriteLine(categories2[i].CategoryName);
}


Console.WriteLine("***********");
Console.WriteLine("\n Güncelleme öncesi instructor listesi ");

InstructorManager instructor = new InstructorManager( new InstructorDal());
List<Instructor> instructors = instructor.GetAll();
for (int i = 0; i < instructors.Count; i++)
{
    Console.WriteLine(instructors[i].FirstName + instructors[i].LastName);
}

Console.WriteLine("\n Id ye göre güncelleme insructor ");
Instructor instructor1 = instructors.Where(i => i.InstructorId == 2).FirstOrDefault();
//Console.WriteLine(instructor1.FirstName);
instructor1.City = "Bursa";
instructor.Update(instructor1);

Instructor updateInstructor = instructors.Where(i => i.InstructorId == 2).FirstOrDefault();
Console.WriteLine(instructor1.FirstName + " " + instructor1.City);

int secim = 0;
switch (secim)
{
    case 1:

    default:
        break;
}