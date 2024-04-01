using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class mark : MonoBehaviour
{
    public TextMeshProUGUI TEXTMARK;
     public static int Mark = 0;

    private void Update()
    {
        TEXTMARK.text = Mark.ToString(); //CHANGE THE INT TO STRING THEN CAN BE USED IN UI mark
    }
    public static void setmark(int number)
    {
        Mark = number;
    }

}
