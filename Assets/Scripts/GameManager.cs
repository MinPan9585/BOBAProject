using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float remainingTime;
    public int[] objectList;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    void Update()
    {
        remainingTime -= Time.deltaTime;
        if(remainingTime <= 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        //show UI
        //show score
        //show retry button, main menu button
        //play vfx & sfx
    }

    public void GameWin()
    {
        //show UI
        //show score
        //show next level button, main menu button
        //play vfx & sfx
    }
}
