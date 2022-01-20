using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyToolsNamespace
{
    public static class MyTools
    {
        public static void AddXPosition(this Transform t, float x)
        {
            Vector3 vector3 = new Vector3(x, 0, 0);
            t.position += vector3;
        }
    }

}
