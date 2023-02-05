using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{
    public static int money=500;
    public TextMeshProUGUI money_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        money_text.text= ": "+money.ToString();
    }
    public static void spend(int price){
        money-=price;
    }
    public static void gain(int price){
        money+=price;
    }
}
