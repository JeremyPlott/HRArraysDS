using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HRArraysDS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4 };

            List<int> reversedArray = new List<int>();

            for (int i = a.Length - 1; i > -1; i--)
            {
                reversedArray.Add(a[i]);
            }

            return reversedArray.ToArray();

        }
    }
}
