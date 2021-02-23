using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class CommonBtnClick : MonoBehaviour
{
    public void OnBtnClick_Print()
    {
        var image = this.transform.GetComponent<Image>();
        image.color = new Color(Random.Range(0, 1), Random.Range(0, 1), Random.Range(0, 1));
        Debug.Log(this.name + " 's color is (" + image.color.r + "," + image.color.g + "," + image.color.b + ").");
    }
}
