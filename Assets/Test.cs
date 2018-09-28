using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public bool ifBool;
    public int value;
    public int userValue;
    public int points = 10;
    public int playerLife = 100;
    public int DragonHP;
    public int DragonATK;
    public int secondD;
    private int maxDMG;
    private int minDMG;
    public int CriticalDamage;
    private int HLbaseValue = 50;
    public int YKey;
    private int OldHL;
    public int HKey;
    public int Score;
    public int startValue;
    // Use this for initialization
    void Start()
    {
        //if (ifBool == true)
        //{
        //    print("Ja");
        //}
        //else
        //{
        //    print("Nej");
        //}
        DragonHP = DragonHP + Random.Range(100, 151);
        minDMG = Random.Range(1, 11);
        maxDMG = Random.Range(20, 31);


    }

    // Update is called once per frame
    void Update()
    {
        Uppgift5();
        // != inte lika med
        // == lika med
        // > större än
        // < mindre än
        // >= större eller lika med
        // <= mindre eller lika med
        // && och (shift6)
        // || eller (altgr <)
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Uppgift 1a");
            userValue = userValue + 2;
        }


        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Uppgift 1b");
            userValue = userValue / 2;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print(userValue);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Uppgift 2a");
            points = points + Random.Range(1, 7);
            points = points - Random.Range(1, 7);
            Debug.Log(points);
            if (points >= 20)
            {
                print("Congrats!");
            }
            if (points <= 0)
            {
                print("Game Over!");
            }
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Uppgift 3");
            DragonATK = Random.Range(1, 3);
            if (DragonATK == 1)
            {
                playerLife = playerLife - Random.Range(10, 21);
            }
            DragonHP = DragonHP - Random.Range(minDMG, maxDMG);
            if (playerLife <= 0)
            {
                print("Dragon Wins");
            }
            if (DragonHP <= 0)
            {
                print("Player Wins");
            }
            print(string.Format(
                 "DragonHP:" + DragonHP));
            print(string.Format(
                "PlayerHP:" + playerLife));
            secondD = Random.Range(1, 11);
            if (secondD == 1)
            {
                DragonHP = DragonHP * 2;
            }
            CriticalDamage = Random.Range(1, 21);
            if (CriticalDamage == 1)
            {
                DragonHP = 0;
            }

        }







        //if (value == 5)
        //{
        //    print("Kanske");
        //}
        //else if (value == 4)
        //{
        //    print("Vet ej");
        //}
        //else if (value == 3)
        //{
        //    print("Tyst");
        //}
        //else if (value == 2)
        //{
        //    print("Ja");
        //}
        //else
        //{
        //    print("Nej");
        //}
    }


    void Uppgift5()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            OldHL = YKey;
            YKey = Random.Range(1, 101);
            if (YKey <= OldHL)
            {
                print("You Lose");
                startValue = 50;
            }
            if (YKey >= OldHL)
            {
                print("Keep Going");
                Score += 1;
            }

        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            OldHL = YKey;
            YKey = Random.Range(1, 101);
            if (YKey <= OldHL)
            {
                print("Keep Going");
                Score += 1;
            }
            if (YKey >= OldHL)
            {
                print("You Lose");
                startValue = 50;
            }

        }
    }

}

