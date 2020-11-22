using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using OrganisationX.Contracts;
using OrganisationX.Data;
using OrganisationX.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OrganisationX.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _repo;
        private readonly IMapper _mapper;


        public EmployeeController(IEmployeeRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // GET: EmployeeController
        public ActionResult Index()
        {
            var employee = _repo.FindAll().ToList();
            var model = _mapper.Map<List<Employees>, List<EmployeesVM>>(employee);
            return View(model);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(string id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var employees = _repo.FindById(id);
            var model = _mapper.Map<EmployeesVM>(employees);

            return View(model);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeesVM model)
        {
            try
            {
                var employees = _mapper.Map<Employees>(model);
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                
                var isSuccess = _repo.Create(employees);

                if (!isSuccess)
                {
                    ModelState.AddModelError("", "Something Went Wrong");
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(string id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var employees = _repo.FindById(id);
            var model = _mapper.Map<EmployeesVM>(employees);

            return View(model);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeesVM model)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var employee = _mapper.Map<Employees>(model);
                var isSuccess = _repo.Update(employee);

                if (!isSuccess)
                {
                    ModelState.AddModelError("", "Something Went Wrong");
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "Something Went Wrong");
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(string id)
        {
            var employee = _repo.FindById(id);
            if (employee == null)
            {
                return NotFound();
            }
            var isSuccess = _repo.Delete(employee);

            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: LeaveTypesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, EmployeesVM model)
        {
            try
            {
                var employee = _repo.FindById(id);
                if (employee == null)
                {
                    return NotFound();
                }
                var isSuccess = _repo.Delete(employee);

                if (!isSuccess)
                {
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
    }
}
