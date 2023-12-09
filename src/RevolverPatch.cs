using HarmonyLib;
using Il2Cpp;

namespace SkillAdjustmentRevolver
{
    [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.Awake))]
    internal class RevolverAdjustment
    {

        public static void Postfix(SkillsManager __instance)
        {
            __instance.m_Skill_Revolver.m_ConditionDegradeOnUseReduction[0] = Settings.settings.Degrade1;
            __instance.m_Skill_Revolver.m_AimAssistAngleDegrees[0] = Settings.settings.Aim1rev;
            __instance.m_Skill_Revolver.m_RecoilCompensation[0] = Settings.settings.Recoil1;
            __instance.m_Skill_Revolver.m_StruggleBonus[0] = Settings.settings.Struggle1;
            __instance.m_Skill_Revolver.m_ConditionRepairBonus[0] = Settings.settings.Repair1;
            __instance.m_Skill_Revolver.m_DamageIncrease[0] = Settings.settings.Damage1rev;
            __instance.m_Skill_Revolver.m_CriticalHitChanceIncrease[0] = Settings.settings.Crit1;


            __instance.m_Skill_Revolver.m_ConditionDegradeOnUseReduction[1] = Settings.settings.Degrade2;
            __instance.m_Skill_Revolver.m_AimAssistAngleDegrees[1] = Settings.settings.Aim2rev;
            __instance.m_Skill_Revolver.m_RecoilCompensation[1] = Settings.settings.Recoil2;
            __instance.m_Skill_Revolver.m_StruggleBonus[1] = Settings.settings.Struggle2;
            __instance.m_Skill_Revolver.m_ConditionRepairBonus[1] = Settings.settings.Repair2;
            __instance.m_Skill_Revolver.m_DamageIncrease[1] = Settings.settings.Damage2rev;
            __instance.m_Skill_Revolver.m_CriticalHitChanceIncrease[1] = Settings.settings.Crit2;


            __instance.m_Skill_Revolver.m_ConditionDegradeOnUseReduction[2] = Settings.settings.Degrade3;
            __instance.m_Skill_Revolver.m_AimAssistAngleDegrees[2] = Settings.settings.Aim3rev;
            __instance.m_Skill_Revolver.m_RecoilCompensation[2] = Settings.settings.Recoil3;
            __instance.m_Skill_Revolver.m_StruggleBonus[2] = Settings.settings.Struggle3;
            __instance.m_Skill_Revolver.m_ConditionRepairBonus[2] = Settings.settings.Repair3;
            __instance.m_Skill_Revolver.m_DamageIncrease[2] = Settings.settings.Damage3rev;
            __instance.m_Skill_Revolver.m_CriticalHitChanceIncrease[2] = Settings.settings.Crit3;


            __instance.m_Skill_Revolver.m_ConditionDegradeOnUseReduction[3] = Settings.settings.Degrade4;
            __instance.m_Skill_Revolver.m_AimAssistAngleDegrees[3] = Settings.settings.Aim4rev;
            __instance.m_Skill_Revolver.m_RecoilCompensation[3] = Settings.settings.Recoil4;
            __instance.m_Skill_Revolver.m_StruggleBonus[3] = Settings.settings.Struggle4;
            __instance.m_Skill_Revolver.m_ConditionRepairBonus[3] = Settings.settings.Repair4;
            __instance.m_Skill_Revolver.m_DamageIncrease[3] = Settings.settings.Damage4rev;
            __instance.m_Skill_Revolver.m_CriticalHitChanceIncrease[3] = Settings.settings.Crit4;


            __instance.m_Skill_Revolver.m_ConditionDegradeOnUseReduction[4] = Settings.settings.Degrade5;
            __instance.m_Skill_Revolver.m_AimAssistAngleDegrees[4] = Settings.settings.Aim5rev;
            __instance.m_Skill_Revolver.m_RecoilCompensation[4] = Settings.settings.Recoil5;
            __instance.m_Skill_Revolver.m_StruggleBonus[4] = Settings.settings.Struggle5;
            __instance.m_Skill_Revolver.m_ConditionRepairBonus[4] = Settings.settings.Repair5;
            __instance.m_Skill_Revolver.m_DamageIncrease[4] = Settings.settings.Damage5rev;
            __instance.m_Skill_Revolver.m_CriticalHitChanceIncrease[4] = Settings.settings.Crit5;

        }

    }


    [HarmonyPatch(typeof(Skill_Revolver), nameof(Skill_Revolver.GetTierBenefits))]
    public class RevolverBenefits
    {
        static void Postfix(ref string __result, Skill_Revolver __instance)
        {
            SkillTiers currentTier = (SkillTiers)__instance.GetCurrentTierNumber();

            //lvl 1
            if (currentTier == SkillTiers.Beginner && Settings.settings.Degrade1 >= 1) { __result += $"\nPer-use condition degradation reduced by {Settings.settings.Degrade1}%"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.Aim1rev >= 1) { __result += $"\nAim assist increased by {Settings.settings.Aim1rev}%"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.Recoil1 >= 1) { __result += $"\nRecoil compensation increased by {Settings.settings.Recoil1}%"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.Struggle1 >= 1) { __result += $"\nStruggle effectiveness increased by {Settings.settings.Struggle1}%"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.Repair1 >= 1) { __result += $"\n{Settings.settings.Repair1} Condition per repair action"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.Damage1rev >= 1) { __result += $"\nDamage increased by {Settings.settings.Damage1rev}%"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.Crit1 >= 1) { __result += $"\nCritical hit chance increased by {Settings.settings.Crit1}%"; }

            //lvl 2
            if (currentTier == SkillTiers.Novice && Settings.settings.Degrade2 >= 1) { __result += $"\nPer-use condition degradation reduced by {Settings.settings.Degrade2}%"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.Aim2rev >= 1) { __result += $"\nAim assist increased by {Settings.settings.Aim2rev}%"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.Struggle2 >= 1) { __result += $"\nStruggle effectiveness increased by {Settings.settings.Struggle2}%"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.Damage2rev >= 1) { __result += $"\nDamage increased by {Settings.settings.Damage2rev}%"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.Crit2 >= 1) { __result += $"\nCritical hit chance increased by {Settings.settings.Crit2}%"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.Repair2 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Repair: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.Repair2} Condition per repair action";
                }
            }
            if (currentTier == SkillTiers.Novice && Settings.settings.Recoil2 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Recoil: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Recoil compensation increased by: {Settings.settings.Recoil2}%";
                }
            }

            //lvl 3
            if (currentTier == SkillTiers.Skilled && Settings.settings.Degrade3 >= 1) { __result += $"\nPer-use condition degradation reduced by {Settings.settings.Degrade3}%"; }
            if (currentTier == SkillTiers.Skilled && Settings.settings.Aim3rev >= 1) { __result += $"\nAim assist increased by {Settings.settings.Aim3rev}%"; }
            if (currentTier == SkillTiers.Skilled && Settings.settings.Damage3rev >= 1) { __result += $"\nDamage increased by {Settings.settings.Damage3rev}%"; }
            if (currentTier == SkillTiers.Skilled && Settings.settings.Crit3 >= 1) { __result += $"\nCritical hit chance increased by {Settings.settings.Crit3}%"; }
            if (currentTier == SkillTiers.Skilled && Settings.settings.Repair3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Repair: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.Repair3} Condition per repair action";
                }
            }
            if (currentTier == SkillTiers.Skilled && Settings.settings.Recoil3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Recoil: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Recoil compensation increased by: {Settings.settings.Recoil3}%";
                }
            }
            if (currentTier == SkillTiers.Skilled && Settings.settings.Struggle3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Struggle: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Struggle effectiveness increased by: {Settings.settings.Struggle3}%";
                }
            }

            //lvl 4
            if (currentTier == SkillTiers.Expert && Settings.settings.Degrade4 >= 1) { __result += $"\nPer-use condition degradation reduced by {Settings.settings.Degrade4}%"; }
            if (currentTier == SkillTiers.Expert && Settings.settings.Damage4rev >= 1) { __result += $"\nDamage increased by {Settings.settings.Damage4rev}%"; }
            if (currentTier == SkillTiers.Expert && Settings.settings.Crit4 >= 1) { __result += $"\nCritical hit chance increased by {Settings.settings.Crit4}%"; }
            if (currentTier == SkillTiers.Expert && Settings.settings.Repair4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Repair: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.Repair4} Condition per repair action";
                }
            }
            if (currentTier == SkillTiers.Expert && Settings.settings.Recoil4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Recoil: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Recoil compensation increased by: {Settings.settings.Recoil4}%";
                }
            }
            if (currentTier == SkillTiers.Expert && Settings.settings.Struggle4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Struggle: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Struggle effectiveness increased by: {Settings.settings.Struggle4}%";
                }
            }
            if (currentTier == SkillTiers.Expert && Settings.settings.Aim4rev >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Struggle: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Aim assist increased by: {Settings.settings.Aim4rev}%";
                }
            }

            //lvl 5
            if (currentTier == SkillTiers.Master && Settings.settings.Damage5rev >= 1) { __result += $"\nDamage increased by {Settings.settings.Damage5rev}%"; }
            if (currentTier == SkillTiers.Master && Settings.settings.Crit5 >= 1) { __result += $"\nCritical hit chance increased by {Settings.settings.Crit5}%"; }
            if (currentTier == SkillTiers.Master && Settings.settings.Repair5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Repair: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.Repair5} Condition per repair action";
                }
            }
            if (currentTier == SkillTiers.Master && Settings.settings.Recoil5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Recoil: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Recoil compensation increased by: {Settings.settings.Recoil5}%";
                }
            }
            if (currentTier == SkillTiers.Master && Settings.settings.Struggle5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Struggle: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Struggle effectiveness increased by: {Settings.settings.Struggle5}%";
                }
            }
            if (currentTier == SkillTiers.Master && Settings.settings.Degrade5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Degradation: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Per-use condition degradation reduced by: {Settings.settings.Degrade5}%";
                }
            }

        }

    }

}
