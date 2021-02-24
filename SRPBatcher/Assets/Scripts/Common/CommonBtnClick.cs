using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GAsset.Common;

public class CommonBtnClick : MonoBehaviour
{
    public void OnBtnClick_Print()
    {
        var image = this.transform.GetComponent<Image>();
        image.color = new Color(CommonFunction.GetRandomfloat(0, 1.0f, 2), CommonFunction.GetRandomfloat(0, 1.0f, 2), CommonFunction.GetRandomfloat(0, 1.0f, 2));
        Debug.Log(this.name + " 's color is (" + image.color.r + "," + image.color.g + "," + image.color.b + ").");
    }
}
