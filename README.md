# JobSystemBenchmark
benchmark the job system speed

## Overview

## Implement

### By default
When scene is empty,it can runs at 4000 fps

```C#
void Update()
{
    for (int i = 0; i < 100000; i++)
    {
        var f = Mathf.Sqrt(Mathf.Pow(10, 100000f)) / 10000000f;
    }
}
```

after this ,frame reduce to 60 fps