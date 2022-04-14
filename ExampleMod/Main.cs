using MelonLoader;
using UnityEngine;

[assembly:MelonInfo(typeof(ExampleMod.Main), "ExampleMod", "1.0.0", "gompo")]
[assembly:MelonGame(developer: null, name: null)]

namespace ExampleMod;

public class Main : MelonMod
{
    public override void OnUpdate() {
        if (Input.GetKeyDown(KeyCode.P))
        {
            LoggerInstance.Msg("Pressed the P key!");
        }
    }
}
