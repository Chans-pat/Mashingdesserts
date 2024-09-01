using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class mashermanager : MonoBehaviour
{
    public TextMeshProUGUI clickstotaltext;

    public float totalclick;

   public void addclick()
    {
        totalclick++;
        clickstotaltext.text = totalclick.ToString("0");
    }
}
