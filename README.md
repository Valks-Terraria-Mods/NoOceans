The oceans no longer get generated on world creation.

```cs
public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
{
    tasks.RemoveAll(x => x.Name.Equals("Beaches"));
}
```
