using System.Windows.Forms;
using System.IO;
class Form1 : Form
{
    CheckBox chk = new CheckBox();
    ComboBox cmb = new ComboBox();
    Button save = new Button();
    Form1()
    {
        chk.Text = "Тёмная тема";
        chk.Location = new System.Drawing.Point(20, 30);
        cmb.Items.AddRange(new[] { "Русский", "English" });
        cmb.Location = new System.Drawing.Point(20, 70);
        cmb.Size = new System.Drawing.Size(120, 25); 
        save.Text = "Сохранить";
        save.Location = new System.Drawing.Point(20, 110);
        save.Click += (s, e) => {
            this.BackColor = chk.Checked ? System.Drawing.Color.DimGray : System.Drawing.SystemColors.Control;
            this.ForeColor = chk.Checked ? System.Drawing.Color.White : System.Drawing.Color.Black;
            File.WriteAllText("settings.txt", chk.Checked + "|" + cmb.SelectedItem);
        };
        if (File.Exists("settings.txt"))
        {
            string[] data = File.ReadAllText("settings.txt").Split('|');
            chk.Checked = bool.Parse(data[0]);
            cmb.SelectedItem = data[1];
        }
        else cmb.SelectedIndex = 0;
        Controls.Add(chk);
        Controls.Add(cmb);
        Controls.Add(save);
    }
    static void Main() => Application.Run(new Form1());
}