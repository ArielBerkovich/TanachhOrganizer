using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RonitOrganizer
{
    public class MaterialPanel
    {
        String name;
        String fullFolderPath;
        Panel panel = new Panel();
        Panel optionsPanel = new Panel();
        Panel spacePanel = new Panel();
        Button expendPanelButton = new Button();
        Button openFolder = new Button();
        Button addSource = new Button();
        Button removeSouce = new Button();
        Button removePanel = new Button();


        public MaterialPanel(Panel mainPanel,String fullFolderPath)
        {
            this.fullFolderPath = fullFolderPath;
            this.name = Path.GetFileName(Path.GetDirectoryName(fullFolderPath + "\\"));
           
            initPanels();
            initButtons(mainPanel);
            finalizePanels(mainPanel);
        }

        private void finalizePanels(Panel mainPanel)
        {
            Label lbl = new Label();
            lbl.Text = this.name;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Font = new Font("Times New Roman", 20.0f, FontStyle.Bold);
            lbl.Height = 300;
            lbl.Width = 250;
            lbl.Location = new Point(panel.Location.X + panel.Width / 2 - lbl.Width / 2, 80);
            panel.Controls.Add(lbl);
            panel.Controls.Add(openFolder);
            panel.Controls.Add(expendPanelButton);
            panel.Controls.Add(optionsPanel);

            optionsPanel.Controls.Add(removePanel);
            optionsPanel.Controls.Add(addSource);

            mainPanel.Controls.Add(panel);
            mainPanel.Controls.Add(spacePanel);
        }

        private void initPanels()
        {
            panel.Width = 250;
            panel.Dock = DockStyle.Left;
            panel.BackColor = Color.Aqua;
            initColor();

            spacePanel.BackColor = Color.WhiteSmoke;
            spacePanel.Width = 40;
            spacePanel.Dock = DockStyle.Left;

            optionsPanel.Visible = false;
            optionsPanel.Dock = DockStyle.Bottom;
            optionsPanel.AutoSize = true;
            optionsPanel.BackColor = Color.BlanchedAlmond;
        }

        private void initButtons(Panel mainPanel)
        {
            expendPanelButton.Text = "+";
            expendPanelButton.Height = 40;
            expendPanelButton.BackColor = Color.Beige;
            expendPanelButton.Font = new Font("Times New Roman", 20.0f);
            expendPanelButton.Dock = DockStyle.Bottom;
            expendPanelButton.Click += (s, e) =>
            {
                if (optionsPanel.Visible == false)
                {
                    expendPanelButton.Text = "-";
                    optionsPanel.Visible = true;
                }
                else
                {
                    expendPanelButton.Text = "+";
                    optionsPanel.Visible = false;
                }
            };

            expendPanelButton.MouseHover += (s, e) =>
            {
                this.expendPanelButton.BackColor = Color.Yellow;
            };
            expendPanelButton.MouseLeave += (s, e) =>
            {
                this.expendPanelButton.BackColor = Color.Beige;
            };

            openFolder.Text = "פתח תיקייה";
            openFolder.Height = 40;
            openFolder.BackColor = Color.Beige;
            openFolder.Dock = DockStyle.Top;
            openFolder.MouseHover += (s, e) =>
            {
                this.openFolder.BackColor = Color.Yellow;
            };
            openFolder.MouseLeave += (s, e) =>
            {
                this.openFolder.BackColor = Color.Beige;
            };
            openFolder.Font = new Font("Times New Roman", 20.0f);
            openFolder.Dock = DockStyle.Bottom;
            openFolder.Click += (s, e) =>
            {
                Process.Start(fullFolderPath);
            };

            removePanel.Click += (s, e) => 
            {
                mainPanel.Controls.Remove(panel);
                mainPanel.Controls.Remove(spacePanel);
            };
            removePanel.Font = new Font("Times New Roman", 15.0f);
            removePanel.Height = 30;
            removePanel.Text = "הסר חומר";
            removePanel.Dock = DockStyle.Top;

            addSource.Click += (s, e) =>
            {
                string path;
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); 
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = fileDialog.FileName;
                    File.Copy(path, fullFolderPath+Path.GetFileName(path), true);

                }
            };
            addSource.Font = new Font("Times New Roman", 15.0f);
            addSource.Height = 30;
            addSource.Text = "הוסף חומר";
            addSource.Dock = DockStyle.Top;
        }

        private void removePanelFunc(Panel mainPanel)
        {
            mainPanel.Controls.Remove(panel);

        }

        private void initColor()
        {
            if (name.Contains("בראשית"))
            {
                panel.BackColor = Color.SandyBrown;
            }
            if (name.Contains("שמות"))
            {
                panel.BackColor = Color.Turquoise;
            }
            if (name.Contains("ויקרא"))
            {
                panel.BackColor = Color.Coral;
            }
        }
    }
}
