using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CarryObjects;

public class Player : MonoBehaviour
{

    public int HP = 10;
    public int Attack = 1;
    public int Armor = 0;

    public int TempAttackPlus = 0;

    public int Class = 2;
    public int Level = 1;

    //1 = Warrior
    //2 = Cleric
    //3 = Knight
    //4 = Wizard

    private CarryObjects carry;

    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("ValuesToCarry") != null) carry = GameObject.Find("ValuesToCarry").GetComponent<CarryObjects>();
    }

    // Update is called once per frame
    void Update()
    {

        if (carry != null) Class = carry.Class;
        else Class = 1;


    }
}
