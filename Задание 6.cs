using System.Windows.Forms;
class Form1 : Form
{
    TextBox tb = new TextBox();
    Button add = new Button(), del = new Button();
    ListBox lb = new ListBox();
    Form1()
    {
        tb.Location = new System.Drawing.Point(20, 20);
        tb.Size = new System.Drawing.Size(150, 20);
        add.Text = "Добавить";
        add.Location = new System.Drawing.Point(180, 18);
        add.Click += (s, e) => {
            if (tb.Text != "") lb.Items.Add(tb.Text);
            tb.Clear();
        };     
        del.Text = "Удалить";
        del.Location = new System.Drawing.Point(20, 50);
        del.Click += (s, e) => {
            if (lb.SelectedItem != null) lb.Items.Remove(lb.SelectedItem);
        }; 
        lb.Location = new System.Drawing.Point(20, 90);
        lb.Size = new System.Drawing.Size(250, 200);
        
        Controls.Add(tb);
        Controls.Add(add);
        Controls.Add(del);
        Controls.Add(lb);
    }
    static void Main() => Application.Run(new Form1());
}
