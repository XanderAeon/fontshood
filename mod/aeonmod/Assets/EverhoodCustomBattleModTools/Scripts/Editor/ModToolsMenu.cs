//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EverhoodCustomBattleModTools.Generated
{
    using UMod.Shared;
    
    
    public class ModToolsMenu
    {
        
        [UnityEditor.MenuItem("Mod Tools/Create/New Mod", priority=0)]
        internal static void Menu_Create_New_Mod()
        {
            UMod.BuildEngine.ModToolsUtil.ShowToolsWindow(typeof(UMod.Exporter.CreateModWindow));
        }
        
        [UnityEditor.MenuItem("Mod Tools/Create/Prefab Node", priority=1)]
        internal static void Menu_Create_Prefab_Node()
        {
            UMod.BuildEngine.ModToolsUtil.CreatePrefabNode();
        }
        
        [UnityEditor.MenuItem("Mod Tools/Create/Material Node", priority=2)]
        internal static void Menu_Create_Material_Node()
        {
            UMod.BuildEngine.ModToolsUtil.CreateMaterialNode();
        }
        
        [UnityEditor.MenuItem("Mod Tools/Exporter", priority=23)]
        internal static void Menu_Exporter()
        {
            UMod.BuildEngine.ModToolsUtil.ShowToolsWindow(typeof(UMod.Exporter.ExporterWindow));
        }
        
        [UnityEditor.MenuItem("Mod Tools/Export Settings", priority=44)]
        internal static void Menu_Export_Settings()
        {
            UMod.BuildEngine.ModToolsUtil.ShowToolsWindow(typeof(UMod.Exporter.SettingsWindow));
        }
        
        [UnityEditor.MenuItem("Mod Tools/Build Mod %#b", priority=45)]
        internal static void Menu_Build_Mod___b()
        {
            UMod.ModTools.Export.ExportSettings settings = UMod.ModTools.Export.ExportSettings.Active.Load();
            if ((settings == null))
            {
                throw new UMod.ModLoadException("The export settings are missing from this mod tools package");
            }
            UMod.BuildEngine.ModToolsUtil.StartBuild(settings);
        }
        
        [UnityEditor.MenuItem("Mod Tools/Build and Run %#r", priority=46)]
        internal static void Menu_Build_and_Run___r()
        {
            UMod.BuildEngine.ModToolsUtil.CreateNewMod();
        }
        
        [UnityEditor.MenuItem("Mod Tools/Help", priority=67)]
        internal static void Menu_Help()
        {
            UMod.BuildEngine.ModToolsUtil.ShowToolsWindow(typeof(UMod.Exporter.HelpWindow));
        }
        
        [UnityEditor.MenuItem("Mod Tools/About", priority=68)]
        internal static void Menu_About()
        {
            UMod.BuildEngine.ModToolsUtil.ShowToolsWindow(typeof(UMod.Exporter.AboutWindow));
        }
        
        [UnityEditor.MenuItem("Mod Tools/Referencing/Rebuild Reference Cache", priority=89)]
        internal static void Menu_Referencing_Rebuild_Reference_Cache()
        {
            UMod.BuildEngine.ModToolsUtil.RebuildReferenceCache();
        }
        
        [UnityEditor.MenuItem("Mod Tools/Game Assets", priority=110)]
        internal static void Menu_Game_Assets()
        {
            UMod.BuildEngine.ModToolsUtil.ShowToolsWindow(typeof(UMod.Exporter.GameAssetsWindow));
        }
    }
}