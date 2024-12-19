using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using GTA;

namespace WeapFuncs.net
{
    public class Main : Script
    {
        public static bool GlobalRateOfFire;
        public static bool ReloadInVehicles;
        public static bool CrouchRelFix;
        public static bool SemiAutoShotgunBlindfire;
        public static bool NPCSemiAutoShotgunBlindfire;
        public static bool ConsistentPistolBlindfireLoop;
        public static bool FullAutoCZ75;
        public static bool FullAutoStreetSweeper;
        public static bool SawnOffYeet;
        public static GTA.Object gunmodel = null;
        public static int Boolet = 0;
        public static int CurrEp = 0;
        public Main()
        {
            LoadINI();
            RateOfFire.LoadINI();
            this.Tick += new EventHandler(this.ScriptCommunicationExample2_Tick);
        }
        private void ScriptCommunicationExample2_Tick(object sender, EventArgs e)
        {
            WeapFuncs.Tick();
            if (GlobalRateOfFire)
                RateOfFire.Tick();
            if (SemiAutoShotgunBlindfire)
                ShotgunBlindfireFix.Tick();
            if (NPCSemiAutoShotgunBlindfire)
                NPCSemiAutoShot.Tick();
        }
        private void LoadINI()
        {
            SettingsFile ini = SettingsFile.Open(Path.Combine("scripts", "WeapFuncs.ini"));
            ini.Load();
            GlobalRateOfFire = ini.GetValueBool("GlobalROF", "WEAPFUNCS", false);
            ReloadInVehicles = ini.GetValueBool("ReloadInVehicles", "WEAPFUNCS", false);
            CrouchRelFix = ini.GetValueBool("MP5ReloadCrouchFix", "WEAPFUNCS", false);
            SemiAutoShotgunBlindfire = ini.GetValueBool("SemiAutoShotgunBlindfire", "WEAPFUNCS", false);
            NPCSemiAutoShotgunBlindfire = ini.GetValueBool("NPCSemiAutoShotgunBlindfire", "WEAPFUNCS", false);
            ConsistentPistolBlindfireLoop = ini.GetValueBool("ConsistentPistolBlindfireLoop", "WEAPFUNCS", false);
            FullAutoCZ75 = ini.GetValueBool("FullAutoCZ75Blindfire", "WEAPFUNCS", false);
            FullAutoStreetSweeper = ini.GetValueBool("FullAutoStreetSweeperBlindfire", "WEAPFUNCS", false);
            SawnOffYeet = ini.GetValueBool("SawnOffFiresSecondShellImmediately", "WEAPFUNCS", false);
        }
    }
}
