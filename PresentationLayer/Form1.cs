using NavigationView.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigationView
{
    public partial class Form1 : Form
    {
        NavigationControl navigationControl;
        NavigationButtons navigationButtons;

        // Change the color of your buttons if you want
        Color btnDefaultColor = Color.FromKnownColor(KnownColor.ControlLight);
        Color btnSelectedtColor = Color.FromKnownColor(KnownColor.ControlDark);//ControlDark

        CreateCustomer createCustomer = new CreateCustomer();

        AllCustomersControl allcustomersControl = new AllCustomersControl();
        CreateOrderControl createorderControl = new CreateOrderControl();
        AllOrdersControl ordersControl = new AllOrdersControl();

        InventoryControl inventoryControl = new InventoryControl();
        CreateInventory createInventory = new CreateInventory();
        EditOrderControl editOrderControl =  new EditOrderControl();

        public Form1()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButtons();
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>() // Your UserControl list
            {
                createCustomer, allcustomersControl,
                createorderControl, ordersControl,
                inventoryControl , createInventory,
                editOrderControl


        };

            navigationControl = new NavigationControl(userControls, panel2); // create an instance of NavigationControl class
            navigationControl.Display(0); // display UserControl1 as default
        }

        private void InitializeNavigationButtons()
        {
            List<Button> buttons = new List<Button>()
            { button1, button2, button3,button4,button5 };

            // create a NavigationButtons instance
            navigationButtons = new NavigationButtons(buttons, btnDefaultColor, btnSelectedtColor);
            // Make a default selected button
            navigationButtons.Highlight(button1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButtons.Highlight(button1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            allcustomersControl.BindData();
            navigationControl.Display(1);
            navigationButtons.Highlight(button2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButtons.Highlight(button3);
            //AllCustomersControl c = new AllCustomersControl();
           // c.BindData();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ordersControl.Bind
            ordersControl.BindData();
            navigationControl.Display(3);
            navigationButtons.Highlight(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inventoryControl.BindData();
            navigationControl.Display(4);
            navigationButtons.Highlight(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            navigationControl.Display(5);
            navigationButtons.Highlight(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            navigationControl.Display(6);
            navigationButtons.Highlight(button7);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
