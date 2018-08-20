
using strange.extensions.context.impl;
using UnityEngine;

public class Demo01MVCContext : MVCSContext
{
    public Demo01MVCContext(MonoBehaviour view) : base(view)
    {
    }

//    protected override void mapBindings()
//    {
//        base.mapBindings();
//        Debug.Log("Context Start");
//    }

//    public override void Launch()
//    {
//        base.Launch();
//        Debug.Log("Launch");
//    }
}
