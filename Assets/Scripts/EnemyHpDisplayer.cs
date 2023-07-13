using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static Enemy;

public class EnemyHpDisplayer : MonoBehaviour
{

    private TextMeshProUGUI HPDisp;
    private Enemy enemyscript;

    void Start()
    {
        HPDisp = gameObject.GetComponent<TextMeshProUGUI>();
        enemyscript = GameObject.Find("Enemy").GetComponent<Enemy>();
    }


    void Update()
    {
        HPDisp.text = enemyscript.HP.ToString();
    }
}
