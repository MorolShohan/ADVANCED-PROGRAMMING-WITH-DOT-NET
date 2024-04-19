using BLL.DTOs;
using DAL.EF.Entities;
using DAL.Repos;
using System.Collections.Generic;

namespace BLL.Services
{
    public class CourseService
    {
        public static void Create(CourseDTO c)
        {
            //convert courseDTO to Course
            Course cd = new Course();
            new CourseRepo().Create(cd);

        }

        public static List<CourseDTO> Get()
        {
            var data = new CourseRepo().Get();//List of course
            //convert to courseDTO
            var list = new List<CourseDTO>();
            return list;
        }
    }
}
