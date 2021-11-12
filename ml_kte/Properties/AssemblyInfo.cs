﻿using System.Reflection;

[assembly: AssemblyTitle("KinectTrackingExtension")]
[assembly: AssemblyVersion("1.0.3")]
[assembly: AssemblyFileVersion("1.0.3")]

[assembly: MelonLoader.MelonInfo(typeof(ml_kte.Main), "KinectTrackingExtension", "1.0.3", "SDraw", "https://github.com/SDraw/ml_mods")]
[assembly: MelonLoader.MelonGame("VRChat", "VRChat")]
[assembly: MelonLoader.MelonAdditionalDependencies("VRChatUtilityKit")]
[assembly: MelonLoader.MelonPlatform(MelonLoader.MelonPlatformAttribute.CompatiblePlatforms.WINDOWS_X64)]
[assembly: MelonLoader.MelonPlatformDomain(MelonLoader.MelonPlatformDomainAttribute.CompatibleDomains.IL2CPP)]