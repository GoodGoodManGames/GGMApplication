﻿using GGM.Context;
using GGM.Context.Attribute;

namespace UnitTest.Dummy.Entity
{
    [Managed(ManagedType.Singleton)]
    public class SingletonManaged
    {
        [AutoWired]
        public SingletonManaged(ProtoManaged protoManaged, ProtoManaged_1 protoManaged_1) { }
    }

    [Managed(ManagedType.Singleton)]
    public class SingletonManaged_1
    {
        [AutoWired]
        public SingletonManaged_1(SingletonManaged singleton) { }
    }
}
