﻿using AdoteUmPet.Core.CQRS.Mediator;
using AdoteUmPet.Infrastructure.Contexts;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace AdoteUmPet.API.Configurations
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection AddServicesConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, MediatorHandler>();
            
            services.AddDbContext<ApplicationDbContext>();

            services.AddMediatR(AppDomain.CurrentDomain.Load("AdoteUmPet.Application"));

            return services;
        }
    }
}
