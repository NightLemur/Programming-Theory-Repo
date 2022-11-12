using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public Text PlayerNameText;

    // Start is called before the first frame update
    void Start()
    {
        PlayerNameText.text = $"Current Player: {MenuManager.instance.PlayerName}";
    }
}
