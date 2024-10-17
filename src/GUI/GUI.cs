namespace WinForms_app.src.GUI;
public partial class GUI : Form
{
    private Button myButton;

    public GUI()
    {
        // Create a new button
        myButton = new Button
        {
            Text = "Click Me",
            Location = new Point(),
            Padding = new Padding{
                
            },
            BackColor = Color.MediumAquamarine,
        };
        myButton.Click += new EventHandler(MyButton_Click); // Event handler for button click

        // Add the button to the form
        Controls.Add(myButton);
        InitializeComponent();
    }

    // Event handler method
    private void MyButton_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Hello! You clicked the button.");
    }
}