namespace Kodlama.io.Entities;

public class Course
{
    public int CourseId { get; set; }
    public int CategoryId { get; set; } //bir kurs bir kategoriye dahil olmalı.
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    public List<Instructor> Instructors { get; set; } // Bir kursun birden fazla eğitmeni olabilir.
}