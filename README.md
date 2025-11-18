<div align="center">
<h1 align="center">CatchBot</h1>

<p align="center">
A Stardew Valley mod that automatically hooks fish when you cast your fishing rod. I created this because my mouse clicks often failed to register, and I didn’t want to install a large fishing overhaul or any mods that add additional cheating features.
</p>
</div>

## Getting Started

1. **Install the SMAPI mod loader**:
   Download and unzip `SMAPI-x.x.x-installer.zip` from the [official SMAPI releases page](https://github.com/Pathoschild/SMAPI/releases/latest), then run the installer. For detailed instructions, see the Stardew Valley Wiki’s [modding guide](https://stardewvalleywiki.com/Modding:Player_Guide/Getting_Started).

2. **Locate your game folder**:
   Open the folder where Stardew Valley is installed on your system:

   * **Windows**: `C:\Program Files (x86)\Steam\steamapps\common\Stardew Valley`
   * **Linux**: `~/.local/share/Steam/steamapps/common/Stardew Valley`
   * **Mac**: `~/Library/Application Support/Steam/SteamApps/common/Stardew Valley/Contents/MacOS`

3. **Install the mod**:
   Download and unzip `CatchBot-x.x.x.zip` from the mod’s [Releases page](https://github.com/kunal-ma/CatchBot/releases/latest). Place the extracted folder into the `Mods` directory inside your Stardew Valley game folder. If the `Mods` folder doesn’t exist, create it.

   Your folder structure should look like this:

   ```
   Stardew Valley/
     Mods/
       CatchBot/
         CatchBot.dll
         manifest.json
         config.json
   ```

4. **Launch the game with SMAPI**:
   Start Stardew Valley through SMAPI, which will automatically detect and load the mod.

5. **Update or remove the mod**:

   * **Update:** Delete the old mod folder and add the new version (“clean update”), or overwrite the files while keeping your existing `config.json`.
   * **Uninstall:** Delete the `CatchBot` folder from the `Mods` directory.

## Configuration

You can customize the mod’s behavior through the `config.json` file.

| Property | Description | Values |
| -------- | ----------- | ------ |
| AutoHookEnabled | Clicking to start the fishing minigame is not required. (*Default*: `true`) | `true` / `false` |

> [!IMPORTANT]
> You can **reload** the configuration in-game by pressing the `F5` key.

## Acknowledgements

Distributed under the GNU Affero General Public License v3.0. See <a href="https://github.com/kunal-ma/CatchBot/blob/main/LICENSE">`LICENSE`</a> for more information.

Your contributions can be invaluable to this project. If you have an idea to make this better, feel free to fork the repository and submit a pull request. Thank you for your support :)
