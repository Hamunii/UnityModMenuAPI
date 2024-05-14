using System.Reflection;

namespace ModMenuAPI.ModMenuItems.BaseItems;

/// <summary>
/// A base class to derive from by menu item classes. <br/>
/// Only use this if you are developing new button types for ModMenuAPI.
/// </summary>
public abstract class ModMenuBaseItemBase
{
    internal ModMenuBaseItemBase()
    {
        if (Metadata.InvokeOnInit)
            CommonInvoke();
    }
    /// <summary>
    /// The type of this menu item.
    /// </summary>
    internal abstract ModMenuItemType ItemType { get; }

    /// <summary>
    /// The metadata for this menu item.
    /// </summary>
    public abstract ModMenuItemMetadata Metadata { get; }

    /// <summary>
    /// The common interface for clicking different types of buttons programmatically.
    /// </summary>
    public abstract void CommonInvoke();

    /// <summary>
    /// Determines whether or not this button can be clicked. Useful if an action requires specific circumstances to be executed successfully.
    /// </summary>
    public bool Clickable { get; set; } = true;

    internal Assembly ParentAssembly { get; set; } = null!;
}