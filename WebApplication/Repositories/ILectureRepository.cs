using System.Collections.Generic;
using System.Linq;
using WebApplication.Models;

namespace WebApplication.Repositories
{
    public interface ILectureRepository
    {
        void SaveLecture(Lecture lecture);
        List<Lecture> getAllLectures();
        Lecture getLectureById(int id);
        void deleteLecture(int id);
    }
}