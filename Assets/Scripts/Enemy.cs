using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public int HP = 100;
    public bool isWaitPlayer = true;
 
    private int index = 1;
   



    void Start()
    {
     
    }

    void OnDamage(int mValue)
    {
        HP -= mValue;
    }


    /// <summary>  
 
    /// </summary>  
    public void StartAI()
    {
        if (!isWaitPlayer)
        {
            if (HP > 20)
            {
                
                if (Random.Range(1, 5) % 5 != 1)
                {
                    Debug.Log("in" + index + "round:Enemy Attack");
                   
                 
                    index += 1;
                    isWaitPlayer = true;
                }
        
                else
                {
                    Debug.Log("in" + index + "round:Enemy Attack2");
                  
                    index += 1;
                    isWaitPlayer = true;
                }
            }
            else
            {
                switch (Random.Range(1, 5) % 5)
                {
                    case 0:
                        Debug.Log("in" + index + "round:Enemy Attack3");


                        index += 1;
                        isWaitPlayer = true;
                        break;
                    case 1:
                        Debug.Log("in" + index + "round:Enemy Attack4");

                
                        index += 1;
                        isWaitPlayer = true;
                        break;
                    case 2:
                        Debug.Log("in" + index + "round:Enemy Attack5");

               
                        index += 1;
                        isWaitPlayer = true;
                        break;
                }
            }
        }
    }
}
