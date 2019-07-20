using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StringController : MonoBehaviour {


    //自分で定義した改行文字を\nに置き換える
    //str=\nに書き換えたい文字列
    //separator=自分で定義した改行文字
    public string LineBreak(string str,string[] separator)
    {
        string[] arr = str.Split(separator, StringSplitOptions.None);
        string newString = arr[0];
        
        for (int w = 1; w < arr.Length; w++)
        {
            newString = newString + "\n" + arr[w];
        }
        return newString;
    }

    //複数の文字列に対応
    public List<string> LineBreak(List<string> str, string[] separator)
    {
        List<string> newStrings = str;
        for (int i = 0; i < str.Count; i++)
        {

            string[] arr = str[i].Split(separator, StringSplitOptions.None);
            string newString = arr[0];

            for (int w = 1; w < arr.Length; w++)
            {
                newString = newString + "\n" + arr[w];
            }
            newStrings[i] = newString;
        }
        return newStrings;
    }
}
