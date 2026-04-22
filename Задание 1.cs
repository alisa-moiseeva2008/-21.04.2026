using System.Windows.Forms;
class Form1 : Form
{
    Button btn = new Button();
    TextBox tb = new TextBox();

    Form1()
    {
        btn.Text = "Нажми";
        btn.Location = new System.Drawing.Point(50, 30);
        btn.Click += (s, e) => tb.Text = "Hello, World!";
        
        tb.Location = new System.Drawing.Point(50, 80);
        tb.Size = new System.Drawing.Size(150, 20);
        
        Controls.Add(btn);
        Controls.Add(tb);
    }

    static void Main() => Application.Run(new Form1());
}