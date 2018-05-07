﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelegramBot.Models;

namespace TelegramBot
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void addNewCat_Click(object sender, EventArgs e)
        {
            using (CatImagesContext context = new CatImagesContext())
            {
                try
                {
                    if (textBox1.Text != null)
                    {
                        CatImages image = new CatImages() { ImageUrl = textBox1.Text };
                        context.Images.Add(image);
                        context.SaveChanges();
                    }
                }
                catch { }
            }
        }

        private void addNewWallpaper_Click(object sender, EventArgs e)
        {
            using (WallpapersContext context = new WallpapersContext())
            {
                try
                {
                    if (textBox2.Text != null)
                    {
                        Wallpapers image = new Wallpapers() { ImageUrl = textBox2.Text };
                        context.Images.Add(image);
                        context.SaveChanges();
                    }
                }
                catch { }
            }
        }
    }
}
