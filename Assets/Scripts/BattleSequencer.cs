using System.Collections;
using System.Collections.Generic;
using System;
using static Enemy;
using static Player;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class BattleSequencer : MonoBehaviour
{

    private Enemy enemyscript;
    private Player playerscript;
    private Button button;
    private Button SecondButton;

    private TextMeshProUGUI BigText;

    // Start is called before the first frame update
    void Start()
    {

        enemyscript = GameObject.Find("Enemy").GetComponent<Enemy>();

        playerscript = GameObject.Find("Player").GetComponent<Player>();

        button = GameObject.Find("AttackButton").GetComponent<Button>();

        SecondButton = GameObject.Find("SecondAction").GetComponent<Button>();

        BigText = GameObject.Find("BigText").GetComponent<TextMeshProUGUI>();

    }

    public bool battleend = false;
    // Update is called once per frame
    void Update()
    {
        if (battleend == false)
        {
            if (enemyscript.HP <= 0)
            {
                StopAllCoroutines();
                battleend = true;
                button.interactable = false;
                SecondButton.interactable = false;
                StartCoroutine(DisplayBigText("You win!"));

            }

            if (playerscript.HP <= 0)
            {
                StopAllCoroutines();
                battleend = true;
                button.interactable = false;
                SecondButton.interactable = false;
                StartCoroutine(DisplayBigText("You lost!"));


            }
        }

    }

    public IEnumerator CombatSequence()
    {

        if ( enemyscript.HP <= 0 || playerscript.HP <= 0)
        {
        }
        else { 

            button.interactable = false;
        SecondButton.interactable = false;

        yield return new WaitForSeconds(0.5f);

            //enemy actions
        playerscript.HP -= Math.Max(enemyscript.Attack - playerscript.Armor, 0);

        yield return new WaitForSeconds(0.5f);

        button.interactable = true;
        SecondButton.interactable = true;

        yield break;
        }
    }

    public IEnumerator DisplayBigText(string Text)
    {
        BigText.text = Text;

        yield return new WaitForSeconds(1.2f);


        SceneManager.LoadScene("MenuScene");

    }
}
