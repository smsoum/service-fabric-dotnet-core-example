// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace VisualObjects.WebService
{
    using Microsoft.ServiceFabric.Actors;

    public interface IVisualObjectsBox
    {
        void SetObjectString(ActorId actorId, string objectJson);

        void computeJson();

        string GetJson();
    }
}