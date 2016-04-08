using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class TicTacToe : MonoBehaviour {

    public List<Text> gameboard;
    public GameObject WinPanel;
    public GameObject BasePanel;
    private Text winner;

    void Start()
    {
        BasePanel = GameObject.Find("BasePanel");
        if (BasePanel != null)
        {
           ActivatePanel(BasePanel.GetComponent<CanvasGroup>());
        }
        WinPanel = GameObject.Find("WinPanel");
        if (WinPanel != null)
        {
            DeactivatePanel(WinPanel.GetComponent<CanvasGroup>());
            winner = WinPanel.GetComponentInChildren<Text>();
        }
    }

    public static void ActivatePanel(CanvasGroup panel)
    {
        panel.alpha = 1;
        panel.interactable = true;
        panel.blocksRaycasts = true;
    }

    public static void DeactivatePanel(CanvasGroup panel)
    {
        panel.alpha = 0;
        panel.interactable = false;
        panel.blocksRaycasts = false;
    }

    public void Reset()
    {
        SceneManager.LoadScene(0);
    }

    void FixedUpdate()
    {
        if (winner != null && gameboard != null)
        {
            if ((gameboard[0].text.Equals("X") && gameboard[1].text.Equals("X") && gameboard[2].text.Equals("X")) ||
                (gameboard[3].text.Equals("X") && gameboard[4].text.Equals("X") && gameboard[5].text.Equals("X")) ||
                (gameboard[6].text.Equals("X") && gameboard[7].text.Equals("X") && gameboard[8].text.Equals("X")) ||
                (gameboard[0].text.Equals("X") && gameboard[3].text.Equals("X") && gameboard[6].text.Equals("X")) ||
                (gameboard[1].text.Equals("X") && gameboard[4].text.Equals("X") && gameboard[7].text.Equals("X")) ||
                (gameboard[2].text.Equals("X") && gameboard[5].text.Equals("X") && gameboard[8].text.Equals("X")) ||
                (gameboard[0].text.Equals("X") && gameboard[4].text.Equals("X") && gameboard[8].text.Equals("X")) ||
                (gameboard[2].text.Equals("X") && gameboard[4].text.Equals("X") && gameboard[6].text.Equals("X")))
            {
                winner.text = "X your the Winner!!";
                ActivatePanel(WinPanel.GetComponent<CanvasGroup>());
            }
            else if ((gameboard[0].text.Equals("O") && gameboard[1].text.Equals("O") && gameboard[2].text.Equals("O")) ||
                (gameboard[3].text.Equals("O") && gameboard[4].text.Equals("O") && gameboard[5].text.Equals("O")) ||
                (gameboard[6].text.Equals("O") && gameboard[7].text.Equals("O") && gameboard[8].text.Equals("O")) ||
                (gameboard[0].text.Equals("O") && gameboard[3].text.Equals("O") && gameboard[6].text.Equals("O")) ||
                (gameboard[1].text.Equals("O") && gameboard[4].text.Equals("O") && gameboard[7].text.Equals("O")) ||
                (gameboard[2].text.Equals("O") && gameboard[5].text.Equals("O") && gameboard[8].text.Equals("O")) ||
                (gameboard[0].text.Equals("O") && gameboard[4].text.Equals("O") && gameboard[8].text.Equals("O")) ||
                (gameboard[2].text.Equals("O") && gameboard[4].text.Equals("O") && gameboard[6].text.Equals("O")))
            {
                winner.text = "O your the Winner!!";
                ActivatePanel(WinPanel.GetComponent<CanvasGroup>());
            }
        }
    }
}
