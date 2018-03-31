using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int HP = 100;
    public bool isWaitPlayer = true;
    private int index = 1;
    

    // Use this for initialization
    void Start()
    {

      

    }

    // Update is called once per frame
    void OnDamage(int mValue)
    {
        HP -= mValue;
    }

    void OnGUI()
    {

        if (isWaitPlayer)
        {
            GUI.Window(0, new Rect(Screen.width / 2 , Screen.height / 2, 200, 200), InitWindow, "choose action");
        }
    }

    void InitWindow(int ID)
    {

        if (GUI.Button(new Rect(0, 20, 200, 30), "Attack"))
        {
            Debug.Log("Attack");

            isWaitPlayer = false;

            index += 1;

        }
        if (GUI.Button(new Rect(0, 50, 200, 30), "Deffend"))
        {
            Debug.Log("Attack");

            isWaitPlayer = false;

            index += 1;
        }

    }

}
