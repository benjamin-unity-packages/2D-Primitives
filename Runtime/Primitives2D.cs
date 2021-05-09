using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BenjiDev {
    public static class Primitives2D
    {
        public static GameObject Capsule()
        {
            return Object.Instantiate(Resources.Load<GameObject>("Capsule"));
        }

        public static GameObject Character()
        {
            return Object.Instantiate(Resources.Load<GameObject>("Character"));
        }

        public static GameObject Circle()
        {
            return Object.Instantiate(Resources.Load<GameObject>("Circle"));
        }

        public static GameObject Diamond()
        {
            return Object.Instantiate(Resources.Load<GameObject>("Diamond"));
        }

        public static GameObject HexagonFlatTop()
        {
            return Object.Instantiate(Resources.Load<GameObject>("HexagonFlatTop"));
        }

        public static GameObject HexagonPointTop()
        {
            return Object.Instantiate(Resources.Load<GameObject>("HexagonPointTop"));

        }

        public static GameObject Square()
        {
            return Object.Instantiate(Resources.Load<GameObject>("Square"));
        }

        public static GameObject SquareRounded()
        {
            return Object.Instantiate(Resources.Load<GameObject>("SquareRounded"));
        }
    }
}