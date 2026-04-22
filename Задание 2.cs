using System.Windows.Forms;
class Form1 : Form
{
    TextBox tb = new TextBox();
    Button btn = new Button();
    Label lbl = new Label();
    Form1()
    {
        tb.Location = new System.Drawing.Point(20, 30);
        tb.Size = new System.Drawing.Size(150, 20);
        btn.Text = "Поздороваться";
        btn.Location = new System.Drawing.Point(20, 70);
        btn.Click += (s, e) => lbl.Text = "Привет, " + tb.Text + "!";
        lbl.Location = new System.Drawing.Point(20, 110);
        lbl.Size = new System.Drawing.Size(200, 30);
        Controls.Add(tb);
        Controls.Add(btn);
        Controls.Add(lbl);
    }
    static void Main() => Application.Run(new Form1());
}
