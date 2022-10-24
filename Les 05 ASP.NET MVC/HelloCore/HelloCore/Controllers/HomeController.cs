﻿using Microsoft.AspNetCore.Mvc;

using HelloCore.Entities;
using HelloCore.Services;
using HelloCore.ViewModels;

namespace HelloCore.Controllers;

public class HomeController : Controller
{
    private readonly IRestaurantData restaurantData;
    private readonly IGreeter greeter;

    public HomeController(IRestaurantData restaurantData, IGreeter greeter)
    {
        this.restaurantData = restaurantData;
        this.greeter = greeter;
    }

    public IActionResult Index()
    {
        //var restaurant = new Restaurant() { Id = 1, Name = "The Restaurant" };
        //var restaurants = restaurantData.GetAll();
        //return new ObjectResult(restaurants);
        var model = new HomePageViewModel();
        model.Restaurants = restaurantData.GetAll();
        model.CurrentMessage = greeter.GetGreeting();
        return new ObjectResult(model);
    }
    public IActionResult Detail(int id)
    {
        var restaurant = restaurantData.Get(id);
        if (restaurant is null)
        {
            return NotFound();
        }
        return Ok(restaurant);
    }
    [HttpPost]
    public IActionResult Create([FromBody]RestaurantCreateViewModel restaurantCreateViewModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var newRestaurant = new Restaurant()
        {
            Name = restaurantCreateViewModel.Name,
            CuisineType = restaurantCreateViewModel.CuisineType,
        };
        restaurantData.Add(newRestaurant);
        return CreatedAtAction(nameof(Detail), new { newRestaurant.Id }, newRestaurant);
    }
}
