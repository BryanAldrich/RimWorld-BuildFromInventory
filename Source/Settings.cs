﻿using System;
using System.Collections.Generic;
using UnityEngine;
using Verse;
using RimWorld;

namespace Build_From_Inventory
{
	class Settings : ModSettings
	{
		public bool setting;

		public static Settings Get()
		{
			return LoadedModManager.GetMod<Build_From_Inventory.Mod>().GetSettings<Settings>();
		}

		public void DoWindowContents(Rect wrect)
		{
			var options = new Listing_Standard();
			options.Begin(wrect);
			
			options.CheckboxLabeled("Sample setting", ref setting);
			options.Gap();

			options.End();
		}
		
		public override void ExposeData()
		{
			Scribe_Values.Look(ref setting, "setting", true);
		}
	}
}