using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IJobTutorial : MonoBehaviour
{
    void Update()
    {
        for (int i = 0; i < 100000; i++)
        {
            var f = Mathf.Sqrt(Mathf.Pow(10, 100000f)) / 10000000f;
        }
    }
}
