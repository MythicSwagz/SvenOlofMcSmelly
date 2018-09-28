using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uppgift : MonoBehaviour
{
    public string sentence1;
    public string sentence2;
    public string sentence3;
    public int number;
    public int triangleBase;
    public int angle;
    public int pieces;
    public string username;
    public int radius;
    public float damage;
    public int life;
    public int demons;
    public float minDamage;
    public int maxDamage;
    public float count;
    public float countMulti;
    private float playerMaxLife = 1000;
    private float playerResist = 0.2f;
    private float enemyDamage = 100;
    // Use this for initialization
    void Start()
    {
        Uppgift1();
        Uppgift2();
        Uppgift3();
        Uppgift4();
        Uppgift5();
        Uppgift5a();
        Uppgift6();
        Uppgift7();
        Uppgift8();
        Uppgift8a();
        Uppgift8b();
        Uppgift8c();
        Uppgift9();
        Uppgift10();
        Uppgift11();
    }
    void Uppgift2()
    {
        Debug.Log(string.Format("Uppgift 2: {0}", sentence1));
        Debug.Log(sentence2);
        Debug.Log(sentence3);
    }
    void Uppgift1()
    {
        Debug.Log(string.Format(
            "Uppgift 1: {0}",
            (963f * 421f) - (175463f / 87f)));
    }
    void Uppgift3()
    {
        Debug.Log(string.Format("Uppgift 3: {0}", Mathf.Pow(number, 2)));
        Debug.Log(Mathf.Sqrt(number));
    }
    void Uppgift4()
    {
        Debug.Log(string.Format("Uppgift 4: {0}", triangleBase * 8 / 2));
    }
    void Uppgift5()
    {
        Debug.Log(string.Format("Uppgift 5: {0}", 360f / angle));
    }
    void Uppgift5a()
    {
        Debug.Log(string.Format("Uppgift 5: {0}", 360f / pieces));
    }
    void Uppgift6()
    {
        Debug.Log(string.Format("Uppgift 6: {0}", string.Format("Farmer " + username + " of Säve")));
    }
    void Uppgift7()
    {
        Debug.Log(string.Format("Uppgift 7: {0}", 4 * Mathf.PI * Mathf.Pow(radius, 3) / 3 * 2978));
    }
    void Uppgift8()
    {
        Debug.Log(string.Format("Uppgift 8: {0}", 890000 / damage));
    }
    void Uppgift8a()
    {
        Debug.Log(string.Format("Uppgift 8a: {0}", life / damage));
    }
    void Uppgift8b()
    {
        Debug.Log(string.Format("Uppgift 8b: {0}", demons * life / damage));
    }
    void Uppgift8c()
    {
        //Debug.Log(Random.Range(0, 5));
        //Debug.Log(Random.Range(0f, 10f));
        Debug.Log(string.Format("Uppgift 8c: {0}", (life / minDamage)));
        Debug.Log(life / maxDamage);
        Debug.Log((minDamage + maxDamage) / 2);
    }
    void Uppgift9()
    {
        count = count * 2;
        Debug.Log(string.Format("Uppgift 9: {0}", count));
    }
    void Uppgift10()
    {
        Debug.Log(string.Format("Uppgift 10: {0}", ((countMulti * 3) / 2)));
    }
    void Uppgift11()
    {
        Debug.Log(string.Format("Uppgift 11: {0}", (playerMaxLife - enemyDamage * playerResist)));
    }
    // Update is called once per frame
    void Update()
    {
        Uppgift9();
    }
}
