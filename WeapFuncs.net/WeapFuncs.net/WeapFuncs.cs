using System;
using System.Windows.Forms;
using System.Collections.Generic;
using GTA;
using System.Runtime;
using System.IO;

namespace WeapFuncs.net
{
    internal class WeapFuncs
    {
        public static void Tick()
        {
            GTA.Native.Pointer AnimPointer = 0.0;
            if (Game.LocalPlayer.Character.Exists() && Game.LocalPlayer.Character != null && Game.LocalPlayer.Character.isAlive && !Game.LocalPlayer.Character.isRagdoll && !Game.LocalPlayer.Character.isGettingUp)
            {
                Main.CurrEp = GTA.Native.Function.Call<int>("GET_CURRENT_EPISODE");
                if (Main.ReloadInVehicles == true)
                {
                    GTA.Native.Function.Call("REQUEST_ANIMS", "gun@handgun");
                    if (Game.LocalPlayer.Character.Weapons.Current == Weapon.Handgun_Glock && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "gun@handgun", "reload") && Game.LocalPlayer.Character.isSittingInVehicle() && Game.LocalPlayer.Character.Weapons.Current.AmmoInClip == 0)
                    {
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "bl_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow_conv", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "bl_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "bl_aim_loop"))
                        {
                            Main.gunmodel = World.CreateObject("w_glock", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.14f, 0.0f, 0.0f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM", Game.LocalPlayer.Character, "reload", "gun@handgun", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                        }
                        else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyairtug", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyairtug", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_spee", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_spee", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "bl_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "br_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_big", "ds_aim_loop"))
                        {
                            Main.gunmodel = World.CreateObject("w_glock", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.14f, 0.0f, 0.0f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@handgun", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                        }
                        else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "bl_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "br_aim_loop_1h"))
                        {
                            Main.gunmodel = World.CreateObject("w_glock", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.14f, 0.0f, 0.0f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@handgun", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                        }
                    }
                    if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "gun@handgun", "reload") && Game.LocalPlayer.Character.isSittingInVehicle())
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "gun@handgun", "reload", AnimPointer);
                        if (AnimPointer > 0.9 && Main.gunmodel.Exists() && Main.gunmodel != null)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "gun@handgun", "reload", 1.0);
                            Main.gunmodel.Delete();
                        }
                    }

                    if (Game.LocalPlayer.Character.Weapons.Current == Weapon.Handgun_DesertEagle && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "gun@deagle", "reload") && Game.LocalPlayer.Character.isSittingInVehicle() && Game.LocalPlayer.Character.Weapons.Current.AmmoInClip == 0)
                    {
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "bl_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow_conv", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "bl_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "bl_aim_loop"))
                        {
                            Main.gunmodel = World.CreateObject("w_eagle", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.14f, 0.0f, 0.0f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@deagle", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                        }
                        else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyairtug", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyairtug", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_spee", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_spee", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "bl_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "br_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_big", "ds_aim_loop"))
                        {
                            Main.gunmodel = World.CreateObject("w_eagle", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.14f, 0.0f, 0.0f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@deagle", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                        }
                        else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "bl_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "br_aim_loop_1h"))
                        {
                            Main.gunmodel = World.CreateObject("w_eagle", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.14f, 0.0f, 0.0f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@deagle", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                        }
                    }
                    if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "gun@deagle", "reload") && Game.LocalPlayer.Character.isSittingInVehicle())
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "gun@deagle", "reload", AnimPointer);
                        if (AnimPointer > 0.9 && Main.gunmodel.Exists() && Main.gunmodel != null)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "gun@deagle", "reload", 1.0);
                            Main.gunmodel.Delete();
                        }
                    }

                    if (Game.LocalPlayer.Character.Weapons.Current == Weapon.SMG_Uzi && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "gun@uzi", "reload") && Game.LocalPlayer.Character.isSittingInVehicle() && (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip == 0))
                    {
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "bl_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow_conv", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "bl_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "bl_aim_loop"))
                        {
                            AnimationSet rloadveh = new AnimationSet("gun@uzi");
                            Main.gunmodel = World.CreateObject("w_uzi", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.14f, 0.0f, 0.0f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@uzi", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                            Game.LocalPlayer.Character.Animation.WaitUntilFinished(rloadveh, "reload");
                            Main.gunmodel.Delete();
                        }
                        else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyairtug", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyairtug", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_spee", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_spee", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "bl_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "br_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_big", "ds_aim_loop"))
                        {
                            AnimationSet rloadveh = new AnimationSet("gun@uzi");
                            Main.gunmodel = World.CreateObject("w_uzi", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.14f, 0.0f, 0.0f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@uzi", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                            Game.LocalPlayer.Character.Animation.WaitUntilFinished(rloadveh, "reload");
                            Main.gunmodel.Delete();
                        }
                        else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "bl_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "br_aim_loop_1h"))
                        {
                            AnimationSet rloadveh = new AnimationSet("gun@uzi");
                            Main.gunmodel = World.CreateObject("w_uzi", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.14f, 0.0f, 0.0f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@uzi", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                            Game.LocalPlayer.Character.Animation.WaitUntilFinished(rloadveh, "reload");
                            Main.gunmodel.Delete();
                        }
                    }

                    if (Game.LocalPlayer.Character.Weapons.Current == Weapon.SMG_MP5 && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "gun@mp5k", "reload") && Game.LocalPlayer.Character.isSittingInVehicle() && Game.LocalPlayer.Character.Weapons.Current.AmmoInClip == 0)
                    {
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "bl_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow_conv", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "bl_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "bl_aim_loop"))
                        {
                            AnimationSet rloadveh = new AnimationSet("gun@mp5k");
                            Main.gunmodel = World.CreateObject("w_mp5", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.0f, 0.0f, 0.0f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@mp5k", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                            Game.LocalPlayer.Character.Animation.WaitUntilFinished(rloadveh, "reload");
                            Main.gunmodel.Delete();
                        }
                        else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyairtug", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyairtug", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_spee", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_spee", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "bl_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "br_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_big", "ds_aim_loop"))
                        {
                            AnimationSet rloadveh = new AnimationSet("gun@mp5k");
                            Main.gunmodel = World.CreateObject("w_mp5", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.0f, 0.0f, 0.0f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@mp5k", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                            Game.LocalPlayer.Character.Animation.WaitUntilFinished(rloadveh, "reload");
                            Main.gunmodel.Delete();

                        }
                        else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "bl_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "br_aim_loop_1h"))
                        {
                            AnimationSet rloadveh = new AnimationSet("gun@mp5k");
                            Main.gunmodel = World.CreateObject("w_mp5", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.0f, 0.0f, 0.0f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@mp5k", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                            Game.LocalPlayer.Character.Animation.WaitUntilFinished(rloadveh, "reload");
                            Main.gunmodel.Delete();

                        }
                    }

                    if (Game.LocalPlayer.Character.Weapons.Current == Weapon.Rifle_AK47 && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "gun@ak47", "reload") && Game.LocalPlayer.Character.isSittingInVehicle() && Game.LocalPlayer.Character.Weapons.Current.AmmoInClip == 0)
                    {
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_spee", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "bl_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "bl_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "br_aim_loop"))
                        {
                            AnimationSet rloadveh = new AnimationSet("gun@ak47");
                            Main.gunmodel = World.CreateObject("w_ak47", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.3f, 0.0f, -0.02f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@ak47", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                            Game.LocalPlayer.Character.Animation.WaitUntilFinished(rloadveh, "reload");
                            Main.gunmodel.Delete();

                        }
                    }

                    if (Game.LocalPlayer.Character.Weapons.Current == Weapon.Rifle_M4 && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "gun@ak47", "reload") && Game.LocalPlayer.Character.isSittingInVehicle() && Game.LocalPlayer.Character.Weapons.Current.AmmoInClip == 0)
                    {
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_spee", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "bl_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "bl_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "br_aim_loop"))
                        {
                            AnimationSet rloadveh = new AnimationSet("gun@ak47");
                            Main.gunmodel = World.CreateObject("w_m4", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.23f, 0.0f, -0.02f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@ak47", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                            Game.LocalPlayer.Character.Animation.WaitUntilFinished(rloadveh, "reload");
                            Main.gunmodel.Delete();

                        }
                    }

                    if (Game.LocalPlayer.Character.Weapons.Current == Weapon.TLAD_Automatic9mm && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "gun@cz75", "reload") && Game.LocalPlayer.Character.isSittingInVehicle() && Game.LocalPlayer.Character.Weapons.Current.AmmoInClip == 0)
                    {
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "bl_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow_conv", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "bl_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "bl_aim_loop"))
                        {
                            Main.gunmodel = World.CreateObject("w_e1_cz75", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.04f, -0.02f, -0.01f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@cz75", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                        }
                        else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyairtug", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyairtug", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_spee", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_spee", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "bl_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "br_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_big", "ds_aim_loop"))
                        {
                            Main.gunmodel = World.CreateObject("w_e1_cz75", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.04f, -0.02f, -0.01f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@cz75", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                        }
                        else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "bl_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "br_aim_loop_1h"))
                        {
                            Main.gunmodel = World.CreateObject("w_e1_cz75", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.04f, -0.02f, -0.01f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@cz75", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                        }
                    }
                    if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "gun@cz75", "reload") && Game.LocalPlayer.Character.isSittingInVehicle())
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "gun@cz75", "reload", AnimPointer);
                        if (AnimPointer > 0.9 && Main.gunmodel.Exists() && Main.gunmodel != null)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "gun@cz75", "reload", 1.0);
                            Main.gunmodel.Delete();
                        }
                    }

                    if (Game.LocalPlayer.Character.Weapons.Current == Weapon.TBOGT_Pistol44 && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "gun@44a", "reload") && Game.LocalPlayer.Character.isSittingInVehicle() && Game.LocalPlayer.Character.Weapons.Current.AmmoInClip == 0)
                    {
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "bl_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow_conv", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "bl_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "bl_aim_loop"))
                        {
                            Main.gunmodel = World.CreateObject("w_e2_44amag", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.0f, -0.02f, -0.02f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@44a", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                        }
                        else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyairtug", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyairtug", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_spee", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_spee", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "bl_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "br_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_big", "ds_aim_loop"))
                        {
                            Main.gunmodel = World.CreateObject("w_e2_44amag", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.0f, -0.02f, -0.02f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@44a", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                        }
                        else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "bl_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "br_aim_loop_1h"))
                        {
                            Main.gunmodel = World.CreateObject("w_e2_44amag", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.0f, -0.02f, -0.02f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@44a", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                        }
                    }
                    if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "gun@44a", "reload") && Game.LocalPlayer.Character.isSittingInVehicle())
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "gun@44a", "reload", AnimPointer);
                        if (AnimPointer > 0.9 && Main.gunmodel.Exists() && Main.gunmodel != null)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "gun@44a", "reload", 1.0);
                            Main.gunmodel.Delete();
                        }
                    }

                    if (Game.LocalPlayer.Character.Weapons.Current == Weapon.TBOGT_AssaultSMG && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "gun@p90", "reload") && Game.LocalPlayer.Character.isSittingInVehicle() && Game.LocalPlayer.Character.Weapons.Current.AmmoInClip == 0)
                    {
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "bl_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow_conv", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "bl_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "bl_aim_loop"))
                        {
                            AnimationSet rloadveh = new AnimationSet("gun@p90");
                            Main.gunmodel = World.CreateObject("w_e2_p90", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.0f, 0.0f, 0.02f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@p90", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                            Game.LocalPlayer.Character.Animation.WaitUntilFinished(rloadveh, "reload");
                            Main.gunmodel.Delete();
                        }
                        else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyairtug", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyairtug", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_spee", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_spee", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "bl_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "br_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_big", "ds_aim_loop"))
                        {
                            AnimationSet rloadveh = new AnimationSet("gun@p90");
                            Main.gunmodel = World.CreateObject("w_e2_p90", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.0f, 0.0f, 0.02f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@p90", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                            Game.LocalPlayer.Character.Animation.WaitUntilFinished(rloadveh, "reload");
                            Main.gunmodel.Delete();
                        }
                        else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "bl_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "br_aim_loop_1h"))
                        {
                            AnimationSet rloadveh = new AnimationSet("gun@p90");
                            Main.gunmodel = World.CreateObject("w_e2_p90", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.0f, 0.0f, 0.02f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@p90", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                            Game.LocalPlayer.Character.Animation.WaitUntilFinished(rloadveh, "reload");
                            Main.gunmodel.Delete();
                        }
                    }

                    if (Game.LocalPlayer.Character.Weapons.Current == Weapon.TBOGT_GoldenSMG && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "gun@gold_uzi", "reload") && Game.LocalPlayer.Character.isSittingInVehicle() && Game.LocalPlayer.Character.Weapons.Current.AmmoInClip == 0)
                    {
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "bl_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebylow_conv", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "bl_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "bl_aim_loop"))
                        {
                            AnimationSet rloadveh = new AnimationSet("gun@gold_uzi");
                            Main.gunmodel = World.CreateObject("w_e2_uzi", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.13f, 0.0f, 0.02f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@gold_uzi", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                            Game.LocalPlayer.Character.Animation.WaitUntilFinished(rloadveh, "reload");
                            Main.gunmodel.Delete();
                        }
                        else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebytruck", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyairtug", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyairtug", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebystd", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyvan", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_spee", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_spee", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "ds_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "bl_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "br_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_big", "ds_aim_loop"))
                        {
                            AnimationSet rloadveh = new AnimationSet("gun@gold_uzi");
                            Main.gunmodel = World.CreateObject("w_e2_uzi", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.13f, 0.0f, 0.02f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@gold_uzi", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                            Game.LocalPlayer.Character.Animation.WaitUntilFinished(rloadveh, "reload");
                            Main.gunmodel.Delete();
                        }
                        else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "ps_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "bl_aim_loop_1h") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "br_aim_loop_1h"))
                        {
                            AnimationSet rloadveh = new AnimationSet("gun@gold_uzi");
                            Main.gunmodel = World.CreateObject("w_e2_uzi", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.13f, 0.0f, 0.02f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@gold_uzi", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                            Game.LocalPlayer.Character.Animation.WaitUntilFinished(rloadveh, "reload");
                            Main.gunmodel.Delete();
                        }
                    }

                    if (Game.LocalPlayer.Character.Weapons.Current == Weapon.TBOGT_AdvancedMG && !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "gun@m249", "reload") && Game.LocalPlayer.Character.isSittingInVehicle() && Game.LocalPlayer.Character.Weapons.Current.AmmoInClip == 0)
                    {
                        if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_spee", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "bl_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyboat_stnd", "br_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "ps_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "bl_aim_loop") || GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "veh@drivebyheli", "br_aim_loop"))
                        {
                            AnimationSet rloadveh = new AnimationSet("gun@m249");
                            Main.gunmodel = World.CreateObject("w_e2_m249", Game.LocalPlayer.Character.Position);
                            Main.gunmodel.Collision = false;
                            Main.gunmodel.AttachToPed(Game.LocalPlayer.Character, Bone.RightHand, new Vector3(0.08f, 0.0f, 0.03f), Vector3.Zero);
                            GTA.Native.Function.Call("TASK_PLAY_ANIM_UPPER_BODY", Game.LocalPlayer.Character, "reload", "gun@m249", 0.80, 0, 1, 0, 0, -1);
                            Game.WaitInCurrentScript(10);
                            Game.LocalPlayer.Character.Animation.WaitUntilFinished(rloadveh, "reload");
                            Main.gunmodel.Delete();

                        }
                    }
                }

                if (Main.CrouchRelFix == true && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "gun@mp5k", "reload_crouch"))
                {
                    GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "gun@mp5k", "reload_crouch", AnimPointer);
                    if (AnimPointer > 0.6 && AnimPointer < 0.85)
                    {
                        GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "gun@mp5k", "reload_crouch", 0.9);
                    }
                }
                if (Game.LocalPlayer.Character.Weapons.Current == Weapon.Shotgun_Basic)
                {
                    if ((Game.LocalPlayer.Character.Weapons.Current.AmmoInClip < 1 || !Game.isGameKeyPressed(GameKey.Attack)) && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_high_corner", "shotgun_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_high_corner", "shotgun_blindfire", AnimPointer);
                        if (AnimPointer > 0.67 && AnimPointer < 0.83)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_high_corner", "shotgun_blindfire", 0.83);
                        }
                    }
                    else if ((Game.LocalPlayer.Character.Weapons.Current.AmmoInClip < 1 || !Game.isGameKeyPressed(GameKey.Attack)) && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_high_corner", "shotgun_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_high_corner", "shotgun_blindfire", AnimPointer);
                        if (AnimPointer > 0.72 && AnimPointer < 0.82)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_high_corner", "shotgun_blindfire", 0.82);
                        }
                    }
                    else if ((Game.LocalPlayer.Character.Weapons.Current.AmmoInClip < 1 || !Game.isGameKeyPressed(GameKey.Attack)) && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_low_centre", "shotgun_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_centre", "shotgun_blindfire", AnimPointer);
                        if (AnimPointer > 0.68 && AnimPointer < 0.79)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_centre", "shotgun_blindfire", 0.79);
                        }
                    }
                    else if ((Game.LocalPlayer.Character.Weapons.Current.AmmoInClip < 1 || !Game.isGameKeyPressed(GameKey.Attack)) && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_low_centre", "shotgun_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_centre", "shotgun_blindfire", AnimPointer);
                        if (AnimPointer > 0.7 && AnimPointer < 0.79)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_centre", "shotgun_blindfire", 0.79);
                        }
                    }
                }

                else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.TLAD_SawedOffShotgun && Main.SawnOffYeet == true)
                {
                    if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "gun@sawnoff", "fire"))
                    {
                        if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack) && !Game.isGameKeyPressed(GameKey.Aim))
                        {
                            GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "gun@sawnoff", "fire", AnimPointer);
                            if (AnimPointer > 0.72 && AnimPointer < 0.88)
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "gun@sawnoff", "fire", 0.7);
                            }
                        }
                    }
                    else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "gun@sawnoff", "fire_crouch"))
                    {
                        if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack) && !Game.isGameKeyPressed(GameKey.Aim))
                        {
                            GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "gun@sawnoff", "fire_crouch", AnimPointer);
                            if (AnimPointer > 0.675 && AnimPointer < 0.88)
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "gun@sawnoff", "fire_crouch", 0.655);
                            }
                        }
                    }
                }

                else if (Game.LocalPlayer.Character.Weapons.Current == Weapon.TLAD_Automatic9mm && Main.FullAutoCZ75 == true)
                {
                    if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_high_corner", "pistol_blindfire"))
                    {
                        if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack))
                        {
                            GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_high_corner", "pistol_blindfire", AnimPointer);
                            if (AnimPointer > 0.15 && AnimPointer < 0.44)
                            {
                                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_high_corner", "pistol_blindfire", 0.74);
                            }
                            if (AnimPointer > 0.8)
                            {
                                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                            }
                        }
                        if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip < 1 || !Game.isGameKeyPressed(GameKey.Attack) || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_high_corner", "pistol_blindfire"))
                        {
                            GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_high_corner", "pistol_blindfire", AnimPointer);
                            if (AnimPointer > 0.15 && AnimPointer < 0.44)
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_high_corner", "pistol_blindfire", 0.8);
                            }
                            if (AnimPointer > 0.8 || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_high_corner", "pistol_blindfire"))
                            {
                                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                            }
                        }
                    }
                    else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_high_corner", "pistol_blindfire"))
                    {
                        if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack))
                        {
                            GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_high_corner", "pistol_blindfire", AnimPointer);
                            if (AnimPointer > 0.15 && AnimPointer < 0.44)
                            {
                                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_high_corner", "pistol_blindfire", 0.76);
                            }
                            if (AnimPointer > 0.8)
                            {
                                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                            }
                        }
                        if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip < 1 || !Game.isGameKeyPressed(GameKey.Attack) || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_high_corner", "pistol_blindfire"))
                        {
                            GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_high_corner", "pistol_blindfire", AnimPointer);
                            if (AnimPointer > 0.15 && AnimPointer < 0.44)
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_high_corner", "pistol_blindfire", 0.8);
                            }
                            if (AnimPointer > 0.8 || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_high_corner", "pistol_blindfire"))
                            {
                                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                            }
                        }
                    }
                    else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_low_corner", "pistol_blindfire"))
                    {
                        if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack))
                        {
                            GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_corner", "pistol_blindfire", AnimPointer);
                            if (AnimPointer > 0.15 && AnimPointer < 0.44)
                            {
                                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_corner", "pistol_blindfire", 0.7);
                            }
                            if (AnimPointer > 0.8)
                            {
                                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                            }
                        }
                        if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip < 1 || !Game.isGameKeyPressed(GameKey.Attack) || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_low_corner", "pistol_blindfire"))
                        {
                            GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_corner", "pistol_blindfire", AnimPointer);
                            if (AnimPointer > 0.15 && AnimPointer < 0.44)
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_corner", "pistol_blindfire", 0.8);
                            }
                            if (AnimPointer > 0.8 || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_low_corner", "pistol_blindfire"))
                            {
                                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                            }
                        }
                    }
                    else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_low_corner", "pistol_blindfire"))
                    {
                        if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack))
                        {
                            GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_corner", "pistol_blindfire", AnimPointer);
                            if (AnimPointer > 0.15 && AnimPointer < 0.44)
                            {
                                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_corner", "pistol_blindfire", 0.725);
                            }
                            if (AnimPointer > 0.8)
                            {
                                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                            }
                        }
                        if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip < 1 || !Game.isGameKeyPressed(GameKey.Attack) || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_low_corner", "pistol_blindfire"))
                        {
                            GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_corner", "pistol_blindfire", AnimPointer);
                            if (AnimPointer > 0.15 && AnimPointer < 0.44)
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_corner", "pistol_blindfire", 0.8);
                            }
                            if (AnimPointer > 0.8 || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_low_corner", "pistol_blindfire"))
                            {
                                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                            }
                        }
                    }
                    else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_low_centre", "pistol_blindfire"))
                    {
                        if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack))
                        {
                            GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_centre", "pistol_blindfire", AnimPointer);
                            if (AnimPointer > 0.18 && AnimPointer < 0.44)
                            {
                                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_centre", "pistol_blindfire", 0.12);
                            }
                            if (AnimPointer > 0.8)
                            {
                                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                            }
                        }
                        if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip < 1 || !Game.isGameKeyPressed(GameKey.Attack) || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_low_centre", "pistol_blindfire"))
                        {
                            GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_centre", "pistol_blindfire", AnimPointer);
                            if (AnimPointer > 0.18 && AnimPointer < 0.44)
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_centre", "pistol_blindfire", 0.8);
                            }
                            if (AnimPointer > 0.8 || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_low_centre", "pistol_blindfire"))
                            {
                                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                            }
                        }
                    }
                    else if (GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_low_centre", "pistol_blindfire"))
                    {
                        if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack))
                        {
                            GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_centre", "pistol_blindfire", AnimPointer);
                            if (AnimPointer > 0.15 && AnimPointer < 0.44)
                            {
                                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, true);
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_centre", "pistol_blindfire", 0.74);
                            }
                            if (AnimPointer > 0.8)
                            {
                                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                            }
                        }
                        if (Game.LocalPlayer.Character.Weapons.Current.AmmoInClip < 1 || !Game.isGameKeyPressed(GameKey.Attack) || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_low_centre", "pistol_blindfire"))
                        {
                            GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_centre", "pistol_blindfire", AnimPointer);
                            if (AnimPointer > 0.15 && AnimPointer < 0.44)
                            {
                                GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_centre", "pistol_blindfire", 0.8);
                            }
                            if (AnimPointer > 0.8 || !GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_low_centre", "pistol_blindfire"))
                            {
                                GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                            }
                        }
                    }
                    GTA.Native.Function.Call("FREEZE_CHAR_POSITION", Game.LocalPlayer.Character, false);
                }

                if (Main.CurrEp == 2 && Main.ConsistentPistolBlindfireLoop == true && (Main.FullAutoCZ75 == false || Game.LocalPlayer.Character.Weapons.Current != Weapon.TLAD_Automatic9mm))
                {
                    if ((Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack)) && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_high_corner", "pistol_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_high_corner", "pistol_blindfire", AnimPointer);
                        if (AnimPointer > 0.08 && AnimPointer < 0.12)
                        {
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                        if (AnimPointer > 0.24 && AnimPointer < 0.28 && (Main.Boolet - Game.LocalPlayer.Character.Weapons.Current.AmmoInClip) == 1)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_high_corner", "pistol_blindfire", 0.66);
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                    }
                    else if ((Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack)) && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_high_corner", "pistol_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_high_corner", "pistol_blindfire", AnimPointer);
                        if (AnimPointer > 0.11 && AnimPointer < 0.16)
                        {
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                        if (AnimPointer > 0.31 && AnimPointer < 0.36 && (Main.Boolet - Game.LocalPlayer.Character.Weapons.Current.AmmoInClip) == 1)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_high_corner", "pistol_blindfire", 0.67);
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                    }
                    else if ((Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack)) && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_low_centre", "pistol_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_centre", "pistol_blindfire", AnimPointer);
                        if (AnimPointer > 0.19 && AnimPointer < 0.22)
                        {
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                        if (AnimPointer > 0.31 && AnimPointer < 0.34)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_centre", "pistol_blindfire", 0.69);
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                    }
                    else if ((Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack)) && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_low_corner", "pistol_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_corner", "pistol_blindfire", AnimPointer);
                        if (AnimPointer > 0.17 && AnimPointer < 0.2)
                        {
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                        if (AnimPointer > 0.39 && AnimPointer < 0.43 && (Main.Boolet - Game.LocalPlayer.Character.Weapons.Current.AmmoInClip) == 1)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_corner", "pistol_blindfire", 0.72);
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                    }
                    else if ((Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack)) && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_low_corner", "pistol_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_corner", "pistol_blindfire", AnimPointer);
                        if (AnimPointer > 0.12 && AnimPointer < 0.16)
                        {
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                        if (AnimPointer > 0.32 && AnimPointer < 0.35 && (Main.Boolet - Game.LocalPlayer.Character.Weapons.Current.AmmoInClip) == 1)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_corner", "pistol_blindfire", 0.68);
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                    }
                }
                else if (Main.CurrEp < 2 && Main.ConsistentPistolBlindfireLoop == true && (Main.FullAutoCZ75 == false || Game.LocalPlayer.Character.Weapons.Current != Weapon.TLAD_Automatic9mm))
                {
                    if ((Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack)) && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_high_corner", "pistol_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_high_corner", "pistol_blindfire", AnimPointer);
                        if (AnimPointer > 0.06 && AnimPointer < 0.11)
                        {
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                        if (AnimPointer > 0.23 && AnimPointer < 0.26 && (Main.Boolet - Game.LocalPlayer.Character.Weapons.Current.AmmoInClip) == 1)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_high_corner", "pistol_blindfire", 0.68);
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                    }
                    else if ((Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack)) && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_high_corner", "pistol_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_high_corner", "pistol_blindfire", AnimPointer);
                        if (AnimPointer > 0.11 && AnimPointer < 0.15)
                        {
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                        if (AnimPointer > 0.26 && AnimPointer < 0.3 && (Main.Boolet - Game.LocalPlayer.Character.Weapons.Current.AmmoInClip) == 1)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_high_corner", "pistol_blindfire", 0.72);
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                    }
                    else if ((Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack)) && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_low_centre", "pistol_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_centre", "pistol_blindfire", AnimPointer);
                        if (AnimPointer > 0.08 && AnimPointer < 0.12)
                        {
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                        if (AnimPointer > 0.18 && AnimPointer < 0.22)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_centre", "pistol_blindfire", 0.42);
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                        if (AnimPointer > 0.54 && AnimPointer < 0.58)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_centre", "pistol_blindfire", 0.32);
                        }
                    }
                    else if ((Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack)) && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_low_centre", "pistol_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_centre", "pistol_blindfire", AnimPointer);
                        if (AnimPointer > 0.06 && AnimPointer < 0.1)
                        {
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                        if (AnimPointer > 0.18 && AnimPointer < 0.22)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_centre", "pistol_blindfire", 0.64);
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                    }
                    else if ((Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack)) && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_l_low_corner", "pistol_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_corner", "pistol_blindfire", AnimPointer);
                        if (AnimPointer > 0.04 && AnimPointer < 0.09)
                        {
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                        if (AnimPointer > 0.2 && AnimPointer < 0.24 && (Main.Boolet - Game.LocalPlayer.Character.Weapons.Current.AmmoInClip) == 1)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_l_low_corner", "pistol_blindfire", 0.6);
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                    }
                    else if ((Game.LocalPlayer.Character.Weapons.Current.AmmoInClip > 0 && Game.isGameKeyPressed(GameKey.Attack)) && GTA.Native.Function.Call<bool>("IS_CHAR_PLAYING_ANIM", Game.LocalPlayer.Character, "cover_r_low_corner", "pistol_blindfire"))
                    {
                        GTA.Native.Function.Call("GET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_corner", "pistol_blindfire", AnimPointer);
                        if (AnimPointer > 0.06 && AnimPointer < 0.1)
                        {
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                        if (AnimPointer > 0.19 && AnimPointer < 0.23 && (Main.Boolet - Game.LocalPlayer.Character.Weapons.Current.AmmoInClip) == 1)
                        {
                            GTA.Native.Function.Call("SET_CHAR_ANIM_CURRENT_TIME", Game.LocalPlayer.Character, "cover_r_low_corner", "pistol_blindfire", 0.62);
                            Main.Boolet = Game.LocalPlayer.Character.Weapons.Current.AmmoInClip;
                        }
                    }
                }
            }
        }
    }
}
