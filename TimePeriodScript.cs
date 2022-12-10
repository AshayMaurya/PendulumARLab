using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimePeriodScript : MonoBehaviour
{
    //[SerializeField] InputField ipLength, ipGravity;
    [SerializeField] TMP_InputField ipLength, ipGravity;
//    [SerializeField] Text timePView;
    [SerializeField] TMP_Text timePView;
    public static float resultTperiod;
    public void calC()
    {
        float ln = float.Parse(ipLength.text);
        float grav = float.Parse(ipGravity.text);
        resultTperiod = 2 * Mathf.PI * (Mathf.Sqrt(ln / grav));
        timePView.text = ""+resultTperiod;
    }
}
