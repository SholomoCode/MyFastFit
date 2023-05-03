using Microsoft.AspNetCore.Mvc;
using MyFastFit.Data;
using MyFastFit.Models;
using MyFastFit.ViewModels;

namespace MyFastFit.Controllers
{
    public class MembersController : Controller
    {
        private FastFitDbContext context;

        public MembersController(FastFitDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            List<Members> members = context.Members.ToList();
            return View(members);
        }

        public IActionResult Add()
        {
            MembersViewModel addMembersViewModel = new MembersViewModel();

            return View(addMembersViewModel);
        }

        [HttpPost] 
        public IActionResult Add(MembersViewModel addMembersViewModel)
        {
            if (ModelState.IsValid)
            {
                Members newMember = new Members
                {
                    Name = addMembersViewModel.Name,
                    ShoeSize = addMembersViewModel.ShoeSize,
                    ShoeType = addMembersViewModel.ShoeType,
                };

                context.Members.Add(newMember);
                context.SaveChanges();

                return Redirect("/Members");
            }
            return View(addMembersViewModel);
        }
    }
}
