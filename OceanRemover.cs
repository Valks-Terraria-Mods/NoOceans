using Terraria.ModLoader;
using System.Collections.Generic;
using Terraria.World.Generation;

namespace NoOceans
{
    class OceanRemover : ModWorld
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            tasks.RemoveAll(x => x.Name.Equals("Beaches"));
        }
    }
}
