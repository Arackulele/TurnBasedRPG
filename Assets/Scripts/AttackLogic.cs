using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using static Enemy;
using static Player;
using static BattleSequencer;
using TMPro;
using UnityEngine.UI;

public class AttackLogic : MonoBehaviour
{

    private Enemy enemyscript;
    private Player playerscript;
    private BattleSequencer battlesequencer;

    private ParticleSystem bloodfx;



    private Button button;

    // Start is called before the first frame update
    void Start()
    {

    enemyscript = GameObject.Find("Enemy").GetComponent<Enemy>();

    playerscript = GameObject.Find("Player").GetComponent<Player>();

    battlesequencer = GameObject.Find("BattleSequencer").GetComponent<BattleSequencer>();

    button = gameObject.GetComponent<Button>();

    bloodfx = GameObject.Find("BloodFX").GetComponent<ParticleSystem>();

    }



    public void OnPress()
    {

        bloodfx.Clear();

        bloodfx.Play();

        enemyscript.HP -= Math.Max((playerscript.Attack + UnityEngine.Random.Range(0, 5) + playerscript.TempAttackPlus) - enemyscript.Armor, 0);

        Debug.Log("Dealing " + playerscript.Attack + "Random" + playerscript.TempAttackPlus + "Damage");

        playerscript.TempAttackPlus = 0;

        StartCoroutine(battlesequencer.CombatSequence());

    }


}
