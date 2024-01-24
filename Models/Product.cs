﻿namespace BlazorEcommerce.Models;

public class Product
{
    public int Id { get; set; }
    public string? Title { get; set; } = string.Empty;
    public float Price { get; set; } = 0.0f;
    public string? Category { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public string? Image { get; set; } = string.Empty;
}
