using GTA;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeapFuncs.net
{
    internal class ReloadSpeed
    {
        static float PistolReload = 0;
        static float DeagleReload = 0;
        static float PumpShotReload = 0;
        static float CombatShotReload = 0;
        static float UziReload = 0;
        static float MP5Reload = 0;
        static float AK47Reload = 0;
        static float M4Reload = 0;
        static float SnipReload = 0;
        static float PsgReload = 0;
        static float RpgReload = 0;
        static float AutoPReload = 0;
        static float SawnOffReload = 0;
        static float AssaultShotReload = 0;
        static float GrndLaunchReload = 0;
        static float Pistol44Reload = 0;
        static float AA12Reload = 0;
        static float AA12ExpReload = 0;
        static float P90Reload = 0;
        static float GoldUziReload = 0;
        static float M249Reload = 0;
        static float AdvSnipReload = 0;
        static float Episodic22Reload = 0;
        static float Episodic23Reload = 0;
        static float Episodic24Reload = 0;
        public static void Tick()
        {
            if (Game.LocalPlayer.Character.Weapons.Current == Weapon.Handgun_Glock)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@handgun", "reload", ((double)PistolReload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@handgun", "reload_crouch", ((double)PistolReload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.Handgun_DesertEagle)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@deagle", "reload", ((double)DeagleReload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@deagle", "reload_crouch", ((double)DeagleReload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.Shotgun_Basic)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@shotgun", "reload", ((double)PumpShotReload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@shotgun", "reload_crouch", ((double)PumpShotReload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.Shotgun_Baretta)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@baretta", "reload", ((double)CombatShotReload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@baretta", "reload_crouch", ((double)CombatShotReload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.SMG_Uzi)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@uzi", "reload", ((double)UziReload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@uzi", "reload_crouch", ((double)UziReload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.SMG_MP5)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@mp5k", "reload", ((double)MP5Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@mp5k", "reload_crouch", ((double)MP5Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@mp5k", "p_load", ((double)MP5Reload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.Rifle_AK47)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@ak47", "reload", ((double)AK47Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@ak47", "reload_crouch", ((double)AK47Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@ak47", "p_load", ((double)AK47Reload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.Rifle_M4)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@ak47", "reload", ((double)M4Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@ak47", "reload_crouch", ((double)M4Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@ak47", "p_load", ((double)M4Reload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.SniperRifle_M40A1)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@rifle", "reload", ((double)SnipReload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@rifle", "reload_crouch", ((double)SnipReload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@rifle", "p_load", ((double)SnipReload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.SniperRifle_Basic)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@rifle", "reload", ((double)PsgReload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@rifle", "reload_crouch", ((double)PsgReload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@rifle", "p_load", ((double)PsgReload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.Heavy_RocketLauncher)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@rocket", "reload", ((double)RpgReload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@rocket", "reload_crouch", ((double)RpgReload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.TLAD_Automatic9mm)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@cz75", "reload", ((double)AutoPReload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@cz75", "reload_crouch", ((double)AutoPReload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.TLAD_SawedOffShotgun)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@sawnoff", "reload", ((double)SawnOffReload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@sawnoff", "reload_crouch", ((double)SawnOffReload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.TLAD_AssaultShotgun)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@test_gun", "reload", ((double)AssaultShotReload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@test_gun", "reload_crouch", ((double)AssaultShotReload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@test_gun", "p_load", ((double)AssaultShotReload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.TLAD_GrenadeLauncher || Game.LocalPlayer.Character.Weapons.Current == Weapon.TBOGT_GrenadeLauncher)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@grnde_launch", "reload", ((double)GrndLaunchReload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@grnde_launch", "reload_crouch", ((double)GrndLaunchReload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@grnde_launch", "p_load", ((double)GrndLaunchReload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.TBOGT_Pistol44)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@44a", "reload", ((double)Pistol44Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@44a", "reload_crouch", ((double)Pistol44Reload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.TBOGT_NormalShotgun)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@aa12", "reload", ((double)AA12Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@aa12", "reload_crouch", ((double)AA12Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@aa12", "p_load", ((double)AA12Reload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.TBOGT_ExplosiveShotgun)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@aa12", "reload", ((double)AA12ExpReload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@aa12", "reload_crouch", ((double)AA12ExpReload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@aa12", "p_load", ((double)AA12ExpReload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.TBOGT_AssaultSMG)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@p90", "reload", ((double)P90Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@p90", "reload_crouch", ((double)P90Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@p90", "p_load", ((double)P90Reload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.TBOGT_GoldenSMG)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@gold_uzi", "reload", ((double)GoldUziReload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@gold_uzi", "reload_crouch", ((double)GoldUziReload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@gold_uzi", "p_load", ((double)GoldUziReload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.TBOGT_AdvancedMG)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@m249", "reload", ((double)M249Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@m249", "reload_crouch", ((double)M249Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@m249", "p_load", ((double)M249Reload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.TBOGT_AdvancedSniper)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@dsr1", "reload", ((double)AdvSnipReload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@dsr1", "reload_crouch", ((double)AdvSnipReload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@dsr1", "p_load", ((double)AdvSnipReload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.Episodic_22)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@handgun", "reload", ((double)Episodic22Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@handgun", "reload_crouch", ((double)Episodic22Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@ak47", "reload", ((double)Episodic22Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@ak47", "reload_crouch", ((double)Episodic22Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@ak47", "p_load", ((double)Episodic22Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@m249", "reload", ((double)Episodic22Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@m249", "reload_crouch", ((double)Episodic22Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@m249", "p_load", ((double)Episodic22Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@uzi", "reload", ((double)Episodic22Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@uzi", "reload_crouch", ((double)Episodic22Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@mp5k", "reload", ((double)Episodic22Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@mp5k", "reload_crouch", ((double)Episodic22Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@mp5k", "p_load", ((double)Episodic22Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@rifle", "reload", ((double)Episodic22Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@rifle", "reload_crouch", ((double)Episodic22Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@rifle", "p_load", ((double)Episodic22Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@shotgun", "reload", ((double)Episodic22Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@shotgun", "reload_crouch", ((double)Episodic22Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@baretta", "reload", ((double)Episodic22Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@baretta", "reload_crouch", ((double)Episodic22Reload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.Episodic_23)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@handgun", "reload", ((double)Episodic23Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@handgun", "reload_crouch", ((double)Episodic23Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@ak47", "reload", ((double)Episodic23Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@ak47", "reload_crouch", ((double)Episodic23Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@ak47", "p_load", ((double)Episodic23Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@m249", "reload", ((double)Episodic23Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@m249", "reload_crouch", ((double)Episodic23Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@m249", "p_load", ((double)Episodic23Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@uzi", "reload", ((double)Episodic23Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@uzi", "reload_crouch", ((double)Episodic23Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@mp5k", "reload", ((double)Episodic23Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@mp5k", "reload_crouch", ((double)Episodic23Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@mp5k", "p_load", ((double)Episodic23Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@rifle", "reload", ((double)Episodic23Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@rifle", "reload_crouch", ((double)Episodic23Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@rifle", "p_load", ((double)Episodic23Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@shotgun", "reload", ((double)Episodic23Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@shotgun", "reload_crouch", ((double)Episodic23Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@baretta", "reload", ((double)Episodic23Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@baretta", "reload_crouch", ((double)Episodic23Reload));
            }

            else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.Episodic_24)
            {
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@handgun", "reload", ((double)Episodic24Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@handgun", "reload_crouch", ((double)Episodic24Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@ak47", "reload", ((double)Episodic24Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@ak47", "reload_crouch", ((double)Episodic24Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@ak47", "p_load", ((double)Episodic24Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@m249", "reload", ((double)Episodic24Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@m249", "reload_crouch", ((double)Episodic24Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@m249", "p_load", ((double)Episodic24Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@uzi", "reload", ((double)Episodic24Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@uzi", "reload_crouch", ((double)Episodic24Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@mp5k", "reload", ((double)Episodic24Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@mp5k", "reload_crouch", ((double)Episodic24Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@mp5k", "p_load", ((double)Episodic24Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@rifle", "reload", ((double)Episodic24Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@rifle", "reload_crouch", ((double)Episodic24Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@rifle", "p_load", ((double)Episodic24Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@shotgun", "reload", ((double)Episodic24Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@shotgun", "reload_crouch", ((double)Episodic24Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@baretta", "reload", ((double)Episodic24Reload));
                GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", Game.LocalPlayer.Character, "gun@baretta", "reload_crouch", ((double)Episodic24Reload));
            }

        }
        public static void LoadINI()
        {
            SettingsFile ini = SettingsFile.Open(Path.Combine("scripts", "WeapFuncs.ini"));
            ini.Load();
            PistolReload = ini.GetValueFloat("Reload", "GLOCK", 1.0f);
            DeagleReload = ini.GetValueFloat("Reload", "DEAGLE", 1.0f);
            PumpShotReload = ini.GetValueFloat("Reload", "PUMP SHOTGUN", 1.0f);
            CombatShotReload = ini.GetValueFloat("Reload", "SEMIAUTO SHOTGUN", 1.0f);
            UziReload = ini.GetValueFloat("Reload", "MICRO UZI", 1.0f);
            MP5Reload = ini.GetValueFloat("Reload", "MP5", 1.0f);
            AK47Reload = ini.GetValueFloat("Reload", "AK47", 1.0f);
            M4Reload = ini.GetValueFloat("Reload", "M4", 1.0f);
            SnipReload = ini.GetValueFloat("Reload", "BOLTACTION SNIPER", 1.0f);
            PsgReload = ini.GetValueFloat("Reload", "SEMIAUTO SNIPER", 1.0f);
            RpgReload = ini.GetValueFloat("Reload", "RPG", 1.0f);
            AutoPReload = ini.GetValueFloat("Reload", "FULLAUTO PISTOL", 1.0f);
            SawnOffReload = ini.GetValueFloat("Reload", "SAWNOFF SHOTGUN", 1.0f);
            AssaultShotReload = ini.GetValueFloat("Reload", "ASSAULT SHOTGUN", 1.0f);
            GrndLaunchReload = ini.GetValueFloat("Reload", "GRENADE LAUNCHER", 1.0f);
            Pistol44Reload = ini.GetValueFloat("Reload", "PISTOL 44", 1.0f);
            AA12Reload = ini.GetValueFloat("Reload", "AA12", 1.0f);
            AA12ExpReload = ini.GetValueFloat("Reload", "AA12 EXP", 1.0f);
            P90Reload = ini.GetValueFloat("Reload", "P90", 1.0f);
            GoldUziReload = ini.GetValueFloat("Reload", "GOLD UZI", 1.0f);
            M249Reload = ini.GetValueFloat("Reload", "M249", 1.0f);
            AdvSnipReload = ini.GetValueFloat("Reload", "ADV SNIPER", 1.0f);
            Episodic22Reload = ini.GetValueFloat("Reload", "EPISODIC 22", 1.0f);
            Episodic23Reload = ini.GetValueFloat("Reload", "EPISODIC 23", 1.0f);
            Episodic24Reload = ini.GetValueFloat("Reload", "EPISODIC 24", 1.0f);
        }
    }
}
