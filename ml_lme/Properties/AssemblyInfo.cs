﻿using System.Reflection;

[assembly: AssemblyTitle("LeapMotionExtension")]
[assembly: AssemblyVersion("1.3.12")]
[assembly: AssemblyFileVersion("1.3.12")]

[assembly: MelonLoader.MelonInfo(typeof(ml_lme.LeapMotionExtention), "LeapMotionExtension", "1.3.12", "SDraw", "https://github.com/SDraw/ml_mods")]
[assembly: MelonLoader.MelonGame("VRChat", "VRChat")]
[assembly: MelonLoader.MelonAdditionalDependencies("VRChatUtilityKit")]
[assembly: MelonLoader.MelonPlatform(MelonLoader.MelonPlatformAttribute.CompatiblePlatforms.WINDOWS_X64)]
[assembly: MelonLoader.MelonPlatformDomain(MelonLoader.MelonPlatformDomainAttribute.CompatibleDomains.IL2CPP)]
