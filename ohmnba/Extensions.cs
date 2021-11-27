using Consul;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Threading.Tasks;
using Winton.Extensions.Configuration.Consul;

namespace ohmnba
{
    public static class Extensions
    {
        //public static IHostBuilder UseConsul(this IHostBuilder hostBuilder)
        //{
        //    hostBuilder.ConfigureAppConfiguration((context, builder) =>
        //    {
        //        var applicationName = context.HostingEnvironment.ApplicationName.Replace(".", string.Empty);
        //        var environmentName = context.HostingEnvironment.EnvironmentName;
        //        builder.AddJsonFile($"appsettings.{environmentName}.json", false, true);
        //        // builder.AddJsonFile("appsettings.Defaults.json");
        //        var configurationRoot = builder.Build();
        //        var host = configurationRoot["Consul:Host"];
        //        var consulClient = new ConsulClient(configuration => { configuration.Address = new Uri(host); });
        //        var environmentKVAddress = $"{applicationName}/Config";
        //        var nbaDataEndpoints = $"{applicationName}/nbaDataEndpoints";
        //        var task = consulClient.KV.Get(environmentKVAddress).Result;
        //        if (task.Response == null)
        //        {
        //            var result = File.ReadAllBytes($"appsettings.{environmentName}.json");
        //            consulClient.KV.Put(new KVPair($"{environmentKVAddress}")
        //            {
        //                Value = result
        //            });
        //        }

        //        builder.AddConsul(environmentKVAddress, source =>
        //        {
        //            source.ReloadOnChange = true;
        //            source.ConsulConfigurationOptions = configuration => { configuration.Address = new Uri(host); };
        //        });
        //        var task2 = consulClient.KV.Get(nbaDataEndpoints).Result;
        //        if (task2.Response == null)
        //        {

        //        }
        //        builder.AddConsul(nbaDataEndpoints, source =>
        //        {
        //            source.ReloadOnChange = true;
        //            source.ConsulConfigurationOptions = configuration => { configuration.Address = new Uri(host); };
        //        });
        //    });
        //    return hostBuilder;
        //}

        //public static IServiceCollection AddConsulClient(this IServiceCollection services, string hostAddress)
        //{
        //    services.AddSingleton<IConsulClient>(new ConsulClient(clientConfiguration =>
        //    {
        //        clientConfiguration.Address = new Uri(hostAddress);
        //    }));
        //    return services;
        //}
    }
}
