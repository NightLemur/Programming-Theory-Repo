using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// INHERITANCE
public class Sphere : Shape
{
    public Text NameText;
    public Text PropertiesText;

    private void Start()
    {
        // ABSTRACTION
        Initialize();
        Color = Color.red;
        Diameter = 2f;

        RenderColor();
    }

    // ENCAPSULATION
    public float Diameter { get; set; }

    // POLYMORPHISM
    override
    public void ShowProperties()
    {
        NameText.text = "Name: Sphere";
        PropertiesText.text = $"Diameter: {Diameter} \nColor: ({Color.r}, {Color.g}, {Color.g}, {Color.a})";
    }
}
