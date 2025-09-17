namespace Pizza___Poject
{
    public partial class Form1 : Form
    {
        PizzaOrder pizzaOrder;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pizzaOrder = new PizzaOrder();
            rdoLargSize.CheckedChanged   += Size_CheckedChanged;
            rdoMeduimSize.CheckedChanged += Size_CheckedChanged;
            rdoLargSize.CheckedChanged   += Size_CheckedChanged;

            rdoThinCrust.CheckedChanged += Crust_CheckedChanged;
            rdoThickCrust.CheckedChanged += Crust_CheckedChanged;

        }


        private void Size_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSmallSize.Checked)
                pizzaOrder.Size = "Small";
            else if (rdoMeduimSize.Checked)
                pizzaOrder.Size = "Medium";
            else if (rdoLargSize.Checked)
                pizzaOrder.Size = "Large";
            else
                pizzaOrder.Size = "No Selected";

            labSizePizza.Text = pizzaOrder.Size;
        }


        private void Crust_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoThinCrust.Checked)
                pizzaOrder.Crust = "Thin Crust";
            else if (rdoThickCrust.Checked)
                pizzaOrder.Crust = "Thick Crust";
            else
                pizzaOrder.Crust = "No Selected";

            labCrust.Text = pizzaOrder.Crust;
        }

    }
}
