using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Enemy;
using static Player;
using static BattleSequencer;
using TMPro;
using UnityEngine.UI;

public class SecondButtonScript : MonoBehaviour
{

    private Enemy enemyscript;
    private Player playerscript;
    private BattleSequencer battlesequencer;

    private TextMeshProUGUI secondbuttontext;

    private Button button;

    // Start is called before the first frame update
    void Start()
    {



    enemyscript = GameObject.Find("Enemy").GetComponent<Enemy>();

    playerscript = GameObject.Find("Player").GetComponent<Player>();

    battlesequencer = GameObject.Find("BattleSequencer").GetComponent<BattleSequencer>();

        secondbuttontext = GameObject.Find("ScndBtnTxt").GetComponent<TextMeshProUGUI>();

        button = gameObject.GetComponent<Button>();



    }

    void Update()
    {

        switch (playerscript.Class)
        {
            default:
            case 1:

                secondbuttontext.text = "Warcry";

                break;
            case 2:

                secondbuttontext.text = "Heal";

                break;
            case 3:

                secondbuttontext.text = "Shield";

                break;

            case 4:

                secondbuttontext.text = "Cast";

                break;
        }

    }



    public void OnPress()
    {

        switch (playerscript.Class)
        {
            default:
            case 1:

                playerscript.TempAttackPlus += 2;

                break;
            case 2:

                playerscript.HP += 2;

                break;
            case 3:

                playerscript.Armor++;

                break;

            case 4:

                //spell logic here

                break;
        }



        StartCoroutine(battlesequencer.CombatSequence());

    }


}
