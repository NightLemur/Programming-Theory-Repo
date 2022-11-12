using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cylinder : Shape
{
    public Text NameText;
    public Text PropertiesText;

    // ENCAPSULATION
    public float Diameter { get; set; }
    public float Height { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        // ABSTRACTION
        Initialize();
        Color = Color.green;
        Diameter = 1f;
        Height = 0.5f;

        RenderColor();
    }

    // POLYMORPHISM
    override
    public void ShowProperties()
    {
        NameText.text = "Name: Cylinder";
        PropertiesText.text = $"Height: {Height} Diameter: {Diameter} \nColor: ({Color.r}, {Color.g}, {Color.g}, {Color.a})";
    }
}
