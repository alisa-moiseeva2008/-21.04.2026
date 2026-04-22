using System.Windows.Forms;
class Form1 : Form
{
    int count = 0;
    TextBox tb = new TextBox();
    Button set = new Button(), inc = new Button();
    Label lbl = new Label();
    Form1()
    {
        tb.Location = new System.Drawing.Point(20, 30);
        tb.Size = new System.Drawing.Size(80, 20);
        
        set.Text = "Установить";
        set.Location = new System.Drawing.Point(110, 28);
        set.Click += (s, e) => {
            count = int.Parse(tb.Text);
            lbl.Text = count.ToString();
        };    
        inc.Text = "+1";
        inc.Location = new System.Drawing.Point(20, 70);
        inc.Click += (s, e) => {
            count++;
            lbl.Text = count.ToString();
        };
        
        lbl.Text = "0";
        lbl.Location = new System.Drawing.Point(20, 110);
        lbl.Size = new System.Drawing.Size(100, 30);
        
        Controls.Add(tb);
        Controls.Add(set);
        Controls.Add(inc);
        Controls.Add(lbl);
    }
    static void Main() => Application.Run(new Form1());
}