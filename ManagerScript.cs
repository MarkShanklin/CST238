using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ManagerScript : MonoBehaviour
{
    public Text targetText;
    private Text thisText;
    private Button myButton;
    public Text playerText;

    void OnEnable()
    {
        myButton = GetComponent<Button>();
        thisText = GetComponentInChildren<Text>();

        myButton.onClick.AddListener(() => { ChangeTarget(); });
    }

    public void ChangeTarget()
    {
        string playerString = playerText.text;
        if(thisText.text.Length.Equals(0))
        {
            targetText.text = playerString;
            if (playerString.Equals("X"))
            {
                playerText.text = "O";
            }
            else if(playerString.Equals("O"))
            {
                playerText.text = "X";
            }         
        }   
    }
}