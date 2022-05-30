using cafe_automation.Widgets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;
namespace cafe_automation
{
    public partial class formDetay : Form
    {
        public List<Category> allCategories = new List<Category>();
        public List<Item> allItems = new List<Item>();
        public  List<Button> categoryButtons = new List<Button>();
        public  List<order> allOrders = new List<order>();
        public  float totalCost = 0;
        public  int selectedCategory = 1;
        
        public formDetay()
        {
            
            InitializeComponent();
            allCategories = CRUD.getCategories();
            allItems = CRUD.getItems();
            createCategoryButtons();
            createItemList();
            updateTotalCost(0);
            timer1.Interval = 250;
        }


        public void createCategoryButtons()
        {
            for(int i = allCategories.Count-1;i>=0;i--)
            {
                int category_id;
                Button btn = new Button();
                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
                btn.Dock = System.Windows.Forms.DockStyle.Top;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
                btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(51)))));
                btn.Location = new System.Drawing.Point(3, 280);
                btn.Name = "categoryButton"+allCategories[i].getID().ToString();
                btn.Size = new System.Drawing.Size(214, 59);
                btn.TabIndex = 3;
                btn.Text = allCategories[i].getName();
                btn.UseVisualStyleBackColor = false;
                category_id = allCategories[i].getID();
                btn.Click += (s, e) =>
                {
                    if(selectedCategory != category_id)
                    {
                        selectedCategory = category_id;
                        pressedCategoryButton(btn);
                    }
                };
                categoryPanel.Controls.Add(btn);
                categoryPanel.Controls.Add(logoPanel);
                categoryButtons.Add(btn);

            }
            selectedCategory = 1;
            pressedCategoryButton(categoryButtons[categoryButtons.Count-1]);
        }

        public void createItemList()
        {
            foreach(Item itm in allItems)
            {
                
                item willBeAdded = new item()
                {
                    Title = itm.getName(),
                    Cost = itm.getCost(),
                    Icon = Image.FromFile(".\\icons\\" + itm.getPicName()),
                    CategoryID = itm.getCategoryID(),
                };
                flowLayoutPanel1.Controls.Add(willBeAdded);

                willBeAdded.OnSelect += (ss, ee) =>
                {
                    
                    if(timer1.Enabled == false)
                    {
                        timer1.Enabled = true;

                        Application.DoEvents();
                        Stopwatch sw = new Stopwatch();
                        sw.Start();
                        bool isHave = false;
                        foreach (order ord in allOrders)
                        {
                            if (ord.Name == willBeAdded.Title)
                            {
                                isHave = true;
                                ord.Count += 1;
                                ord.refreshLabels();
                                updateTotalCost(ord.Cost);
                            }
                        }

                        if (!isHave)
                        {
                            order new_order = new order()
                            {
                                Count = 1,
                                Name = willBeAdded.Title,
                                Cost = willBeAdded.Cost,
                            };
                            new_order.btnIncrease_Click += (ss1, ee1) => {
                                new_order.Count += 1;
                                updateTotalCost(new_order.Cost);
                                new_order.refreshLabels();
                            };
                            new_order.btnReduce_Click += (ss1, ee1) =>
                            {
                                new_order.Count -= 1;
                                if (new_order.Count <= 0)
                                {
                                    allOrders.Remove(new_order);
                                    new_order.Dispose();
                                }
                                else
                                {
                                    new_order.refreshLabels();
                                }
                                updateTotalCost(-1 * new_order.Cost);
                            };
                            updateTotalCost(new_order.Cost);
                            new_order.Dock = DockStyle.Top;
                            new_order.refreshLabels();
                            allOrders.Add(new_order);
                            orderPanel.Controls.Add(new_order);
                        }
                        sw.Stop();
                        Console.WriteLine("Geçen süre : " + sw.Elapsed.Milliseconds.ToString());
                    }
                    
                  
                };
            }
        }
        

        public void pressedCategoryButton(Button pressed_btn)
        {
            foreach(Button btn in categoryButtons)
            {
                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
                btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(51)))));
            }
            pressed_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(51)))));
            pressed_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            showItems();
        }

        public void showItems()
        {
            foreach(item itm in flowLayoutPanel1.Controls)
            {
                itm.Visible = selectedCategory == 1 || itm.CategoryID == selectedCategory;
            }
        }

        public void updateTotalCost(float value)
        {
            totalCost += value;
            lblTotalCost.Text = totalCost.ToString("C2");
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Console.WriteLine("Timer devre disi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formMain.isTableAvailable();
            this.Visible = false;
        }
    }
}
