using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtensionClass : MonoBehaviour
{

}
public static class IntExtensions
{
    public static void Intcrement(this int number)
        => number++;

    // Take note of the extra ref keyword here
    public static void RefIntcrement(this ref int number)
        => number++;

    public static void RefIntCrementWithAmount(this ref int number, int amount)
    {
        number += amount;
    }

    public static void RefIntReset(this ref int number) => number = 0;
}

public static class ListExtensions
{
    public static void Shuffle<T>(this IList<T> list)
    {
        System.Random rnd = new System.Random();
        for (var i = list.Count - 1; i > 0; i--)
            list.Swap(0, rnd.Next(i + 1));
    }

    public static void Swap<T>(this IList<T> list, int i, int j)
    {
        var temp = list[i];
        list[i] = list[j];
        list[j] = temp;
    }
}
