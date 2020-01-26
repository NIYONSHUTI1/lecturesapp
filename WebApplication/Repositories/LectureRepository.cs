using System.Collections.Generic;
using WebApplication.Models;

namespace WebApplication.Repositories
{
    public class LectureRepository:ILectureRepository
    {
        public void SaveLecture(Lecture lecture)
        {
            throw new System.NotImplementedException();
        }

        public List<Lecture> getAllLectures()
        {
            return new List<Lecture>();
        }

        public Lecture getLectureById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void deleteLecture(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}