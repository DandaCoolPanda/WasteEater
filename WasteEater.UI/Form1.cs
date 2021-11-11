using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WasteEater.BusinessLogic;
using WasteEater.BusinessLogic.Models;

namespace WasteEater.UI
{
    public partial class Form1 : Form
    {

        private int ZIPCode = 9000;
        Store[] Stores;

        public Form1()
        {
            InitializeComponent();
            

            Stores = DataHandler.GetStores(ZIPCode);

            for(int i = 0; i < Stores.Length; i++)
            {
                storeComboBox.Items.Add(Stores[i].brand + "; " + Stores[i].address.street);
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void getDataButton_Click(object sender, EventArgs e)
        {
            Clearance[] products = Array.Empty<Clearance>();

            if(storeComboBox.SelectedIndex >= 0)
            {
                for(int i = 0; i < Stores.Length; i++)
                {
                    if(i == storeComboBox.SelectedIndex)
                    {
                        products = DataHandler.GetProductDataByStoreId(Stores[i].id);
                    }
                }
            }
            else
            {
                products = DataHandler.GetProductDataByZIPCode(ZIPCode);
            }
            
            products = SortingDataManager.SortProductsByLastUpdate(products);

            generateProducts(products);
        }





        Panel[] panels;
        Label[] storeInfoLabels;
        Label[] updatedLabels;
        Label[] experationLabels;
        Label[] piecesLabels;
        Label[] oldPriceLabels;
        Label[] newPriceLabels;
        Label[] nameLabels;
        PictureBox[] pictureBoxes;

        private void generateProducts(Clearance[] products)
        {
            clearProducts();

            flowLayoutPanel1.SuspendLayout();


            panels = new Panel[products.Count()];
            storeInfoLabels = new Label[products.Count()];
            updatedLabels = new Label[products.Count()];
            experationLabels = new Label[products.Count()];
            piecesLabels = new Label[products.Count()];
            oldPriceLabels = new Label[products.Count()];
            newPriceLabels = new Label[products.Count()];
            nameLabels = new Label[products.Count()];
            pictureBoxes = new PictureBox[products.Count()];


            
            for(int i = 0; i < products.Count(); i++)
            {
                panels[i] = new Panel();
                storeInfoLabels[i] = new Label();
                updatedLabels[i] = new Label();
                experationLabels[i] = new Label();
                piecesLabels[i] = new Label();
                oldPriceLabels[i] = new Label();
                newPriceLabels[i] = new Label();
                nameLabels[i] = new Label();
                pictureBoxes[i] = new PictureBox();


                panels[i].SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(pictureBoxes[i])).BeginInit();
                this.flowLayoutPanel1.Controls.Add(panels[i]);
                // 
                // productLayout
                // 
                panels[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                panels[i].Controls.Add(storeInfoLabels[i]);
                panels[i].Controls.Add(updatedLabels[i]);
                panels[i].Controls.Add(experationLabels[i]);
                panels[i].Controls.Add(piecesLabels[i]);
                panels[i].Controls.Add(oldPriceLabels[i]);
                panels[i].Controls.Add(newPriceLabels[i]);
                panels[i].Controls.Add(nameLabels[i]);
                panels[i].Controls.Add(pictureBoxes[i]);
                panels[i].Margin = new Padding(3);
                panels[i].Location = new System.Drawing.Point(0,0);
                panels[i].Name = "productLayout" + i;
                panels[i].Size = new System.Drawing.Size(240, 334);
                panels[i].TabIndex = i;
                // 
                // storeInfoLabel
                // 
                storeInfoLabels[i].AutoSize = true;
                storeInfoLabels[i].Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                storeInfoLabels[i].Location = new System.Drawing.Point(20, 265);
                storeInfoLabels[i].Name = "storeInfoLabel";
                storeInfoLabels[i].Size = new System.Drawing.Size(103, 20);
                storeInfoLabels[i].TabIndex = 7;
                storeInfoLabels[i].Text = "Store: "+products[i].storeInfo;
                // 
                // updatedLabel
                // 
                updatedLabels[i].AutoSize = true;
                updatedLabels[i].Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                updatedLabels[i].Location = new System.Drawing.Point(20, 236);
                updatedLabels[i].Name = "updatedLabel";
                updatedLabels[i].Size = new System.Drawing.Size(74, 20);
                updatedLabels[i].TabIndex = 6;

                TimeSpan timeDifference =  DateTime.Now - products[i].offer.lastUpdate;

                int totalMinutes = (int)timeDifference.TotalMinutes;
                int hours = totalMinutes / 60;
                updatedLabels[i].Text = "Updated: " +( hours >= 1 ? hours + " hrs " + totalMinutes % 60 + " mins" : totalMinutes.ToString() + " mins") + " ago";
                // 
                // experationLabel
                // 

                timeDifference = products[i].offer.endTime - DateTime.Now;

                totalMinutes = (int)timeDifference.TotalMinutes;
                hours = totalMinutes / 60;
                int days = hours / 24;


                experationLabels[i].Text = "Experation: " + ((hours >= 24) ? days + "d " + hours % 24 + "hrs" : hours + "hrs " + totalMinutes % 60 + "min");
                experationLabels[i].AutoSize = true;
                experationLabels[i].Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                experationLabels[i].Location = new System.Drawing.Point(20, 210);
                experationLabels[i].Name = "experationLabel";
                experationLabels[i].Size = new System.Drawing.Size(87, 20);
                experationLabels[i].TabIndex = 5;
                // 
                // piecesLabel
                // 
                piecesLabels[i].AutoSize = true;
                piecesLabels[i].Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                piecesLabels[i].Location = new System.Drawing.Point(20, 184);
                piecesLabels[i].Name = "piecesLabel";
                piecesLabels[i].Size = new System.Drawing.Size(57, 20);
                piecesLabels[i].TabIndex = 4;
                piecesLabels[i].Text = "Stock: " + products[i].offer.stock + ((products[i].offer.stockUnit == "each") ? " pcs" : " kg");
                // 
                // oldPriceLabel
                // 
                oldPriceLabels[i].AutoSize = true;
                oldPriceLabels[i].Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                    | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point);
                oldPriceLabels[i].Location = new System.Drawing.Point(174, 176);
                oldPriceLabels[i].Name = "oldPriceLabel";
                oldPriceLabels[i].Size = new System.Drawing.Size(29, 17);
                oldPriceLabels[i].TabIndex = 3;
                oldPriceLabels[i].Text = products[i].offer.originalPrice +",-";
                // 
                // newPriceLabel
                // 
                newPriceLabels[i].AutoSize = true;
                newPriceLabels[i].Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                newPriceLabels[i].Location = new System.Drawing.Point(172, 155);
                newPriceLabels[i].Name = "newPriceLabel";
                newPriceLabels[i].Size = new System.Drawing.Size(38, 21);
                newPriceLabels[i].TabIndex = 2;
                newPriceLabels[i].Text = products[i].offer.newPrice + ",-";
                // 
                // nameLabel
                // 
                nameLabels[i].AutoSize = true;
                nameLabels[i].Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                nameLabels[i].Location = new System.Drawing.Point(20, 125);
                nameLabels[i].Name = "nameLabel";
                nameLabels[i].Size = new System.Drawing.Size(56, 21);
                nameLabels[i].TabIndex = 1;
                nameLabels[i].Text = products[i].product.description;
                // 
                // pictureBox1
                // 
                pictureBoxes[i].ImageLocation = "1,1";
                pictureBoxes[i].Location = new System.Drawing.Point(20, 21);
                pictureBoxes[i].MaximumSize = new System.Drawing.Size(200, 200);
                pictureBoxes[i].Name = "pictureBox1";
                pictureBoxes[i].Size = new System.Drawing.Size(190, 90);
                pictureBoxes[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureBoxes[i].TabIndex = 0;
                pictureBoxes[i].TabStop = false;

                if(products[i].product.image != null)
                    pictureBoxes[i].Load(products[i].product.image);


                //other
                panels[i].ResumeLayout(false);
                panels[i].PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(pictureBoxes[i])).EndInit();
            }
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
        }

        private void clearProducts()
        {
            if(panels != null && panels.Count() > 0)
            {
                for(int i =0; i < panels.Count(); i++)
                {
                    flowLayoutPanel1.Controls.Remove(panels[i]);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
