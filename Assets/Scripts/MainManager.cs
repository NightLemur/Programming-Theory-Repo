using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public Camera cam;
    public GameObject PropertiesContainer;
    public Text PlayerNameText;

    private Sphere selectedSphere; // The Sphere that was last clicked on
    private Cuboid selectedCuboid; // The Cuboid that was last clicked on
    private Cylinder selectedCylinder; // The Cylinder that was last clicked on

    // Start is called before the first frame update
    void Start()
    {
        PlayerNameText.text = $"Current Player: {MenuManager.instance.PlayerName}";
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.GetComponent<Sphere>() != null)
                {
                    selectedSphere = hit.collider.gameObject.GetComponent<Sphere>();
                    selectedSphere.ShowProperties();

                    PropertiesContainer.SetActive(true);
                }
                else if (hit.collider.gameObject.GetComponent<Cuboid>() != null)
                {
                    selectedCuboid = hit.collider.gameObject.GetComponent<Cuboid>();
                    selectedCuboid.ShowProperties();

                    PropertiesContainer.SetActive(true);
                }
                else if (hit.collider.gameObject.GetComponent<Cylinder>() != null)
                {
                    selectedCylinder = hit.collider.gameObject.GetComponent<Cylinder>();
                    selectedCylinder.ShowProperties();

                    PropertiesContainer.SetActive(true);
                }
                else
                    Debug.Log("Unexpected Class encountered.");
            }
            else
                PropertiesContainer.gameObject.SetActive(false);
        }
    }
}
