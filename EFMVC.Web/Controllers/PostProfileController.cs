using System.Collections.Generic;
using System.Web.Mvc;
using EFMVC.Web.ViewModels;
using EFMVC.Domain.Commands;
using EFMVC.Core.Common;
using EFMVC.Web.Core.Extensions;
using EFMVC.CommandProcessor.Dispatcher;
using EFMVC.Data.Repositories;
using EFMVC.Web.Core.ActionFilters;
using AutoMapper;
using EFMVC.Model;

namespace EFMVC.Web.Controllers
{
    [CompressResponse]
    public class PostProfileController : Controller
    {
        private readonly ICommandBus commandBus;
        private readonly IPostProfileRepository postProfileRepository;
        public PostProfileController(ICommandBus commandBus, IPostProfileRepository postProfileRepository)
        {
            this.commandBus = commandBus;
            this.postProfileRepository = postProfileRepository;
        }
        //
        // GET: /Profile/

        public ActionResult Index()
        {
            var postProfiles = postProfileRepository.GetAll(); 
            return View(postProfiles);
        }

        //
        // GET: /Profile/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Profile/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // GET: /Profile/Edit/5

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var postProfile = postProfileRepository.GetById(id);
            var viewModel = Mapper.Map<PostProfile, PostProfileFormModel>(postProfile);
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(PostProfileFormModel form)
        {
            if (ModelState.IsValid)
            {
                var command = Mapper.Map<PostProfileFormModel, CreateOrUpdatePostProfileCommand>(form);
                IEnumerable<ValidationResult> errors = commandBus.Validate(command);
                ModelState.AddModelErrors(errors);
                if (ModelState.IsValid)
                {
                    var result = commandBus.Submit(command);
                    if (result.Success) return RedirectToAction("Index");
                }
            }
            //if fail
            if (form.ProfileId == 0)
                return View("Create", form);
            else
                return View("Edit", form);
        }

        //
        // POST: /Profile/Delete/5

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var command = new DeletePostProfileCommand { ProfileId = id };
            var result = commandBus.Submit(command);
            var postProfiles = postProfileRepository.GetAll();
            return PartialView("_PostProfileList", postProfiles);
        }
    }
}
