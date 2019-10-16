using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;


namespace NewWorld
{
    public class ModEntry : Mod, IAssetLoader
    {
        private IModHelper modHelper;
        public override void Entry(IModHelper helper)
        {
            modHelper = helper;

            helper.Events.GameLoop.GameLaunched += this.OnGameLaunched;
            // helper.Events.GameLoop.SaveLoaded += this.OnSaveLoaded;
        }



        public bool CanLoad<T>(IAssetInfo asset)
        {


            if (asset.AssetNameEquals("Portraits/Sebastian"))
            {
                return true;
            }
            if (asset.AssetNameEquals("Portraits/Leah"))
            {
                return true;
            }



            return false;
        }

        public T Load<T>(IAssetInfo asset)
        {


            Monitor.Log($"Load");




            throw new InvalidOperationException($"Unexpected asset '{asset.AssetName}'.");
        }




        private void OnGameLaunched(object sender, GameLaunchedEventArgs e)
        {

            Monitor.Log($"Launched");

        }

        private void OnSaveLoaded(object sender, SaveLoadedEventArgs args)
        {
            Monitor.Log($"Loaded");

        }


    }
}