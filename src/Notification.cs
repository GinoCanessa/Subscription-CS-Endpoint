using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace subscription_cs_endpoint
{
    public static class Notification
    {

      /// <summary>
      /// Function to handle a subscription notification
      /// </summary>
      /// <param name="content"></param>
      /// <returns>True if handled correctly, false otherwise.</returns>
      public static bool HandleNotification(string content)
      {
        if (string.IsNullOrEmpty(content))
        {
          return false;
        }

        try
        {
          fhirCsR4.Models.Bundle bundle = JsonSerializer.Deserialize<fhirCsR4.Models.Bundle>(content);

          if ((bundle.Entry == null) || (!bundle.Entry.Any()))
          {
            System.Console.WriteLine($"HandleNotification <<< bundle: {bundle.Id} has no entries!");
            return false;
          }

          if (bundle.Entry[0].Resource == null)
          {
            System.Console.WriteLine($"HandleNotification <<< bundle {bundle.Id} entry[0] is missing the resource!");
            return false;
          }

          if (bundle.Entry[0].Resource.ResourceType != "SubscriptionStatus")
          {
            System.Console.WriteLine($"HandleNotification <<< invalid entry[0] resource type: {bundle.Entry[0].Resource.ResourceType}");
            return false;
          }

          fhirCsR4.Models.SubscriptionStatus status = (fhirCsR4.Models.SubscriptionStatus)bundle.Entry[0].Resource;

          System.Console.WriteLine($" <<<   received notification type: {status.Type}");
          System.Console.WriteLine($"     eventsSinceSubscriptionStart: {status.EventsSinceSubscriptionStart}");
          System.Console.WriteLine($"             eventsInNotification: {status.EventsInNotification}");
        }
        catch (Exception ex)
        {
          System.Console.WriteLine($"HandleNotification <<< caught: {ex.Message}");
          if (ex.InnerException != null)
          {
            System.Console.WriteLine($" <<< inner: {ex.InnerException.Message}");
          }
        }

        // if we are still here, we are successful
        return true;
      }
    }
}