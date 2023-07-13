using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CarryObjects : MonoBehaviour
{
    private TMP_Dropdown classselect;

    private static CarryObjects instances;

    public int Class = 1;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);

        if (instances == null)
        {
            instances = this;
        }
        else
        {
            DestroyObject(gameObject);
        }

        classselect = GameObject.Find("Dropdown").GetComponent<TMP_Dropdown>();

    }

    public void SetClass()
    {
        Class = classselect.value + 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
