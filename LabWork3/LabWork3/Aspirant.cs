﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LabWork3
{
    [Serializable]
    internal class Aspirant : MemberOfUnic, ISerializable
    {
        public override string FIO { get; set; } = "";

        public override int Age { get; set; }

        public Aspirant(string fio, int age)
        {
            FIO = fio; Age = age;
        }

        public Aspirant()
        {
        }

        public override string Work()
        {
            return "Aspirant doing something";
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("FIO", FIO, typeof(string));
            info.AddValue("Age", Age, typeof(int));
        }

        public Aspirant(SerializationInfo info, StreamingContext context)
        {
            // Reset the property value using the GetValue method.
            FIO = (string)info.GetValue("FIO", typeof(string));
            Age = (int)info.GetValue("Age", typeof(int));
        }
    }
}
