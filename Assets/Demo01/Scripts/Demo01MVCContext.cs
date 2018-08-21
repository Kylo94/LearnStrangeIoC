
using strange.extensions.context.api;
using strange.extensions.context.impl;
using UnityEngine;

public class Demo01MVCContext : MVCSContext
{
    public Demo01MVCContext(MonoBehaviour view) : base(view)
    {
    }

    protected override void mapBindings()
    {
        base.mapBindings();

        Debug.Log("Mediator ... ");
        mediationBinder.Bind<CubeView>().To<CubeMediator>();

        Debug.Log("Command ... ");
        commandBinder.Bind(ContextEvent.START).To<StartCmd>().Once();
    }

}
