using Microsoft.AspNetCore.Mvc;

namespace RPG.Controllers
{
    public class GameController : Controller
    {
        private static readonly List<string> Messages = new List<string>
    {
        "ようこそ、勇者よ……",
        "ここは不思議な村だ。",
        "さあ、冒険に出かけよう！"c
    };

        private static int messageIndex = 0;

        public IActionResult GetNextMessage()
        {
            if (messageIndex < Messages.Count)
            {
                return Content(Messages[messageIndex++]);
            }
            else
            {
                return Content("（おしまい）");
            }
        }
    }
}
