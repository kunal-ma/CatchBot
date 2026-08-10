<h1 align="center">CatchBot</h1>

<p align="center">
A Stardew Valley mod that automatically hooks fish when you cast your fishing rod. I made this because my mouse clicks often failed to register, and I didn’t want to install a large fishing overhaul or any mods that add features I consider cheating.
</p>

## Getting Started

1. **Install the SMAPI mod loader**:
   Download and install `SMAPI-x.x.x-installer.zip` from the [official SMAPI releases page](https://github.com/Pathoschild/SMAPI/releases/latest). For detailed instructions, see the Stardew Valley Wiki’s [modding guide](https://stardewvalleywiki.com/Modding:Player_Guide/Getting_Started).

2. **Install the mod**:
   Download and unzip `CatchBot-x.x.x.zip` from the [Releases page](https://github.com/kunal-ma/catchbot/releases/latest). Place the extracted folder into the `Mods` directory inside your Stardew Valley game folder. Launch the game through SMAPI, which will automatically detect and load the mod.

   Your folder structure should look like this:

   ```
   Stardew Valley/
     Mods/
       CatchBot/
         CatchBot.dll
         manifest.json
         config.json
   ```

3. **Update or remove the mod**:

   * **Update**: Copy your `config.json` to an external location, delete the old mod folder and add the new version, and move the `config.json` back.
   * **Uninstall**: Delete the `CatchBot` folder from the `Mods` directory.

## Configuration

You can customize the mod’s behavior through the `config.json` file.

| Property        | Description                                                                 | Values           |
| --------------- | --------------------------------------------------------------------------- | ---------------- |
| AutoHookEnabled | Clicking to start the fishing minigame is not required. (*Default*: `true`) | `true` / `false` |

> [!IMPORTANT]
> You can reload the configuration in-game by pressing the `F5` key.

## Acknowledgements

Distributed under the GNU Affero General Public License v3.0. See <a href="https://github.com/kunal-ma/catchbot/blob/main/LICENSE">`LICENSE`</a> for more information.
