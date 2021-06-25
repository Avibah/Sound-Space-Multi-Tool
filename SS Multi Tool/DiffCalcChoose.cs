using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;

namespace SS_Multi_Tool
{
    public partial class DiffCalcChoose : Form
    {
        public int selectedindex = 0;
        public List<string> maplist;
        public List<double> starlist;
        public List<double> pplist;
        public DiffCalcChoose(List<string> mapset, List<double> starset, List<double> ppset)
        {
            InitializeComponent();
            maplist = mapset;
            starlist = starset;
            pplist = ppset;
            foreach (var map in maplist)
            {
                MapList.Rows.Add(mapset.IndexOf(map) + 1, map, starset[mapset.IndexOf(map)], ppset[mapset.IndexOf(map)]);
            }
        }

        private void Choose_Click(object sender, EventArgs e)
        {
            selectedindex = int.Parse(MapList.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            MapList.Rows.Clear();
            MapList.Refresh();
            var culture = CultureInfo.CurrentUICulture;
            foreach (var map in maplist)
            {
                if (culture.CompareInfo.IndexOf(map, SearchBox.Text, CompareOptions.IgnoreCase) >= 0)
                {
                    MapList.Rows.Add(maplist.IndexOf(map) + 1, map, starlist[maplist.IndexOf(map)], pplist[maplist.IndexOf(map)]);
                }
            }
        }

        private void SearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Search_Click(sender, e);
            }
        }
    }
}
