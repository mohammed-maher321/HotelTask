﻿using HotelTask.Application.Interfaces;
using HotelTask.Application.Services;

namespace HotelTask.API.Extension
{
    public static class ServiceExtension
    {
        public delegate IReadHotelService ServiceResolver(string key);
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<ReadJsonHotelService>();
            services.AddTransient<ReadXmlHotelService>();
            services.AddTransient<IHotelService,HotelService>();

            services.AddTransient<ServiceResolver>(serviceProvider => key =>
            {
                switch (key)
                {
                    case "Json":
                        return serviceProvider.GetService<ReadJsonHotelService>();
                    case "Xml":
                        return serviceProvider.GetService<ReadXmlHotelService>();
                    default:
                        throw new KeyNotFoundException(); // or maybe return null, up to you
                }
            });

        }
    }
}
