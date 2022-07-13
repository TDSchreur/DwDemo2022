// Copyright (c) T.D.Schreur

namespace App;

public class Demo7
{

    [TypeVroegah(typeof(string))]
    ////[GenericAttribute<string>()]
    public static string? Method() => default;

    // Vroegah
    [AttributeUsage(AttributeTargets.Method)]
    public class TypeVroegahAttribute : Attribute
    {
        public TypeVroegahAttribute(Type t) => ParamType = t;

        public Type ParamType { get; }
    }

    ////// C# 11 feature:
    ////[AttributeUsage(AttributeTargets.Method)]
    ////public class GenericAttribute<T> : Attribute
    ////{
    ////    /*
    ////     * Nu generic :)
    ////     * Alles mag, behalve;
    ////     * - dynamic
    ////     * - string? (or any nullable reference type)
    ////     * - (int X, int Y) (or any other tuple types using C# tuple syntax).
    ////     */
    ////}
}
