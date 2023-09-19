using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserCRUD.Data;
using UserCRUD.Models;
using UserCRUD.Models.Domain;

namespace UserCRUD.Controllers
{
    public class UsersController : Controller
    {
        private readonly MVCDataContext mvcDataContext;

        public UsersController(MVCDataContext mvcDataContext)
        {
            this.mvcDataContext = mvcDataContext;
        }
        [HttpGet]
        public async Task<IActionResult> index()
        {
            var users = await mvcDataContext.Users.ToListAsync();
            return View(users);
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddUserViewModel addUserRequest)
        {
            var user = new User()
            {
                Id = Guid.NewGuid(),
                Name = addUserRequest.Name,
                Email = addUserRequest.Email,
                Salary = addUserRequest.Salary,
                Department = addUserRequest.Department,
                DateOfBirth = addUserRequest.DateOfBirth,
            };

            await mvcDataContext.Users.AddAsync(user);
            await mvcDataContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var user = await mvcDataContext.Users.FirstOrDefaultAsync(x => x.Id == id);
            if(user != null)
            {
                var viewModel = new UpdateUserViewModel()
                {
                    Id = user.Id,
                    Name = user.Name,
                    Email = user.Email,
                    Salary = user.Salary,
                    Department = user.Department,
                    DateOfBirth = user.DateOfBirth,
                };
                return View(viewModel);
            }
           
            return RedirectToAction("Index");
        }


        [HttpPost]
        public async Task<IActionResult> Edit(UpdateUserViewModel model)
        {
            var user = await mvcDataContext.Users.FindAsync(model.Id);
            if(user != null)
            {
                user.Id = model.Id;
                user.Name = model.Name; 
                user.Email = model.Email;   
                user.Salary = model.Salary; 
                user.Department = model.Department;
                user.DateOfBirth = model.DateOfBirth;

                await mvcDataContext.SaveChangesAsync();
                return RedirectToAction("Index");
            };
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UpdateUserViewModel model)
        {
            var user = await mvcDataContext.Users.FindAsync(model.Id);
            if(user != null)
            {
                mvcDataContext.Users.Remove(user);
                await mvcDataContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
	}
}
