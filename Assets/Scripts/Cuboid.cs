using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// INHERITANCE
public class Cuboid : Shape
{
    public Text NameText;
    public Text PropertiesText;

    // ENCAPSULATION
    public float Length { get; set; }
    public float Width { get; set; }
    public float Height { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        // ABSTRACTION
        Initialize();
        Color = Color.yellow;
        Length = 2f;
        Width = 1f;
        Height = 0.5f;

        RenderColor();
    }

    // POLYMORPHISM
    override
    public void ShowProperties()
    {
        NameText.text = "Name: Cuboid";
        PropertiesText.text = $"Length: {Length} Width: {Width} Height: {Height} \nColor: ({Color.r}, {Color.g}, {Color.g}, {Color.a})";
    }
}
