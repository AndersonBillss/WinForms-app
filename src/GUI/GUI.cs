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
            Padding = new Padding(10,10,10,10),
            BackColor = Color.MediumAquamarine,
        };
        myButton.Click += new EventHandler(MyButton_Click); // Event handler for button click
        Label myLabel = new Label
        {
            Text = "Enter your name:",
            Location = new Point(50, 120),
            AutoSize = true,
        };

        // Create a new textbox
        TextBox myTextBox = new TextBox
        {
            Location = new Point(50, 150),
            Width = 200,
        };

        // Create a new checkbox
        CheckBox myCheckBox = new CheckBox
        {
            Text = "I agree to the terms and conditions",
            Location = new Point(50, 200),
            AutoSize = true,
        };

        // Add the button to the form
        Controls.Add(myButton);
        Controls.Add(myLabel);
        Controls.Add(myTextBox);
        Controls.Add(myCheckBox);
        InitializeComponent();
    }

    // Event handler method
    private void MyButton_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Hello! You clicked the button.");
    }
}