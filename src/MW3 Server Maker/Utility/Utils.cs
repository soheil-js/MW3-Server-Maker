using System.Drawing;

namespace MW3_Server_Maker
{
    internal static class Utils
    {
        #region MAP

        public static MapType Map(string map)
        {
            map = map.ToLower();

            //Standard Maps
            if (map == "seatown")
                return MapType.Seatown;
            else if (map == "dome")
                return MapType.Dome;
            else if (map == "arkaden")
                return MapType.Arkaden;
            else if (map == "bakaara")
                return MapType.Bakaara;
            else if (map == "resistance")
                return MapType.Resistance;
            else if (map == "downturn")
                return MapType.Downturn;
            else if (map == "bootleg")
                return MapType.Bootleg;
            else if (map == "carbon")
                return MapType.Carbon;
            else if (map == "hardhat")
                return MapType.Hardhat;
            else if (map == "lockdown")
                return MapType.Lockdown;
            else if (map == "village")
                return MapType.Village;
            else if (map == "fallen")
                return MapType.Fallen;
            else if (map == "outpost")
                return MapType.Outpost;
            else if (map == "interchange")
                return MapType.Interchange;
            else if (map == "underground")
                return MapType.Underground;
            else if (map == "mission")
                return MapType.Mission;

            //[DLC 1] Collection 1
            else if (map == "piazza")
                return MapType.Piazza;
            else if (map == "liberation")
                return MapType.Liberation;
            else if (map == "overwatch")
                return MapType.Overwatch;
            else if (map == "black box")
                return MapType.BlackBox;

            //[DLC 2] Collection 2
            else if (map == "sanctuary")
                return MapType.Sanctuary;
            else if (map == "foundation")
                return MapType.Foundation;
            else if (map == "oasis")
                return MapType.Oasis;
            else if (map == "erosion")
                return MapType.Erosion;
            else if (map == "aground")
                return MapType.Aground;

            //[DLC 3] Collection 3: Chaos Pack
            else if (map == "u-turn")
                return MapType.UTurn;
            else if (map == "vortex")
                return MapType.Vortex;
            else if (map == "intersection")
                return MapType.Intersection;

            //[DLC 4] Collection 4: Final Assault
            else if (map == "boardwalk")
                return MapType.Boardwalk;
            else if (map == "decommission")
                return MapType.Decommission;
            else if (map == "gulch")
                return MapType.Gulch;
            else if (map == "off shore")
                return MapType.OffShore;
            else if (map == "parish")
                return MapType.Parish;

            //Face Off
            else if (map == "lookout")
                return MapType.Lookout;
            else if (map == "getaway")
                return MapType.Getaway;

            //Free
            else //if (map == "terminal")
                return MapType.Terminal;
        }

        public static string Map(MapType map)
        {
            //Standard Maps
            if (map == MapType.Seatown)
                return "mp_seatown";
            else if (map == MapType.Dome)
                return "mp_dome";
            else if (map == MapType.Arkaden)
                return "mp_plaza2";
            else if (map == MapType.Bakaara)
                return "mp_mogadishu";
            else if (map == MapType.Resistance)
                return "mp_paris";
            else if (map == MapType.Downturn)
                return "mp_exchange";
            else if (map == MapType.Bootleg)
                return "mp_bootleg";
            else if (map == MapType.Carbon)
                return "mp_carbon";
            else if (map == MapType.Hardhat)
                return "mp_hardhat";
            else if (map == MapType.Lockdown)
                return "mp_alpha";
            else if (map == MapType.Village)
                return "mp_vilage";
            else if (map == MapType.Fallen)
                return "mp_lambeth";
            else if (map == MapType.Outpost)
                return "mp_radar";
            else if (map == MapType.Interchange)
                return "mp_interchange";
            else if (map == MapType.Underground)
                return "mp_underground";
            else if (map == MapType.Mission)
                return "mp_bravo";

            //[DLC 1] Collection 1
            else if (map == MapType.Piazza)
                return "mp_italy";
            else if (map == MapType.Liberation)
                return "mp_park";
            else if (map == MapType.Overwatch)
                return "mp_overwatch";
            else if (map == MapType.BlackBox)
                return "mp_morningwood";

            //[DLC 2] Collection 2
            else if (map == MapType.Sanctuary)
                return "mp_meteora";
            else if (map == MapType.Foundation)
                return "mp_cement";
            else if (map == MapType.Oasis)
                return "mp_qadeem";
            else if (map == MapType.Erosion)
                return "mp_courtyard_ss";
            else if (map == MapType.Aground)
                return "mp_aground_ss";

            //[DLC 3] Collection 3: Chaos Pack
            else if (map == MapType.UTurn)
                return "mp_burn_ss";
            else if (map == MapType.Vortex)
                return "mp_six_ss";
            else if (map == MapType.Intersection)
                return "mp_crosswalk_ss";

            //[DLC 4] Collection 4: Final Assault
            else if (map == MapType.Boardwalk)
                return "mp_boardwalk";
            else if (map == MapType.Decommission)
                return "mp_shipbreaker";
            else if (map == MapType.Gulch)
                return "mp_moab";
            else if (map == MapType.OffShore)
                return "mp_roughneck";
            else if (map == MapType.Parish)
                return "mp_nola";

            //Face Off
            else if (map == MapType.Lookout)
                return "mp_restrepo_ss";
            else if (map == MapType.Getaway)
                return "mp_hillside_ss";


            //Free
            else //if (map == MapType.Terminal)
                return "mp_terminal_cls";
            
        }

        public static string FindMap(string map)
        {
            map = map.ToLower();

            //Standard Maps
            if (map == "mp_seatown")
                return "Seatown";
            else if (map == "mp_dome")
                return "Dome";
            else if (map == "mp_plaza2")
                return "Arkaden";
            else if (map == "mp_mogadishu")
                return "Bakaara";
            else if (map == "mp_paris")
                return "Resistance";
            else if (map == "mp_exchange")
                return "Downturn";
            else if (map == "mp_bootleg")
                return "Bootleg";
            else if (map == "mp_carbon")
                return "Carbon";
            else if (map == "mp_hardhat")
                return "Hardhat";
            else if (map == "mp_alpha")
                return "Lockdown";
            else if (map == "mp_vilage")
                return "Village";
            else if (map == "mp_lambeth")
                return "Fallen";
            else if (map == "mp_radar")
                return "Outpost";
            else if (map == "mp_interchange")
                return "Interchange";
            else if (map == "mp_underground")
                return "Underground";
            else if (map == "mp_bravo")
                return "Mission";

            //[DLC 1] Collection 1
            else if (map == "mp_italy")
                return "Piazza";
            else if (map == "mp_park")
                return "Liberation";
            else if (map == "mp_overwatch")
                return "Overwatch";
            else if (map == "mp_morningwood")
                return "Black Box";

            //[DLC 2] Collection 2
            else if (map == "mp_meteora")
                return "Sanctuary";
            else if (map == "mp_cement")
                return "Foundation";
            else if (map == "mp_qadeem")
                return "Oasis";
            else if (map == "mp_courtyard_ss")
                return "Erosion";
            else if (map == "mp_aground_ss")
                return "Aground";

            //[DLC 3] Collection 3: Chaos Pack
            else if (map == "mp_burn_ss")
                return "U-Turn";
            else if (map == "mp_six_ss")
                return "Vortex";
            else if (map == "mp_crosswalk_ss")
                return "Intersection";

            //[DLC 4] Collection 4: Final Assault
            else if (map == "mp_boardwalk")
                return "Boardwalk";
            else if (map == "mp_shipbreaker")
                return "Decommission";
            else if (map == "mp_moab")
                return "Gulch";
            else if (map == "mp_roughneck")
                return "Off Shore";
            else if (map == "mp_nola")
                return "Parish";

            //Face Off
            else if (map == "mp_restrepo_ss")
                return "Lookout";
            else if (map == "mp_hillside_ss")
                return "Getaway";

            //Free
            else //if (map == "mp_terminal_cls")
                return "Terminal";
        }

        #endregion

        #region MOD

        public static ModType Mod(string mod)
        {
            mod = mod.ToLower();

            //Standard
            if (mod == "free for all")
                return ModType.FreeForAll;
            else if (mod == "team deathmatch")
                return ModType.TeamDeathmatch;
            else if (mod == "search and destroy")
                return ModType.SearchAndDestroy;
            else if (mod == "sabotage")
                return ModType.Sabotage;
            else if (mod == "domination")
                return ModType.Domination;
            else if (mod == "headquarters")
                return ModType.Headquarters;
            else if (mod == "capture the flag")
                return ModType.CaptureTheFlag;
            else if (mod == "demolition")
                return ModType.Demolition;
            else if (mod == "kill confirmed")
                return ModType.KillConfirmed;
            else if (mod == "team defender")
                return ModType.TeamDefender;

            //Alternative
            else if (mod == "drop zone")
                return ModType.DropZone;
            else if (mod == "team juggernaut")
                return ModType.TeamJuggernaut;
            else if (mod == "juggernaut")
                return ModType.Juggernaut;
            else if (mod == "gun game")
                return ModType.GunGame;
            else if (mod == "infected")
                return ModType.Infected;
            else //if (mod == "one in the chamber")
                return ModType.OneInTheChamber;
        }

        public static string Mod(ModType mod, bool hardCore)
        {
            var type = (hardCore ? "HC" : "SC");

            //Standard
            if (mod == ModType.FreeForAll)
                return "FFA-" + type;
            else if (mod == ModType.TeamDeathmatch)
                return "TDM-" + type;
            else if (mod == ModType.SearchAndDestroy)
                return "SD-" + type;
            else if (mod == ModType.Sabotage)
                return "SAB-" + type;
            else if (mod == ModType.Domination)
                return "DOM-" + type;
            else if (mod == ModType.Headquarters)
                return "HQ-" + type;
            else if (mod == ModType.CaptureTheFlag)
                return "CTF-" + type;
            else if (mod == ModType.Demolition)
                return "DD-" + type;
            else if (mod == ModType.KillConfirmed)
                return "KC-" + type;
            else if (mod == ModType.TeamDefender)
                return "TDEF-" + type;

            //Alternative
            else if (mod == ModType.DropZone)
                return "DZ-" + type;
            else if (mod == ModType.TeamJuggernaut)
                return "TJ-" + type;
            else if (mod == ModType.Juggernaut)
                return "JUG-" + type;
            else if (mod == ModType.GunGame)
                return "GG-" + type;
            else if (mod == ModType.Infected)
                return "INF-" + type;
            else //if (mod == ModType.OneInTheChamber)
                return "OIC-" + type;
        }

        public static string FindMod(string mod)
        {
            //Standard
            if (mod.StartsWith("FFA"))
                return "Free For All";
            else if (mod.StartsWith("TDM"))
                return "Team Deathmatch";
            else if (mod.StartsWith("SD"))
                return "Search And Destroy";
            else if (mod.StartsWith("SAB"))
                return "Sabotage";
            else if (mod.StartsWith("DOM"))
                return "Domination";
            else if (mod.StartsWith("HQ"))
                return "Headquarters";
            else if (mod.StartsWith("CTF"))
                return "Capture The Flag";
            else if (mod.StartsWith("DD"))
                return "Demolition";
            else if (mod.StartsWith("KC"))
                return "Kill Confirmed";
            else if (mod.StartsWith("TDEF"))
                return "Team Defender";

            //Alternative
            else if (mod.StartsWith("DZ"))
                return "Drop Zone";
            else if (mod.StartsWith("TJ"))
                return "Team Juggernaut";
            else if (mod.StartsWith("JUG"))
                return "Juggernaut";
            else if (mod.StartsWith("GG"))
                return "Gun Game";
            else if (mod.StartsWith("INF"))
                return "Infected";
            else //if (mod.StartsWith("OIC"))
                return "One In The Chamber";
        }

        #endregion

        #region IMAGE

        public static Image Image(MapType map)
        {
            //Standard Maps
            if (map == MapType.Seatown)
                return Properties.Resources.seatown;
            else if (map == MapType.Dome)
                return Properties.Resources.dome;
            else if (map == MapType.Arkaden)
                return Properties.Resources.arkaden;
            else if (map == MapType.Bakaara)
                return Properties.Resources.bakaara;
            else if (map == MapType.Resistance)
                return Properties.Resources.resistance;
            else if (map == MapType.Downturn)
                return Properties.Resources.downturn;
            else if (map == MapType.Bootleg)
                return Properties.Resources.bootleg;
            else if (map == MapType.Carbon)
                return Properties.Resources.carbon;
            else if (map == MapType.Hardhat)
                return Properties.Resources.hardhat;
            else if (map == MapType.Lockdown)
                return Properties.Resources.lockdown;
            else if (map == MapType.Village)
                return Properties.Resources.village;
            else if (map == MapType.Fallen)
                return Properties.Resources.fallen;
            else if (map == MapType.Outpost)
                return Properties.Resources.outpost;
            else if (map == MapType.Interchange)
                return Properties.Resources.interchange;
            else if (map == MapType.Underground)
                return Properties.Resources.underground;
            else if (map == MapType.Mission)
                return Properties.Resources.mission;

            //[DLC 1] Collection 1
            else if (map == MapType.Piazza)
                return Properties.Resources.piazza;
            else if (map == MapType.Liberation)
                return Properties.Resources.liberation;
            else if (map == MapType.Overwatch)
                return Properties.Resources.overwatch;
            else if (map == MapType.BlackBox)
                return Properties.Resources.black_box;

            //[DLC 2] Collection 2
            else if (map == MapType.Sanctuary)
                return Properties.Resources.sanctuary;
            else if (map == MapType.Foundation)
                return Properties.Resources.foundation;
            else if (map == MapType.Oasis)
                return Properties.Resources.oasis;
            else if (map == MapType.Erosion)
                return Properties.Resources.erosion;
            else if (map == MapType.Aground)
                return Properties.Resources.aground;

            //[DLC 3] Collection 3: Chaos Pack
            else if (map == MapType.UTurn)
                return Properties.Resources.u_turn;
            else if (map == MapType.Vortex)
                return Properties.Resources.vortex;
            else if (map == MapType.Intersection)
                return Properties.Resources.intersection;

            //[DLC 4] Collection 4: Final Assault
            else if (map == MapType.Boardwalk)
                return Properties.Resources.boardwalk;
            else if (map == MapType.Decommission)
                return Properties.Resources.decommission;
            else if (map == MapType.Gulch)
                return Properties.Resources.gulch;
            else if (map == MapType.OffShore)
                return Properties.Resources.off_shore;
            else if (map == MapType.Parish)
                return Properties.Resources.parish;

            //Face Off
            else if (map == MapType.Lookout)
                return Properties.Resources.lookout;
            else if (map == MapType.Getaway)
                return Properties.Resources.getaway;

            //Free
            else //if (map == MapType.Terminal)
                return Properties.Resources.terminal;
        }

        #endregion

        #region PRIORITY

        public static int Priority(string priority)
        {
            if (priority == "1")
                return 1;
            else if (priority == "100")
                return 100;
            else if (priority == "200")
                return 200;
            else if (priority == "300")
                return 300;
            else if (priority == "400")
                return 400;
            else if (priority == "500")
                return 500;
            else if (priority == "600")
                return 600;
            else if (priority == "700")
                return 700;
            else if (priority == "800")
                return 800;
            else if (priority == "900")
                return 900;
            else
                return 1000;
        }

        #endregion
    }
}
