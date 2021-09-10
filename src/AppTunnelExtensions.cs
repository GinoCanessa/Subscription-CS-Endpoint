using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Localtunnel;
using Localtunnel.Connections;
using Localtunnel.Tunnels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace subscription_cs_endpoint
{
    public static class AppTunnelExtensions
    {
      private const string _tunnelSubdomain = "fhir-cs-tunnel-turtorial";

      private static List<Tunnel> _tunnels = new List<Tunnel>();

      public static async void BuildTunnel(this IApplicationBuilder app)
      {
        IServerAddressesFeature addressesFeature = null;

        // try to get addresses for a few seconds
        for (int loops = 0; loops < 100; loops++)
        {
            addressesFeature = app.ServerFeatures.Get<IServerAddressesFeature>();

            if ((addressesFeature == null) ||
                (!addressesFeature.Addresses.Any()))
            {
                await Task.Delay(100);
                continue;
            }

            break;
        }

        if ((addressesFeature == null) ||
            (!addressesFeature.Addresses.Any()))
        {
            throw new Exception($"Failed to get listen port!");
        }

        foreach (string address in addressesFeature.Addresses)
        {
          if (address.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
          {
            int portSeperatorIndex = address.IndexOf(":", 8);

            if (int.TryParse(address.Substring(portSeperatorIndex + 1), out int port) &&
                (port != 0))
            {
              await BuildSslTunnel(port);
            }
          }
          else if (address.StartsWith("http://", StringComparison.OrdinalIgnoreCase))
          {
            int portSeperatorIndex = address.IndexOf(":", 7);

            if (int.TryParse(address.Substring(portSeperatorIndex + 1), out int port) &&
                (port != 0))
            {
              await BuildHttpTunnel(port);
            }
          }
        }
      }

      private static async Task BuildSslTunnel(int port)
      {
        LocaltunnelClient client = new LocaltunnelClient();

        ProxiedSslTunnelOptions options = new ProxiedSslTunnelOptions()
        {
          Port = port,
        };

        Tunnel tunnel = await client.OpenAsync(
          handle => new ProxiedSslTunnelConnection(handle, options),
          _tunnelSubdomain);

        await tunnel.StartAsync();

        // add to static list to ensure it never goes out of scope
        _tunnels.Add(tunnel);

        System.Console.WriteLine($" <<< opened SSL tunnel: {tunnel.Information.Url}");
      }

      private static async Task BuildHttpTunnel(int port)
      {
        LocaltunnelClient client = new LocaltunnelClient();

        ProxiedHttpTunnelOptions options = new ProxiedHttpTunnelOptions()
        {
          Port = port,
        };

        Tunnel tunnel = await client.OpenAsync(
          handle => new ProxiedHttpTunnelConnection(handle, options),
          _tunnelSubdomain);

        await tunnel.StartAsync();

        // add to static list to ensure it never goes out of scope
        _tunnels.Add(tunnel);

        System.Console.WriteLine($" <<< opened HTTP tunnel: {tunnel.Information.Url}");
      }
  }
}
