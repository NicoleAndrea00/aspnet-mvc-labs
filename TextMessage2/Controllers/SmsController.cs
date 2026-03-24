using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TextMessageModel = TextMessage.Models.MessageText;

namespace TextMessage.Controllers
{
    public class SmsController : Controller
    {
        // GET: SmsController
        public ActionResult Send()
        {
            TextMessageModel message = new TextMessageModel();
            return View(message);
        }

        // POST: SmsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Send(TextMessageModel message)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Confirmation", message);
            }
            return View(message);

        }
        public ActionResult Confirmation(TextMessageModel message)
        {
            return View(message);
        }
    }
}
