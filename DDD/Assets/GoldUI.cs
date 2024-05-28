using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldUI : MonoBehaviour
{
    public Text goldText;

    private void Update()
    {
        goldText.text = PlayerStats.Money + "";
    }
}
