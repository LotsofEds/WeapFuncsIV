using GTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeapFuncs.net
{
    internal class ShotgunBlindfireFix
    {
        public static void Tick()
        {
            GTA.Native.Pointer ShotgunBF = 0.0;
            if (Game.LocalPlayer.Character.Weapons.Current == Weapon.TLAD_AssaultShotgun && Main.FullAutoStreetSweeper == true)
            {
                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_high_corner", "shotgun_blindfire"))
                {
                    if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_high_corner", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF > 0.255 && ShotgunBF < 0.44)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_high_corner", "shotgun_blindfire", 0.2);
                        }
                        if (ShotgunBF > 0.77)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                    if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip < 1 || !Game.isGameKeyPressed(GameKey.Attack) || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_high_corner", "shotgun_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_high_corner", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF > 0.255 && ShotgunBF < 0.44)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_high_corner", "shotgun_blindfire", 0.77);
                        }
                        if (ShotgunBF > 0.77 || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_high_corner", "shotgun_blindfire"))
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                }
                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_high_corner", "shotgun_blindfire"))
                {
                    if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_high_corner", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF > 0.305 && ShotgunBF < 0.51)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_high_corner", "shotgun_blindfire", 0.25);
                        }
                        if (ShotgunBF > 0.78)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                    if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip < 1 || !Game.isGameKeyPressed(GameKey.Attack) || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_high_corner", "shotgun_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_high_corner", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF > 0.305 && ShotgunBF < 0.51)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_high_corner", "shotgun_blindfire", 0.78);
                        }
                        if (ShotgunBF > 0.78 || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_high_corner", "shotgun_blindfire"))
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                }

                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_low_corner", "shotgun_blindfire"))
                {
                    if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_corner", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF > 0.3 && ShotgunBF < 0.54)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_corner", "shotgun_blindfire", 0.73);
                        }
                        if (ShotgunBF > 0.76)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                    if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip < 1 || !Game.isGameKeyPressed(GameKey.Attack) || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_low_corner", "shotgun_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_corner", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF > 0.3 && ShotgunBF < 0.56)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_corner", "shotgun_blindfire", 0.76);
                        }
                        if (ShotgunBF > 0.76 || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_low_corner", "shotgun_blindfire"))
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                }
                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_low_corner", "shotgun_blindfire"))
                {
                    if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_corner", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF > 0.24 && ShotgunBF < 0.54)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_corner", "shotgun_blindfire", 0.725);
                        }
                        if (ShotgunBF > 0.84)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                    if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip < 1 || !Game.isGameKeyPressed(GameKey.Attack) || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_low_corner", "shotgun_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_corner", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF > 0.24 && ShotgunBF < 0.54)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_corner", "shotgun_blindfire", 0.76);
                        }
                        if (ShotgunBF > 0.76 || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_low_corner", "shotgun_blindfire"))
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                }
                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_low_centre", "shotgun_blindfire"))
                {
                    if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_centre", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF > 0.295 && ShotgunBF < 0.54)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_centre", "shotgun_blindfire", 0.25);
                        }
                        if (ShotgunBF > 0.76)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                    if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip < 1 || !Game.isGameKeyPressed(GameKey.Attack) || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_low_centre", "shotgun_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_centre", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF > 0.295 && ShotgunBF < 0.56)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_centre", "shotgun_blindfire", 0.76);
                        }
                        if (ShotgunBF > 0.76 || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_low_centre", "shotgun_blindfire"))
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                }
                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_low_centre", "shotgun_blindfire"))
                {
                    if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_centre", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF > 0.275 && ShotgunBF < 0.54)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_centre", "shotgun_blindfire", 0.75);
                        }
                        if (ShotgunBF > 0.76)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                    if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip < 1 || !Game.isGameKeyPressed(GameKey.Attack) || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_low_centre", "shotgun_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_centre", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF > 0.275 && ShotgunBF < 0.54)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_centre", "shotgun_blindfire", 0.76);
                        }
                        if (ShotgunBF > 0.76 || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_low_centre", "shotgun_blindfire"))
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                }
                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
            }

            if ((Game.LocalPlayer.Character.Weapons.Current != Weapon.TLAD_AssaultShotgun || Main.FullAutoStreetSweeper == false)&&Game.LocalPlayer.Character.Weapons.Current == Game.LocalPlayer.Character.Weapons.AnyShotgun&& Game.LocalPlayer.Character.Weapons.Current != Weapon.Shotgun_Basic)
            {
                if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_high_corner", "shotgun_blindfire"))
                {
                    if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_high_corner", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF > 0.345 && ShotgunBF < 0.44)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_high_corner", "shotgun_blindfire", 0.2);
                        }
                        else if (ShotgunBF > 0.77)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                    else if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip < 1 || !Game.isGameKeyPressed(GameKey.Attack) || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_high_corner", "shotgun_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_high_corner", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF > 0.345 && ShotgunBF < 0.44)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_high_corner", "shotgun_blindfire", 0.77);
                        }
                        else if (ShotgunBF > 0.77 || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_high_corner", "shotgun_blindfire"))
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                }
                else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_high_corner", "shotgun_blindfire"))
                {
                    if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_high_corner", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF > 0.4 && ShotgunBF < 0.51)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_high_corner", "shotgun_blindfire", 0.25);
                        }
                        else if (ShotgunBF > 0.78)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                    else if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip < 1 || !Game.isGameKeyPressed(GameKey.Attack) || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_high_corner", "shotgun_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_high_corner", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF > 0.4 && ShotgunBF < 0.51)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_high_corner", "shotgun_blindfire", 0.78);
                        }
                        else if (ShotgunBF > 0.78 || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_high_corner", "shotgun_blindfire"))
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                }
                else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_low_corner", "shotgun_blindfire"))
                {
                    if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_corner", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF < 0.27)
                        {
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                        else if (ShotgunBF > 0.33 && ShotgunBF < 0.54)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_corner", "shotgun_blindfire", 0.71);
                        }
                        else if (ShotgunBF > 0.73 && ShotgunBF < 0.76 && Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack) && (Main.Boolet - Game.LocalPlayer.Character.Weapons.Current.AmmoInClip) == 1)
                        {
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_corner", "shotgun_blindfire", 0.23);
                        }
                        else if (ShotgunBF > 0.76)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                    else if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip < 1 || !Game.isGameKeyPressed(GameKey.Attack) || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_low_corner", "shotgun_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_corner", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF > 0.33 && ShotgunBF < 0.56)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_corner", "shotgun_blindfire", 0.76);
                        }
                        else if (ShotgunBF > 0.76 || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_low_corner", "shotgun_blindfire"))
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                }
                else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_low_corner", "shotgun_blindfire"))
                {
                    if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_corner", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF < 0.21)
                        {
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                        else if (ShotgunBF > 0.24 && ShotgunBF < 0.54)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_corner", "shotgun_blindfire", 0.76);
                        }
                        else if (ShotgunBF > 0.82 && ShotgunBF < 0.9 && Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack) && (Main.Boolet - Game.LocalPlayer.Character.Weapons.Current.AmmoInClip) == 1)
                        {
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_corner", "shotgun_blindfire", 0.17);
                        }
                        else if (ShotgunBF > 0.84)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                    else if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip < 1 || !Game.isGameKeyPressed(GameKey.Attack) || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_low_corner", "shotgun_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_corner", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF > 0.24 && ShotgunBF < 0.54)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_corner", "shotgun_blindfire", 0.76);
                        }
                        else if (ShotgunBF > 0.76 || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_low_corner", "shotgun_blindfire"))
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                }
                else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_low_centre", "shotgun_blindfire"))
                {
                    if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_centre", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF > 0.33 && ShotgunBF < 0.54)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_centre", "shotgun_blindfire", 0.21);
                        }
                        else if (ShotgunBF > 0.76)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                    else if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip < 1 || !Game.isGameKeyPressed(GameKey.Attack) || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_low_centre", "shotgun_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_centre", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF > 0.33 && ShotgunBF < 0.56)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_centre", "shotgun_blindfire", 0.76);
                        }
                        else if (ShotgunBF > 0.76 || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_low_centre", "shotgun_blindfire"))
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                }
                else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_low_centre", "shotgun_blindfire"))
                {
                    if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_centre", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF < 0.25)
                        {
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                        else if (ShotgunBF > 0.3 && ShotgunBF < 0.54)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_centre", "shotgun_blindfire", 0.69);
                        }
                        else if (ShotgunBF > 0.76 && ShotgunBF < 0.9 && Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack) && (Main.Boolet - Game.LocalPlayer.Character.Weapons.Current.AmmoInClip) == 1)
                        {
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_centre", "shotgun_blindfire", 0.23);
                        }
                        else if (ShotgunBF > 0.76)
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                    else if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip < 1 || !Game.isGameKeyPressed(GameKey.Attack) || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_low_centre", "shotgun_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_centre", "shotgun_blindfire", ShotgunBF);
                        if (ShotgunBF > 0.3 && ShotgunBF < 0.54)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_centre", "shotgun_blindfire", 0.76);
                        }
                        else if (ShotgunBF > 0.76 || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_low_centre", "shotgun_blindfire"))
                        {
                            GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                        }
                    }
                }
                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
            }
        }
    }
}
