﻿namespace TicketToCode.Api.Endpoints.Ingredients;

public class GetAllRecipes : IEndpoint
{
    public static void MapEndpoint(IEndpointRouteBuilder app) => app
    .MapGet("/Recipes", Handle)
    .WithTags("Recipes")
    .WithSummary("Get all recipes");

    // DTO's

    public record Response(
        int Id, 
        string Name, 
        Category Category);

    // Logic
    private static List<Response> Handle(IDatabase db)
    {
        return db.Recipes
            .Select(item => new Response(
                item.Id,
                item.Name,
                item.Category))
            .ToList();

    }


    }

