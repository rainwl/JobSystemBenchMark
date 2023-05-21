using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections;
using UnityEngine;
using Unity.Jobs;

public struct ExpensiveCalculation : IJob
{
    public NativeArray<float> Value;

    public void Execute()
    {
        for (int i = 0; i < 100000; i++)
        {
            Value[0] = Mathf.Sqrt(Mathf.Pow(10, 100000f)) / 10000000f;
        }
    }
}


public class IJobTutorial : MonoBehaviour
{
    void Update()
    {
        NativeArray<float> _Value = new NativeArray<float>(1, Allocator.TempJob);
        ExpensiveCalculation job = new ExpensiveCalculation()
        {
            Value = _Value
        };
        JobHandle jobHandle = job.Schedule();
        jobHandle.Complete();
        Debug.Log(job.Value[0]);
        _Value.Dispose();
    }
}