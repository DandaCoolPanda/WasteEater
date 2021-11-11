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

        public Form1()
        {
            InitializeComponent();

            

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void getDataButton_Click(object sender, EventArgs e)
        {
            Clearance[] products = DataHandler.GetProductDataByZIPCode(9000);
            generateProducts(products);
        }




        private void generateProducts(Clearance[] products)
        {

            Panel[] panels = new Panel[products.Count()];
            Label[] storeInfoLabels = new Label[products.Count()];
            Label[] updatedLabels = new Label[products.Count()];
            Label[] experationLabels = new Label[products.Count()];
            Label[] piecesLabels = new Label[products.Count()];
            Label[] oldPriceLabels = new Label[products.Count()];
            Label[] newPriceLabels = new Label[products.Count()];
            Label[] nameLabels = new Label[products.Count()];
            PictureBox[] pictureBoxes = new PictureBox[products.Count()];

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
                panels[i].Location = new System.Drawing.Point(3, 3);
                panels[i].Name = "productLayout";
                panels[i].Size = new System.Drawing.Size(240, 334);
                panels[i].TabIndex = 0;
                // 
                // storeInfoLabel
                // 
                storeInfoLabels[i].AutoSize = true;
                storeInfoLabels[i].Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                storeInfoLabels[i].Location = new System.Drawing.Point(20, 265);
                storeInfoLabels[i].Name = "storeInfoLabel";
                storeInfoLabels[i].Size = new System.Drawing.Size(103, 20);
                storeInfoLabels[i].TabIndex = 7;
                storeInfoLabels[i].Text = products[i].storeInfo;
                // 
                // updatedLabel
                // 
                updatedLabels[i].AutoSize = true;
                updatedLabels[i].Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                updatedLabels[i].Location = new System.Drawing.Point(20, 236);
                updatedLabels[i].Name = "updatedLabel";
                updatedLabels[i].Size = new System.Drawing.Size(74, 20);
                updatedLabels[i].TabIndex = 6;
                updatedLabels[i].Text = "Updated: " + products[i].offer.lastUpdate;
                // 
                // experationLabel
                // 
                experationLabels[i].AutoSize = true;
                experationLabels[i].Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                experationLabels[i].Location = new System.Drawing.Point(20, 210);
                experationLabels[i].Name = "experationLabel";
                experationLabels[i].Size = new System.Drawing.Size(87, 20);
                experationLabels[i].TabIndex = 5;
                experationLabels[i].Text = "Experation: " + products[i].offer.endTime;
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
                pictureBoxes[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBoxes[i].TabIndex = 0;
                pictureBoxes[i].TabStop = false;

                if(products[i].product.image != null)
                    pictureBoxes[i].Load(products[i].product.image);


                //other
                panels[i].ResumeLayout(false);
                panels[i].PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(pictureBoxes[i])).EndInit();
            }
        }
    }
}
