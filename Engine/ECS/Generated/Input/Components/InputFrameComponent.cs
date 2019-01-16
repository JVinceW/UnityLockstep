//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputContext {

    public InputEntity frameEntity { get { return GetGroup(InputMatcher.Frame).GetSingleEntity(); } }
    public FrameComponent frame { get { return frameEntity.frame; } }
    public bool hasFrame { get { return frameEntity != null; } }

    public InputEntity SetFrame(ECS.Data.Command[] newCommands) {
        if (hasFrame) {
            throw new Entitas.EntitasException("Could not set Frame!\n" + this + " already has an entity with FrameComponent!",
                "You should check if the context already has a frameEntity before setting it or use context.ReplaceFrame().");
        }
        var entity = CreateEntity();
        entity.AddFrame(newCommands);
        return entity;
    }

    public void ReplaceFrame(ECS.Data.Command[] newCommands) {
        var entity = frameEntity;
        if (entity == null) {
            entity = SetFrame(newCommands);
        } else {
            entity.ReplaceFrame(newCommands);
        }
    }

    public void RemoveFrame() {
        frameEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public FrameComponent frame { get { return (FrameComponent)GetComponent(InputComponentsLookup.Frame); } }
    public bool hasFrame { get { return HasComponent(InputComponentsLookup.Frame); } }

    public void AddFrame(ECS.Data.Command[] newCommands) {
        var index = InputComponentsLookup.Frame;
        var component = (FrameComponent)CreateComponent(index, typeof(FrameComponent));
        component.Commands = newCommands;
        AddComponent(index, component);
    }

    public void ReplaceFrame(ECS.Data.Command[] newCommands) {
        var index = InputComponentsLookup.Frame;
        var component = (FrameComponent)CreateComponent(index, typeof(FrameComponent));
        component.Commands = newCommands;
        ReplaceComponent(index, component);
    }

    public void RemoveFrame() {
        RemoveComponent(InputComponentsLookup.Frame);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherFrame;

    public static Entitas.IMatcher<InputEntity> Frame {
        get {
            if (_matcherFrame == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.Frame);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherFrame = matcher;
            }

            return _matcherFrame;
        }
    }
}
