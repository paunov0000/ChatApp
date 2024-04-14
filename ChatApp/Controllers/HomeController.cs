using ChatApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    public class HomeController : Controller
    {
        private static readonly ChatViewModel _chatViewModel = new ChatViewModel
        {
            Messages = new List<MessageViewModel>(),
            Message = new MessageViewModel()
        };

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Title"] = nameof(Index);
            return View(_chatViewModel);
        }

        [HttpPost]
        public IActionResult Send(MessageViewModel messageViewModel)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            _chatViewModel.Messages.Add(messageViewModel);

            return RedirectToAction(nameof(Index));
        }
    }
}
