using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LabWork3
{
    public partial class Form1 : Form
    {
        MembersList members = new MembersList();
        public Form1()
        {
            InitializeComponent();
            ChooseMember.Items.Add(new Student());
            ChooseMember.Items.Add(new Teacher());
            ChooseMember.Items.Add(new Stuff());

        }

        private void Create_Click(object sender, EventArgs e)
        {
            MemberOfUnic newMember = ChooseMember.SelectedItem as MemberOfUnic;

            newMember.FIO = Fio.Text;
            newMember.Age = int.Parse(Age.Text);

            MembersList.Items.Add(newMember.FIO);

            members.Add(newMember);


        }

        private void Serialize_Click(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream("data.bin", FileMode.OpenOrCreate))
            {
                IFormatter formatter = new BinaryFormatter();

                formatter.Serialize(fileStream, members);

                MembersList.ClearSelected();
            }
        }

        private void Deserialize_Click(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream("data.bin",FileMode.OpenOrCreate))
            {
                IFormatter formatter = new BinaryFormatter();

                members = (MembersList)formatter.Deserialize(fileStream);

                foreach (var item in members.GetMembers())
                {
                    MembersList.Items.Add(item.FIO);
                }
            }
        }

        private void Refactor_Click(object sender, EventArgs e)
        {
            foreach (var item in members.GetMembers())
            {
                if (MembersList.SelectedItem.ToString() == item.FIO)
                {
                    item.FIO = Fio.Text;
                    item.Age = int.Parse(Age.Text);
                    MembersList.SelectedItem = item.FIO;                    
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            foreach (var item in members.GetMembers())
            {
                if (MembersList.SelectedItem.ToString() == item.FIO)
                {
                    members.Remove(item);
                    MembersList.SelectedItem = "";
                    return;
                }
            }
        }
    }
}