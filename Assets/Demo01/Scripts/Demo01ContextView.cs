using strange.extensions.context.impl;

public class Demo01ContextView : ContextView
{
    private void Awake()
    {
        //一个参数的重载会自动执行Start,并且启动Launch
        //bool参数重载不会执行Start，以及Launch
        context = new Demo01MVCContext(this); //上下文环境
    }
}