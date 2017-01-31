//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public InputComponent input { get { return (InputComponent)GetComponent(InputComponentsLookup.Input); } }
    public bool hasInput { get { return HasComponent(InputComponentsLookup.Input); } }

    public void AddInput(int newX, int newY) {
        var component = CreateComponent<InputComponent>(InputComponentsLookup.Input);
        component.x = newX;
        component.y = newY;
        AddComponent(InputComponentsLookup.Input, component);
    }

    public void ReplaceInput(int newX, int newY) {
        var component = CreateComponent<InputComponent>(InputComponentsLookup.Input);
        component.x = newX;
        component.y = newY;
        ReplaceComponent(InputComponentsLookup.Input, component);
    }

    public void RemoveInput() {
        RemoveComponent(InputComponentsLookup.Input);
    }
}
