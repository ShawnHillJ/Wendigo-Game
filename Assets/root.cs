using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Root
{
    private static Root r = new Root();

    public static Root get_root()
    {
        return r;
    }

    public static RootModel model = new RootModel();
    public static RootView view = new RootView();
    public static RootController controller = new RootController();
}
