using Modding;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UObject = UnityEngine.Object;
using SFCore.Generics;
using SFCore.Utils;

namespace CharmsForEnemies;

public class CharmsForEnemies : Mod
{
    internal static CharmsForEnemies Instance;

    public override string GetVersion() => Util.GetVersion(Assembly.GetExecutingAssembly());

    public CharmsForEnemies() : base("Charms for Enemies")
    {
        Instance = this;

        InitCallbacks();
    }

    public override void Initialize()
    {
        Log("Initializing");
        Instance = this;

        Log("Initialized");
    }

    private void InitCallbacks()
    {
    }
}