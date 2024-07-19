﻿using Looplex.DotNet.Core.Application.Abstractions.Services;
using Looplex.DotNet.Core.WebAPI.Routes;
using Looplex.DotNet.Middlewares.ScimV2.ExtensionMethods;

namespace Looplex.DotNet.Samples.WebAPI.Routes;

public class DefaultScimV2RouteOptions
{
    public static ScimV2RouteOptions CreateFor<TService>() where TService : class, ICrudService
    {
        var service = nameof(TService);
        return new ScimV2RouteOptions
        {
            
            OptionsForGet = new RouteBuilderOptions
            {
                Services = [$"{service}.{nameof(ICrudService.GetAllAsync)}"],
                Middlewares = [],
            },
            OptionsForGetById = new RouteBuilderOptions
            {
                Services = [$"{service}.{nameof(ICrudService.GetByIdAsync)}"],
                Middlewares = [],
            },
            OptionsForPost = new RouteBuilderOptions
            {
                Services = [$"{service}.{nameof(ICrudService.CreateAsync)}"],
                Middlewares = [],
            },
            OptionsForDelete = new RouteBuilderOptions
            {
                Services = [$"{service}.{nameof(ICrudService.DeleteAsync)}"],
                Middlewares = [],
            },
        };
    }
}