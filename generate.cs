using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class generate : MonoBehaviour
{
    public TMP_Text hasil;

    public TMP_InputField input;
    string strin = "abcdefg";
    // Start is called before the first frame update
    void Start()
    {
        // hasil.text = strin.Substring(0,3);
        // for (int i = 0; i <= 6; i++)
        // {
        //     hasil.text += strin.Substring(i, 1)+"\n";
        //     // Debug.Log(strin.Substring(i, 1));
        // }

    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(input.text.Length);
        
    }

    public void generatesegitiga()
    {
        for (int i = 0; i <= input.text.Length - 1; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (j >= 1)
                {
                    hasil.text += "0";
                }
                else
                {
                    hasil.text += input.text.Substring(i, 1);
                }
                
            }
            hasil.text += "0"+"\n";
            // Debug.Log(strin.Substring(i, 1));
        }
    }
    // public void generatebilanganganjil()
    // {
    //     for (int i = 0; i <= input.text.Length - 1; i++)
    //     {
    //         if (strin.Substring(i, 1) % 2)
    //         {
    //             
    //         }
    //         hasil.text += strin.Substring(i, 1);
    //     }
    // }
}
