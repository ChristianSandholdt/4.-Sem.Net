﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Product
{
    private string name; // field
    public string Name // property
    {
        get { return name; }
        private set { name = value; }
    }

    private double price; // field
    public double Price // property
    { 
        // 
        set {
            if (value <= 0)
            { 
                throw new Exception("Price is not accepted"); 
            } 
            else { 
                price = value; 
            } 
        } 
        get { return price; } 
    }


    private string imageUrl; // field
    public string ImageUrl // property
    {
        get { return imageUrl; }
        set { imageUrl = value; }
    }

    private string manufacturer; // field
    public string Manufacturer // property
    {
        get { return manufacturer;}
        set { manufacturer = value; }
    }

    // constructor 1
    public Product(string name, double price)
    {
        this.name = name;
        this.price = price;
    }

    // constructor 2
    public Product(string name, double price, string imageUrl, string manufacturer)
    {
        Name = name;
        Price = price;
        ImageUrl = imageUrl;
        Manufacturer = manufacturer;
    }
}