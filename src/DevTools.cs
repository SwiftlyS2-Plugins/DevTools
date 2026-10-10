using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Shared.Plugins;
using SwiftlyS2.Shared;

namespace DevTools;

[PluginMetadata(Id = "DevTools", Version = "1.0.0", Name = "DevTools", Author = "Swiftly Development Team", Description = "No description.")]
public partial class DevTools : BasePlugin {
    public DevTools(ISwiftlyCore core) : base(core)
    {
    }

    public override void ConfigureSharedInterface(IInterfaceManager interfaceManager) {
    }

    public override void UseSharedInterface(IInterfaceManager interfaceManager) {
    }

    public override void Load(bool hotReload) {
        
    }

    public override void Unload() {
    }
} 