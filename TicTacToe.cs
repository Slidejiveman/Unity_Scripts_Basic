using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToe : MonoBehaviour
{

    [SerializeField]
    Text[] cells;
    string mark;
    bool gameOver;
    // capture all of the win conditions to make checks easy
    int[,] wins = new int[,]
    {
        { 0, 1, 2 },
        { 3, 4, 5 },
        { 6, 7, 8 },
        { 0, 3, 6 },
        { 1, 4, 7 },
        { 2, 5, 8 },
        { 0, 4, 8 },
        { 2, 4, 6 }
    };

    // Use this for initialization
    void Start()
    {
        NewGame();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NewGame()
    {
        mark = "X";
        for (int i = 0; i < 9; i++)
        {
            cells[i].text = "";
        }
        gameOver = false;
    }

    public void SelectCell(int index)
    {
        // check to see if the cell is empty. If it isn't return
        if (gameOver || !string.IsNullOrEmpty(cells[index].text))
            return;
        // if it is empty, add the mark.
        cells[index].text = mark;
        // now, change the mark based on the player.
        mark = (mark == "X") ? "0" : "X";
        CheckGameState();
    }

    void CheckGameState()
    {
        // I think i++ and ++i doesn't make a difference here
        // because it is called as a non-nested statement.
        // That means it is called after the loops contents.
        for (int i = 0; i < wins.GetLength(0); i++)
        {
            int j = wins[i, 0];
            int k = wins[i, 1];
            int l = wins[i, 2];
            if (cells[j].text == cells[k].text &&
                cells[k].text == cells[l].text &&
                !string.IsNullOrEmpty(cells[j].text))
            {
                gameOver = true;
                Debug.Log(cells[j].text + " wins");
                Invoke("NewGame", 3f);
                break;
            }
        }
    }
}
