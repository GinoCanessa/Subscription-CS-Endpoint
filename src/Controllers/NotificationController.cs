using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace subscription_cs_endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Route("/")]
    public class NotificationController : ControllerBase
    {
      [HttpGet]
      [Produces("text/plain")]
      public string DefaultGet()
      {
        return $"OK: {DateTime.Now.ToString()}";
      }

      [HttpPost]
      [Consumes("application/fhir+json", new[] {"application/json"})]
      public virtual async Task<IActionResult> HandlePost()
      {
        // sanity check
        if ((Request == null) || (Request.Body == null))
        {
          System.Console.WriteLine("HandlePost <<< cannot process a POST without data!");
          return StatusCode(400, "POST requires data");
        }

        try
        {
          // read the post body to process
          using (StreamReader reader = new StreamReader(Request.Body))
          {
            string content = await reader.ReadToEndAsync();

            if (!Notification.HandleNotification(content))
            {
              System.Console.WriteLine(
                "vvvvv POST vvvvv\n" +
                content + "\n" +
                "^^^^^ POST ^^^^^");
            }
          }
        }
        catch (Exception ex)
        {
          System.Console.WriteLine($"HandlePost <<< caught: {ex.Message}");
          if (ex.InnerException != null)
          {
            System.Console.WriteLine($" <<< inner: {ex.InnerException.Message}");
          }
          return StatusCode(500, ex.Message);
        }

        // accept with no content
        return StatusCode(204);
      }
    }
}