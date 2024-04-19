using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3var15task2
{
    public partial class Form1 : Form
    {
        private double SmallRoomPrice;
        private double MediumRoomPrice;
        private double LargeRoomPrice;

        public Form1()
        {
            InitializeComponent();
            SmallRoomPrice = Convert.ToDouble(firstPriceTextBox.Text);
            MediumRoomPrice = Convert.ToDouble(secondPriceTextBox.Text);
            LargeRoomPrice = Convert.ToDouble(thirdPriceTextBox.Text);
            countRoomUpDown.ValueChanged += UpdateOrderCost;
            smallRoomButton.CheckedChanged += UpdateOrderCost;
            mediumRoomButton.CheckedChanged += UpdateOrderCost;
            largeRoomButton.CheckedChanged += UpdateOrderCost;
            firstPriceTextBox.TextChanged += UpdateRoomPrices;
            secondPriceTextBox.TextChanged += UpdateRoomPrices;
            thirdPriceTextBox.TextChanged += UpdateRoomPrices;
        }

        private void UpdateOrderCost(object sender, EventArgs e)
        {
            int countRooms = (int)countRoomUpDown.Value;

            double roomPrice = 0;
            if (smallRoomButton.Checked)
                roomPrice = SmallRoomPrice;
            else if (mediumRoomButton.Checked)
                roomPrice = MediumRoomPrice;
            else if (largeRoomButton.Checked)
                roomPrice = LargeRoomPrice;

            double orderCost = countRooms * roomPrice;

            if (countRooms > 10)
                orderCost *= 0.7; 

            outputTextBox.Text = $"Вартість замовлення: {orderCost:N2}";
        }

        private void UpdateRoomPrices(object sender, EventArgs e)
        {
            SmallRoomPrice = Convert.ToDouble(firstPriceTextBox.Text);
            MediumRoomPrice = Convert.ToDouble(secondPriceTextBox.Text);
            LargeRoomPrice = Convert.ToDouble(thirdPriceTextBox.Text);

            UpdateOrderCost(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
