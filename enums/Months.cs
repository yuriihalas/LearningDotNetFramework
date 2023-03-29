using System;

namespace LearningDotNetFramework.enums
{
    [Flags]
    public enum Months
    {
        January = 1 << 0,
        February = 1 << 1,
        May = 1 << 2,
        June = 1 << 3,
        July = 1 << 4
    }
}