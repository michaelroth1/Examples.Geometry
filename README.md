# As simple Geometry assembly

This repository contains a Geometry Assembly focused on computing the areas of basic geometric shapes: rectangles, circles, and triangles.

## Overview

The primary goal of this assembly is to provide functionality for calculating the area of different geometric shapes. It offers methods and classes for computing the area of rectangles, circles, and triangles.

### Geometric Shapes Supported

- **Rectangle:** Includes functions to calculate the area based on its width and height.
- **Circle:** Provides methods to compute the area using its radius.
- **Triangle:** Offers functionality to calculate the area based on its base and height.

## Usage

### Getting Started

To use this Geometry Assembly in your project, follow these steps:

1. **Clone the Repository:**
    ```bash
    git clone https://github.com/michaelroth1/Examples.Geometry
    ```

2. **Include in Your Project:**
    - Integrate the necessary files or the entire assembly into your project's codebase.
    - Import or reference the appropriate classes or functions for area calculations.

### Example Usage

Here's a simple example demonstrating how to calculate the area of different shapes using this assembly:

```csharp
    static void Main(string[] args)
    {   
        Console.WriteLine($"Start the calculation of a rectangle:");

        AreaCalulator calc = new();

        calc.CalculateArea(new Rectangle(2, 4));

        Console.ReadLine();
    }
```