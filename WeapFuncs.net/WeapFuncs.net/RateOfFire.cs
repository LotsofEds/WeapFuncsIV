using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using GTA;

namespace WeapFuncs.net
{
    internal class RateOfFire
    {
        private static bool CheckDateTime;
        private static DateTime currentDateTime;
        static int Radius = 0;
        static float PistolFire = 0;
        static float PistolFireDb = 0;
        static float PistolFireCover = 0;
        static float PistolReload = 0;
        static float DeagleFire = 0;
        static float DeagleFireDb = 0;
        static float DeagleFireCover = 0;
        static float DeagleReload = 0;
        static float PumpShotFire = 0;
        static float PumpShotFireCover = 0;
        static float PumpShotReload = 0;
        static float CombatShotFire = 0;
        static float CombatShotFireCoverNPC = 0;
        static float CombatShotFireCover = 0;
        static float CombatShotReload = 0;
        static float UziFire = 0;
        static float UziFireDb = 0;
        static float UziFireCover = 0;
        static float UziReload = 0;
        static float MP5Fire = 0;
        static float MP5FireDb = 0;
        static float MP5FireCover = 0;
        static float MP5Reload = 0;
        static float AK47Fire = 0;
        static float AK47FireDb = 0;
        static float AK47FireCover = 0;
        static float AK47Reload = 0;
        static float M4Fire = 0;
        static float M4FireDb = 0;
        static float M4FireCover = 0;
        static float M4Reload = 0;
        static float SnipFire = 0;
        static float SnipFireDb = 0;
        static float SnipFireCover = 0;
        static float SnipReload = 0;
        static float PsgFire = 0;
        static float PsgFireDb = 0;
        static float PsgFireCover = 0;
        static float PsgReload = 0;
        static float RpgFire = 0;
        static float RpgFireCover = 0;
        static float RpgReload = 0;
        static float AutoPFire = 0;
        static float AutoPFireDb = 0;
        static float AutoPFireCover = 0;
        static float AutoPReload = 0;
        static float SawnOffFire = 0;
        static float SawnOffFireDb = 0;
        static float SawnOffFireCoverNPC = 0;
        static float SawnOffFireCover = 0;
        static float SawnOffReload = 0;
        static float AssaultShotFire = 0;
        static float AssaultShotFireDb = 0;
        static float AssaultShotFireCoverNPC = 0;
        static float AssaultShotFireCover = 0;
        static float AssaultShotReload = 0;
        static float GrndLaunchFire = 0;
        static float GrndLaunchFireCover = 0;
        static float GrndLaunchReload = 0;
        static float Pistol44Fire = 0;
        static float Pistol44FireDb = 0;
        static float Pistol44FireCover = 0;
        static float Pistol44Reload = 0;
        static float AA12Fire = 0;
        static float AA12FireCoverNPC = 0;
        static float AA12FireCover = 0;
        static float AA12Reload = 0;
        static float AA12ExpFire = 0;
        static float AA12ExpFireCoverNPC = 0;
        static float AA12ExpFireCover = 0;
        static float AA12ExpReload = 0;
        static float P90Fire = 0;
        static float P90FireDb = 0;
        static float P90FireCover = 0;
        static float P90Reload = 0;
        static float GoldUziFire = 0;
        static float GoldUziFireDb = 0;
        static float GoldUziFireCover = 0;
        static float GoldUziReload = 0;
        static float M249Fire = 0;
        static float M249FireDb = 0;
        static float M249FireCover = 0;
        static float M249Reload = 0;
        static float AdvSnipFire = 0;
        static float AdvSnipFireDb = 0;
        static float AdvSnipFireCover = 0;
        static float AdvSnipReload = 0;
        static float Episodic22Fire = 0;
        static float Episodic22FireDb = 0;
        static float Episodic22FireCover = 0;
        static float Episodic22Reload = 0;
        static float Episodic23Fire = 0;
        static float Episodic23FireDb = 0;
        static float Episodic23FireCover = 0;
        static float Episodic23Reload = 0;
        static float Episodic24Fire = 0;
        static float Episodic24FireDb = 0;
        static float Episodic24FireCover = 0;
        static float Episodic24Reload = 0;
        public static void Tick()
        {
            if (CheckDateTime == false)
            {
                currentDateTime = DateTime.Now;
                CheckDateTime = true;
            }
            if (DateTime.Now.Subtract(currentDateTime).TotalMilliseconds > 20.0)
            {
                CheckDateTime = false;

                foreach (GTA.Ped ped in GTA.World.GetPeds(Game.LocalPlayer.Character.Position, Radius))
                {
                    if (!Game.Exists(ped)) continue;
                    if (!ped.isAliveAndWell) continue;
                    if (ped.Weapons.Current == ped.Weapons.AnyMelee) continue;
                    if (ped.Weapons.Current == Weapon.Unarmed) continue;

                    if (ped.Weapons.Current == Weapon.Handgun_Glock)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "fire", ((double)PistolFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "fire_crouch", ((double)PistolFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "dbfire", ((double)PistolFireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "dbfire_l", ((double)PistolFireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "pistol_blindfire", ((double)PistolFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "pistol_blindfire", ((double)PistolFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "pistol_blindfire", ((double)PistolFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "pistol_blindfire", ((double)PistolFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "pistol_blindfire", ((double)PistolFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "pistol_blindfire", ((double)PistolFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "reload", ((double)PistolReload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "reload_crouch", ((double)PistolReload));
                    }

                    else if (ped.Weapons.Current == Weapon.Handgun_DesertEagle)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@deagle", "fire", ((double)DeagleFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@deagle", "fire_crouch", ((double)DeagleFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@deagle", "dbfire", ((double)DeagleFireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@deagle", "dbfire_l", ((double)DeagleFireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "pistol_blindfire", ((double)DeagleFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "pistol_blindfire", ((double)DeagleFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "pistol_blindfire", ((double)DeagleFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "pistol_blindfire", ((double)DeagleFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "pistol_blindfire", ((double)DeagleFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "pistol_blindfire", ((double)DeagleFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@deagle", "reload", ((double)DeagleReload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@deagle", "reload_crouch", ((double)DeagleReload));
                    }

                    else if (ped.Weapons.Current == Weapon.Shotgun_Basic)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@shotgun", "fire", ((double)PumpShotFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@shotgun", "fire_crouch", ((double)PumpShotFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "shotgun_blindfire", ((double)PumpShotFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "shotgun_blindfire", ((double)PumpShotFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "shotgun_blindfire", ((double)PumpShotFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "shotgun_blindfire", ((double)PumpShotFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "shotgun_blindfire", ((double)PumpShotFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "shotgun_blindfire", ((double)PumpShotFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@shotgun", "reload", ((double)PumpShotReload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@shotgun", "reload_crouch", ((double)PumpShotReload));
                    }

                    else if (ped.Weapons.Current == Weapon.Shotgun_Baretta)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@baretta", "fire", ((double)CombatShotFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@baretta", "fire_crouch", ((double)CombatShotFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@baretta", "reload", ((double)CombatShotReload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@baretta", "reload_crouch", ((double)CombatShotReload));
                        if (ped != Game.LocalPlayer.Character)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "shotgun_blindfire", ((double)CombatShotFireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "shotgun_blindfire", ((double)CombatShotFireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "shotgun_blindfire", ((double)CombatShotFireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "shotgun_blindfire", ((double)CombatShotFireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "shotgun_blindfire", ((double)CombatShotFireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "shotgun_blindfire", ((double)CombatShotFireCoverNPC));
                        }
                        else if (ped == Game.LocalPlayer.Character)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "shotgun_blindfire", ((double)CombatShotFireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "shotgun_blindfire", ((double)CombatShotFireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "shotgun_blindfire", ((double)CombatShotFireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "shotgun_blindfire", ((double)CombatShotFireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "shotgun_blindfire", ((double)CombatShotFireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "shotgun_blindfire", ((double)CombatShotFireCover));
                        }
                    }

                    else if (ped.Weapons.Current == Weapon.SMG_Uzi)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "fire", ((double)UziFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "fire_crouch", ((double)UziFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "dbfire", ((double)UziFireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "dbfire_l", ((double)UziFireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "uzi_blindfire", ((double)UziFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "uzi_blindfire", ((double)UziFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "uzi_blindfire", ((double)UziFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "uzi_blindfire", ((double)UziFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "uzi_blindfire", ((double)UziFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "uzi_blindfire", ((double)UziFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "reload", ((double)UziReload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "reload_crouch", ((double)UziReload));
                    }

                    else if (ped.Weapons.Current == Weapon.SMG_MP5)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "fire", ((double)MP5Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "fire_crouch", ((double)MP5Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "dbfire", ((double)MP5FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "dbfire_l", ((double)MP5FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "ak47_blindfire", ((double)MP5FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "ak47_blindfire", ((double)MP5FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "ak47_blindfire", ((double)MP5FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "ak47_blindfire", ((double)MP5FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "ak47_blindfire", ((double)MP5FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "ak47_blindfire", ((double)MP5FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "reload", ((double)MP5Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "reload_crouch", ((double)MP5Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "p_load", ((double)MP5Reload));
                    }

                    else if (ped.Weapons.Current == Weapon.Rifle_AK47)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "fire", ((double)AK47Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "fire_alt", ((double)AK47Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "fire_crouch", ((double)AK47Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "fire_crouch_alt", ((double)AK47Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "ak47_blindfire", ((double)AK47FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "ak47_blindfire", ((double)AK47FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "ak47_blindfire", ((double)AK47FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "ak47_blindfire", ((double)AK47FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "ak47_blindfire", ((double)AK47FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "dbfire", ((double)AK47FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "reload", ((double)AK47Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "reload_crouch", ((double)AK47Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "p_load", ((double)AK47Reload));
                    }

                    else if (ped.Weapons.Current == Weapon.Rifle_M4)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "fire", ((double)M4Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "fire_alt", ((double)M4Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "fire_crouch", ((double)M4Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "fire_crouch_alt", ((double)M4Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "ak47_blindfire", ((double)M4FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "ak47_blindfire", ((double)M4FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "ak47_blindfire", ((double)M4FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "ak47_blindfire", ((double)M4FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "ak47_blindfire", ((double)M4FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "ak47_blindfire", ((double)M4FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "dbfire", ((double)M4FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "reload", ((double)M4Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "reload_crouch", ((double)M4Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "p_load", ((double)M4Reload));
                    }

                    else if (ped.Weapons.Current == Weapon.SniperRifle_M40A1)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "fire", ((double)SnipFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "fire_alt", ((double)SnipFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "fire_crouch", ((double)SnipFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "fire_crouch_alt", ((double)SnipFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "rifle_blindfire", ((double)SnipFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "rifle_blindfire", ((double)SnipFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "rifle_blindfire", ((double)SnipFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "rifle_blindfire", ((double)SnipFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "rifle_blindfire", ((double)SnipFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "rifle_blindfire", ((double)SnipFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "dbfire", ((double)SnipFireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "reload", ((double)SnipReload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "reload_crouch", ((double)SnipReload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "p_load", ((double)SnipReload));
                    }

                    else if (ped.Weapons.Current == Weapon.SniperRifle_Basic)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "fire", ((double)PsgFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "fire_alt", ((double)PsgFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "fire_crouch", ((double)PsgFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "fire_crouch_alt", ((double)PsgFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "rifle_blindfire", ((double)PsgFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "rifle_blindfire", ((double)PsgFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "rifle_blindfire", ((double)PsgFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "rifle_blindfire", ((double)PsgFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "rifle_blindfire", ((double)PsgFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "rifle_blindfire", ((double)PsgFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "dbfire", ((double)PsgFireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "reload", ((double)PsgReload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "reload_crouch", ((double)PsgReload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "p_load", ((double)PsgReload));
                    }

                    else if (ped.Weapons.Current == Weapon.Heavy_RocketLauncher)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rocket", "fire", ((double)RpgFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rocket", "fire_crouch", ((double)RpgFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "rocket_blindfire", ((double)RpgFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "rocket_blindfire", ((double)RpgFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "rocket_blindfire", ((double)RpgFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "rocket_blindfire", ((double)RpgFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "rocket_blindfire", ((double)RpgFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "rocket_blindfire", ((double)RpgFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rocket", "reload", ((double)RpgReload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rocket", "reload_crouch", ((double)RpgReload));
                    }

                    else if (ped.Weapons.Current == Weapon.TLAD_Automatic9mm)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@cz75", "fire", ((double)AutoPFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@cz75", "fire_crouch", ((double)AutoPFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@cz75", "dbfire", ((double)AutoPFireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@cz75", "dbfire_l", ((double)AutoPFireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "pistol_blindfire", ((double)AutoPFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "pistol_blindfire", ((double)AutoPFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "pistol_blindfire", ((double)AutoPFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "pistol_blindfire", ((double)AutoPFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "pistol_blindfire", ((double)AutoPFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "pistol_blindfire", ((double)AutoPFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@cz75", "reload", ((double)AutoPReload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@cz75", "reload_crouch", ((double)AutoPReload));
                    }

                    else if (ped.Weapons.Current == Weapon.TLAD_SawedOffShotgun)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@sawnoff", "fire", ((double)SawnOffFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@sawnoff", "fire_crouch", ((double)SawnOffFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@sawnoff", "dbfire", ((double)SawnOffFireDb));
                        if (ped != Game.LocalPlayer.Character)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "shotgun_blindfire", ((double)SawnOffFireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "shotgun_blindfire", ((double)SawnOffFireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "shotgun_blindfire", ((double)SawnOffFireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "shotgun_blindfire", ((double)SawnOffFireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "shotgun_blindfire", ((double)SawnOffFireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "shotgun_blindfire", ((double)SawnOffFireCoverNPC));
                        }
                        else if (ped == Game.LocalPlayer.Character)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "shotgun_blindfire", ((double)SawnOffFireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "shotgun_blindfire", ((double)SawnOffFireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "shotgun_blindfire", ((double)SawnOffFireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "shotgun_blindfire", ((double)SawnOffFireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "shotgun_blindfire", ((double)SawnOffFireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "shotgun_blindfire", ((double)SawnOffFireCover));
                        }
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@sawnoff", "reload", ((double)SawnOffReload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@sawnoff", "reload_crouch", ((double)SawnOffReload));
                    }

                    else if (ped.Weapons.Current == Weapon.TLAD_AssaultShotgun)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@test_gun", "fire", ((double)AssaultShotFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@test_gun", "fire_up", ((double)AssaultShotFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@test_gun", "fire_down", ((double)AssaultShotFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@test_gun", "fire_crouch", ((double)AssaultShotFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@test_gun", "dbfire", ((double)AssaultShotFireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@test_gun", "dbfire_l", ((double)AssaultShotFireDb));
                        if (ped != Game.LocalPlayer.Character)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "shotgun_blindfire", ((double)AssaultShotFireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "shotgun_blindfire", ((double)AssaultShotFireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "shotgun_blindfire", ((double)AssaultShotFireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "shotgun_blindfire", ((double)AssaultShotFireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "shotgun_blindfire", ((double)AssaultShotFireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "shotgun_blindfire", ((double)AssaultShotFireCoverNPC));
                        }
                        else if (ped == Game.LocalPlayer.Character)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "shotgun_blindfire", ((double)AssaultShotFireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "shotgun_blindfire", ((double)AssaultShotFireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "shotgun_blindfire", ((double)AssaultShotFireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "shotgun_blindfire", ((double)AssaultShotFireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "shotgun_blindfire", ((double)AssaultShotFireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "shotgun_blindfire", ((double)AssaultShotFireCover));
                        }
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@test_gun", "reload", ((double)AssaultShotReload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@test_gun", "reload_crouch", ((double)AssaultShotReload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@test_gun", "p_load", ((double)AssaultShotReload));
                    }

                    else if (ped.Weapons.Current == Weapon.TLAD_GrenadeLauncher || ped.Weapons.Current == Weapon.TBOGT_GrenadeLauncher)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@grnde_launch", "fire", ((double)GrndLaunchFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@grnde_launch", "fire_crouch", ((double)GrndLaunchFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "rocket_blindfire", ((double)GrndLaunchFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "rocket_blindfire", ((double)GrndLaunchFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "rocket_blindfire", ((double)GrndLaunchFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "rocket_blindfire", ((double)GrndLaunchFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "rocket_blindfire", ((double)GrndLaunchFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "rocket_blindfire", ((double)GrndLaunchFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@grnde_launch", "reload", ((double)GrndLaunchReload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@grnde_launch", "reload_crouch", ((double)GrndLaunchReload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@grnde_launch", "p_load", ((double)GrndLaunchReload));
                    }

                    else if (ped.Weapons.Current == Weapon.TBOGT_Pistol44)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@44a", "fire", ((double)Pistol44Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@44a", "fire_crouch", ((double)Pistol44Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@44a", "dbfire", ((double)Pistol44FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@44a", "dbfire_l", ((double)Pistol44FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "pistol_blindfire", ((double)Pistol44FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "pistol_blindfire", ((double)Pistol44FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "pistol_blindfire", ((double)Pistol44FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "pistol_blindfire", ((double)Pistol44FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "pistol_blindfire", ((double)Pistol44FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "pistol_blindfire", ((double)Pistol44FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@44a", "reload", ((double)Pistol44Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@44a", "reload_crouch", ((double)Pistol44Reload));
                    }

                    else if (ped.Weapons.Current == Weapon.TBOGT_NormalShotgun)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@aa12", "fire", ((double)AA12Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@aa12", "fire_crouch", ((double)AA12Fire));
                        if (ped != Game.LocalPlayer.Character)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "shotgun_blindfire", ((double)AA12FireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "shotgun_blindfire", ((double)AA12FireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "shotgun_blindfire", ((double)AA12FireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "shotgun_blindfire", ((double)AA12FireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "shotgun_blindfire", ((double)AA12FireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "shotgun_blindfire", ((double)AA12FireCoverNPC));
                        }
                        else if (ped == Game.LocalPlayer.Character)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "shotgun_blindfire", ((double)AA12FireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "shotgun_blindfire", ((double)AA12FireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "shotgun_blindfire", ((double)AA12FireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "shotgun_blindfire", ((double)AA12FireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "shotgun_blindfire", ((double)AA12FireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "shotgun_blindfire", ((double)AA12FireCover));
                        }
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@aa12", "reload", ((double)AA12Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@aa12", "reload_crouch", ((double)AA12Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@aa12", "p_load", ((double)AA12Reload));
                    }

                    else if (ped.Weapons.Current == Weapon.TBOGT_ExplosiveShotgun)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@aa12", "fire", ((double)AA12ExpFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@aa12", "fire_crouch", ((double)AA12ExpFire));
                        if (ped != Game.LocalPlayer.Character)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "shotgun_blindfire", ((double)AA12ExpFireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "shotgun_blindfire", ((double)AA12ExpFireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "shotgun_blindfire", ((double)AA12ExpFireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "shotgun_blindfire", ((double)AA12ExpFireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "shotgun_blindfire", ((double)AA12ExpFireCoverNPC));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "shotgun_blindfire", ((double)AA12ExpFireCoverNPC));
                        }
                        else if (ped == Game.LocalPlayer.Character)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "shotgun_blindfire", ((double)AA12ExpFireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "shotgun_blindfire", ((double)AA12ExpFireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "shotgun_blindfire", ((double)AA12ExpFireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "shotgun_blindfire", ((double)AA12ExpFireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "shotgun_blindfire", ((double)AA12ExpFireCover));
                            GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "shotgun_blindfire", ((double)AA12ExpFireCover));
                        }
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@aa12", "reload", ((double)AA12ExpReload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@aa12", "reload_crouch", ((double)AA12ExpReload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@aa12", "p_load", ((double)AA12ExpReload));
                    }

                    else if (ped.Weapons.Current == Weapon.TBOGT_AssaultSMG)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@p90", "fire", ((double)P90Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@p90", "fire_crouch", ((double)P90Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@p90", "dbfire", ((double)P90FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "ak47_blindfire", ((double)P90FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "ak47_blindfire", ((double)P90FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "ak47_blindfire", ((double)P90FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "ak47_blindfire", ((double)P90FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "ak47_blindfire", ((double)P90FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "ak47_blindfire", ((double)P90FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@p90", "reload", ((double)P90Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@p90", "reload_crouch", ((double)P90Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@p90", "p_load", ((double)P90Reload));
                    }

                    else if (ped.Weapons.Current == Weapon.TBOGT_GoldenSMG)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@gold_uzi", "fire", ((double)GoldUziFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@gold_uzi", "fire_crouch", ((double)GoldUziFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@gold_uzi", "dbfire", ((double)GoldUziFireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@gold_uzi", "dbfire_l", ((double)GoldUziFireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "uzi_blindfire", ((double)GoldUziFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "uzi_blindfire", ((double)GoldUziFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "uzi_blindfire", ((double)GoldUziFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "uzi_blindfire", ((double)GoldUziFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "uzi_blindfire", ((double)GoldUziFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "uzi_blindfire", ((double)GoldUziFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@gold_uzi", "reload", ((double)GoldUziReload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@gold_uzi", "reload_crouch", ((double)GoldUziReload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@gold_uzi", "p_load", ((double)GoldUziReload));
                    }

                    else if (ped.Weapons.Current == Weapon.TBOGT_AdvancedMG)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "fire", ((double)M249Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "fire_up", ((double)M249Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "fire_down", ((double)M249Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "fire_crouch", ((double)M249Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "dbfire", ((double)M249FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "ak47_blindfire", ((double)M249FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "ak47_blindfire", ((double)M249FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "ak47_blindfire", ((double)M249FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "ak47_blindfire", ((double)M249FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "ak47_blindfire", ((double)M249FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "ak47_blindfire", ((double)M249FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "reload", ((double)M249Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "reload_crouch", ((double)M249Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "p_load", ((double)M249Reload));
                    }

                    else if (ped.Weapons.Current == Weapon.TBOGT_AdvancedSniper)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@dsr1", "fire", ((double)AdvSnipFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@dsr1", "fire_alt", ((double)AdvSnipFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@dsr1", "fire_crouch", ((double)AdvSnipFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@dsr1", "fire_crouch_alt", ((double)AdvSnipFire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@dsr1", "dbfire", ((double)AdvSnipFireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "rifle_blindfire", ((double)AdvSnipFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "rifle_blindfire", ((double)AdvSnipFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "rifle_blindfire", ((double)AdvSnipFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "rifle_blindfire", ((double)AdvSnipFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "rifle_blindfire", ((double)AdvSnipFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "rifle_blindfire", ((double)AdvSnipFireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@dsr1", "reload", ((double)AdvSnipReload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@dsr1", "reload_crouch", ((double)AdvSnipReload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@dsr1", "p_load", ((double)AdvSnipReload));
                    }

                    else if (ped.Weapons.Current == Weapon.Episodic_22)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "fire", ((double)Episodic22Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "fire_crouch", ((double)Episodic22Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "dbfire", ((double)Episodic22FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "dbfire_l", ((double)Episodic22FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "pistol_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "pistol_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "pistol_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "pistol_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "pistol_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "pistol_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "reload", ((double)Episodic22Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "reload_crouch", ((double)Episodic22Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "fire", ((double)Episodic22Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "fire_alt", ((double)Episodic22Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "fire_crouch", ((double)Episodic22Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "fire_crouch_alt", ((double)Episodic22Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "ak47_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "ak47_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "ak47_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "ak47_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "ak47_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "dbfire", ((double)Episodic22FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "reload", ((double)Episodic22Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "reload_crouch", ((double)Episodic22Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "p_load", ((double)Episodic22Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "fire", ((double)Episodic22Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "fire_up", ((double)Episodic22Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "fire_down", ((double)Episodic22Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "fire_crouch", ((double)Episodic22Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "dbfire", ((double)Episodic22FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "reload", ((double)Episodic22Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "reload_crouch", ((double)Episodic22Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "p_load", ((double)Episodic22Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "fire", ((double)Episodic22Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "fire_crouch", ((double)Episodic22Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "dbfire", ((double)Episodic22FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "dbfire_l", ((double)Episodic22FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "uzi_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "uzi_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "uzi_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "uzi_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "uzi_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "uzi_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "reload", ((double)Episodic22Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "reload_crouch", ((double)Episodic22Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "fire", ((double)Episodic22Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "fire_crouch", ((double)Episodic22Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "dbfire", ((double)Episodic22FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "dbfire_l", ((double)Episodic22FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "reload", ((double)Episodic22Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "reload_crouch", ((double)Episodic22Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "p_load", ((double)Episodic22Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "fire", ((double)Episodic22Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "fire_alt", ((double)Episodic22Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "fire_crouch", ((double)Episodic22Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "fire_crouch_alt", ((double)Episodic22Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "rifle_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "rifle_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "rifle_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "rifle_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "rifle_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "rifle_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "dbfire", ((double)Episodic22FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "reload", ((double)Episodic22Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "reload_crouch", ((double)Episodic22Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "p_load", ((double)Episodic22Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@shotgun", "fire", ((double)Episodic22Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@shotgun", "fire_crouch", ((double)Episodic22Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "shotgun_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "shotgun_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "shotgun_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "shotgun_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "shotgun_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "shotgun_blindfire", ((double)Episodic22FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@shotgun", "reload", ((double)Episodic22Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@shotgun", "reload_crouch", ((double)Episodic22Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@baretta", "fire", ((double)Episodic22Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@baretta", "fire_crouch", ((double)Episodic22Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@baretta", "reload", ((double)Episodic22Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@baretta", "reload_crouch", ((double)Episodic22Reload));
                    }

                    else if (ped.Weapons.Current == Weapon.Episodic_23)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "fire", ((double)Episodic23Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "fire_crouch", ((double)Episodic23Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "dbfire", ((double)Episodic23FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "dbfire_l", ((double)Episodic23FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "pistol_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "pistol_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "pistol_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "pistol_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "pistol_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "pistol_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "reload", ((double)Episodic23Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "reload_crouch", ((double)Episodic23Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "fire", ((double)Episodic23Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "fire_alt", ((double)Episodic23Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "fire_crouch", ((double)Episodic23Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "fire_crouch_alt", ((double)Episodic23Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "ak47_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "ak47_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "ak47_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "ak47_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "ak47_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "dbfire", ((double)Episodic23FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "reload", ((double)Episodic23Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "reload_crouch", ((double)Episodic23Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "p_load", ((double)Episodic23Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "fire", ((double)Episodic23Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "fire_up", ((double)Episodic23Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "fire_down", ((double)Episodic23Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "fire_crouch", ((double)Episodic23Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "dbfire", ((double)Episodic23FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "reload", ((double)Episodic23Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "reload_crouch", ((double)Episodic23Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "p_load", ((double)Episodic23Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "fire", ((double)Episodic23Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "fire_crouch", ((double)Episodic23Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "dbfire", ((double)Episodic23FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "dbfire_l", ((double)Episodic23FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "uzi_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "uzi_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "uzi_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "uzi_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "uzi_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "uzi_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "reload", ((double)Episodic23Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "reload_crouch", ((double)Episodic23Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "fire", ((double)Episodic23Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "fire_crouch", ((double)Episodic23Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "dbfire", ((double)Episodic23FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "dbfire_l", ((double)Episodic23FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "reload", ((double)Episodic23Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "reload_crouch", ((double)Episodic23Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "p_load", ((double)Episodic23Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "fire", ((double)Episodic23Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "fire_alt", ((double)Episodic23Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "fire_crouch", ((double)Episodic23Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "fire_crouch_alt", ((double)Episodic23Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "rifle_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "rifle_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "rifle_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "rifle_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "rifle_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "rifle_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "dbfire", ((double)Episodic23FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "reload", ((double)Episodic23Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "reload_crouch", ((double)Episodic23Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "p_load", ((double)Episodic23Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@shotgun", "fire", ((double)Episodic23Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@shotgun", "fire_crouch", ((double)Episodic23Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "shotgun_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "shotgun_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "shotgun_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "shotgun_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "shotgun_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "shotgun_blindfire", ((double)Episodic23FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@shotgun", "reload", ((double)Episodic23Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@shotgun", "reload_crouch", ((double)Episodic23Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@baretta", "fire", ((double)Episodic23Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@baretta", "fire_crouch", ((double)Episodic23Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@baretta", "reload", ((double)Episodic23Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@baretta", "reload_crouch", ((double)Episodic23Reload));
                    }

                    else if (ped.Weapons.Current == Weapon.Episodic_24)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "fire", ((double)Episodic24Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "fire_crouch", ((double)Episodic24Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "dbfire", ((double)Episodic24FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "dbfire_l", ((double)Episodic24FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "pistol_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "pistol_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "pistol_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "pistol_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "pistol_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "pistol_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "reload", ((double)Episodic24Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@handgun", "reload_crouch", ((double)Episodic24Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "fire", ((double)Episodic24Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "fire_alt", ((double)Episodic24Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "fire_crouch", ((double)Episodic24Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "fire_crouch_alt", ((double)Episodic24Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "ak47_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "ak47_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "ak47_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "ak47_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "ak47_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "dbfire", ((double)Episodic24FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "reload", ((double)Episodic24Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "reload_crouch", ((double)Episodic24Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@ak47", "p_load", ((double)Episodic24Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "fire", ((double)Episodic24Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "fire_up", ((double)Episodic24Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "fire_down", ((double)Episodic24Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "fire_crouch", ((double)Episodic24Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "dbfire", ((double)Episodic24FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "reload", ((double)Episodic24Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "reload_crouch", ((double)Episodic24Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@m249", "p_load", ((double)Episodic24Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "fire", ((double)Episodic24Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "fire_crouch", ((double)Episodic24Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "dbfire", ((double)Episodic24FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "dbfire_l", ((double)Episodic24FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "uzi_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "uzi_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "uzi_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "uzi_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "uzi_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "uzi_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "reload", ((double)Episodic24Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@uzi", "reload_crouch", ((double)Episodic24Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "fire", ((double)Episodic24Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "fire_crouch", ((double)Episodic24Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "dbfire", ((double)Episodic24FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "dbfire_l", ((double)Episodic24FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "reload", ((double)Episodic24Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "reload_crouch", ((double)Episodic24Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@mp5k", "p_load", ((double)Episodic24Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "fire", ((double)Episodic24Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "fire_alt", ((double)Episodic24Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "fire_crouch", ((double)Episodic24Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "fire_crouch_alt", ((double)Episodic24Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "rifle_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "rifle_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "rifle_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "rifle_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "rifle_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "rifle_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "dbfire", ((double)Episodic24FireDb));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "reload", ((double)Episodic24Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "reload_crouch", ((double)Episodic24Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@rifle", "p_load", ((double)Episodic24Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@shotgun", "fire", ((double)Episodic24Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@shotgun", "fire_crouch", ((double)Episodic24Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_high_corner", "shotgun_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_centre", "shotgun_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_l_low_corner", "shotgun_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_high_corner", "shotgun_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_centre", "shotgun_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "cover_r_low_corner", "shotgun_blindfire", ((double)Episodic24FireCover));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@shotgun", "reload", ((double)Episodic24Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@shotgun", "reload_crouch", ((double)Episodic24Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@baretta", "fire", ((double)Episodic24Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@baretta", "fire_crouch", ((double)Episodic24Fire));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@baretta", "reload", ((double)Episodic24Reload));
                        GTA.Native.Function.Call("SET_CHAR_ANIM_SPEED", ped, "gun@baretta", "reload_crouch", ((double)Episodic24Reload));
                    }
                }
            }
        }
        public static void LoadINI()
        {
            SettingsFile ini = SettingsFile.Open(Path.Combine("scripts", "WeapFuncs.ini"));
            ini.Load();
            Radius = ini.GetValueInteger("PedDistance", "GLOBAL RATE OF FIRE", 75);
            PistolFire = ini.GetValueFloat("NormalROF", "GLOCK", 1.0f);
            PistolFireDb = ini.GetValueFloat("DrivebyROF", "GLOCK", 1.0f);
            PistolFireCover = ini.GetValueFloat("InCoverROF", "GLOCK", 1.0f);
            PistolReload = ini.GetValueFloat("Reload", "GLOCK", 1.0f);
            DeagleFire = ini.GetValueFloat("NormalROF", "DEAGLE", 1.0f);
            DeagleFireDb = ini.GetValueFloat("DrivebyROF", "DEAGLE", 1.0f);
            DeagleFireCover = ini.GetValueFloat("InCoverROF", "DEAGLE", 1.0f);
            DeagleReload = ini.GetValueFloat("Reload", "DEAGLE", 1.0f);
            PumpShotFire = ini.GetValueFloat("NormalROF", "PUMP SHOTGUN", 1.0f);
            PumpShotFireCover = ini.GetValueFloat("InCoverROF", "PUMP SHOTGUN", 1.0f);
            PumpShotReload = ini.GetValueFloat("Reload", "PUMP SHOTGUN", 1.0f);
            CombatShotFire = ini.GetValueFloat("NormalROF", "SEMIAUTO SHOTGUN", 1.0f);
            CombatShotFireCoverNPC = ini.GetValueFloat("NPCInCoverROF", "SEMIAUTO SHOTGUN", 1.0f);
            CombatShotFireCover = ini.GetValueFloat("InCoverROF", "SEMIAUTO SHOTGUN", 1.0f);
            CombatShotReload = ini.GetValueFloat("Reload", "SEMIAUTO SHOTGUN", 1.0f);
            UziFire = ini.GetValueFloat("NormalROF", "MICRO UZI", 1.0f);
            UziFireDb = ini.GetValueFloat("DrivebyROF", "MICRO UZI", 1.0f);
            UziFireCover = ini.GetValueFloat("InCoverROF", "MICRO UZI", 1.0f);
            UziReload = ini.GetValueFloat("Reload", "MICRO UZI", 1.0f);
            MP5Fire = ini.GetValueFloat("NormalROF", "MP5", 1.0f);
            MP5FireDb = ini.GetValueFloat("DrivebyROF", "MP5", 1.0f);
            MP5FireCover = ini.GetValueFloat("InCoverROF", "MP5", 1.0f);
            MP5Reload = ini.GetValueFloat("Reload", "MP5", 1.0f);
            AK47Fire = ini.GetValueFloat("NormalROF", "AK47", 1.0f);
            AK47FireDb = ini.GetValueFloat("DrivebyROF", "AK47", 1.0f);
            AK47FireCover = ini.GetValueFloat("InCoverROF", "AK47", 1.0f);
            AK47Reload = ini.GetValueFloat("Reload", "AK47", 1.0f);
            M4Fire = ini.GetValueFloat("NormalROF", "M4", 1.0f);
            M4FireDb = ini.GetValueFloat("DrivebyROF", "M4", 1.0f);
            M4FireCover = ini.GetValueFloat("InCoverROF", "M4", 1.0f);
            M4Reload = ini.GetValueFloat("Reload", "M4", 1.0f);
            SnipFire = ini.GetValueFloat("NormalROF", "BOLTACTION SNIPER", 1.0f);
            SnipFireDb = ini.GetValueFloat("DrivebyROF", "BOLTACTION SNIPER", 1.0f);
            SnipFireCover = ini.GetValueFloat("InCoverROF", "BOLTACTION SNIPER", 1.0f);
            SnipReload = ini.GetValueFloat("Reload", "BOLTACTION SNIPER", 1.0f);
            PsgFire = ini.GetValueFloat("NormalROF", "SEMIAUTO SNIPER", 1.0f);
            PsgFireDb = ini.GetValueFloat("DrivebyROF", "SEMIAUTO SNIPER", 1.0f);
            PsgFireCover = ini.GetValueFloat("InCoverROF", "SEMIAUTO SNIPER", 1.0f);
            PsgReload = ini.GetValueFloat("Reload", "SEMIAUTO SNIPER", 1.0f);
            RpgFire = ini.GetValueFloat("NormalROF", "RPG", 1.0f);
            RpgFireCover = ini.GetValueFloat("InCoverROF", "RPG", 1.0f);
            RpgReload = ini.GetValueFloat("Reload", "RPG", 1.0f);
            AutoPFire = ini.GetValueFloat("NormalROF", "FULLAUTO PISTOL", 1.0f);
            AutoPFireDb = ini.GetValueFloat("DrivebyROF", "FULLAUTO PISTOL", 1.0f);
            AutoPFireCover = ini.GetValueFloat("InCoverROF", "FULLAUTO PISTOL", 1.0f);
            AutoPReload = ini.GetValueFloat("Reload", "FULLAUTO PISTOL", 1.0f);
            SawnOffFire = ini.GetValueFloat("NormalROF", "SAWNOFF SHOTGUN", 1.0f);
            SawnOffFireDb = ini.GetValueFloat("DrivebyROF", "SAWNOFF SHOTGUN", 1.0f);
            SawnOffFireCoverNPC = ini.GetValueFloat("NPCInCoverROF", "SAWNOFF SHOTGUN", 1.0f);
            SawnOffFireCover = ini.GetValueFloat("InCoverROF", "SAWNOFF SHOTGUN", 1.0f);
            SawnOffReload = ini.GetValueFloat("Reload", "SAWNOFF SHOTGUN", 1.0f);
            AssaultShotFire = ini.GetValueFloat("NormalROF", "ASSAULT SHOTGUN", 1.0f);
            AssaultShotFireDb = ini.GetValueFloat("DrivebyROF", "ASSAULT SHOTGUN", 1.0f);
            AssaultShotFireCoverNPC = ini.GetValueFloat("NPCInCoverROF", "ASSAULT SHOTGUN", 1.0f);
            AssaultShotFireCover = ini.GetValueFloat("InCoverROF", "ASSAULT SHOTGUN", 1.0f);
            AssaultShotReload = ini.GetValueFloat("Reload", "ASSAULT SHOTGUN", 1.0f);
            GrndLaunchFire = ini.GetValueFloat("NormalROF", "GRENADE LAUNCHER", 1.0f);
            GrndLaunchFireCover = ini.GetValueFloat("InCoverROF", "GRENADE LAUNCHER", 1.0f);
            GrndLaunchReload = ini.GetValueFloat("Reload", "GRENADE LAUNCHER", 1.0f);
            Pistol44Fire = ini.GetValueFloat("NormalROF", "PISTOL 44", 1.0f);
            Pistol44FireDb = ini.GetValueFloat("DrivebyROF", "PISTOL 44", 1.0f);
            Pistol44FireCover = ini.GetValueFloat("InCoverROF", "PISTOL 44", 1.0f);
            Pistol44Reload = ini.GetValueFloat("Reload", "PISTOL 44", 1.0f);
            AA12Fire = ini.GetValueFloat("NormalROF", "AA12", 1.0f);
            AA12FireCoverNPC = ini.GetValueFloat("NPCInCoverROF", "AA12", 1.0f);
            AA12FireCover = ini.GetValueFloat("InCoverROF", "AA12", 1.0f);
            AA12Reload = ini.GetValueFloat("Reload", "AA12", 1.0f);
            AA12ExpFire = ini.GetValueFloat("NormalROF", "AA12 EXP", 1.0f);
            AA12ExpFireCoverNPC = ini.GetValueFloat("NPCInCoverROF", "AA12 EXP", 1.0f);
            AA12ExpFireCover = ini.GetValueFloat("InCoverROF", "AA12 EXP", 1.0f);
            AA12ExpReload = ini.GetValueFloat("Reload", "AA12 EXP", 1.0f);
            P90Fire = ini.GetValueFloat("NormalROF", "P90", 1.0f);
            P90FireDb = ini.GetValueFloat("DrivebyROF", "P90", 1.0f);
            P90FireCover = ini.GetValueFloat("InCoverROF", "P90", 1.0f);
            P90Reload = ini.GetValueFloat("Reload", "P90", 1.0f);
            GoldUziFire = ini.GetValueFloat("NormalROF", "GOLD UZI", 1.0f);
            GoldUziFireDb = ini.GetValueFloat("DrivebyROF", "GOLD UZI", 1.0f);
            GoldUziFireCover = ini.GetValueFloat("InCoverROF", "GOLD UZI", 1.0f);
            GoldUziReload = ini.GetValueFloat("Reload", "GOLD UZI", 1.0f);
            M249Fire = ini.GetValueFloat("NormalROF", "M249", 1.0f);
            M249FireDb = ini.GetValueFloat("DrivebyROF", "M249", 1.0f);
            M249FireCover = ini.GetValueFloat("InCoverROF", "M249", 1.0f);
            M249Reload = ini.GetValueFloat("Reload", "M249", 1.0f);
            AdvSnipFire = ini.GetValueFloat("NormalROF", "ADV SNIPER", 1.0f);
            AdvSnipFireDb = ini.GetValueFloat("DrivebyROF", "ADV SNIPER", 1.0f);
            AdvSnipFireCover = ini.GetValueFloat("InCoverROF", "ADV SNIPER", 1.0f);
            AdvSnipReload = ini.GetValueFloat("Reload", "ADV SNIPER", 1.0f);
            Episodic22Fire = ini.GetValueFloat("NormalROF", "EPISODIC 22", 1.0f);
            Episodic22FireDb = ini.GetValueFloat("DrivebyROF", "EPISODIC 22", 1.0f);
            Episodic22FireCover = ini.GetValueFloat("InCoverROF", "EPISODIC 22", 1.0f);
            Episodic22Reload = ini.GetValueFloat("Reload", "EPISODIC 22", 1.0f);
            Episodic23Fire = ini.GetValueFloat("NormalROF", "EPISODIC 23", 1.0f);
            Episodic23FireDb = ini.GetValueFloat("DrivebyROF", "EPISODIC 23", 1.0f);
            Episodic23FireCover = ini.GetValueFloat("InCoverROF", "EPISODIC 23", 1.0f);
            Episodic23Reload = ini.GetValueFloat("Reload", "EPISODIC 23", 1.0f);
            Episodic24Fire = ini.GetValueFloat("NormalROF", "EPISODIC 24", 1.0f);
            Episodic24FireDb = ini.GetValueFloat("DrivebyROF", "EPISODIC 24", 1.0f);
            Episodic24FireCover = ini.GetValueFloat("InCoverROF", "EPISODIC 24", 1.0f);
            Episodic24Reload = ini.GetValueFloat("Reload", "EPISODIC 24", 1.0f);
        }
    }
}