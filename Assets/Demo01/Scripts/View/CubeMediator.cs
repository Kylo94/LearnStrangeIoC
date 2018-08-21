using strange.extensions.mediation.impl;

public class CubeMediator : Mediator
{
    [Inject]
    public CubeView CubeView { get; set; }
    public override void OnRegister()
    {
    }
    public override void OnRemove()
    {
    }
}