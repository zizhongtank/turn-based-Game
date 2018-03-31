using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnbasedgame : MonoBehaviour {

    public Transform mPlayer;
    public Transform mEnemy;

  
    private Player playerScript;
    private Enemy enemyScript;

    
    private OperatorState mState = OperatorState.Player;

   
    public enum OperatorState
    {
        Quit,
        Enemy,
        Player
    }

    void Start()
    {
       
        playerScript = mPlayer.GetComponent<Player>();
        enemyScript = mEnemy.GetComponent<Enemy>();
    }

    
    IEnumerator WaitUI()
    {
        yield return new WaitForSeconds(1);
        enemyScript.isWaitPlayer = true;
    }

 
    IEnumerator WaitAI()
    {
        yield return new WaitForSeconds(2.5F);
        enemyScript.isWaitPlayer = false;
    }

   
    IEnumerator UpdateLater()
    {
        yield return new WaitForSeconds(2.5F);
       
        enemyScript.isWaitPlayer = false;
       
        enemyScript.StartAI();
    }

    void Update()
    {
     
        if (playerScript.HP == 0)
        {
            mState = OperatorState.Quit;
            Debug.Log("play lose");
        }
        else if (enemyScript.HP == 0)
        {
            mState = OperatorState.Quit;
            Debug.Log("play win");
        }
        else
        {
            switch (mState)
            {
                case OperatorState.Player:
                   
                    if (!playerScript.isWaitPlayer)
                    {
                      
                        StartCoroutine("UpdateLater");
                      
                        StartCoroutine("WaitUI");
                        mState = OperatorState.Enemy;
                    }
                    break;
                case OperatorState.Enemy:
                 
                    if (enemyScript.isWaitPlayer)
                    {
                    
                        playerScript.isWaitPlayer = true;
                        StartCoroutine("WaitUI");
                      
                        StartCoroutine("WaitAI");
                        mState = OperatorState.Player;
                    }
                    break;
            }
        }
    }
}