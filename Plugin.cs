
using MelonLoader;
using GorillaTagMLModExample;
using UnityEngine;

// !!!
// NOTE: When you build the project, your IDE will automatically try to move the compiled DLL to the Mods folder, with the name of GorillaTagMLModExample.dll/GorillaTagMLModExample.pdb. If you change the name of the project, make sure to change the name of the DLL in the .csproj file.
// !!!

// Change the MelonInfo to correspond to your mod info. The first parameter is the class that inherits from MelonMod, so if you change the class name below, make sure to change it here as well.
// Make sure to also change the info in Constants.cs if you are going to use that. Constants dont seem to work here, so it isn't used in the MelonInfo attribute, but you can still use it in your mod code.
[assembly: MelonInfo(typeof(PlayerIDGetters), "PlayerIDGetter", "1.0.0", "Estatic")]
[assembly: MelonGame("Another Axiom", "Gorilla Tag")]
namespace GorillaTagMLModExample
{
    public class PlayerIDGetters : MelonMod
    {
        public GameObject testObject;
        // InitializeMelon runs as soon as the mod loads. If you instead want to run code when the player is spawned, put your code in GorillaTagger.OnPlayerSpawned.
        public override void OnInitializeMelon()
        {

        }

    }
}