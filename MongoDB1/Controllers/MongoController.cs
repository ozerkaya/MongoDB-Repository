using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB1.Models;
using MongoRL.Interfaces;
using MongoRL.Poco;
using MongoRL.Repo;

namespace MongoDB1.Controllers
{
    public class MongoController : Controller
    {
        private readonly IStudentDAL _studentDAL;
        private readonly ISchoolsDAL _schoolsDAL;
        private StudentsModel studentModel;
        private SchoolsModel schoolsModel;

        public MongoController(IStudentDAL studentDAL, ISchoolsDAL schoolsDAL)
        {
            _studentDAL = studentDAL;
            _schoolsDAL = schoolsDAL;
            studentModel = new StudentsModel();
            schoolsModel = new SchoolsModel();
        }

        public IActionResult Students()
        {
            studentModel.List = _studentDAL.Get().ToList();
            return View(studentModel);
        }

        [HttpPost]
        public async Task<IActionResult> Students(StudentsModel dataModel, string operation)
        {
            switch (operation)
            {
                case "GetAll":
                    studentModel.List = _studentDAL.Get().ToList();
                    return View(studentModel);
                case "Add":
                    await _studentDAL.AddAsync(new Students
                    {
                        Age = dataModel.Age,
                        Name = dataModel.Name,
                        Surname = dataModel.Surname,
                        CreatedAt = DateTime.Now,
                    });
                    break;
            }

            studentModel.List = _studentDAL.Get().ToList();
            return View(studentModel);
        }

        public IActionResult Schools()
        {
            schoolsModel.List = _schoolsDAL.Get().ToList();
            return View(schoolsModel);
        }

        [HttpPost]
        public async Task<IActionResult> Schools(SchoolsModel dataModel, string operation)
        {
            switch (operation)
            {
                case "GetAll":
                    schoolsModel.List = _schoolsDAL.Get().ToList();
                    return View(schoolsModel);
                case "Add":
                    await _schoolsDAL.AddAsync(new Schools
                    {
                        Name = dataModel.Name,
                        City = dataModel.City
                    });
                    break;
            }

            schoolsModel.List = _schoolsDAL.Get().ToList();
            return View(schoolsModel);
        }
    }
}
