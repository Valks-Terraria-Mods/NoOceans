[![](https://img.shields.io/static/v1?style=flat-square&logo=discord&logoColor=white&color=blue&label=discord&message=valks%20games)](https://discord.gg/866cg8yfxZ)

The oceans no longer get generated on world creation.

```cs
public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
{
    tasks.RemoveAll(x => x.Name.Equals("Beaches"));
}
```

I will not be updating this mod to 1.4.
