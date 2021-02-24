using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GAsset.Common
{
    public static class CommonFunction
    {
        public static float GetRandomfloat(float min, float max, int deci = 0)
        {
            deci = 10 * deci;
            float ranf = Random.Range(min, max);
            if (deci != 0)
            {
                ranf = Mathf.Round(ranf * deci) / deci;
            }
            return ranf;
        }
    }
}