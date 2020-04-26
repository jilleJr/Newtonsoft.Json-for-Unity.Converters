﻿using System.Collections.Generic;
using UnityEngine;

namespace Newtonsoft.Json.UnityConverters.Tests.ConvertingUnityTypes.Math
{
    public class FrustumPlaneTests : ValueTypeTester<FrustumPlanes>
    {
        public static readonly IReadOnlyCollection<(FrustumPlanes deserialized, object anonymous)> representations = new (FrustumPlanes, object)[] {
            (new FrustumPlanes {

                left = 1,
                right = 2,
                bottom = 3,
                top = 4,
                zNear = 5,
                zFar = 6,

            }, new {

                left = 1f,
                right = 2f,
                bottom = 3f,
                top = 4f,
                zNear = 5f,
                zFar = 6f,

            })
        };
    }
}