using ModSettings;
using System.Reflection;

namespace SkillAdjustmentRevolver
{
    internal class Settings : JsonModSettings
    {

        [Section("Revolver")]

        [Name("Revolver Skills")]
        private readonly bool Revolver = true;


        //lvl 1
        [Name("Revolver Level 1 ------------------------------")]
        [Description("Show or hide level 1 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool revolver1 = false;

        [Name("         - Condition loss on use")]
        [Description("Reduce condition loss after use.(Game default = 0%)")]
        [Slider(0, 100)]
        public int Degrade1 = 0;

        [Name("         - Aim Assist")]
        [Description("Set aim assist angle degrees.(Game default = 0)")]
        [Slider(0, 100)]
        public int Aim1rev = 0;

        [Name("         - Recoil Compensation")]
        [Description("Increase recoil compensation.(Game default = 0%)")]
        [Slider(0, 100)]
        public int Recoil1 = 0;

        [Name("         - Struggle bonus")]
        [Description("Increase struggle effectiveness.(Game default = 0%)")]
        [Slider(0, 100)]
        public int Struggle1 = 0;

        [Name("         - Condition repair bonus")]
        [Description("Increase amount of condition recieved from repair.(Game default = 0)")]
        [Slider(0, 100)]
        public int Repair1 = 0;

        [Name("         - Damage bonus")]
        [Description("Increase Damage.(Game default = 0%)")]
        [Slider(0, 100)]
        public int Damage1rev = 0;

        [Name("         - Critcal hit bonus")]
        [Description("Increase critical hits.(Game default = 0%)")]
        [Slider(0, 100)]
        public int Crit1 = 0;


        //lvl 2
        [Name("Revolver Level 2 ------------------------------")]
        [Description("Show or hide level 2 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool revolver2 = false;

        [Name("         - Condition loss on use")]
        [Description("Reduce condition loss after use.(Game default = 0%)")]
        [Slider(0, 100)]
        public int Degrade2 = 0;

        [Name("         - Aim Assist")]
        [Description("Set aim assist angle degrees.(Game default = 0)")]
        [Slider(0, 100)]
        public int Aim2rev = 0;

        [Name("         - Recoil Compensation")]
        [Description("Increase recoil compensation.(Game default = 25%)")]
        [Slider(0, 100)]
        public int Recoil2 = 25;

        [Name("         - Struggle bonus")]
        [Description("Increase struggle effectiveness.(Game default = 0%)")]
        [Slider(0, 100)]
        public int Struggle2 = 0;

        [Name("         - Condition repair bonus")]
        [Description("Increase amount of condition recieved from repair.(Game default = +2)")]
        [Slider(0, 100)]
        public int Repair2 = 2;

        [Name("         - Damage bonus")]
        [Description("Increase Damage.(Game default = 0%)")]
        [Slider(0, 100)]
        public int Damage2rev = 0;

        [Name("         - Critcal hit bonus")]
        [Description("Increase critical hits.(Game default = 0%)")]
        [Slider(0, 100)]
        public int Crit2 = 0;


        //lvl 3
        [Name("Revolver Level 3 ------------------------------")]
        [Description("Show or hide level 3 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool revolver3 = false;

        [Name("         - Condition loss on use")]
        [Description("Reduce condition loss after use.(Game default = 0%)")]
        [Slider(0, 100)]
        public int Degrade3 = 0;

        [Name("         - Aim Assist")]
        [Description("Set aim assist angle degrees.(Game default = 0)")]
        [Slider(0, 100)]
        public int Aim3rev = 0;

        [Name("         - Recoil Compensation")]
        [Description("Increase recoil compensation.(Game default = 35%)")]
        [Slider(0, 100)]
        public int Recoil3 = 35;

        [Name("         - Struggle bonus")]
        [Description("Increase struggle effectiveness.(Game default = 10%)")]
        [Slider(0, 100)]
        public int Struggle3 = 10;

        [Name("         - Condition repair bonus")]
        [Description("Increase amount of condition recieved from repair.(Game default = +3)")]
        [Slider(0, 100)]
        public int Repair3 = 3;

        [Name("         - Damage bonus")]
        [Description("Increase Damage.(Game default = 0%)")]
        [Slider(0, 100)]
        public int Damage3rev = 0;

        [Name("         - Critcal hit bonus")]
        [Description("Increase critical hits.(Game default = 0%)")]
        [Slider(0, 100)]
        public int Crit3 = 0;


        //lvl 4
        [Name("Revolver Level 4 ------------------------------")]
        [Description("Show or hide level 4 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool revolver4 = false;

        [Name("         - Condition loss on use")]
        [Description("Reduce condition loss after use.(Game default = 0%)")]
        [Slider(0, 100)]
        public int Degrade4 = 0;

        [Name("         - Aim Assist")]
        [Description("Set aim assist angle degrees.(Game default = 25)")]
        [Slider(0, 100)]
        public int Aim4rev = 25;

        [Name("         - Recoil Compensation")]
        [Description("Increase recoil compensation.(Game default = 50%)")]
        [Slider(0, 100)]
        public int Recoil4 = 50;

        [Name("         - Struggle bonus")]
        [Description("Increase struggle effectiveness.(Game default = 20%)")]
        [Slider(0, 100)]
        public int Struggle4 = 20;

        [Name("         - Condition repair bonus")]
        [Description("Increase amount of condition recieved from repair.(Game default = +4)")]
        [Slider(0, 100)]
        public int Repair4 = 4;

        [Name("         - Damage bonus")]
        [Description("Increase Damage.(Game default = 0%)")]
        [Slider(0, 100)]
        public int Damage4rev = 0;

        [Name("         - Critcal hit bonus")]
        [Description("Increase critical hits.(Game default = 0%)")]
        [Slider(0, 100)]
        public int Crit4 = 0;


        //lvl 5
        [Name("Revolver Level 5 ------------------------------")]
        [Description("Show or hide level 5 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool revolver5 = false;

        [Name("         - Condition loss on use")]
        [Description("Reduce condition loss after use.(Game default = 50%)")]
        [Slider(0, 100)]
        public int Degrade5 = 50;

        [Name("         - Aim Assist")]
        [Description("Set aim assist angle degrees.(Game default = 50)")]
        [Slider(0, 100)]
        public int Aim5rev = 50;

        [Name("         - Recoil Compensation")]
        [Description("Increase recoil compensation.(Game default = 70%)")]
        [Slider(0, 100)]
        public int Recoil5 = 70;

        [Name("         - Struggle bonus")]
        [Description("Increase struggle effectiveness.(Game default = 30%)")]
        [Slider(0, 100)]
        public int Struggle5 = 30;

        [Name("         - Condition repair bonus")]
        [Description("Increase amount of condition recieved from repair.(Game default = +5)")]
        [Slider(0, 100)]
        public int Repair5 = 5;

        [Name("         - Damage bonus")]
        [Description("Increase Damage.(Game default = 0%)")]
        [Slider(0, 100)]
        public int Damage5rev = 0;

        [Name("         - Critcal hit bonus")]
        [Description("Increase critical hits.(Game default = 0%)")]
        [Slider(0, 100)]
        public int Crit5 = 0;


        protected override void OnChange(FieldInfo field, object oldValue, object newValue)
        {
            if (field.Name == nameof(Revolver) ||
                field.Name == nameof(revolver1) ||
                field.Name == nameof(revolver2) ||
                field.Name == nameof(revolver3) ||
                field.Name == nameof(revolver4) ||
                field.Name == nameof(revolver5))
            {
                RefreshFields();
            }
        }

        internal void RefreshFields()
        {
            SetFieldVisible(nameof(revolver1), Revolver && Revolver);
            SetFieldVisible(nameof(Degrade1), revolver1 && Revolver);
            SetFieldVisible(nameof(Aim1rev), revolver1 && Revolver);
            SetFieldVisible(nameof(Recoil1), revolver1 && Revolver);
            SetFieldVisible(nameof(Struggle1), revolver1 && Revolver);
            SetFieldVisible(nameof(Repair1), revolver1 && Revolver);
            SetFieldVisible(nameof(Damage1rev), revolver1 && Revolver);
            SetFieldVisible(nameof(Crit1), revolver1 && Revolver);

            SetFieldVisible(nameof(revolver2), Revolver && Revolver);
            SetFieldVisible(nameof(Degrade2), revolver2 && Revolver);
            SetFieldVisible(nameof(Aim2rev), revolver2 && Revolver);
            SetFieldVisible(nameof(Recoil2), revolver2 && Revolver);
            SetFieldVisible(nameof(Struggle2), revolver2 && Revolver);
            SetFieldVisible(nameof(Repair2), revolver2 && Revolver);
            SetFieldVisible(nameof(Damage2rev), revolver2 && Revolver);
            SetFieldVisible(nameof(Crit2), revolver2 && Revolver);

            SetFieldVisible(nameof(revolver3), Revolver && Revolver);
            SetFieldVisible(nameof(Degrade3), revolver3 && Revolver);
            SetFieldVisible(nameof(Aim3rev), revolver3 && Revolver);
            SetFieldVisible(nameof(Recoil3), revolver3 && Revolver);
            SetFieldVisible(nameof(Struggle3), revolver3 && Revolver);
            SetFieldVisible(nameof(Repair3), revolver3 && Revolver);
            SetFieldVisible(nameof(Damage3rev), revolver3 && Revolver);
            SetFieldVisible(nameof(Crit3), revolver3 && Revolver);

            SetFieldVisible(nameof(revolver4), Revolver && Revolver);
            SetFieldVisible(nameof(Degrade4), revolver4 && Revolver);
            SetFieldVisible(nameof(Aim4rev), revolver4);
            SetFieldVisible(nameof(Recoil4), revolver4 && Revolver);
            SetFieldVisible(nameof(Struggle4), revolver4 && Revolver);
            SetFieldVisible(nameof(Repair4), revolver4 && Revolver);
            SetFieldVisible(nameof(Damage4rev), revolver4 && Revolver);
            SetFieldVisible(nameof(Crit4), revolver4 && Revolver);

            SetFieldVisible(nameof(revolver5), Revolver);
            SetFieldVisible(nameof(Degrade5), revolver5 && Revolver);
            SetFieldVisible(nameof(Aim5rev), revolver5);
            SetFieldVisible(nameof(Recoil5), revolver5 && Revolver);
            SetFieldVisible(nameof(Struggle5), revolver5 && Revolver);
            SetFieldVisible(nameof(Repair5), revolver5 && Revolver);
            SetFieldVisible(nameof(Damage5rev), revolver5 && Revolver);
            SetFieldVisible(nameof(Crit5), revolver5 && Revolver);

        }


        internal static Settings settings;
        internal static void OnLoad()
        {
            settings = new Settings();
            settings.AddToModSettings("Skill-Adjustment-Revolver");
            settings.RefreshFields();
        }
    }
}