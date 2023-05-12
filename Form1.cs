namespace avaliacao;

public partial class Form1 : Form
{
    public Label lblNome;
    public TextBox txtNome;
    public Form1()
    {
        InitializeComponent();
        this.Text = "Prova 4";
        lblNome = new Label
        {
            Text = "Nome:",
            Location = new Point(320, 130),
            Size = new Size(50, 20)
        };
        txtNome = new TextBox
        {
            Location = new Point(280, 160),
            Size = new Size(150, 20)
        };

        var btnOla = CreateButton("Olá", 300, 200, 100, 50);
        btnOla.Click += BtnOla_Click;
        var btnFechar = CreateButton("Fechar", 300, 300, 100, 50);
        btnFechar.Click += BtnFechar_Close;
        this.Controls.Add(btnOla);
        this.Controls.Add(btnFechar);
        this.Controls.Add(lblNome);
        this.Controls.Add(txtNome);



    }

    private void BtnOla_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Olá: " + txtNome.Text);
    }
    private void BtnFechar_Close(object sender, EventArgs e)
    {
        this.Close();
    }
    private Button CreateButton(string text, int x, int y, int width, int height)
    {
        var button = new Button
        {
            Text = text,
            Size = new Size(width, height),
            Location = new Point(x, y),
        };
        return button;
    }

}
