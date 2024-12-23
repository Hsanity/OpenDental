using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OpenDentBusiness;
using OpenDental.UI;

namespace OpenDental {
	public partial class FormMapAreaContainerDetail:FormODBase {
		public MapAreaContainer MapAreaContainerCur;
		private List<Site> _listSites;

		public FormMapAreaContainerDetail() {
			InitializeComponent();
			InitializeLayoutManager();
			Lan.F(this);
		}

		private void FormMapAreaContainers_Load(object sender,EventArgs e) {
			textDescription.Text=MapAreaContainerCur.Description;
			textWidth.Value=MapAreaContainerCur.FloorWidthFeet;
			textHeight.Value=MapAreaContainerCur.FloorHeightFeet;
			_listSites=Sites.GetDeepCopy();
			comboSite.Items.AddNone<Site>();
			comboSite.Items.AddList(_listSites,x=>x.Description);
			comboSite.SetSelectedKey<Site>(MapAreaContainerCur.SiteNum,x=>x.SiteNum);
		}

		private void butSave_Click(object sender,EventArgs e) {
			if(textDescription.Text==""){
				MsgBox.Show("Please enter a description.");
				return;
			}
			if(!textWidth.IsValid()
				|| !textHeight.IsValid())
			{
				MsgBox.Show("Please enter a valid width and height.");
				return;
			}
			MapAreaContainerCur.Description=textDescription.Text;
			MapAreaContainerCur.FloorWidthFeet=(int)textWidth.Value;
			MapAreaContainerCur.FloorHeightFeet=(int)textHeight.Value;
			MapAreaContainerCur.SiteNum=comboSite.GetSelectedKey<Site>(x=>x.SiteNum);
			MapAreaContainers.Update(MapAreaContainerCur);
			DialogResult=DialogResult.OK;
		}

	}
}