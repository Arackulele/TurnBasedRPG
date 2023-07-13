using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static Player;

public class PlayerAtkDisplayer : MonoBehaviour
{

    private TextMeshProUGUI HPDisp;
    private Player playerscript;

    void Start()
    {
        HPDisp = gameObject.GetComponent<TextMeshProUGUI>();
        playerscript = GameObject.Find("Player").GetComponent<Player>();
    }


    void Update()
    {
        HPDisp.text = playerscript.Attack.ToString();
    }
}
