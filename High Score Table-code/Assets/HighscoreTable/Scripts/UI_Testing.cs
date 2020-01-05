using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
using CodeMonkey;

public class UI_Testing : MonoBehaviour {

    [SerializeField] private HighscoreTable highscoreTable;

    private void Start() {
        transform.Find("submitScoreBtn").GetComponent<Button_UI>().ClickFunc = () => {
            UI_Blocker.Show_Static();

            UI_InputWindow.Show_Static("Score", 0, () => {

                UI_Blocker.Hide_Static();
            }, (int score) => {

                UI_InputWindow.Show_Static("Player Name", "", "ABCDEFGIJKLMNOPQRSTUVXYWZ", 3, () => {

                    UI_Blocker.Hide_Static();
                }, (string nameText) => {

                    UI_Blocker.Hide_Static();
                    highscoreTable.AddHighscoreEntry(score, nameText);
                });
            });
        };
    }
}
