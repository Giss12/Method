using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class AbstractClass
{
    protected abstract int AbstractA(string s);
    protected abstract int AbstractB();
    public virtual int VirtualA(int a, int b)
    {
        return a + b;
    }
    public virtual int VirtualB(int c)
    {
        return c ^ 2;
    }

    public int TemplateMethod(string s, int a, int b, int c)
    {
        return AbstractA(s) ^ AbstractB() + VirtualA(a, b) * VirtualB(c);
    }
}

class OverridenA : AbstractClass
{
    protected override int AbstractA(string s)
    {
        return s.Length;
    }

    protected override int AbstractB()
    {
        return 42;
    }
}

class OverridenB : AbstractClass
{
    protected override int AbstractA(string s)
    {
        string vowels = "ауоыиэяюёе";
        int result = 0;
        foreach (char symbol in s)
        {
            if (vowels.Contains(symbol.ToString()))
                result++;
        }
        return result;
    }

    protected override int AbstractB()
    {
        int a = Random.Range(0, 1);
        return a;
    }
    public override int VirtualA(int a, int b)
    {
        return a * b;
    }
    public override int VirtualB(int c)
    {
        return c % 7;
    }
}
