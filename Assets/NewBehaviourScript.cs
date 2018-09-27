using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //int = heltal
    //float = decimaltal
    //string = text
    //bool = ja/nej

    public int myInt = 5;
    public string sentence1 = "iuh8efiuhef";
    public string sentence2 = "222222";
    public string sentence3 = "Hej";
    public int number = 5;


    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
        Uppgift1();
        Uppgift2();
        Uppgift3();
        Uppgift4();
    }
    int MultiplyByTwo(int number)
    {
        int ret;

        ret = number * 2;

        return ret;
    }
    void Uppgift1()
    {
        Debug.Log((963f * 421f) - (175463f / 87f));
    }
    void Uppgift2()
    {
        Debug.Log(sentence1);
        Debug.Log(sentence2);
        Debug.Log(sentence3);
    }
    void Uppgift3()
    {
        Debug.Log(Mathf.Pow(number, 2));
        Debug.Log(Mathf.Sqrt(number));
    }
    void Uppgift4()
    {

    }
}

