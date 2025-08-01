using Content.Shared.StatusIcon;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Roles;

[RegisterComponent, NetworkedComponent]
public sealed partial class ParadoxCloneComponent : Component
{
    [DataField]
    public ProtoId<FactionIconPrototype> StatusIcon = "ParadoxCloneFaction";
}
