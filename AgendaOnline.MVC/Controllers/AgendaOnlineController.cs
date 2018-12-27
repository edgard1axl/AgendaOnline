using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaOnline.Application.Contracts;
using AgendaOnline.Application.Messages;
using AgendaOnline.Domain.Entities;
using AgendaOnline.MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendaOnline.MVC.Controllers
{
    public class AgendaOnlineController : Controller
    {
        private readonly IAgendaOnlineService _agendaOnlineService;

        public AgendaOnlineController(IAgendaOnlineService agendaOnlineService)
        {
            _agendaOnlineService = agendaOnlineService;
        }

        // GET: AgendaOnline
        public async Task<ActionResult> Index()
        {
            //IList<Contact> contacts = await _agendaOnlineService.GetListContact(null);
            //ContactViewModel model = new ContactViewModel();
            //model.MapContact(contacts);
            return View();
        }

        // GET: AgendaOnline/Details/5
        public ActionResult Details(int id)
        {
            _agendaOnlineService.GetListContact(null);

            return View();
        }

        // GET: AgendaOnline/Details
        public ActionResult Details(IFormCollection collection)
        {
            var resultado = _agendaOnlineService.GetListContact(null);

            return View(resultado);
        }

        // POST: AgendaOnline/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind]ContactViewModel contactModel)
        {
            try
            {
                var contact = contactModel.MapModelToContact(contactModel);
                SaveContactRequest request = new SaveContactRequest();
                request.Contact = contact;
                await _agendaOnlineService.SaveContractAgendaOnline(request);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AgendaOnline/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AgendaOnline/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AgendaOnline/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AgendaOnline/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}