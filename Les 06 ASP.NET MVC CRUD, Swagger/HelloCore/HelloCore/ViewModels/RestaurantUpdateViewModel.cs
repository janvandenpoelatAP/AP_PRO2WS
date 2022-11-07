﻿using HelloCore.Entities;
using System.ComponentModel.DataAnnotations;

namespace HelloCore.ViewModels;

public class RestaurantUpdateViewModel
{
    [Required, MaxLength(80)]
    public string Name { get; set; }
    public CuisineType CuisineType { get; set; }
}
