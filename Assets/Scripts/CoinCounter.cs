using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCounter : MonoBehaviour
{
    public int coins = 0;

    private GUIStyle guiStyle = new GUIStyle();
    private void OnGUI()
    {
        //Change font size
        guiStyle.fontSize = 40;
        //Change text color
        GUI.contentColor = Color.white;
        GUI.Label(new Rect(10, 10, 100, 20), "Coins: " + coins, guiStyle);
        
    }

    private void Update()
    {
        if(coins == 10)
        {
            SceneManager.LoadScene("End");
        }
    }
}
