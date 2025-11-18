using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.Tools;

namespace CatchBot
{
    public class ModEntry : Mod
    {
        private ModConfig Config;

        public override void Entry(IModHelper helper)
        {
            Config = helper.ReadConfig<ModConfig>();
            helper.Events.GameLoop.UpdateTicked += OnUpdateTicked;
            helper.Events.Input.ButtonPressed += OnButtonPressed;
        }

        /// <summary>
        /// Optionally allow config reload with a key (default: F5)
        /// </summary>
        private void OnButtonPressed(object? sender, ButtonPressedEventArgs e)
        {
            if (!Context.IsWorldReady) return;
            if (e.Button == SButton.F5)
            {
                Config = Helper.ReadConfig<ModConfig>();
                Monitor.Log("CatchBot config reloaded.", LogLevel.Info);
            }
        }

        /// <summary>
        /// On every game tick, if player is fishing and config is enabled, trigger auto hook.
        /// </summary>
        private void OnUpdateTicked(object? sender, UpdateTickedEventArgs e)
        {
            if (!Context.IsWorldReady || !Config.AutoHookEnabled)
                return;

            var player = Game1.player;
            if (player.CurrentTool is FishingRod rod)
            {
                // Improved: only trigger when all rod states are correct
                if (rod.isNibbling && rod.isFishing && !rod.isReeling && !rod.pullingOutOfWater && !rod.hit)
                {
                    Farmer.useTool(Game1.player);

                    // Optional: log for debugging
                    Monitor.VerboseLog("CatchBot auto-hook triggered for bite at: " +
                        $"{rod.bobber?.X},{rod.bobber?.Y} at tick {e.Ticks}");
                }
            }
        }
    }
}
