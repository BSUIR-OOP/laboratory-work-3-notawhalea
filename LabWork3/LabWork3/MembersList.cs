using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LabWork3
{
    [Serializable]
    internal class MembersList : ISerializable
    {
        private List<MemberOfUnic> members;

        public MembersList()
        {
            members = new List<MemberOfUnic>();
        }

        public void Add(MemberOfUnic member) => members.Add(member);

        public void Remove(MemberOfUnic member) => members.Remove(member);

        public List<MemberOfUnic> GetMembers() => members;

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //members = (List<MemberOfUnic>)info.AddValue("Members", typeof(List<MemberOfUnic>));
        }

        //public static implicit operator List<MemberOfUnic>(string value)
        //{
            
        //}

    }
}
