using Kodlama.io.DataAccess.Abstracts;
using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccess.Concretes
{
    
    public class CourseDal : ICourseDal
    {
        List<Course> courses;
        public CourseDal()
        {
            Course course1 = new Course();
            course1.CourseId = 1;
            course1.Name = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)";
            course1.Description = ".NET 8 VS..";
            course1.Price = 0;
            course1.Instructors = new List<Instructor> { new Instructor { InstructorId = 1, FirstName = "Engin", LastName = "Demiroğ" } };

            Course course2 = new Course();
            course2.CourseId = 2;
            course2.Name = "(2023) Yazılım Geliştirici Yetiştirme Kampı (Python & Selenium)";
            course2.Description = "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.";
            course2.Price = 10;
            course2.Instructors = new List<Instructor> { new Instructor { InstructorId = 2, FirstName = "Halit Enes", LastName = "Kalaycı"} };

            Course course3 = new Course();
            course3.CourseId = 3;
            course3.Name = "Python";
            course3.Description = "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.";
            course3.Price = 10;
            course3.Instructors = new List<Instructor> { new Instructor { InstructorId = 1, FirstName = "Engin", LastName = "Demiroğ" } };
           
            courses = new List<Course> { course1, course2, course3 };
        }



        //CRUD İşlemleri

        public void Add(Course course)
        {
            courses.Add(course);
            // dbContect.savechanges();
        }

        public void Delete(Course course)
        {
            courses.Remove(course);
            // dbContect.savechanges();

        }

        public Course Update(Course course)
        {
            var courseItem = courses.Where(c => c.CourseId == course.CourseId).FirstOrDefault(); //güncellenmek  istenen veri bulundu.
            courseItem.Name  = course.Name;
            courseItem.Description = course.Description;
            courseItem.Price = course.Price;
            courseItem.Instructors = course.Instructors;

            // dbContect.savechanges();
            return courseItem; //GÜNCELLENEN DEĞERİ DÖNDÜRDÜ.
        }

        public List<Course> GetAll()
        {
            return courses;
        }
    }
}
