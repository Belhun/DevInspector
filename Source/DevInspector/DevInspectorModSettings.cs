//using UnityEngine;
//using Verse;

//namespace DevInspector
//{
//    public class DevInspectorModSettings : ModSettings
//    {

//        public override void ExposeData()
//        {
//            base.ExposeData();
//        }
//    }



//    public class DevInspectorMod : Mod
//    {
//        public static DevInspectorModSettings Settings;

//        public DevInspectorMod(ModContentPack content) : base(content)
//        {
//            Settings = GetSettings<DevInspectorModSettings>();
//        }

//        public override string SettingsCategory()
//        {
//            return "Dev Inspector";
//        }

//        public override void DoSettingsWindowContents(Rect inRect)
//        {
//            var listing = new Listing_Standard();
//            listing.Begin(inRect);

//            listing.End();
//            base.DoSettingsWindowContents(inRect);
//        }
//    }


//}
