using MelonLoader;

namespace SkillAdjustmentRevolver
{ 
	internal sealed class Implementation : MelonMod
	{
		public override void OnInitializeMelon()
		{
            Settings.OnLoad();
        }
	
	}

}
