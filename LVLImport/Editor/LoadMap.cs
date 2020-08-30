using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using UnityEngine;
using UnityEditor;

using LibSWBF2.Logging;
using LibSWBF2.Wrappers;


public class lvlImportMenu : ScriptableObject {

    [MenuItem("SWBF2/Import Map", false, 1)]
    public static void ImportMap() {

        LibSWBF2.Logging.Logger.SetLogLevel(ELogType.Warning);
        LibSWBF2.Logging.Logger.OnLog += (LoggerEntry logEntry) => 
        {
            Debug.Log(logEntry.ToString());
        };

        Debug.Log("Loading... This might take a while...");
        //Level level = Level.FromFile(@"/home/will/.wine32bit/drive_c/Program Files/Steam/steamapps/common/Star Wars Battlefront II/GameData/data/_lvl_pc/geo/geo1.lvl");
        Level level = Level.FromFile(@"/home/will/Desktop/geo1.lvl");
        
        TerrainLoader.ImportTerrain(level);

        Debug.Log("Done");
    }
}