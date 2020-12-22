using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsA : MonoBehaviour
{
    OverridenA overA = new OverridenA();
    OverridenB overB = new OverridenB();
    private void Start()
    {
        avA();
    }

    void avA()
    {
        string a;
        a = overA.TemplateMethod("Ты", 1, 2, 3).ToString();
        Debug.Log(a);
    }
    void avB()
    {
        string a;
        a = overB.TemplateMethod("Вы", 4, 5, 6).ToString();
        Debug.Log(a);
    }
}
