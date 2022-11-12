using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    private MeshRenderer _renderer;

    // ENCAPSULATION
    public Color Color { get; set; }

    // POLYMORPHISM
    public void SetColor(Color color)
    {
        Color = color;
    }
    public void SetColor(float r, float g, float b, float a)
    {
        Color = new Color(r, g, b, a);
    }
    // ABSTRACTION
    public void Initialize()
    {
        _renderer = GetComponent<MeshRenderer>();
    }
    public void RenderColor()
    {
        _renderer.material.color = Color;
    }

    public abstract void ShowProperties();
}
