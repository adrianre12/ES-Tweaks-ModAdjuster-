using Sandbox.Definitions;
using System.Linq;
using VRage.Game.Components;

namespace ESTweaks
{
    [MySessionComponentDescriptor(MyUpdateOrder.NoUpdate)]
    class Onezer : MySessionComponentBase
    {
        public override void LoadData()
        {
            base.LoadData();
            var allDefs = MyDefinitionManager.Static.GetAllDefinitions();
            foreach (var componenet in allDefs.OfType<MyPhysicalItemDefinition>())
            {
                componenet.MinimalPricePerUnit = 1;
            }
        }
    }
}
