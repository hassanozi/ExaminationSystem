using AutoMapper;
using ExaminationSystem.Data;
using ExaminationSystem.DTOs.Exam;
using ExaminationSystem.DTOs.Instructor;
using ExaminationSystem.Helpers;
using ExaminationSystem.Models;
using ExaminationSystem.Profiles;
using ExaminationSystem.Repositories;
using ExaminationSystem.Services.Exams;
using ExaminationSystem.Services.Instructors;
using ExaminationSystem.ViewModels.Exam;
using ExaminationSystem.ViewModels.Instructors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Xml;

namespace ExaminationSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class InstructorController : ControllerBase
    {

        IInstructorsService _instructorsService;

        public InstructorController(IInstructorsService instructorsService)
        {
            _instructorsService = instructorsService;
        }

        //[HttpGet]
        //public IEnumerable<InstructorViewModel> GetAll()
        //{
        //    IRepository<Instructor> instructorRepository = new Repository<Instructor>();

        //    //IEnumerable<Instructor> instructors = instructorRepository.GetAll();

        //    IEnumerable<InstructorViewModel> result =
        //        instructorRepository.Get(x => x.ID < 100)
        //        .ToViewModels();

        //    //IEnumerable<InstructorViewModel> result =
        //    //    instructorRepository.Get<InstructorViewModel>(x => x.ID < 100,
        //    //    x => new InstructorViewModel { FName = x.FirstName, LName = x.LastName });

        //    //instructors = instructors.Where(x => x.ID < 100);

        //    //IEnumerable<InstructorViewModel> result =
        //    //    instructors.Select(x => new InstructorViewModel { FName = x.FirstName, LName = x.LastName });

        //    //foreach (var item in result)
        //    //{
        //    //    Debug.WriteLine(item.FullName);
        //    //}

        //    return result;


        //    //List<InstructorViewModel> result = new List<InstructorViewModel>();

        //    //foreach (var item in query)
        //    //{
        //    //    Debug.WriteLine(item.FullName);
        //    //    result.Add(item);
        //    //}

        //    //return result;
        //}

        [HttpGet]
        public IEnumerable<InstructorViewModel> GetAllInstructors()
        {
            var instruct = _instructorsService.GetAllInstructors();

            return instruct.Select(x => x.MapOne<InstructorViewModel>());
        }

        [HttpGet]
        public InstructorViewModel GetByID(int id)
        {
            var instruct = _instructorsService.GetInstructorById(id);
            
            return instruct.MapOne<InstructorViewModel>();
        }



        [HttpPost]
        public void Post(InstructorCreateViewModel viewModel)
        {
            var instructor = viewModel.MapOne<InstructorCreateDTO>();

            _instructorsService.AddInstructor(instructor);
        }
        [HttpPut]
        public bool Update(InstructorUpdateViewModel viewModel)
        {
            _instructorsService.UpdateInstructor(viewModel);

            return true;
        }

    }
}
