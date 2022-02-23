using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using _13307_egzamin.Models;
using System.Collections.Generic;

namespace _13307_egzamin.Controllers
{
    public class ToDoController : Controller
    {
        private static IList<ToDoModel> tasks = new List<ToDoModel>()
        {
            new ToDoModel(){Id = 1,Title="Sklep", Description=" ulica ********", IsDone = false},
            new ToDoModel(){Id = 1,Title="Zrobic coś tam", Description=" ulica ********", IsDone = false}
        };
        // GET: ToDoController
        public ActionResult Index()
        {
            return View(tasks);
        }

        // GET: ToDoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ToDoController/Create
        public ActionResult Create()
        {
            return View(new ToDoModel());
        }

        // POST: ToDoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ToDoModel toDoModel)
        {
            tasks.Add(toDoModel);

                return RedirectToAction(nameof(Index));
        
        }

        // GET: ToDoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ToDoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ToDoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ToDoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
