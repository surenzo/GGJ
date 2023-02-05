using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VagueHUD : MonoBehaviour
{
    public static int Vague;
    public static int VagueMax;
    public TextMeshProUGUI Vague_text;
    // Start is called before the first frame update
    void Start()
    {
        Vague = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Vague_text.text= "Vague : "+ Vague.ToString()+ " / "+VagueMax.ToString();
    }
    void new_wave(){
        Vague++;
    }
}
