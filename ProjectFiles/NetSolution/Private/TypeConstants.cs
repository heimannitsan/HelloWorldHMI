using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

namespace HelloWorldHMI
{
    public static class ObjectTypes
    {
        private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("HelloWorldHMI");
        public static readonly NodeId MainWindow = new NodeId(namespaceIndex, new Guid("ddb115358e384f76bc27bf29808299da"));
        public static readonly NodeId Screen1 = new NodeId(namespaceIndex, new Guid("db792ee1de5e9322b49845930f8a4ea4"));
        public static readonly NodeId AxisFaceplate = new NodeId(namespaceIndex, new Guid("964d347250eba5d40931a560970901f0"));
    }

    public static class VariableTypes
    {
        private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("HelloWorldHMI");
    }
}
