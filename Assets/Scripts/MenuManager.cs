using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public InputField PlayerNameInputField;

    public static MenuManager instance;

    // ENCAPSULATION
    public string PlayerName { get; private set; }

    // Start is called before the first frame update
    void Awake()
    {
        if (instance != null)
            Destroy(instance.gameObject);

        instance = this;
        DontDestroyOnLoad(instance.gameObject);
    }

    // Public UI Functions
    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene(1);
    }
    public void OnNameInputFieldFinishedEdit()
    {
        PlayerName = PlayerNameInputField.text;
    }
}
