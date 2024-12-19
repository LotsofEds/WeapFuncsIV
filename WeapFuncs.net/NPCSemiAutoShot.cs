using GTA;
using System;
using System.Collections.Generic;
using System.IO;

namespace WeapFuncs.net
{
    internal class NPCSemiAutoShot
    {
        private static bool CheckDateTime;
        private static DateTime currentDateTime;
        private static int pedIndex = 0;
        private static int Boolet = 0;
        private static List<Ped> pedList = new List<Ped>();
        private static List<int> ammoList = new List<int>();
        public static void Tick()
        {
            if (CheckDateTime == false)
            {
                currentDateTime = DateTime.Now;
                CheckDateTime = true;
            }
            if (DateTime.Now.Subtract(currentDateTime).TotalMilliseconds > 100.0)
            {
                CheckDateTime = false;

                foreach (Ped ped in World.GetAllPeds())
                {
                    if (!Game.Exists(ped)) continue;
                    if (ped == Game.LocalPlayer.Character) continue;
                    if (pedList.Contains(ped)) continue;
                    if (ped.Weapons.Current != ped.Weapons.AnyShotgun) continue;
                    if (ped.Weapons.Current == Weapon.Shotgun_Basic) continue;

                    pedList.Add(ped);
                    ammoList.Add(ped.Weapons.Current.AmmoInClip);
                }

                if (pedList.Count > 0)
                {
                    for (int i = pedList.Count - 1; i >= 0; i--)
                    {
                        if (!Game.Exists(pedList[i]) || pedList[i].isDead)
                        {
                            pedList.Remove(pedList[i]);
                            ammoList.Remove(ammoList[i]);
                        }
                    }
                }

                foreach (Ped ped in pedList)
                {
                    if (ped.Weapons.Current == ped.Weapons.AnyShotgun && ped.Weapons.Current != Weapon.Shotgun_Basic)
                    {
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", ped, "cover_l_high_corner", "shotgun_blindfire"))
                        {
                            if ((ammoList[pedList.IndexOf(ped)] - ped.Weapons.Current.AmmoInClip) == 1)
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", ped, "cover_l_high_corner", "shotgun_blindfire", 0.67);
                                ammoList[pedList.IndexOf(ped)] = ped.Weapons.Current.AmmoInClip;
                            }
                        }
                        else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", ped, "cover_r_high_corner", "shotgun_blindfire"))
                        {
                            if ((ammoList[pedList.IndexOf(ped)] - ped.Weapons.Current.AmmoInClip) == 1)
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", ped, "cover_r_high_corner", "shotgun_blindfire", 0.72);
                                ammoList[pedList.IndexOf(ped)] = ped.Weapons.Current.AmmoInClip;
                            }
                        }
                        else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", ped, "cover_l_low_centre", "shotgun_blindfire"))
                        {
                            if ((ammoList[pedList.IndexOf(ped)] - ped.Weapons.Current.AmmoInClip) == 1)
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", ped, "cover_l_low_centre", "shotgun_blindfire", 0.69);
                                ammoList[pedList.IndexOf(ped)] = ped.Weapons.Current.AmmoInClip;
                            }
                        }
                        else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", ped, "cover_r_low_centre", "shotgun_blindfire"))
                        {
                            if ((ammoList[pedList.IndexOf(ped)] - ped.Weapons.Current.AmmoInClip) == 1)
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", ped, "cover_r_low_centre", "shotgun_blindfire", 0.7);
                                ammoList[pedList.IndexOf(ped)] = ped.Weapons.Current.AmmoInClip;
                            }
                        }
                        else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", ped, "cover_l_low_corner", "shotgun_blindfire"))
                        {
                            if ((ammoList[pedList.IndexOf(ped)] - ped.Weapons.Current.AmmoInClip) == 1)
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", ped, "cover_l_low_corner", "shotgun_blindfire", 0.68);
                                ammoList[pedList.IndexOf(ped)] = ped.Weapons.Current.AmmoInClip;
                            }
                        }
                        else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", ped, "cover_r_low_corner", "shotgun_blindfire"))
                        {
                            if ((ammoList[pedList.IndexOf(ped)] - ped.Weapons.Current.AmmoInClip) == 1)
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", ped, "cover_r_low_corner", "shotgun_blindfire", 0.69);
                                ammoList[pedList.IndexOf(ped)] = ped.Weapons.Current.AmmoInClip;
                            }
                        }
                        else
                        {
                            ammoList[pedList.IndexOf(ped)] = ped.Weapons.Current.AmmoInClip;
                        }
                    }
                }
            }
        }
    }
}