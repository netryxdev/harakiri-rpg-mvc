using Microsoft.AspNetCore.Mvc;

namespace harakiri_rpg.Controllers
{
    public abstract class BaseController : Controller
    {
        protected virtual void DisplayMessage(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                return;

            TempData["display-message"] = message;
        }

        protected virtual void DisplayMessage(params string[] messages)
        {
            if (messages.All(string.IsNullOrWhiteSpace))
                return;

            TempData["display-message"] = string.Join('\n', messages.Where(a => !string.IsNullOrWhiteSpace(a)));
        }

        protected virtual void DisplayError(string error)
        {
            if (string.IsNullOrWhiteSpace(error))
                return;
            TempData["display-error"] = error;
        }

        protected virtual void DisplayError(params string[] errors)
        {
            if (errors.All(string.IsNullOrWhiteSpace))
                return;

            TempData["display-error"] = string.Join('\n', errors.Where(a => !string.IsNullOrWhiteSpace(a)));
        }

        protected virtual void DisplayWarning(string warning)
        {
            if (string.IsNullOrWhiteSpace(warning))
                return;
            TempData["display-warning"] = warning;
        }

        protected virtual void DisplayWarning(params string[] warnings)
        {
            if (warnings.All(string.IsNullOrWhiteSpace))
                return;

            TempData["display-warning"] = string.Join('\n', warnings.Where(a => !string.IsNullOrWhiteSpace(a)));
        }
    }
}
