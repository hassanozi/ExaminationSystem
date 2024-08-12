using ExaminationSystem.DTOs.Choice;
using ExaminationSystem.Helpers;
using ExaminationSystem.Services.Choices;
using ExaminationSystem.ViewModels.Choices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ChoiceController : ControllerBase
    {
        IChoiceService _choiceService;

        public ChoiceController(IChoiceService choiceService)
        {
            _choiceService = choiceService;
        }

        [HttpPost]
        public bool Post(ChoicesCreateViewModel choicesCreateViewModel)
        {
            var choice = choicesCreateViewModel.MapOne<ChoiceCreateDTO>();

            _choiceService.AddChoice(choice);

            return true;
        }
    }
}
