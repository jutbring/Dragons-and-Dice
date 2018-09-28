using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inlämning : MonoBehaviour
{
    public int userValue;
    int dice1;
    int dice2;
    int dragonHealth;
    int playerHealth;
    int hitChance;
    int corruptChance;
    int playerMaxDamage;
    int playerMinDamage;
    int critChance;
    int chanceGame;
    int chanceGameCurrent;
    int chanceGameStreak;
    int chanceGameHiScore;
    // Use this for initialization
    void Start()
    {
        dice1 += 10;
        dragonHealth = Random.Range(100, 151);
        playerHealth = 100;
        corruptChance = Random.Range(0, 11);
        if (corruptChance == 10)
        {
            dragonHealth = dragonHealth * 2;
        }
        print(string.Format("Dragon HP: {0}", (dragonHealth)));
        print(string.Format("Player HP: {0}", (playerHealth)));
        chanceGame += 50;
        chanceGameCurrent += 50;
        print("current value: 50");
        chanceGameStreak += 0;
        chanceGameHiScore += 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            userValue += 2;
            print(userValue);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            userValue /= 2;
            print(userValue);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print(userValue);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            dice1 += Random.Range(0, 6);
            dice2 -= Random.Range(0, 6);
            print(dice1 + dice2);
            if (dice1 + dice2 >= 20)
            {
                print("you have! woned");
            }
            else if (dice1 + dice2 <= 0)
            {
                print("too. bad try agen,");
            }

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerMaxDamage = Random.Range(15, 25);
            playerMinDamage = Random.Range(0, 10);
            hitChance = Random.Range(0, 2);
            critChance = Random.Range(0, 21);
            print("player hit");
            if (critChance == 20)
            {
                print("CRITTE!");
                dragonHealth -= 999999999;
                print(string.Format("Dragon HP: {0}", dragonHealth));
            }
            else
            {
                dragonHealth -= playerMaxDamage - playerMinDamage;
                print(string.Format("Dragon HP: {0}", dragonHealth));
            }

            if (hitChance == 1)
            {
                print("Enem hit");
                playerHealth -= Random.Range(10, 21);
                print(string.Format("Player HP: {0}", playerHealth));
            }
            else
            {
                print("Enen misse");
                print(string.Format("Player HP: {0}", (playerHealth)));
            }

            if (playerHealth <= 0)
            {
                print("oh, no you doed! ,-;");
            }
            if (dragonHealth <= 0)
            {
                print("enem slane! :d");
            }
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            print(chanceGame = Random.Range(0, 101));
            if (chanceGame <= chanceGameCurrent)
            {
                print("hah! you lost you lil' bich");
                print(string.Format("score: {0}", (chanceGameStreak)));
                chanceGameStreak = 0;
                chanceGame = 50;
                chanceGameCurrent = 50;
                print("current value: 50");
            }
            else if (chanceGame >= chanceGameCurrent)
            {
                print("crognats! you woned");
                chanceGameStreak += 1;
            }
            chanceGameCurrent = chanceGame;
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            print(chanceGame = Random.Range(0, 101));
            if (chanceGame >= chanceGameCurrent)
            {
                print("hah! you lost you lil' bich");
                print(string.Format("score: {0}", (chanceGameStreak)));
                chanceGameStreak = 0;
                chanceGame = 50;
                chanceGameCurrent = 50;
                print("current value: 50");
            }
            else if (chanceGame <= chanceGameCurrent)
            {
                print("crognats! you woned");
                chanceGameStreak += 1;
            }
            chanceGameCurrent = chanceGame;
        }
        if (chanceGameStreak >= chanceGameHiScore)
        {
            chanceGameHiScore = chanceGameStreak;
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            print(string.Format("highscore: {0}", (chanceGameHiScore)));
        }
    }
}
