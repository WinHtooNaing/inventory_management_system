﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using inventory_management_system.Controller;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;
using inventory_management_system.View.Seller;

namespace inventory_management_system.Seller
{
    public partial class Dashboard : Form
    {
        private readonly ItemController itemController;
        private readonly FakeItemController fakeItemController;

        public Dashboard()
        {
            InitializeComponent();
            itemController = new ItemController();
            fakeItemController = new FakeItemController();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            sellerNameLabel.Text = SessionStorage.Session.UserName;
            LoadItemsIntoGrid();
            LoadFakeItemsIntoGrid();
            fakeDataGridView.CellEndEdit += fakeItemsGridView_CellEndEdit;
            fakeDataGridView.CellValueChanged += fakeItemsGridView_CellValueChanged;
        }
        private void fakeItemsGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && fakeDataGridView.Columns[e.ColumnIndex].Name == "Quantity")
            {
                // Commit changes to ensure CellValueChanged is triggered
                fakeDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
                UpdateTotalPrice();
            }
        }
        private void fakeItemsGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && fakeDataGridView.Columns[e.ColumnIndex].Name == "Quantity")
            {
                try
                {
                    // Get the updated quantity value
                    var quantityCell = fakeDataGridView.Rows[e.RowIndex].Cells["Quantity"];
                    int quantity = int.TryParse(quantityCell.Value?.ToString(), out int parsedQuantity) ? parsedQuantity : 1;

                    if (quantity < 1) // Validate quantity
                    {
                        MessageBox.Show("Quantity must be 1 or greater.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        quantityCell.Value = 1; // Reset invalid quantity to default (1)
                        quantity = 1;
                    }

                    // Get the product price
                    decimal price = Convert.ToDecimal(fakeDataGridView.Rows[e.RowIndex].Cells["Price"].Value);

                    // Calculate and update the Total Price
                    fakeDataGridView.Rows[e.RowIndex].Cells["TotalPrice"].Value = quantity * price;

                    UpdateTotalPrice();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating total price: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void LoadItemsIntoGrid()
        {
            try
            {
                // Fetch all products from the repository
                var items = itemController.GetAllItems();



                // Bind the products list to the DataGridView
                itemGridView.DataSource = items;


                // Add a "No" column for numbering
                if (!itemGridView.Columns.Contains("No"))
                {
                    DataGridViewTextBoxColumn noColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "No",
                        HeaderText = "No",
                        ReadOnly = true
                    };
                    itemGridView.Columns.Insert(0, noColumn);
                }

                // Add Edit button
                if (!itemGridView.Columns.Contains("SellToList"))
                {
                    DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn
                    {
                        Name = "SellToList",
                        HeaderText = "",
                        Text = "Sell to list",
                        UseColumnTextForButtonValue = true
                    };
                    itemGridView.Columns.Add(editColumn);
                    editColumn.DefaultCellStyle.BackColor = Color.Orange;
                    editColumn.DefaultCellStyle.ForeColor = Color.White;
                }



                // Populate "No" column with sequential numbers
                for (int i = 0; i < itemGridView.Rows.Count; i++)
                {
                    itemGridView.Rows[i].Cells["No"].Value = i + 1;
                }

                // Customize the DataGridView
                itemGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Hide the "Id" column
                if (itemGridView.Columns.Contains("Id"))
                {
                    itemGridView.Columns["Id"].Visible = false; // Hide the ID column
                }
                // Hide the "CreatedAt" column
                if (itemGridView.Columns.Contains("CreatedAt"))
                {
                    itemGridView.Columns["CreatedAt"].Visible = false; // Hide the ID column
                }
                // Hide the "Purchase" column
                if (itemGridView.Columns.Contains("PurchasePrice"))
                {
                    itemGridView.Columns["PurchasePrice"].Visible = false; // Hide the ID column
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFakeItemsIntoGrid()
        {
            try
            {


                var items = fakeItemController.GetAllItems();



                // Bind the items list to the DataGridView
                fakeDataGridView.DataSource = items;


                // Add a "No" column for numbering
                if (!fakeDataGridView.Columns.Contains("No"))
                {
                    DataGridViewTextBoxColumn noColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "No",
                        HeaderText = "No",
                        ReadOnly = true
                    };
                    fakeDataGridView.Columns.Insert(0, noColumn);
                }
                // Add a "Quantity" column if not exists
                if (!fakeDataGridView.Columns.Contains("Quantity"))
                {
                    DataGridViewTextBoxColumn qtyColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "Quantity",
                        HeaderText = "Quantity",
                        DefaultCellStyle = new DataGridViewCellStyle { NullValue = "1" } // Default value
                    };
                    fakeDataGridView.Columns.Insert(6, qtyColumn);
                }
                // Add a "Total Price" column if not exists
                if (!fakeDataGridView.Columns.Contains("TotalPrice"))
                {
                    DataGridViewTextBoxColumn totalPriceColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "TotalPrice",
                        HeaderText = "Total Price",
                        ReadOnly = true // Total price is calculated, not editable
                    };
                    fakeDataGridView.Columns.Insert(7, totalPriceColumn);
                }
                // Add Delete button
                if (!fakeDataGridView.Columns.Contains("Delete"))
                {
                    DataGridViewButtonColumn deleteCoulmn = new DataGridViewButtonColumn
                    {
                        Name = "Delete",
                        HeaderText = "",
                        Text = "🗑", // Unicode trash icon
                        UseColumnTextForButtonValue = true
                    };
                    fakeDataGridView.Columns.Add(deleteCoulmn);
                    // Optional: Style the button
                    // deleteCoulmn.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 12); // Use an emoji-supporting font
                    deleteCoulmn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    deleteCoulmn.DefaultCellStyle.BackColor = Color.Red;
                    deleteCoulmn.DefaultCellStyle.ForeColor = Color.White;
                }



                // Populate "No" column with sequential numbers
                for (int i = 0; i < fakeDataGridView.Rows.Count; i++)
                {
                    fakeDataGridView.Rows[i].Cells["No"].Value = i + 1;

                    // Set initial total price (quantity * price)
                    int quantity = Convert.ToInt32(fakeDataGridView.Rows[i].Cells["Quantity"].Value ?? 1);
                    decimal price = Convert.ToDecimal(fakeDataGridView.Rows[i].Cells["Price"].Value);
                    fakeDataGridView.Rows[i].Cells["TotalPrice"].Value = quantity * price;


                }
                fakeDataGridView.RowsAdded += (s, e) =>
                {
                    for (int i = e.RowIndex; i < e.RowIndex + e.RowCount; i++)
                    {
                        fakeDataGridView.Rows[i].Cells["Quantity"].Value = 1;
                    }
                };

                // Customize the DataGridView
                fakeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Hide the "Id" column
                if (fakeDataGridView.Columns.Contains("Id"))
                {
                    fakeDataGridView.Columns["Id"].Visible = false; // Hide the ID column
                }
                // Hide the "Id" column
                if (fakeDataGridView.Columns.Contains("TypeId"))
                {
                    fakeDataGridView.Columns["TypeId"].Visible = false; // Hide the ID column
                }
                // Hide the "Product Price" column
                if (fakeDataGridView.Columns.Contains("Price"))
                {
                    fakeDataGridView.Columns["Price"].Visible = false;
                }
                // Hide the "Product Price" column
                if (fakeDataGridView.Columns.Contains("PurchasePrice"))
                {
                    fakeDataGridView.Columns["PurchasePrice"].Visible = false;
                }
                // Hide the "CreatedAt" column
                if (fakeDataGridView.Columns.Contains("CreatedAt"))
                {
                    fakeDataGridView.Columns["CreatedAt"].Visible = false;
                }

                UpdateTotalPrice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SessionStorage.Session.UserName = "";
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked cell is a button
            if (e.RowIndex >= 0 && (e.ColumnIndex == fakeDataGridView.Columns["Delete"].Index))
            {
                // Get the selected product's ID
                int itemId = Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells["Id"].Value);

                if (e.ColumnIndex == fakeDataGridView.Columns["Delete"].Index)
                {
                    DeleteById(itemId);
                }

            }
        }
        private void DeleteById(int id)
        {
            if (fakeItemController.DeleteItem(id))
            {
                LoadFakeItemsIntoGrid();
            }
            else
            {
                MessageBox.Show("product deleted fail", "Seller Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void itemGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == itemGridView.Columns["SellToList"].Index))
            {
                // Get the selected product's ID
                int itemId = Convert.ToInt32(itemGridView.Rows[e.RowIndex].Cells["Id"].Value);

                if (e.ColumnIndex == itemGridView.Columns["SellToList"].Index)
                {
                    SellToList(itemId);
                }

            }
        }
        private void SellToList(int itemId)
        {
            try
            {
                // Create a itemController instance to fetch product details
                var itemController = new ItemController();

                // Fetch product by ID
                var item = itemController.GetItemById(itemId);

                if (item != null)
                {
                    Model.FakeItem newItem = new Model.FakeItem
                    {
                        TypeId = itemId,
                        Type = item.Types,
                        Category = item.Category,
                        Price = item.SellingPrice,
                        PurchasePrice = item.PurchasePrice,


                    };
                    if (fakeItemController.AddItem(newItem))
                    {
                        LoadFakeItemsIntoGrid();
                    }
                    else
                    {
                        MessageBox.Show("Product  already exists.", "create prduct", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            if (fakeItemController.DeleteAllItems())
            {
                LoadFakeItemsIntoGrid();
            }
            else
            {
                MessageBox.Show("product deleted fail", "Seller Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GeneratePDF(List<Model.SellItem> soldItems)
        {
            try
            {
                // Define the PDF file path
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "SalesReceipt.pdf");

                // Load the Myanmar font
                // string fontPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fonts", "Padauk-Regular.ttf"); // Path to the font file
                string fontPath = @"C:\\Users\\user\\Desktop\\csharp\\inventory_management_system\\inventory_management_system\\Fonts\\Padauk-Regular.ttf";
                BaseFont myanmarFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font myanmarTextFont = new iTextSharp.text.Font(myanmarFont, 12);



                // Check if the directory exists
                string directory = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // Create a new PDF document
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

                doc.Open();

                // Add a title
                iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                Paragraph title = new Paragraph("Sales Receipt\n\n", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                // Add date and seller info
                doc.Add(new Paragraph($"Date: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}\n"));
                doc.Add(new Paragraph($"Seller: {SessionStorage.Session.UserName}\n\n"));

                // Create a table with 5 columns
                PdfPTable table = new PdfPTable(5);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 30, 100, 100, 50, 80 });

                // Add table headers
                table.AddCell("No");
                table.AddCell("Item");
                table.AddCell("Category");
                table.AddCell("Quantity");
                table.AddCell("Total Price (Kyats)");

                // Add items to the table
                int index = 1;
                decimal grandTotal = 0;

                foreach (var item in soldItems)
                {
                    table.AddCell(index.ToString());
                    table.AddCell(new Phrase(item.Category, myanmarTextFont));
                    table.AddCell(new Phrase(item.Type, myanmarTextFont));
                    table.AddCell(item.Quantity.ToString());
                    table.AddCell(item.TotalPrice.ToString("N2"));

                    grandTotal += item.TotalPrice;
                    index++;
                }

                // Add total row
                PdfPCell totalCell = new PdfPCell(new Phrase("Total Price", FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                totalCell.Colspan = 4;
                totalCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                table.AddCell(totalCell);
                table.AddCell(grandTotal.ToString("N2") + " Kyats");

                // Add the table to the document
                doc.Add(table);

                // Close the document
                doc.Close();

                MessageBox.Show($"Sales receipt saved to {filePath}", "PDF Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the PDF automatically
                try
                {
                    // Use ProcessStartInfo to open the PDF with the default application
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = filePath,
                        UseShellExecute = true // This ensures the default application is used
                    };
                    Process.Start(psi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void sellBtn_Click(object sender, EventArgs e)
        {
            List<Model.SellItem> soldItems = new List<Model.SellItem>();
            foreach (DataGridViewRow row in fakeDataGridView.Rows)
            {
                if (row.Cells["TypeId"].Value != null && row.Cells["Quantity"].Value != null)
                {
                    int typeId = Convert.ToInt32(row.Cells["TypeId"].Value);
                    string type = row.Cells["Type"].Value.ToString();
                    string category = row.Cells["Category"].Value.ToString();
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    string sellerName = SessionStorage.Session.UserName; // Seller name stored in session.
                    decimal purchasePrice = Convert.ToDecimal(row.Cells["PurchasePrice"].Value);

                    // Fetch the item to update the quantity
                    var item = itemController.GetItemById(typeId);

                    if (item != null)
                    {
                        if (item.Quantity >= quantity)
                        {
                            item.Quantity -= quantity; // Deduct the sold quantity

                            Model.SellItem sellItem = new Model.SellItem
                            {
                                Type = type,
                                Category = category,
                                Price = price,
                                Quantity = quantity,

                                TotalPrice = price * quantity,
                                SellerName = sellerName,
                                PurchasePrice = purchasePrice,
                            };

                            // add the sold item to the list
                            soldItems.Add(sellItem);
                            //update the database
                            SellItemController sellItemController = new SellItemController();
                            sellItemController.SellItem(sellItem);
                            itemController.UpdateItem(item); // Update the product in the database
                        }
                        else
                        {
                            MessageBox.Show(
                                $"Not enough stock for {item.Types}. Available: {item.Quantity}, Sold: {quantity}",
                                "Stock Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return;
                        }
                    }
                }
            }
            GeneratePDF(soldItems); // Call PDF generation function
            if (fakeItemController.DeleteAllItems())
            {
                MessageBox.Show("Item Sell successfullly", "selling Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFakeItemsIntoGrid();
                LoadItemsIntoGrid();

            }
            else
            {
                MessageBox.Show("item deleted fail", "Seller Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (DataGridViewRow row in fakeDataGridView.Rows)
            {
                if (row.Cells["Quantity"].Value != null && row.Cells["Price"].Value != null)
                {
                    int quantity = int.TryParse(row.Cells["Quantity"].Value.ToString(), out int parsedQuantity) ? parsedQuantity : 1;

                    decimal sellingPrice = Convert.ToDecimal(row.Cells["Price"].Value);
                    totalPrice += quantity * sellingPrice;
                }
            }

            totalPriceTxt.Text = totalPrice.ToString("N2") + " (Kyats)";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DailyRecord dailyRecord = new DailyRecord();
            dailyRecord.Show();
        }
    }
}
