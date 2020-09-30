using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class HelloWorld : MonoBehaviour
{
    void Start()
    {
        LuaEnv luaEnv = new LuaEnv();
        luaEnv.DoString("print('Hello World')");
    }

}
